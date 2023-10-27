using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace MovieDatabase.Backend.Controllers.Authentication
{
    [ApiController]
    [Route("[controller]")]
    public sealed class AuthenticationController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AuthenticationController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        [Route("register")]
        public async Task<IActionResult> Register(RegistrationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _mediator.Send(request);
                request.Password = "";
                return CreatedAtAction(nameof(Register), new { email = request.Email }, request);
            }
            catch (RegistrationException ex)
            {
                foreach (var error in ex.Errors)
                {
                    ModelState.AddModelError(error.Code, error.Description);
                }

                if (ex.Errors.Any(e => e.Code == "DuplicateUserName" || e.Code == "DuplicateEmail"))
                {
                    return Conflict(ModelState);
                }

                return BadRequest(ModelState);
            }
        }

        [HttpPost]
        [Route("login")]
        public async Task<ActionResult<AuthenticationResponse>> Authenticate([FromBody] AuthenticationRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var response = await _mediator.Send(request);
                return Ok(response);
            }
            catch (AuthenticationException)
            {
                return BadRequest(AuthenticationException.Title);
            }
        }
    }
}