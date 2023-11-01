using System.Net;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using MovieDatabase.Backend.Controllers.RoleManagement.Requests;
using MovieDatabase.Http.Extensions;

namespace MovieDatabase.Backend.Tests.RoleManagement;

[Collection(nameof(SharedBackendCollection))]
public class RoleManagementUseCaseTest : IAsyncLifetime
{
    private readonly MovieApplicationFactory _factory;
    private readonly HttpClient _httpClient;
    private readonly Func<Task> _resetData;

    public RoleManagementUseCaseTest(MovieApplicationFactory factory)
    {
        _factory = factory;
        _httpClient = _factory.HttpClient;
        _resetData = _factory.ResetDataAsync;
    }

    public Task DisposeAsync() => _resetData();

    public Task InitializeAsync() => Task.CompletedTask;

    [Fact]
    public async Task It_should_return_401_for_not_logged_user()
    {
        var response = await _httpClient.PostAsJsonAsync("/roles", new RoleAddRequest
        {
            Id = "uwufhwufhuwfhwehfwuefhu",
            Role = "Admin"
        });

        response.StatusCode.Should().Be(HttpStatusCode.Unauthorized);
    }

    [Theory]
    [InlineData("User")]
    [InlineData("Moderator")]
    public async Task It_should_return_403_unauthorized_for_user_with_unsufficient_priviliges(string role)
    {
        using var scope = _factory.Services.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var user = new IdentityUser { UserName = role, Email = $"{role.ToLower()}@testuser.com" };
        await userManager.CreateAsync(user, "password12345!!");

        await userManager.AddToRoleAsync(user, role);

        var token = await _httpClient.LoginAsync($"{role.ToLower()}@testuser.com", "password12345!!");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await _httpClient.PostAsJsonAsync("/roles", new RoleAddRequest
        {
            Id = "uwufhwufhuwfhwehfwuefhu",
            Role = "Admin"
        });

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);
    }

    [Fact]
    public async Task It_should_return_403_for_trying_to_set_admin_role()
    {
        using var scope = _factory.Services.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var user = new IdentityUser { UserName = "Admin", Email = "admin@test.com" };
        await userManager.CreateAsync(user, "password12345!!");

        await userManager.AddToRoleAsync(user, "Admin");

        var token = await _httpClient.LoginAsync("admin@test.com", "password12345!!");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await _httpClient.PostAsJsonAsync("/roles", new RoleAddRequest
        {
            Id = "uwufhwufhuwfhwehfwuefhu",
            Role = "Admin"
        });

        response.StatusCode.Should().Be(HttpStatusCode.Forbidden);

    }

    [Fact]
    public async Task It_should_return_400_for_unknown_role()
    {
        using var scope = _factory.Services.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var user = new IdentityUser { UserName = "Admin", Email = "admin@test.com" };
        await userManager.CreateAsync(user, "password12345!!");

        await userManager.AddToRoleAsync(user, "Admin");

        var token = await _httpClient.LoginAsync("admin@test.com", "password12345!!");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await _httpClient.PostAsJsonAsync("/roles", new RoleAddRequest
        {
            Id = "uwufhwufhuwfhwehfwuefhu",
            Role = "Unknown"
        });

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task It_should_return_400_for_unknown_user()
    {
        using var scope = _factory.Services.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var user = new IdentityUser { UserName = "Admin", Email = "admin@test.com" };
        await userManager.CreateAsync(user, "password12345!!");

        await userManager.AddToRoleAsync(user, "Admin");

        var token = await _httpClient.LoginAsync("admin@test.com", "password12345!!");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await _httpClient.PostAsJsonAsync("/roles", new RoleAddRequest
        {
            Id = "uwufhwufhuwfhwehfwuefhu",
            Role = "Moderator"
        });

        response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
    }

    [Fact]
    public async Task It_should_return_200_when_setting_admin_role_as_super_admin()
    {
        using var scope = _factory.Services.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var user = new IdentityUser { UserName = "Admin", Email = "admin@test.com" };
        await userManager.CreateAsync(user, "password12345!!");

        await userManager.AddToRoleAsync(user, "SuperAdmin");

        var userToBeUpdated = new IdentityUser { UserName = "User", Email = "user@test.com" };
        await userManager.CreateAsync(userToBeUpdated, "password12345!!");

        var identityUser = await userManager.FindByEmailAsync(userToBeUpdated.Email);

        await userManager.AddToRoleAsync(user, "Admin");

        var token = await _httpClient.LoginAsync("admin@test.com", "password12345!!");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await _httpClient.PostAsJsonAsync("/roles", new RoleAddRequest
        {
            Id = identityUser!.Id,
            Role = "Admin"
        });

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        using var assertScope = _factory.Services.CreateScope();
        var userAssertManager = assertScope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var updatedUser = await userAssertManager.FindByIdAsync(identityUser.Id);
        userAssertManager.IsInRoleAsync(updatedUser!, "Admin").Result.Should().BeTrue();
    }

    [Fact]
    public async Task It_should_return_200_when_setting_moderator_role_as_admin()
    {
        using var scope = _factory.Services.CreateScope();
        var userManager = scope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var user = new IdentityUser { UserName = "Admin", Email = "admin@test.com" };
        await userManager.CreateAsync(user, "password12345!!");

        await userManager.AddToRoleAsync(user, "Admin");

        var userToBeUpdated = new IdentityUser { UserName = "User", Email = "user@test.com" };
        await userManager.CreateAsync(userToBeUpdated, "password12345!!");

        var identityUser = await userManager.FindByEmailAsync(userToBeUpdated.Email);

        await userManager.AddToRoleAsync(user, "Admin");

        var token = await _httpClient.LoginAsync("admin@test.com", "password12345!!");
        _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", token);

        var response = await _httpClient.PostAsJsonAsync("/roles", new RoleAddRequest
        {
            Id = identityUser!.Id,
            Role = "Moderator"
        });

        response.StatusCode.Should().Be(HttpStatusCode.OK);

        using var assertScope = _factory.Services.CreateScope();
        var userAssertManager = assertScope.ServiceProvider.GetRequiredService<UserManager<IdentityUser>>();

        var updatedUser = await userAssertManager.FindByIdAsync(identityUser.Id);
        userAssertManager.IsInRoleAsync(updatedUser!, "Moderator").Result.Should().BeTrue();
    }
}