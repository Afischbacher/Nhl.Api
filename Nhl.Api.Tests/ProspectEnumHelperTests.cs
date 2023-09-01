using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Prospect;
using Nhl.Api.Tests.Helpers.Attributes;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class ProspectEnumHelperTests
    {
        [TestMethodWithRetry(RetryCount = 5)]
        public void GetAllProspects()
        {
            var prospects = ProspectEnumHelper.GetAllProspects();
            Assert.IsNotNull(prospects);
            Assert.IsTrue(prospects.Count > 10000);
        }
    }
}
