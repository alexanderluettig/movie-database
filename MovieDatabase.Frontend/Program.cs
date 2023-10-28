using MovieDatabase.Frontend;

var builder = WebApplication.CreateBuilder(args);
var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);
var app = builder.Build();
startup.Configure(app);
app.MapBlazorHub();
app.MapFallbackToPage("/_Host");
app.Run();