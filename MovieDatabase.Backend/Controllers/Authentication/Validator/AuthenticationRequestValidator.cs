using FluentValidation;

namespace MovieDatabase.Backend.Controllers.Authentication.Validator
{
    public sealed class AuthenticationRequestValidator : AbstractValidator<AuthenticationRequest>
    {
        public AuthenticationRequestValidator()
        {
            RuleFor(x => x.Email).NotEmpty().EmailAddress();
            RuleFor(x => x.Password).NotEmpty();
        }
    }
}