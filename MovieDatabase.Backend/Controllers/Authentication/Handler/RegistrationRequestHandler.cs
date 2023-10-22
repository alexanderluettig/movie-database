using MediatR;
using Microsoft.AspNetCore.Identity;

namespace MovieDatabase.Backend.Controllers.Authentication;

internal class RegistrationRequestHandler : IRequestHandler<RegistrationRequest>
{
    private readonly UserManager<IdentityUser> _userManager;

    public RegistrationRequestHandler(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task Handle(RegistrationRequest request, CancellationToken cancellationToken)
    {
        var result = await _userManager.CreateAsync(
            new IdentityUser { UserName = request.Username, Email = request.Email },
            request.Password);

        if (!result.Succeeded)
        {
            throw new RegistrationException($"Registration resulted in errors: {result.Errors.Select(x => x.Code)}", result.Errors);
        }
    }
}