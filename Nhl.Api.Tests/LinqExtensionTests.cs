using System.Linq;

namespace Nhl.Api.Tests;
[TestClass]
public class LinqExtensionTests
{
    internal sealed class TestLinqClass
    {
        public int Number { get; set; }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public void TestDistinctByLinqMethod()
    {
        var testCollection = new List<TestLinqClass>()
        {
           new() { Number = 1 },
           new() { Number = 2 },
           new() { Number = 3 },
           new() { Number = 2 }
        };

        var distinctValues = testCollection.DistinctBy(c => c.Number);

        Assert.IsNotNull(distinctValues);
        Assert.AreEqual(3, distinctValues.Count());
    }
}
