using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieDatabase.Persistence;

namespace MovieDatabase.Backend.Tests.Movies
{
    [Collection(nameof(SharedTestCollection))]
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
        public async Task It_should_return_401_authorized_for_not_logged_in_users()
        {
            var response = await _client.DeleteAsync("/movies/1");
            response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
        }

        [Theory]
        [InlineData("Admin")]
        [InlineData("User")]

        public async Task It_should_return_403_for_non_mod_users(string role)
        {
            using var scope = _factory.Services.CreateScope();
            var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

            await userManager.CreateAsync(
                new IdentityUser { UserName = "User", Email = "user@testuser.com" }, "user12345");
            var user = await userManager.FindByNameAsync("User");
            await userManager.AddToRoleAsync(user!, role);

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
            var arrangeContext = scope.ServiceProvider.GetRequiredService<MovieDBContext>();

            await userManager.CreateAsync(
                new IdentityUser { UserName = "Mod", Email = "mod@testuser.com" }, "mod12345");

            var mod = await userManager.FindByNameAsync("Mod");
            var result = await userManager.AddToRoleAsync(mod!, "Moderator");

            var token = await _client.LoginAsync("mod@testuser.com", "mod12345");

            var check = await userManager.IsInRoleAsync(mod!, "Moderator");

            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);
            var response = await _client.DeleteAsync($"/movies/1337");
            response.StatusCode.Should().Be(HttpStatusCode.NotFound);
        }
    }
}