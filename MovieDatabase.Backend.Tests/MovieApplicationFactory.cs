using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Extensions.Configuration;

namespace MovieDatabase.Backend.Tests
{
    public class MovieApplicationFactory : WebApplicationFactory<Startup>
    {
        public IConfiguration? Configuration { get; private set; }
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureAppConfiguration(config =>
            {
                Configuration = new ConfigurationBuilder()
                    .AddJsonFile("testsettings.json")
                    .Build();

                config.AddConfiguration(Configuration);
            });
        }
    }
}