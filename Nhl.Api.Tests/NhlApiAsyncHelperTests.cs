﻿using System.Collections.Concurrent;
using System.Linq;
using Nhl.Api.Common.Services;

namespace Nhl.Api.Tests;
[TestClass]
public class NhlApiAsyncHelperTests
{
    [TestMethodWithRetry(RetryCount = 5)]
    public void TestRunSyncAsync() => NhlApiAsyncHelper.RunSync(async () => await Task.Run(() => Task.Delay(100)));

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestForEachAsync()
    {
        var numbers = new ConcurrentBag<int>([1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11]);

        var sumOfNumbers = numbers.Sum();

        // Arrange + Act 
        await NhlApiAsyncHelper.ForEachAsync(numbers, 2, async (i) =>
        {
            var value = numbers.TryTake(out i);
            await Task.Run(() => numbers.Add(i * 2));
        });

        Assert.AreNotEqual(numbers.Sum(), sumOfNumbers);

    }
}
