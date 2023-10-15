using Microsoft.AspNetCore.Identity;

namespace MovieDatabase.Backend.Extensions
{
    public static class RolesExtensions
    {
        public static void SetupRoles(this IApplicationBuilder app)
        {
            using var scope = app.ApplicationServices.CreateScope();

            var roleManager = scope.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            if (!roleManager.RoleExistsAsync("Admin").Result)
            {
                var role = new IdentityRole { Name = "Admin" };
                roleManager.CreateAsync(role).Wait();
            }

            if (!roleManager.RoleExistsAsync("User").Result)
            {
                var role = new IdentityRole { Name = "User" };
                roleManager.CreateAsync(role).Wait();
            }

            if (!roleManager.RoleExistsAsync("Moderator").Result)
            {
                var role = new IdentityRole { Name = "Moderator" };
                roleManager.CreateAsync(role).Wait();
            }
        }
    }
}