using MediatR;

namespace MovieDatabase.Backend.Controllers.RoleManagement.Requests;

public sealed class RoleAddRequest : IRequest
{
    public required string Id { get; init; }
    public required string Role { get; init; }
}