using Nhl.Api.Common.Services;

namespace Nhl.Api.Tests;
[TestClass]
public class CachingServiceTests
{

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestTryAddAsync()
    {
        CachingService service = new();

        (var key, var value) = ("key", "value");

        await service.TryAddUpdateAsync(key, value);

        var retrievedValue = service.TryGetAsync<string>(key);

        Assert.IsNotNull(retrievedValue);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestTryAddUpdateAsync()
    {
        CachingService service = new();

        (var key, var value) = ("key", "value");

        await service.TryAddUpdateAsync(key, value);

        var retrievedValue = await service.TryGetAsync<string>(key);

        Assert.IsNotNull(retrievedValue);

        await service.TryAddUpdateAsync(key, "new value");
        retrievedValue = await service.TryGetAsync<string>(key);

        Assert.IsNotNull(retrievedValue);
        Assert.AreEqual(retrievedValue, "new value");
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestTryRemoveAsync()
    {
        CachingService service = new();

        (var key, var value) = ("key", "value");

        await service.TryAddUpdateAsync(key, value);

        var retrievedValue = await service.TryGetAsync<string>(key);

        Assert.IsNotNull(retrievedValue);

        var isRemoved = await service.RemoveAsync(key);

        Assert.IsTrue(isRemoved);
    }
}
