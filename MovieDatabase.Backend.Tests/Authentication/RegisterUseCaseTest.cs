using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieDatabase.Backend.Controllers.Authentication;

namespace MovieDatabase.Backend.Tests.Authentication;

[Collection(nameof(SharedTestCollection))]
public class RegisterUseCaseTest : IAsyncLifetime
{
    private readonly MovieApplicationFactory _factory;
    private readonly HttpClient _client;
    private readonly Func<Task> _resetData;

    public RegisterUseCaseTest(MovieApplicationFactory factory)
    {
        _resetData = factory.ResetDataAsync;
        _client = factory.HttpClient;
        _factory = factory;
    }

    public Task DisposeAsync() => _resetData();

    public Task InitializeAsync() => Task.CompletedTask;

    [Fact]
    public async Task It_should_return_400_for_invalid_requests()
    {
        var response = await _client.PostAsJsonAsync("/authentication/register", new RegistrationRequest
        {
            Email = "",
            Password = "",
            Username = ""
        });
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task It_should_return_409_for_existing_users()
    {
        using var scope = _factory.Services.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();
        var user = new IdentityUser { UserName = "User", Email = "user@test.de" };
        await userManager.CreateAsync(user, "password12345!!");

        var response = await _client.PostAsJsonAsync("/authentication/register", new RegistrationRequest
        {
            Email = "user@test.de",
            Username = "User",
            Password = "password12345!!"
        });

        response.StatusCode.Should().Be(HttpStatusCode.Conflict);
    }

    [Fact]
    public async Task It_should_return_201_for_valid_requests()
    {
        var response = await _client.PostAsJsonAsync("/authentication/register", new RegistrationRequest
        {
            Email = "user@test.com",
            Username = "User",
            Password = "password12345!!"
        });

        response.StatusCode.Should().Be(HttpStatusCode.Created);
    }
}
