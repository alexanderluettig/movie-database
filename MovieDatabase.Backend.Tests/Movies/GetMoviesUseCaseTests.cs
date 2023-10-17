using System.Net.Http.Json;
using Bogus;
using Microsoft.Extensions.DependencyInjection;
using MovieDatabase.Persistence;

namespace MovieDatabase.Backend.Tests.Movies
{
    [Collection(nameof(SharedTestCollection))]
    public class GetMoviesUseCaseTests : IAsyncLifetime
    {
        private readonly MovieApplicationFactory _factory;
        private readonly HttpClient _client;
        private readonly Func<Task> _resetData;

        public GetMoviesUseCaseTests(MovieApplicationFactory factory)
        {
            _factory = factory;
            _client = _factory.HttpClient;
            _resetData = _factory.ResetDataAsync;
        }

        public Task DisposeAsync() => _resetData();

        public Task InitializeAsync() => Task.CompletedTask;

        [Fact]
        public async Task It_should_get_Movies_successfully()
        {
            using var scope = _factory.Services.CreateScope();
            var arrangeContext = scope.ServiceProvider.GetRequiredService<MovieDBContext>();

            var movieFaker = new Faker<Movie>()
                .RuleFor(m => m.Title, f => f.Random.Words(3))
                .RuleFor(m => m.Director, f => f.Name.FullName())
                .RuleFor(m => m.Year, f => f.Random.Int(1900, 2021))
                .RuleFor(m => m.Genre, f => f.Random.Enum<Genre>())
                .RuleFor(m => m.Rating, f => f.Random.Double(0, 100));

            arrangeContext.Movies.AddRange(movieFaker.Generate(100));
            await arrangeContext.SaveChangesAsync();

            var response = await _client.GetAsync("/movies");
            response.EnsureSuccessStatusCode();
            var movies = await response.Content.ReadFromJsonAsync<List<Movie>>();

            movies!.Count.Should().Be(100);
        }
    }
}