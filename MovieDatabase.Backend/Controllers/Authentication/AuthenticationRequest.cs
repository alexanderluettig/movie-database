namespace MovieDatabase.Backend.Controllers.Authentication
{
    public class AuthenticationRequest
    {
        public string Email { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}