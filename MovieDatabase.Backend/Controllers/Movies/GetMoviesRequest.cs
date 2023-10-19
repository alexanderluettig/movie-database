using MediatR;

namespace MovieDatabase.Backend.Controllers.Movies
{
    internal class GetMoviesRequest : IRequest<IEnumerable<Movie>>
    {
    }
}