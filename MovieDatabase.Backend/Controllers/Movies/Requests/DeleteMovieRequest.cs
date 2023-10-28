using MediatR;

namespace MovieDatabase.Backend.Controllers.Movies.Requests;

internal class DeleteMovieRequest : IRequest
{
    public int Id { get; }
    public DeleteMovieRequest(int id)
    {
        Id = id;
    }
}