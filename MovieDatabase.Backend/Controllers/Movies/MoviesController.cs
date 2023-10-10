using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MovieDatabase.Persistence;

namespace MovieDatabase.Backend.Controllers.Movies
{
    [ApiController]
    [Route("[controller]")]
    public class MoviesController : ControllerBase
    {
        private readonly MovieDBContext _context;

        public MoviesController(MovieDBContext context)
        {
            _context = context;
        }

        [HttpGet, Authorize]
        public IActionResult GetMovies()
        {
            var movies = _context.Movies;
            return Ok(movies);
        }
    }
}