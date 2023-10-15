using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MovieDatabase.Identity;
using MovieDatabase.Persistence;

namespace MovieDatabase.Backend.Tests
{
    [Trait("Category", "Integration")]
    public class TestFixture : IClassFixture<MovieApplicationFactory>
    {
        public TestFixture(MovieApplicationFactory factory)
        {
            _factory = factory;
            _client = _factory.CreateClient();
        }

        protected readonly MovieApplicationFactory _factory;
        protected readonly HttpClient _client;
    }
}