using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieDatabase.Persistence;
using MovieDatabase.Http.Extensions;

namespace MovieDatabase.Backend.Tests.Movies
{
    [Collection(nameof(SharedBackendCollection))]
    public class DeleteMoviesUseCaseTests : IAsyncLifetime
    {
        private readonly MovieApplicationFactory _factory;
        private readonly HttpClient _client;

        private readonly Func<Task> _resetData;

        public DeleteMoviesUseCaseTests(MovieApplicationFactory factory)
        {
            _factory = factory;
            _client = _factory.HttpClient;
            _resetData = _factory.ResetDataAsync;
        }

        public Task DisposeAsync() => _resetData();

        public Task InitializeAsync() => Task.CompletedTask;

        [Fact]
        public async Task It_should_return_401_unauthorized_for_not_logged_in_users()
        {
            var response = await _client.DeleteAsync("/movies/1");
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Fact]
        public async Task It_should_return_403_for_normal_users()
        {
            using var scope = _factory.Services.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            await userManager.CreateAsync(
                new IdentityUser { UserName = "User", Email = "user@testuser.com" }, "user12345");
            var user = await userManager.FindByNameAsync("User");
            await userManager.AddToRoleAsync(user!, "User");

            var token = await _client.LoginAsync("user@testuser.com", "user12345");

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.DeleteAsync("/movies/1");
            response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
        }

        [Fact]
        public async Task It_should_return_404_for_non_existing_movies()
        {
            using var scope = _factory.Services.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            await userManager.CreateAsync(
                new IdentityUser { UserName = "Mod", Email = "mod@testuser.com" }, "mod12345");

            var mod = await userManager.FindByNameAsync("Mod");
            var result = await userManager.AddToRoleAsync(mod!, "Moderator");

            var token = await _client.LoginAsync("mod@testuser.com", "mod12345");

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.DeleteAsync($"/movies/1337");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }

        [Theory]
        [InlineData("Admin")]
        [InlineData("Moderator")]
        public async Task It_should_return_200_for_existing_movies(string role)
        {
            using var scope = _factory.Services.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
            var arrangeContext = scope.ServiceProvider.GetRequiredService<MovieDBContext>();

            var entity = arrangeContext.Movies.Add(new()
            {
                Title = "Test Movie",
                Genre = Genre.Romance,
                Rating = 5,
                Director = "Test Director",
                Year = 2021,
            }).Entity;

            await arrangeContext.SaveChangesAsync();

            await userManager.CreateAsync(
                new IdentityUser { UserName = role, Email = $"{role.ToLower()}@testuser.com" }, $"{role.ToLower()}12345");

            var user = await userManager.FindByNameAsync(role);
            var result = await userManager.AddToRoleAsync(user!, role);

            var token = await _client.LoginAsync($"{role.ToLower()}@testuser.com", $"{role.ToLower()}12345");

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.DeleteAsync($"/movies/{entity.Id}");
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }
    }
}