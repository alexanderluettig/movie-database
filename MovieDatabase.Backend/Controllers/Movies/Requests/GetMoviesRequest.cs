using MediatR;

namespace MovieDatabase.Backend.Controllers.Movies.Requests;

internal class GetMoviesRequest : IRequest<IEnumerable<Movie>>
{
}