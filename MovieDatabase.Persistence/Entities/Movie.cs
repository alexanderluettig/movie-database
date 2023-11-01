public sealed class Movie
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public required string Director { get; set; }
    public required int Year { get; set; }
    public required Genre Genre { get; set; }
    public required double Rating { get; set; }
}