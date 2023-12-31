namespace Nhl.Api.Tests;

[TestClass]
public class ResourceDisposeTests
{
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task ResourceDisposeAsyncTest()
    {
        await using var nhlApi = new NhlApi();

        await nhlApi.DisposeAsync();
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public void ResourceDisposeTest()
    {
        using var nhlApi = new NhlApi();

        nhlApi.Dispose();
    }
}
