using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Common.Exceptions;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Season;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class PlayerTests
	{
		[TestMethod]
		public async Task TestGetPlayerByIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			// Connor McDavid - Player Id - 8478402
			var player = await nhlApi.GetPlayerByIdAsync(8478402);

			// Assert
			Assert.IsNotNull(player);

			Assert.IsNotNull(player.Active);
			Assert.IsNotNull(player.AlternateCaptain);
			Assert.IsNotNull(player.BirthCountry);
			Assert.IsNotNull(player.BirthCity);

			Assert.IsNotNull(player.BirthDate);
			Assert.IsNotNull(player.Captain);
			Assert.IsNotNull(player.CurrentAge);
			Assert.IsNotNull(player.CurrentTeam);

			Assert.IsNotNull(player.FirstName);
			Assert.IsNotNull(player.LastName);
			Assert.IsNotNull(player.FullName);
			Assert.IsNotNull(player.Height);

			Assert.IsNotNull(player.ShootsCatches);
			Assert.IsNotNull(player.RosterStatus);
			Assert.IsNotNull(player.Weight);
			Assert.IsNotNull(player.Rookie);
			Assert.IsNotNull(player.PrimaryNumber);
			Assert.IsNotNull(player.Nationality);
			Assert.IsNotNull(player.Id);
			Assert.IsNotNull(player.Link);
			Assert.IsNotNull(player.PlayerHeadshotImageLink);

			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Small));
			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Medium));
			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Large));


		}

		[TestMethod]
		public async Task TestGetPlayerByIdEnumAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			// William Nylander - Player Id - 8477939
			var player = await nhlApi.GetPlayerByIdAsync(PlayerEnum.WilliamNylander8477939);

			// Assert
			Assert.IsNotNull(player);

			Assert.IsNotNull(player.Active);
			Assert.IsNotNull(player.AlternateCaptain);
			Assert.IsNotNull(player.BirthCountry);
			Assert.IsNotNull(player.BirthCity);

			Assert.IsNotNull(player.BirthDate);
			Assert.IsNotNull(player.Captain);
			Assert.IsNotNull(player.CurrentAge);
			Assert.IsNotNull(player.CurrentTeam);

			Assert.IsNotNull(player.FirstName);
			Assert.IsNotNull(player.LastName);
			Assert.IsNotNull(player.FullName);
			Assert.IsNotNull(player.Height);

			Assert.IsNotNull(player.ShootsCatches);
			Assert.IsNotNull(player.RosterStatus);
			Assert.IsNotNull(player.Weight);
			Assert.IsNotNull(player.Rookie);
			Assert.IsNotNull(player.PrimaryNumber);
			Assert.IsNotNull(player.Nationality);
			Assert.IsNotNull(player.Id);
			Assert.IsNotNull(player.Link);
			Assert.IsNotNull(player.PlayerHeadshotImageLink);

			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Small));
			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Medium));
			Assert.IsNotNull(player.GetPlayerHeadshotImageLink(Domain.Enumerations.Player.PlayerHeadshotImageSize.Large));
		}

		[TestMethod]
		public async Task TestGetPlayerByInvalidIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var player = await nhlApi.GetPlayerByIdAsync(1000);

			// Assert
			Assert.IsNull(player);
		}

		[TestMethod]
		public async Task TestGetPlayerStatisticsByTypeAndSeasonAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var playerStatistics = await nhlApi.GetPlayerStatisticsBySeasonAsync(PlayerEnum.AaronEkblad8477932, SeasonYear.season20202021);

			// Assert
			Assert.IsNotNull(playerStatistics);
			Assert.IsNotNull(playerStatistics.Statistics);
			Assert.IsNotNull(playerStatistics.Statistics.First().Type);
			Assert.IsNotNull(playerStatistics.Statistics.First().Splits);
			Assert.IsTrue(playerStatistics.Statistics.First().Splits.Any());

			var statisticsSplits = playerStatistics.Statistics.First().Splits.First();

			Assert.IsNotNull(statisticsSplits.Season);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData);

			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Assists);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Games);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.GameWinningGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Shifts);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShortHandedGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShortHandedPoints);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShortHandedTimeOnIce);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShortHandedTimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Shots);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShotPct);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Goals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Hits);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.OverTimeGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Points);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PlusMinus);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PowerPlayGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PowerPlayPoints);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PowerPlayTimeOnIce);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PowerPlayTimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.TimeOnIce);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.TimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Pim);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.OverTimeGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Blocked);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.EvenTimeOnIce);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PenaltyMinutes);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.FaceOffPct);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.EvenTimeOnIcePerGame);
		}


		[TestMethod]
		public async Task TestGetPlayerStatisticsByTypeAndSeasonWithPlayerIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var playerStatistics = await nhlApi.GetPlayerStatisticsBySeasonAsync(8477495, SeasonYear.season20192020);

			// Assert
			Assert.IsNotNull(playerStatistics);
			Assert.IsNotNull(playerStatistics.Statistics);
			Assert.IsNotNull(playerStatistics.Statistics.First().Type);
			Assert.IsNotNull(playerStatistics.Statistics.First().Splits);
			Assert.IsTrue(playerStatistics.Statistics.First().Splits.Any());

			var statisticsSplits = playerStatistics.Statistics.First().Splits.First();

			Assert.IsNotNull(statisticsSplits.Season);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData);

			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Assists);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Games);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.GameWinningGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Shifts);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShortHandedGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShortHandedPoints);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShortHandedTimeOnIce);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShortHandedTimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Shots);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.ShotPct);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Goals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Hits);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.OverTimeGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Points);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PlusMinus);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PowerPlayGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PowerPlayPoints);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PowerPlayTimeOnIce);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PowerPlayTimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.TimeOnIce);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.TimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Pim);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.OverTimeGoals);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Blocked);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.EvenTimeOnIce);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.PenaltyMinutes);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.FaceOffPct);
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.EvenTimeOnIcePerGame);

		}

		[TestMethod]
		public async Task TestGetPlayerStatisticsByTypeAndSeasonWithPlayerInvalidPlayerTypeAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act / Assert
			await Assert.ThrowsExceptionAsync<InvalidPlayerPositionException>((System.Func<Task>)(async () =>
			{
				await nhlApi.GetPlayerStatisticsBySeasonAsync((Models.Enumerations.Player.PlayerEnum)Models.Enumerations.Player.PlayerEnum.CraigAnderson8467950, (string)SeasonYear.season20192020);
			}));
		}

		[TestMethod]
		public async Task TestGetPlayerStatisticsByTypeAndSeasonWithPlayerIdInvalidPlayerTypeAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act / Assert
			await Assert.ThrowsExceptionAsync<InvalidPlayerPositionException>(async () =>
			{
				var test = await nhlApi.GetPlayerStatisticsBySeasonAsync(8471734, SeasonYear.season20192020);
			});
		}

		[TestMethod]
		public async Task TestGetGoalieStatisticsByTypeAndSeasonAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var goalieStatistics = await nhlApi.GetGoalieStatisticsBySeasonAsync(PlayerEnum.CareyPrice8471679, SeasonYear.season20202021);

			// Assert
			Assert.IsNotNull(goalieStatistics);
			Assert.IsNotNull(goalieStatistics.Statistics);
			Assert.IsNotNull(goalieStatistics.Statistics.First().Type);
			Assert.IsNotNull(goalieStatistics.Statistics.First().Splits);
			Assert.IsTrue(goalieStatistics.Statistics.First().Splits.Any());

			var statisticsSplits = goalieStatistics.Statistics.First().Splits.First();

			Assert.IsNotNull(statisticsSplits.Season);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData);

			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.SavePercentage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Games);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Saves);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.ShortHandedSavePercentage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.ShortHandedShots);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.ShortHandedSaves);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.ShotsAgainst);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Shutouts);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.EvenSaves);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.EvenShots);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.EvenStrengthSavePercentage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.GamesStarted);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.GoalAgainstAverage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Wins);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.TimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.TimeOnIce);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.EvenShots);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Ties);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Losses);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.GoalsAgainst);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.TimeOnIce);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.TimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Ot);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.PowerPlaySavePercentage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.PowerPlaySaves);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.PowerPlayShots);

		}


		[TestMethod]
		public async Task TestGetGoalieStatisticsWithPlayerIdAndSeasonAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var goalieStatistics = await nhlApi.GetGoalieStatisticsBySeasonAsync(8476412, SeasonYear.season20192020);

			// Assert
			Assert.IsNotNull(goalieStatistics);
			Assert.IsNotNull(goalieStatistics.Statistics);
			Assert.IsNotNull(goalieStatistics.Statistics.First().Type);
			Assert.IsNotNull(goalieStatistics.Statistics.First().Splits);
			Assert.IsTrue(goalieStatistics.Statistics.First().Splits.Any());

			var statisticsSplits = goalieStatistics.Statistics.First().Splits.First();

			Assert.IsNotNull(statisticsSplits.Season);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData);

			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.SavePercentage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Games);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Saves);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.ShortHandedSavePercentage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.ShortHandedShots);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.ShortHandedSaves);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.ShotsAgainst);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Shutouts);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.EvenSaves);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.EvenShots);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.EvenStrengthSavePercentage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.GamesStarted);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.GoalAgainstAverage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Wins);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.TimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.TimeOnIce);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Ties);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Losses);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.GoalsAgainst);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.TimeOnIce);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.TimeOnIcePerGame);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.Ot);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.PowerPlaySavePercentage);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.PowerPlaySaves);
			Assert.IsNotNull(statisticsSplits.GoalieStatisticsData.PowerPlayShots);
		}

		[TestMethod]
		public async Task TestSearchAllPlayersAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var results = await nhlApi.SearchAllPlayersAsync("Wayne Gretzky");

			// Assert
			Assert.IsNotNull(results);
			CollectionAssert.AllItemsAreNotNull(results);

			var playerSearchResult = results.First();

			Assert.AreEqual("Brantford", playerSearchResult.BirthCity);
			Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
			Assert.AreEqual("ON", playerSearchResult.BirthProvinceState);
			Assert.AreEqual(DateTime.Parse("1961-01-26"), playerSearchResult.BirthDate);
			Assert.AreEqual("Wayne", playerSearchResult.FirstName);
			Assert.AreEqual("Gretzky", playerSearchResult.LastName);
			Assert.AreEqual("NYR", playerSearchResult.LastTeamOfPlay);
			Assert.AreEqual("6\u0027 0\"", playerSearchResult.Height);
			Assert.AreEqual(99, playerSearchResult.PlayerNumber);

		}


		[TestMethod]
		public async Task TestSearchAllPlayersNoResultsAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act 
			var results = await nhlApi.SearchAllPlayersAsync("");

			// Assert
			Assert.IsNotNull(results);
			Assert.AreEqual(0, results.Count);

		}

		[TestMethod]
		public async Task TestGetGoalieStatisticsByTypeAndSeasonWithPlayerInvalidPlayerTypeAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act / Assert
			await Assert.ThrowsExceptionAsync<InvalidPlayerPositionException>((async () =>
			{
				await nhlApi.GetGoalieStatisticsBySeasonAsync(PlayerEnum.AlexOvechkin8471214, (string)SeasonYear.season20192020);
			}));
		}

		[TestMethod]
		public async Task TestGetGoalieStatisticsByTypeAndSeasonWithPlayerIdInvalidPlayerTypeAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act / Assert
			await Assert.ThrowsExceptionAsync<InvalidPlayerPositionException>(async () =>
			{
				var test = await nhlApi.GetGoalieStatisticsBySeasonAsync(8473986, SeasonYear.season20192020);
			});
		}
	}
}
