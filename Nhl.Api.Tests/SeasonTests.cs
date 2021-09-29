using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Season;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class SeasonTests
	{

		[TestMethod]
		public async Task TestGetLeagueStandingTypesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var leagueStandingTypes = await nhlApi.GetLeagueStandingTypesAsync();

			// Assert
			Assert.IsNotNull(leagueStandingTypes);
			CollectionAssert.AllItemsAreNotNull(leagueStandingTypes);

			foreach (var leagueStandingType in leagueStandingTypes)
			{
				Assert.IsNotNull(leagueStandingType.Description);
				Assert.IsNotNull(leagueStandingType.Name);
			}
		}

		[TestMethod]
		public async Task TestGetSeasonBySeasonYearAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var season = await nhlApi.GetSeasonByYearAsync(SeasonYear.season20192020);

			// Assert
			Assert.IsNotNull(season);
			Assert.IsNotNull(season.ConferencesInUse);
			Assert.IsNotNull(season.DivisionsInUse);
			Assert.IsNotNull(season.NumberOfGames);
			Assert.IsNotNull(season.OlympicsParticipation);
			Assert.IsNotNull(season.RegularSeasonStartDate);
			Assert.IsNotNull(season.RegularSeasonEndDate);
			Assert.IsNotNull(season.SeasonEndDate);
			Assert.IsNotNull(season.SeasonId);

		}

		[TestMethod]
		public async Task TestGetAllSeasonsAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var seasons = await nhlApi.GetSeasonsAsync();

			// Assert
			foreach (var season in seasons)
			{
				Assert.IsNotNull(season);
				Assert.IsNotNull(season.ConferencesInUse);
				Assert.IsNotNull(season.DivisionsInUse);
				Assert.IsNotNull(season.NumberOfGames);
				Assert.IsNotNull(season.OlympicsParticipation);
				Assert.IsNotNull(season.RegularSeasonStartDate);
				Assert.IsNotNull(season.RegularSeasonEndDate);
				Assert.IsNotNull(season.SeasonEndDate);
				Assert.IsNotNull(season.SeasonId);
			}

		}
	}
}
