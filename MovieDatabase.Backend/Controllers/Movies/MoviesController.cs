using System.Runtime.Serialization;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MovieDatabase.Backend.Controllers.Movies
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public MoviesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            var movies = await _mediator.Send(new GetMoviesRequest());
            return Ok(movies);
        }

        [HttpDelete("{id}"), Authorize(Roles = "Moderator")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            try
            {
                await _mediator.Send(new DeleteMovieRequest(id));
                return Ok();
            }
            catch (MovieNotFoundException e)
            {
                return NotFound(e.Message);
            }
        }
    }
}