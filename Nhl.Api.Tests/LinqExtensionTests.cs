using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class LinqExtensionTests
    {
        class TestLinqClass
        {
            public int Number { get; set; }
        }

        [TestMethod]   
        public void TestDistinctByLinqMethod() 
        {
            var testCollection = new List<TestLinqClass>()
            {
               new TestLinqClass{ Number = 1 },
               new TestLinqClass{ Number = 2 },
               new TestLinqClass{ Number = 3 },
               new TestLinqClass{ Number = 2 }
            };

            var distinctValues = testCollection.DistinctBy(c => c.Number);

            Assert.IsNotNull(distinctValues);
            Assert.AreEqual(3, distinctValues.Count());
        }
    }
}
