using System.Data.Common;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Respawn;

namespace MovieDatabase.Backend.Tests
{
    public class MovieApplicationFactory : WebApplicationFactory<Startup>, IAsyncLifetime
    {
        public IConfiguration? Configuration { get; private set; }

        public HttpClient HttpClient { get; private set; } = default!;

        private readonly TestContainers _testContainers = default!;

        private DbConnection _dbDataConnection = default!;
        private DbConnection _dbUserConnection = default!;
        private Respawner _datarespawner = default!;
        private Respawner _userrespawner = default!;

        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
                Configuration = new ConfigurationBuilder()
                    .AddJsonFile("testsettings.json")
                    .Build();

                config.AddConfiguration(Configuration);
            });

            builder.ConfigureTestServices(services =>
            {

            });
        }

        public async Task InitializeAsync()
        {
            HttpClient = CreateClient();
            _dbDataConnection = new SqliteConnection(Configuration!.GetConnectionString("Data"));
            _dbUserConnection = new SqliteConnection(Configuration!.GetConnectionString("User"));

            await _dbDataConnection.OpenAsync();
            await _dbUserConnection.OpenAsync();

            _datarespawner = await Respawner.CreateAsync(_dbDataConnection, new RespawnerOptions
            {
                DbAdapter = DbAdapter.SqlServer,

            });
        }

        Task IAsyncLifetime.DisposeAsync()
        {

        }
    }
}