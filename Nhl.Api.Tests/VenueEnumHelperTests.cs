using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Team;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
