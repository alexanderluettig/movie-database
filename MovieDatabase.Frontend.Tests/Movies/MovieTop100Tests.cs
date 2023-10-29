using FluentAssertions;
using MovieDatabase.Frontend.Tests;

[Collection(nameof(SharedFrontendCollection))]
public class MovieTop100Tests
{
    private readonly MovieApplicationFrontendFactory _factory;

    public MovieTop100Tests(MovieApplicationFrontendFactory factory)
    {
        _factory = factory;
    }

    [Fact]
    public async Task It_should_display_100_Movies()
    {
        var page = await _factory.Browser.NewPageAsync();
        await page.GotoAsync(_factory.ServerAddress + "/");
        var movies = await page.QuerySelectorAllAsync(".movie");
        movies.Count.Should().Be(100);
    }
}