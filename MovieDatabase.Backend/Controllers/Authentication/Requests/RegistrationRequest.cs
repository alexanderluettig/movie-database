using MediatR;

namespace MovieDatabase.Backend.Controllers.Authentication
{
    public class RegistrationRequest : IRequest
    {
        public required string Email { get; set; } = null!;
        public required string Username { get; set; } = null!;
        public required string Password { get; set; } = null!;
    }
}