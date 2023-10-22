namespace MovieDatabase.Backend.Controllers.Authentication
{
    internal class AuthenticationException : Exception
    {
        public const string Title = "Authentication failed";

        public AuthenticationException(string message) : base(message)
        {
        }
    }
}