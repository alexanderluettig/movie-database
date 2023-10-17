using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MovieDatabase.Identity;
public class UserContext : IdentityDbContext<IdentityUser, IdentityRole, string>
{
    public UserContext(DbContextOptions<UserContext> options)
        : base(options)
    {
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<IdentityRole>()
            .HasData(
                new[] {
                    new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                    new IdentityRole { Name = "Moderator", NormalizedName = "MODERATOR" },
                    new IdentityRole { Name = "User", NormalizedName = "USER" } }
            );

        base.OnModelCreating(modelBuilder);
    }
}