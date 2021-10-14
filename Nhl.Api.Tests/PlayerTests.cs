using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Common.Exceptions;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Season;
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
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Games);
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
			Assert.IsNotNull(statisticsSplits.PlayerStatisticsData.Games);
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
		}

		[TestMethod]
		public async Task TestGetPlayerStatisticsByTypeAndSeasonWithPlayerInvalidPlayerTypeAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act / Assert
			await Assert.ThrowsExceptionAsync<InvalidPlayerPositionException>(async () =>
			{
				await nhlApi.GetPlayerStatisticsBySeasonAsync(PlayerEnum.CraigAnderson8467950, SeasonYear.season20192020);
			});
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
	}
}
