using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Season;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
	[TestClass]
	public class StatisticsTests
	{
		[TestMethod]
		public async Task TestGetStatisticsTypesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var statisticsTypes = await nhlApi.GetStatisticTypesAsync();

			// Assert
			Assert.IsNotNull(statisticsTypes);
			CollectionAssert.AllItemsAreNotNull(statisticsTypes);

			foreach (var statisticsType in statisticsTypes)
			{
				Assert.IsNotNull(statisticsType.DisplayName);
			}

		}

		[TestMethod]
		public async Task TestGetTeamStatisticByIdAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teamStatistics = await nhlApi.GetTeamStatisticsByIdAsync(10, null);

			// Assert
			Assert.IsNotNull(teamStatistics);
			CollectionAssert.AllItemsAreNotNull(teamStatistics.Statistics);

			foreach (var statistic in teamStatistics.Statistics)
			{
				CollectionAssert.AllItemsAreNotNull(statistic.Splits);
				foreach (var split in statistic.Splits)
				{
					Assert.IsNotNull(split.Team);
					Assert.IsNotNull(split.Team.Id);
					Assert.IsNotNull(split.Team.Link);
					Assert.IsNotNull(split.Team.Name);

					Assert.IsNotNull(split.TeamStatisticsDetails.EvGGARatio);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffsLost);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffsTaken);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffsWon);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffWinPercentage);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinLeadFirstPer);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinLeadSecondPer);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinOppScoreFirst);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinOutshootOpp);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinOutshotByOpp);
					Assert.IsNotNull(split.TeamStatisticsDetails.Wins);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinScoreFirst);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffsWon);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffWinPercentage);
					Assert.IsNotNull(split.TeamStatisticsDetails.GamesPlayed);
					Assert.IsNotNull(split.TeamStatisticsDetails.GoalsAgainstPerGame);
					Assert.IsNotNull(split.TeamStatisticsDetails.GoalsPerGame);

					Assert.IsNotNull(split.TeamStatisticsDetails.Losses);
					Assert.IsNotNull(split.TeamStatisticsDetails.Ot);
					Assert.IsNotNull(split.TeamStatisticsDetails.PowerPlayGoalsAgainst);
					Assert.IsNotNull(split.TeamStatisticsDetails.PowerPlayOpportunities);
					Assert.IsNotNull(split.TeamStatisticsDetails.PowerPlayPercentage);

					Assert.IsNotNull(split.TeamStatisticsDetails.PowerPlayGoals);
					Assert.IsNotNull(split.TeamStatisticsDetails.PenaltyKillPercentage);
					Assert.IsNotNull(split.TeamStatisticsDetails.ShootingPctg);
					Assert.IsNotNull(split.TeamStatisticsDetails.ShotsPerGame);
				}

				if (statistic.Type.DisplayName != "regularSeasonStatRankings")
				{
					Assert.IsNotNull(statistic.Type);
					Assert.IsNotNull(statistic.Type.DisplayName);
					Assert.IsNotNull(statistic.Type.GameType);
					Assert.IsNotNull(statistic.Type.GameType.Description);
					Assert.IsNotNull(statistic.Type.GameType.Id);
					Assert.IsNotNull(statistic.Type.GameType.Postseason);
				}

			}
		}

		[TestMethod]
		public async Task TestGetTeamStatisticByIdWithSeasonYearAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var teamStatistics = await nhlApi.GetTeamStatisticsByIdAsync(10, SeasonYear.season19171918);

			// Assert
			Assert.IsNotNull(teamStatistics);
			CollectionAssert.AllItemsAreNotNull(teamStatistics.Statistics);

			foreach (var statistic in teamStatistics.Statistics)
			{
				CollectionAssert.AllItemsAreNotNull(statistic.Splits);
				foreach (var split in statistic.Splits)
				{
					Assert.IsNotNull(split.Team);
					Assert.IsNotNull(split.Team.Id);
					Assert.IsNotNull(split.Team.Link);
					Assert.IsNotNull(split.Team.Name);

					Assert.IsNotNull(split.TeamStatisticsDetails.EvGGARatio);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffsLost);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffsTaken);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffsWon);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffWinPercentage);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinLeadFirstPer);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinLeadSecondPer);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinOppScoreFirst);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinOutshootOpp);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinOutshotByOpp);
					Assert.IsNotNull(split.TeamStatisticsDetails.Wins);
					Assert.IsNotNull(split.TeamStatisticsDetails.WinScoreFirst);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffsWon);
					Assert.IsNotNull(split.TeamStatisticsDetails.FaceOffWinPercentage);
					Assert.IsNotNull(split.TeamStatisticsDetails.GamesPlayed);
					Assert.IsNotNull(split.TeamStatisticsDetails.GoalsAgainstPerGame);
					Assert.IsNotNull(split.TeamStatisticsDetails.GoalsPerGame);

					Assert.IsNotNull(split.TeamStatisticsDetails.Losses);
					Assert.IsNotNull(split.TeamStatisticsDetails.Ot);
					Assert.IsNotNull(split.TeamStatisticsDetails.PowerPlayGoalsAgainst);
					Assert.IsNotNull(split.TeamStatisticsDetails.PowerPlayOpportunities);
					Assert.IsNotNull(split.TeamStatisticsDetails.PowerPlayPercentage);

					Assert.IsNotNull(split.TeamStatisticsDetails.PowerPlayGoals);
					Assert.IsNotNull(split.TeamStatisticsDetails.PenaltyKillPercentage);
					Assert.IsNotNull(split.TeamStatisticsDetails.ShootingPctg);
					Assert.IsNotNull(split.TeamStatisticsDetails.ShotsPerGame);
				}

				if (statistic.Type.DisplayName != "regularSeasonStatRankings")
				{
					Assert.IsNotNull(statistic.Type);
					Assert.IsNotNull(statistic.Type.DisplayName);
					Assert.IsNotNull(statistic.Type.GameType);
					Assert.IsNotNull(statistic.Type.GameType.Description);
					Assert.IsNotNull(statistic.Type.GameType.Id);
					Assert.IsNotNull(statistic.Type.GameType.Postseason);
				}

			}
		}
	}
}
