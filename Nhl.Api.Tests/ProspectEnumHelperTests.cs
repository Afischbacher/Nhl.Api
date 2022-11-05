using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Prospect;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class ProspectEnumHelperTests
    {
        [TestMethod]
        public void GetAllProspects()
        {
            var prospects = ProspectEnumHelper.GetAllProspects();
            Assert.IsNotNull(prospects);
            Assert.IsTrue(prospects.Count > 10000);
        }
    }
}
