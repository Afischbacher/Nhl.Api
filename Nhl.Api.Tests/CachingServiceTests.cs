using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Common.Services;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class CachingServiceTests
    {

        [TestMethod]
        public void TestTryAddAsync()
        {
            ICachingService service = new CachingService();

            (string key, string value) = (key: "key", value: "value");

            service.TryAddUpdate(key, value);

            var retrievedValue = service.TryGet<string>(key);

            Assert.IsNotNull(retrievedValue);
        }

        [TestMethod]
        public void TestTryAddUpdateAsync()
        {
            ICachingService service = new CachingService();

            (string key, string value) = (key: "key", value: "value");

            service.TryAddUpdate(key, value);

            var retrievedValue = service.TryGet<string>(key);

            Assert.IsNotNull(retrievedValue);

            service.TryAddUpdate(key, "new value");
            retrievedValue = service.TryGet<string>(key);

            Assert.IsNotNull(retrievedValue);
            Assert.AreEqual(retrievedValue, "new value");
        }

        [TestMethod]
        public void TestTryRemoveAsync()
        {
            ICachingService service = new CachingService();

            (string key, string value) = (key: "key", value: "value");

            service.TryAddUpdate(key, value);

            var retrievedValue = service.TryGet<string>(key);

            Assert.IsNotNull(retrievedValue);

            var isRemoved = service.Remove(key);

            Assert.IsTrue(isRemoved);
        }
    }
}
