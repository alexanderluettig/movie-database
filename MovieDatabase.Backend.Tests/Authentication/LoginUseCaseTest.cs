using System.Net;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieDatabase.Backend.Controllers.Authentication;

namespace MovieDatabase.Backend.Tests.Authentication;

[Collection(nameof(SharedTestCollection))]
public class LoginUseCaseTest : IAsyncLifetime
{
    private readonly MovieApplicationFactory _factory;
    private readonly HttpClient _client;
    private readonly Func<Task> _resetData;

    public LoginUseCaseTest(MovieApplicationFactory factory)
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
        var response = await _client.PostAsJsonAsync("/authentication/login", new AuthenticationRequest
        {
            Email = "",
            Password = ""
        });
        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task It_should_return_401_for_invalid_credentials()
    {
        var response = await _client.PostAsJsonAsync("/authentication/login", new AuthenticationRequest
        {
            Email = "user@test.com",
            Password = "password12345!!"
        });

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Fact]
    public async Task It_should_return_200_for_valid_credentials()
    {
        var scope = _factory.Services.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var user = new IdentityUser
        {
            Email = "user@test.com",
            UserName = "User",
        };

        await userManager.CreateAsync(user, "password12345!!");

        var response = await _client.PostAsJsonAsync("/authentication/login", new AuthenticationRequest
        {
            Email = "user@test.com",
            Password = "password12345!!"
        });

        response.StatusCode.Should().Be(HttpStatusCode.OK);
        var data = await response.Content.ReadFromJsonAsync<AuthenticationResponse>();
        data!.Token.Should().NotBeNullOrEmpty();
    }
}