using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Tests.Helpers.Attributes;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class VenueEnumHelperTests
    {
        [TestMethodWithRetry(RetryCount = 5)]
        public void GetAllVenuesTest()
        {
            var venues = VenueEnumHelper.GetAllVenues();
            Assert.IsNotNull(venues);
            Assert.IsTrue(venues.Count > 30);
        }
    }
}
