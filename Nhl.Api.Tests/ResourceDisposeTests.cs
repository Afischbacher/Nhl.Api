using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class ResourceDisposeTests
    {
        [TestMethod]
        public async Task ResourceDisposeAsyncTest() 
        {
            await using var nhlApi = new NhlApi();

            await nhlApi.DisposeAsync();
        }

        [TestMethod]
        public void ResourceDisposeTest()
        {
            using var nhlApi = new NhlApi();

            nhlApi.Dispose();
        }
    }
}
