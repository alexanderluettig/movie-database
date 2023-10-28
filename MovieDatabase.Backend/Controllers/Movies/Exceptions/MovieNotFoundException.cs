namespace MovieDatabase.Backend.Controllers.Movies.Exceptions;

internal class MovieNotFoundException : Exception
{
    public static readonly string Title = "Movie not found";
    public MovieNotFoundException(int id)
        : base($"Movie with id {id} was not found")
    {
    }
}