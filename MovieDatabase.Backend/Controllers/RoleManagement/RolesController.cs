using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieDatabase.Backend.Controllers.RoleManagement.Exceptions;
using MovieDatabase.Backend.Controllers.RoleManagement.Requests;

namespace MovieDatabase.Backend.Controllers.RoleManagement;

[ApiController]
[Route("[controller]")]
public sealed class RolesController : ControllerBase
{
    private readonly IMediator _mediator;

    public RolesController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public async Task<IActionResult> UpdateUserRole(RoleAddRequest request)
    {
        if (request.Role == "Admin" && !User.IsInRole("SuperAdmin"))
        {
            return Forbid();
        }

        try
        {
            await _mediator.Send(request);
            return Ok();
        }
        catch (UserNotFoundException ex)
        {
            return BadRequest(ex.Message);
        }
    }
}