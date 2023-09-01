using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Team;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class VenueEnumHelperTests
    {
        [TestMethod]
        public void GetAllVenuesTest() 
        {
            var venues = VenueEnumHelper.GetAllVenues();
            Assert.IsNotNull(venues);
            Assert.IsTrue(venues.Count > 30);
        }
    }
}
