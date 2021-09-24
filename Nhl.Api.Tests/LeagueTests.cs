using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class LeagueTests
	{
		[TestMethod]
		public async Task TestGetLeagueStandingsNullDateAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var leagueStandings = await nhlApi.GetLeagueStandingsAsync(null);

			// Assert
			Assert.IsNotNull(leagueStandings);
			CollectionAssert.AllItemsAreNotNull(leagueStandings);

			foreach (var record in leagueStandings)
			{
				Assert.IsNotNull(record.Conference);
				Assert.IsNotNull(record.Division);
				Assert.IsNotNull(record.League);
				Assert.IsNotNull(record.StandingsType);
				Assert.IsNotNull(record.TeamRecords);
			}
		}

		[TestMethod]
		public async Task TestGetLeagueStandingsWithDateAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var leagueStandings = await nhlApi.GetLeagueStandingsAsync(System.DateTime.Parse("2019-03-12"));

			// Assert
			Assert.IsNotNull(leagueStandings);
			CollectionAssert.AllItemsAreNotNull(leagueStandings);

			foreach (var record in leagueStandings)
			{
				Assert.IsNotNull(record.Conference);
				Assert.IsNotNull(record.Division);
				Assert.IsNotNull(record.League);
				Assert.IsNotNull(record.StandingsType);
				Assert.IsNotNull(record.TeamRecords);
			}
		}
	}
}
