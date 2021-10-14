using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class GameTests
	{

		[TestMethod]
		public async Task TestGetGameTypesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var gameTypes = await nhlApi.GetGameTypesAsync();

			// Assert
			Assert.IsNotNull(gameTypes);
			CollectionAssert.AllItemsAreNotNull(gameTypes);

			foreach (var gameType in gameTypes)
			{
				Assert.IsNotNull(gameType.Id);
				Assert.IsNotNull(gameType.Description);
				Assert.IsNotNull(gameType.Postseason);
			}
		}

		[TestMethod]
		public async Task TestGetGameStatusesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var gameStatuses = await nhlApi.GetGameStatusesAsync();

			// Assert
			Assert.IsNotNull(gameStatuses);
			CollectionAssert.AllItemsAreNotNull(gameStatuses);

			foreach (var gameStatus in gameStatuses)
			{
				Assert.IsNotNull(gameStatus.BaseballCode);
				Assert.IsNotNull(gameStatus.StartTimeTBD);
				Assert.IsNotNull(gameStatus.AbstractGameState);
				Assert.IsNotNull(gameStatus.DetailedState);
				Assert.IsNotNull(gameStatus.Code);
			}
		}

		[TestMethod]
		public async Task TestGetGamePlayTypesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var playTypes = await nhlApi.GetPlayTypesAsync();

			// Assert
			Assert.IsNotNull(playTypes);
			CollectionAssert.AllItemsAreNotNull(playTypes);

			foreach (var playType in playTypes)
			{
				Assert.IsNotNull(playType.Code);
				Assert.IsNotNull(playType.CmsKey);
				Assert.IsNotNull(playType.Id);
				Assert.IsNotNull(playType.Name);
				Assert.IsNotNull(playType.SecondaryEventCodes);
			}
		}

		[TestMethod]
		public async Task TestGetTournamentTypesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var tournamentTypes = await nhlApi.GetTournamentTypesAsync();

			// Assert
			Assert.IsNotNull(tournamentTypes);
			CollectionAssert.AllItemsAreNotNull(tournamentTypes);

			foreach (var tournamentType in tournamentTypes)
			{
				Assert.IsNotNull(tournamentType.Description);
				Assert.IsNotNull(tournamentType.GameTypeEnum);
				Assert.IsNotNull(tournamentType.Parameter);
			}
		}

		[TestMethod]
		[Ignore("Currently the API endpoint is not correctly displaying data")]
		public async Task TestGetPlayoffTournamentTypesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var playoffTournamentTypes = await nhlApi.GetPlayoffTournamentTypesAsync();

			// Assert
			Assert.IsNotNull(playoffTournamentTypes);

			foreach (var playoffTournamentRound in playoffTournamentTypes.Rounds)
			{
				Assert.IsNotNull(playoffTournamentRound.Code);
				Assert.IsNotNull(playoffTournamentRound.Format);
				Assert.IsNotNull(playoffTournamentRound.Names);
				Assert.IsNotNull(playoffTournamentRound.Number);
			}
		}


		[TestMethod]
		public async Task TestGetGetGameScheduleByDateAsnyc()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var gameSchedule = await nhlApi.GetGameScheduleByDateAsync(null);

			// Assert
			Assert.IsNotNull(gameSchedule);
			Assert.IsNotNull(gameSchedule.MetaData);
			Assert.IsNotNull(gameSchedule.TotalEvents);
			Assert.IsNotNull(gameSchedule.TotalGames);
			Assert.IsNotNull(gameSchedule.TotalItems);
			Assert.IsNotNull(gameSchedule.TotalMatches);

			foreach (var gameDate in gameSchedule.Dates)
			{
				Assert.IsNotNull(gameDate.TotalEvents);
				Assert.IsNotNull(gameDate.TotalGames);
				Assert.IsNotNull(gameDate.TotalMatches);
				Assert.IsNotNull(gameDate.Matches);
				Assert.IsNotNull(gameDate.Events);
			}
		}


		[TestMethod]
		public async Task TestGetGetGameScheduleByDateNotNullAsnyc()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var gameSchedule = await nhlApi.GetGameScheduleByDateAsync(DateTime.Parse("2020-01-29"));

			// Assert
			Assert.IsNotNull(gameSchedule);
			Assert.IsNotNull(gameSchedule.MetaData);
			Assert.IsNotNull(gameSchedule.TotalEvents);
			Assert.IsNotNull(gameSchedule.TotalGames);
			Assert.IsNotNull(gameSchedule.TotalItems);
			Assert.IsNotNull(gameSchedule.TotalMatches);

			foreach (var gameDate in gameSchedule.Dates)
			{
				Assert.IsNotNull(gameDate.TotalEvents);
				Assert.IsNotNull(gameDate.TotalGames);
				Assert.IsNotNull(gameDate.TotalMatches);
				Assert.IsNotNull(gameDate.Matches);
				Assert.IsNotNull(gameDate.Events);
			}
		}

		[TestMethod]
		public async Task TestGetGetGameScheduleByDateNotNullWithInAsnyc()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var gameSchedule = await nhlApi.GetGameScheduleByDateAsync(2020, 1, 29);

			// Assert
			Assert.IsNotNull(gameSchedule);
			Assert.IsNotNull(gameSchedule.MetaData);
			Assert.IsNotNull(gameSchedule.TotalEvents);
			Assert.IsNotNull(gameSchedule.TotalGames);
			Assert.IsNotNull(gameSchedule.TotalItems);
			Assert.IsNotNull(gameSchedule.TotalMatches);

			foreach (var gameDate in gameSchedule.Dates)
			{
				Assert.IsNotNull(gameDate.TotalEvents);
				Assert.IsNotNull(gameDate.TotalGames);
				Assert.IsNotNull(gameDate.TotalMatches);
				Assert.IsNotNull(gameDate.Matches);
				Assert.IsNotNull(gameDate.Events);
			}
		}
	}
}
