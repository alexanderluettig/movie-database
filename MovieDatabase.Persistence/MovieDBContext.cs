using Bogus;
using Microsoft.EntityFrameworkCore;

namespace MovieDatabase.Persistence;
public class MovieDBContext : DbContext
{
    public MovieDBContext(DbContextOptions<MovieDBContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Will probably replaced by webcrawling data from IMDB
        var movieIDs = 1;
        var movieFaker = new Faker<Movie>()
            .RuleFor(m => m.Id, f => movieIDs++)
            .RuleFor(m => m.Title, f => f.Random.Words(3))
            .RuleFor(m => m.Director, f => f.Name.FullName())
            .RuleFor(m => m.Year, f => f.Random.Int(1900, 2021))
            .RuleFor(m => m.Genre, f => f.Random.Enum<Genre>())
            .RuleFor(m => m.Rating, f => f.Random.Double(0, 100));

        modelBuilder.Entity<Movie>()
            .HasData(movieFaker.Generate(100));
    }

    public DbSet<Movie> Movies { get; set; }
}
