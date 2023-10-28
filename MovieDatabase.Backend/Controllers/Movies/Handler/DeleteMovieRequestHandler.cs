using MediatR;
using MovieDatabase.Backend.Controllers.Movies.Exceptions;
using MovieDatabase.Backend.Controllers.Movies.Requests;
using MovieDatabase.Persistence;

namespace MovieDatabase.Backend.Controllers.Movies.Handler;

internal class DeleteMovieRequestHandler : IRequestHandler<DeleteMovieRequest>
{
    private readonly MovieDBContext _context;

    public DeleteMovieRequestHandler(MovieDBContext context)
    {
        _context = context;
    }

    public async Task Handle(DeleteMovieRequest request, CancellationToken cancellationToken)
    {
        var movie = _context.Movies.Find(request.Id) ?? throw new MovieNotFoundException(request.Id);
        _context.Movies.Remove(movie);
        await _context.SaveChangesAsync(cancellationToken: cancellationToken);
    }
}