using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Venue;
using Nhl.Api.Tests.Helpers.Attributes;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class VenueTests
    {
        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetAllVenuesAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueVenues = await nhlApi.GetLeagueVenuesAsync();

            // Assert
            Assert.IsNotNull(leagueVenues);

            foreach (var record in leagueVenues)
            {
                Assert.IsNotNull(record.AppEnabled);
                Assert.IsNotNull(record.Id);
                Assert.IsNotNull(record.Link);
                Assert.IsNotNull(record.Name);
            }
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetLeagueVenueByIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueVenue = await nhlApi.GetLeagueVenueByIdAsync(5058);

            // Assert
            Assert.IsNotNull(leagueVenue);
            Assert.IsNotNull(leagueVenue.AppEnabled);
            Assert.IsNotNull(leagueVenue.Id);
            Assert.IsNotNull(leagueVenue.Link);
            Assert.IsNotNull(leagueVenue.Name);

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetLeagueVenueByIdEnumAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueVenue = await nhlApi.GetLeagueVenueByIdAsync(VenueEnum.BridgestoneArena);

            // Assert
            Assert.IsNotNull(leagueVenue);
            Assert.IsNotNull(leagueVenue.AppEnabled);
            Assert.IsNotNull(leagueVenue.Id);
            Assert.IsNotNull(leagueVenue.Link);
            Assert.IsNotNull(leagueVenue.Name);

        }
    }
}
