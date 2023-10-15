namespace MovieDatabase.Backend.Tests
{
    [CollectionDefinition(nameof(SharedTestCollection))]
    public class SharedTestCollection : ICollectionFixture<MovieApplicationFactory>
    {
    }
}