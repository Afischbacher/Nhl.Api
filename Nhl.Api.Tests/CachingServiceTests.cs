using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Common.Services;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class CachingServiceTests
    {

        [TestMethod]
        public async Task TestTryAddAsync()
        {
            ICachingService service = new CachingService();

            (string key, string value) = ("key", "value");

            await service.TryAddUpdateAsync(key, value);

            var retrievedValue = service.TryGetAsync<string>(key);

            Assert.IsNotNull(retrievedValue);
        }

        [TestMethod]
        public async Task TestTryAddUpdateAsync()
        {
            ICachingService service = new CachingService();

            (string key, string value) = ("key", "value");

            await service.TryAddUpdateAsync(key, value);

            var retrievedValue = await service.TryGetAsync<string>(key);

            Assert.IsNotNull(retrievedValue);

            await service.TryAddUpdateAsync(key, "new value");
            retrievedValue = await service.TryGetAsync<string>(key);

            Assert.IsNotNull(retrievedValue);
            Assert.AreEqual(retrievedValue, "new value");
        }

        [TestMethod]
        public async Task TestTryRemoveAsync()
        {
            ICachingService service = new CachingService();

            (string key, string value) = ("key", "value");

            await service.TryAddUpdateAsync(key, value);

            var retrievedValue = await service.TryGetAsync<string>(key);

            Assert.IsNotNull(retrievedValue);

            var isRemoved = await service.RemoveAsync(key);

            Assert.IsTrue(isRemoved);
        }
    }
}
