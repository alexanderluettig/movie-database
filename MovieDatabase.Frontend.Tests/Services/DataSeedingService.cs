using System.Net.Http.Json;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MovieDatabase.Backend.Controllers.Authentication;
using MovieDatabase.Identity;
using MovieDatabase.Persistence;

namespace MovieDatabase.Frontend.Tests.Services;

public class DataSeedingService
{
    private readonly MovieDBContext _dataContext;
    private readonly UserContext _userContext;
    private readonly HttpClient _httpClient;
    public DataSeedingService(MovieDBContext dataContext, UserContext userContext, HttpClient httpClient)
    {
        _dataContext = dataContext;
        _userContext = userContext;
        _httpClient = httpClient;
    }

    public async Task<(string email, string password)> CreateUserWithRole(string username, string password, string role)
    {
        var registrationRequest = new RegistrationRequest
        {
            Username = username,
            Email = $"{username}@test.com",
            Password = password,
        };

        var response = await _httpClient.PostAsJsonAsync("/authentication/register", registrationRequest);
        response.EnsureSuccessStatusCode();

        var roleId = (await _userContext.Roles.SingleAsync(x => x.Name == role)).Id;
        var userId = (await _userContext.Users.SingleAsync(x => x.UserName == username)).Id;

        await _userContext.UserRoles.AddAsync(new IdentityUserRole<string>
        {
            RoleId = roleId,
            UserId = userId
        });

        await _userContext.SaveChangesAsync();

        return (registrationRequest.Email, registrationRequest.Username);
    }
}