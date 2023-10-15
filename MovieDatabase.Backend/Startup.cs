using System.Text;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using MovieDatabase.Backend.Extensions;
using MovieDatabase.Backend.Services;
using MovieDatabase.Identity;
using MovieDatabase.Persistence;

public class Startup
{
    public Startup(IConfigurationRoot configuration)
    {
        Configuration = configuration;
    }

    public IConfigurationRoot Configuration { get; }

    public void ConfigureServices(IServiceCollection services)
    {
        services.AddDbContext<MovieDBContext>(x => x.UseSqlite(Configuration.GetConnectionString("Data")));
        services.AddDbContext<UserContext>(x => x.UseSqlite(Configuration.GetConnectionString("User")));

        services.AddControllers();
        services.AddEndpointsApiExplorer();

        services.AddSwaggerGen(option =>
        {
            option.SwaggerDoc("v1", new OpenApiInfo { Title = "Demo API", Version = "v1" });
            option.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
            {
                In = ParameterLocation.Header,
                Description = "Please enter a valid token",
                Name = "Authorization",
                Type = SecuritySchemeType.Http,
                BearerFormat = "JWT",
                Scheme = "Bearer"
            });
            option.AddSecurityRequirement(new OpenApiSecurityRequirement
                {
                    {
                        new OpenApiSecurityScheme
                        {
                            Reference = new OpenApiReference
                            {
                                Type=ReferenceType.SecurityScheme,
                                Id="Bearer"
                            }
                        },
                            Array.Empty<string>()
                    }
                });
        });

        services
        .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer(config =>
        {
            config.TokenValidationParameters = new TokenValidationParameters
            {
                ClockSkew = TimeSpan.Zero,
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = Configuration.GetValue<string>("JwtSettings:Issuer"),
                ValidAudience = Configuration.GetValue<string>("JwtSettings:Audience"),
                IssuerSigningKey =
                new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration.GetValue<string>("JwtSettings:Key")!)),
            };
        });

        services
        .AddIdentityCore<IdentityUser>(options =>
        {
            options.SignIn.RequireConfirmedAccount = false;
            options.User.RequireUniqueEmail = true;
            options.Password.RequireDigit = false;
            options.Password.RequiredLength = 6;
            options.Password.RequireNonAlphanumeric = false;
            options.Password.RequireUppercase = false;
            options.Password.RequireLowercase = false;
        })
        .AddRoles<IdentityRole>()
        .AddEntityFrameworkStores<UserContext>();

        services.AddScoped<TokenService, TokenService>();
    }

    public void Configure(IApplicationBuilder app)
    {
        using (var scope = app.ApplicationServices.CreateScope())
        {
            var datadb = scope.ServiceProvider.GetRequiredService<MovieDBContext>();
            datadb.Database.Migrate();

            var userdb = scope.ServiceProvider.GetRequiredService<UserContext>();
            userdb.Database.Migrate();
        }

        if (Configuration.GetValue<string>("ASPNETCORE_ENVIRONMENT") == "Development")
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.SetupRoles();

        app.UseAuthentication();
        app.UseRouting();
        app.UseAuthorization();

        app.UseHttpsRedirection();

        app.UseCors();

        app.UseEndpoints(endpoints =>
        {
            endpoints.MapControllers();
        });
    }
}