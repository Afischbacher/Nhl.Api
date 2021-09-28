using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class VenueTests
	{
		[TestMethod]
		public async Task TestGetAllVenuesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

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

		[TestMethod]
		public async Task TestGetLeagueVenueByIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var leagueVenue = await nhlApi.GetLeagueVenueByIdAsync(5058);

			// Assert
			Assert.IsNotNull(leagueVenue);

			Assert.IsNotNull(leagueVenue.AppEnabled);
			Assert.IsNotNull(leagueVenue.Id);
			Assert.IsNotNull(leagueVenue.Link);
			Assert.IsNotNull(leagueVenue.Name);

		}
	}
}
