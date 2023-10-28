namespace MovieDatabase.Frontend.Tests;
[CollectionDefinition(nameof(SharedFrontendCollection))]
public class SharedFrontendCollection : ICollectionFixture<MovieApplicationBackendFactory>, ICollectionFixture<MovieApplicationFrontendFactory>
{
}
