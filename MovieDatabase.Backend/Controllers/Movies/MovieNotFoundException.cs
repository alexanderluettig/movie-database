namespace MovieDatabase.Backend.Controllers.Movies
{
    internal class MovieNotFoundException : Exception
    {
        public static readonly string Title = "Movie not found";
        public MovieNotFoundException(int id)
            : base($"Movie with id {id} was not found")
        {
        }
    }
}