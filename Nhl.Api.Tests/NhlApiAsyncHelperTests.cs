using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Common.Services;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class NhlApiAsyncHelperTests
    {
        [TestMethod]
        public async Task TestRunSyncAsync() 
        {
            NhlApiAsyncHelper.RunSync(async () =>  await Task.Run(() => Task.Delay(100)) );
        }

        [TestMethod]
        public async Task TestForEachAsync()
        {
            var numbers = new ConcurrentBag<int>(new [] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, });

            var sumOfNumbers = numbers.Sum();

            // Arrange + Act 
            await NhlApiAsyncHelper.ForEachAsync<int>(numbers, 2, async(i) =>
            {
                var value = numbers.TryTake(out i);
                numbers.Add(i * 2);
            });

            Assert.AreNotEqual(numbers.Sum(), sumOfNumbers);
            
        }
    }
}
