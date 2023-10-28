namespace MovieDatabase.Backend.Tests
{
    [CollectionDefinition(nameof(SharedBackendCollection))]
    public class SharedBackendCollection : ICollectionFixture<MovieApplicationFactory>
    {
    }
}