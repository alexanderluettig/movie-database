using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;

namespace MovieDatabase.Backend.Tests.Movies
{
    public class GetMoviesUseCaseTests : TestFixture
    {
        public GetMoviesUseCaseTests(MovieApplicationFactory factory) : base(factory)
        {
        }

        [Fact]
        public async Task It_should_get_Movies_successfully()
        {
            var response = await _client.GetAsync("/movies");
            var movies = await response.Content.ReadFromJsonAsync<List<Movie>>();

            movies!.Count.Should().Be(100);
            response.EnsureSuccessStatusCode();
        }
    }
}