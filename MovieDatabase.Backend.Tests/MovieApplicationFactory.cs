using System.Data.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using MovieDatabase.Identity;
using MovieDatabase.Persistence;
using Respawn;
using Respawn.Graph;
using Testcontainers.MsSql;

namespace MovieDatabase.Backend.Tests;

public class MovieApplicationFactory : WebApplicationFactory<Startup>, IAsyncLifetime
{
    public IConfiguration? Configuration { get; private set; }

    public HttpClient HttpClient { get; private set; } = default!;

    private readonly MsSqlContainer _dataContainer = new MsSqlBuilder()
        .Build();

    private readonly MsSqlContainer _userContainer = new MsSqlBuilder()
        .Build();

    private DbConnection _dbDataConnection = default!;
    private DbConnection _dbUserConnection = default!;
    private Respawner _dataRespawner = default!;
    private Respawner _userRespawner = default!;

    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureTestServices(services =>
        {
            services.RemoveAll(typeof(DbContextOptions<MovieDBContext>));
            services.RemoveAll(typeof(DbContextOptions<UserContext>));

            services.AddDbContext<MovieDBContext>(x => x.UseSqlServer(_dataContainer.GetConnectionString()));
            services.AddDbContext<UserContext>(x => x.UseSqlServer(_userContainer.GetConnectionString()));
        });
    }

    public async Task ResetDataAsync()
    {
        await _dataRespawner.ResetAsync(_dbDataConnection);
        await _userRespawner.ResetAsync(_dbUserConnection);
        HttpClient.DefaultRequestHeaders.Authorization = null;
    }

    public async Task InitializeAsync()
    {
        await _dataContainer.StartAsync();
        await _userContainer.StartAsync();

        HttpClient = CreateClient();
        _dbDataConnection = new SqlConnection(_dataContainer.GetConnectionString()!);
        _dbUserConnection = new SqlConnection(_userContainer.GetConnectionString()!);

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
        await _dataContainer.StopAsync();
        await _userContainer.StopAsync();
    }
}