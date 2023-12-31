using MediatR;
using Microsoft.EntityFrameworkCore;
using MovieDatabase.Backend.Controllers.Movies.Requests;
using MovieDatabase.Persistence;

namespace MovieDatabase.Backend.Controllers.Movies.Handler;

internal sealed class GetMoviesRequestHandler : IRequestHandler<GetMoviesRequest, IEnumerable<Movie>>
{
    private readonly MovieDBContext _context;

    public GetMoviesRequestHandler(MovieDBContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Movie>> Handle(GetMoviesRequest request, CancellationToken cancellationToken)
    {
        return await _context.Movies.ToListAsync(cancellationToken: cancellationToken);
    }
}