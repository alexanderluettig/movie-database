using System.Data.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Microsoft.Playwright;
using MovieDatabase.Frontend.Tests.Services;
using MovieDatabase.Identity;
using MovieDatabase.Persistence;
using Respawn;
using Respawn.Graph;

namespace MovieDatabase.Frontend.Tests;

public class MovieApplicationFrontendFactory : WebApplicationFactory<Startup>, IAsyncLifetime
{
    private IPlaywright PlaywrightInstance { get; set; } = null!;
    private IHost? _host;
    private DbConnection _dbDataConnection = default!;
    private DbConnection _dbUserConnection = default!;
    private Respawner _dataRespawner = default!;
    private Respawner _userRespawner = default!;
    public IConfiguration? Configuration { get; private set; }
    public IBrowser Browser { get; set; } = null!;

    public async Task ResetDataAsync()
    {
        await _dataRespawner.ResetAsync(_dbDataConnection);
        await _userRespawner.ResetAsync(_dbUserConnection);
    }

    public string ServerAddress
    {
        get
        {
            EnsureServer();
            return ClientOptions.BaseAddress.ToString();
        }
    }

    public MovieApplicationFrontendFactory()
    {
        Configuration = new ConfigurationBuilder()
                .AddJsonFile("testsettings.json")
                .Build();
    }

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            services.AddDbContext<MovieDBContext>(x => x.UseSqlServer(Configuration!.GetConnectionString("Data")));
            services.AddDbContext<UserContext>(x => x.UseSqlServer(Configuration!.GetConnectionString("User")));

            services.AddScoped<DataSeedingService>();
        });
    }

    protected override IHost CreateHost(IHostBuilder builder)
    {
        var testHost = builder.Build();
        builder.ConfigureWebHost(webHostBuilder => webHostBuilder.UseKestrel());

        _host = builder.Build();
        _host.Start();

        var server = _host.Services.GetRequiredService<IServer>();
        var addresses = server.Features.Get<IServerAddressesFeature>();

        ClientOptions.BaseAddress = addresses!.Addresses
            .Select(x => new Uri(x))
            .Last();

        testHost.Start();
        return testHost;
    }

    async Task IAsyncLifetime.InitializeAsync()
    {
        PlaywrightInstance = await Playwright.CreateAsync();
        Browser = await PlaywrightInstance.Chromium.LaunchAsync();

        _dbDataConnection = new SqlConnection(Configuration!.GetConnectionString("Data"));
        _dbUserConnection = new SqlConnection(Configuration!.GetConnectionString("User"));

        await _dbDataConnection.OpenAsync();
        await _dbUserConnection.OpenAsync();

        _dataRespawner = await Respawner.CreateAsync(_dbDataConnection, new RespawnerOptions
        {
            DbAdapter = DbAdapter.SqlServer,
            SchemasToInclude = new[] { "dbo" },
        });

        _userRespawner = await Respawner.CreateAsync(_dbUserConnection, new RespawnerOptions
        {
            DbAdapter = DbAdapter.SqlServer,
            SchemasToInclude = new[] { "dbo" },
            TablesToIgnore = new Table[] { "AspNetRoles" }
        });
    }

    async Task IAsyncLifetime.DisposeAsync()
    {
        await Browser.DisposeAsync();
        PlaywrightInstance.Dispose();
    }

    private void EnsureServer()
    {
        if (_host == null)
        {
            using var _ = CreateDefaultClient();
        }
    }
}