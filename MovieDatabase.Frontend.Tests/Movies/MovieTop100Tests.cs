using FluentAssertions;
using MovieDatabase.Frontend.Tests;

[Collection(nameof(SharedFrontendCollection))]
public class MovieTop100Tests : IAsyncLifetime
{
    private readonly MovieApplicationFrontendFactory _factory;
    private readonly Func<Task> _resetData;

    public Task DisposeAsync() => _resetData();

    public Task InitializeAsync() => Task.CompletedTask;

    public MovieTop100Tests(MovieApplicationFrontendFactory factory)
    {
        _factory = factory;
        _resetData = _factory.ResetDataAsync;
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