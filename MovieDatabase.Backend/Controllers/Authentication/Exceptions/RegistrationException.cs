using Microsoft.AspNetCore.Identity;

namespace MovieDatabase.Backend.Controllers.Authentication
{
    public class RegistrationException : Exception
    {
        public const string Title = "Registration failed";
        public RegistrationException(string message, IEnumerable<IdentityError> errors) : base(message)
        {
            Errors = errors;
        }
        public IEnumerable<IdentityError> Errors { get; init; }
    }
}