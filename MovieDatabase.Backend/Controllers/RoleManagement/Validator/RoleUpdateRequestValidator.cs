using FluentValidation;
using MovieDatabase.Backend.Controllers.RoleManagement.Requests;

namespace MovieDatabase.Backend.Controllers.RoleManagement.Validator;

public sealed class RoleUpdateRequestValidator : AbstractValidator<RoleAddRequest>
{
    public RoleUpdateRequestValidator()
    {
        RuleFor(x => x.Id).NotEmpty();
        RuleFor(x => x.Role).NotEmpty().Must(x => x == "Admin" || x == "Moderator");
    }
}