using MediatR;

namespace MovieDatabase.Backend.Controllers.Authentication
{
    public class AuthenticationRequest : IRequest<AuthenticationResponse>
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}