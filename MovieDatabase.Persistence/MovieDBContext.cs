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
    }

    public DbSet<Movie> Movies { get; set; }
}
