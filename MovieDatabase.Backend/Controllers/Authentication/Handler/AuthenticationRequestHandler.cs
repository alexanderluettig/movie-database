using MediatR;
using Microsoft.AspNetCore.Identity;
using MovieDatabase.Backend.Services;

namespace MovieDatabase.Backend.Controllers.Authentication.Handler
{
    internal sealed class AuthenticationRequestHandler : IRequestHandler<AuthenticationRequest, AuthenticationResponse>
    {
        private readonly UserManager<IdentityUser> _userManager;
        private readonly TokenService _tokenService;

        public AuthenticationRequestHandler(TokenService tokenService, UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
            _tokenService = tokenService;
        }

        public async Task<AuthenticationResponse> Handle(AuthenticationRequest request, CancellationToken cancellationToken)
        {
            var managedUser = await _userManager.FindByEmailAsync(request.Email);
            if (managedUser == null)
            {
                throw new AuthenticationException("Bad credentials");
            }
            var isPasswordValid = await _userManager.CheckPasswordAsync(managedUser, request.Password);
            if (!isPasswordValid)
            {
                throw new AuthenticationException("Bad credentials");
            }

            var accessToken = _tokenService.CreateToken(managedUser);

            return new AuthenticationResponse
            {
                Username = managedUser.UserName!,
                Email = managedUser.Email!,
                Token = accessToken,
            };
        }
    }
}