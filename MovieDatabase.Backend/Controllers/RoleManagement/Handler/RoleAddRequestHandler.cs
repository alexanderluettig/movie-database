using MediatR;
using Microsoft.AspNetCore.Identity;
using MovieDatabase.Backend.Controllers.RoleManagement.Exceptions;
using MovieDatabase.Backend.Controllers.RoleManagement.Requests;

namespace MovieDatabase.Backend.Controllers.RoleManagement.Handler;

public sealed class RoleAddRequestHandler : IRequestHandler<RoleAddRequest>
{
    private readonly UserManager<IdentityUser> _userManager;

    public RoleAddRequestHandler(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task Handle(RoleAddRequest request, CancellationToken cancellationToken)
    {
        var user = await _userManager.FindByIdAsync(request.Id);

        if (user == null)
        {
            throw new UserNotFoundException(request.Id);
        }

        await _userManager.AddToRoleAsync(user, request.Role);
    }
}