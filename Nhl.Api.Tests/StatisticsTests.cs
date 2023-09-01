using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Season;
using Nhl.Api.Tests.Helpers.Attributes;
using System;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class StatisticsTests
    {

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetStatisticsTypesAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

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

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamStatisticByIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

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

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamStatisticByIdEnumAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamStatistics = await nhlApi.GetTeamStatisticsByIdAsync(TeamEnum.ArizonaCoyotes, null);

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

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamStatisticByIdWithSeasonYearAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

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

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetTeamStatisticByIdWithEnumAndSeasonYearAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var teamStatistics = await nhlApi.GetTeamStatisticsByIdAsync(TeamEnum.CalgaryFlames, SeasonYear.season20052006);

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

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetPlayerByStatisticTypeBySeasonAsync()
        {
            await using INhlApi nhlApi = new NhlApi();

            var enumValues = Enum.GetValues(typeof(PlayerStatisticEnum)) as PlayerStatisticEnum[];

            foreach (var playerStatistic in enumValues)
            {
                var player = await nhlApi.GetPlayerByStatisticTypeBySeasonAsync(playerStatistic, SeasonYear.season20192020);

                Assert.IsNotNull(player);
                Assert.IsNotNull(player.PlayerStatisticsData);
                Assert.IsNotNull(player.PlayerStatisticsData.Shifts);
                Assert.IsNotNull(player.PlayerStatisticsData.Shots);
                Assert.IsNotNull(player.PlayerStatisticsData.ShortHandedGoals);
                Assert.IsNotNull(player.PlayerStatisticsData.Assists);
                Assert.IsNotNull(player.PlayerStatisticsData.Points);

                Assert.IsNotNull(player.PlayerStatisticsData.Hits);
                Assert.IsNotNull(player.PlayerStatisticsData.Pim);
                Assert.IsNotNull(player.PlayerStatisticsData.FaceOffPct);
                Assert.IsNotNull(player.PlayerStatisticsData.Games);
                Assert.IsNotNull(player.PlayerStatisticsData.TimeOnIce);

                Assert.IsNotNull(player.Player);
                Assert.IsNotNull(player.Player);
                Assert.IsNotNull(player.Player.Id);
                Assert.IsNotNull(player.Player.FullName);

            }
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetGoalieByStatisticTypeBySeasonAsync()
        {
            await using INhlApi nhlApi = new NhlApi();

            var enumValues = Enum.GetValues(typeof(GoalieStatisticEnum)) as GoalieStatisticEnum[];

            foreach (var goalieStatistic in enumValues)
            {
                var goalie = await nhlApi.GetGoalieByStatisticTypeBySeasonAsync(goalieStatistic, SeasonYear.season19992000);

                Assert.IsNotNull(goalie);

                Assert.IsNotNull(goalie.GoalieStatisticsData.SavePercentage);
                Assert.IsNotNull(goalie.GoalieStatisticsData.EvenSaves);
                Assert.IsNotNull(goalie.GoalieStatisticsData.Games);
                Assert.IsNotNull(goalie.GoalieStatisticsData.GamesStarted);
                Assert.IsNotNull(goalie.GoalieStatisticsData.TimeOnIcePerGame);
                Assert.IsNotNull(goalie.GoalieStatisticsData.PowerPlaySavePercentage);
                Assert.IsNotNull(goalie.GoalieStatisticsData.Wins);
                Assert.IsNotNull(goalie.GoalieStatisticsData.Losses);
                Assert.IsNotNull(goalie.GoalieStatisticsData.Shutouts);
                Assert.IsNotNull(goalie.GoalieStatisticsData.ShotsAgainst);

                Assert.IsNotNull(goalie.Player);
                Assert.IsNotNull(goalie.Player.Id);
                Assert.IsNotNull(goalie.Player.FullName);

            }
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetPlayersByStatisticTypeBySeasonAsync()
        {
            await using INhlApi nhlApi = new NhlApi();

            var enumValues = Enum.GetValues(typeof(PlayerStatisticEnum)) as PlayerStatisticEnum[];

            foreach (var playerStatistic in enumValues)
            {

                var players = await nhlApi.GetPlayersByStatisticTypeBySeasonAsync(playerStatistic, SeasonYear.season20192020);
                foreach (var player in players)
                {

                    Assert.IsNotNull(player);
                    Assert.IsNotNull(player.PlayerStatisticsData);
                    Assert.IsNotNull(player.PlayerStatisticsData.Shifts);
                    Assert.IsNotNull(player.PlayerStatisticsData.Shots);
                    Assert.IsNotNull(player.PlayerStatisticsData.ShortHandedGoals);
                    Assert.IsNotNull(player.PlayerStatisticsData.Assists);
                    Assert.IsNotNull(player.PlayerStatisticsData.Points);

                    Assert.IsNotNull(player.PlayerStatisticsData.Hits);
                    Assert.IsNotNull(player.PlayerStatisticsData.Pim);
                    Assert.IsNotNull(player.PlayerStatisticsData.FaceOffPct);
                    Assert.IsNotNull(player.PlayerStatisticsData.Games);
                    Assert.IsNotNull(player.PlayerStatisticsData.TimeOnIce);

                    Assert.IsNotNull(player.Player);
                    Assert.IsNotNull(player.Player);
                    Assert.IsNotNull(player.Player.Id);
                    Assert.IsNotNull(player.Player.FullName);
                }
            }
        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetPlayersByStatisticTypeBySeasonAscendingAsync()
        {
            await using INhlApi nhlApi = new NhlApi();

            var enumValues = Enum.GetValues(typeof(PlayerStatisticEnum)) as PlayerStatisticEnum[];

            foreach (var playerStatistic in enumValues)
            {

                var players = await nhlApi.GetPlayersByStatisticTypeBySeasonAsync(playerStatistic, SeasonYear.season20192020, isDescending: false, numberOfPlayers: 25);
                foreach (var player in players)
                {

                    Assert.IsNotNull(player);
                    Assert.IsNotNull(player.PlayerStatisticsData);
                    Assert.IsNotNull(player.PlayerStatisticsData.Shifts);
                    Assert.IsNotNull(player.PlayerStatisticsData.Shots);
                    Assert.IsNotNull(player.PlayerStatisticsData.ShortHandedGoals);
                    Assert.IsNotNull(player.PlayerStatisticsData.Assists);
                    Assert.IsNotNull(player.PlayerStatisticsData.Points);

                    Assert.IsNotNull(player.PlayerStatisticsData.Hits);
                    Assert.IsNotNull(player.PlayerStatisticsData.Pim);
                    Assert.IsNotNull(player.PlayerStatisticsData.FaceOffPct);
                    Assert.IsNotNull(player.PlayerStatisticsData.Games);
                    Assert.IsNotNull(player.PlayerStatisticsData.TimeOnIce);

                    Assert.IsNotNull(player.Player);
                    Assert.IsNotNull(player.Player);
                    Assert.IsNotNull(player.Player.Id);
                    Assert.IsNotNull(player.Player.FullName);
                }

            }
        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetGoaliesWithTopStatisticBySeasonAsync()
        {
            await using INhlApi nhlApi = new NhlApi();

            var enumValues = Enum.GetValues(typeof(GoalieStatisticEnum)) as GoalieStatisticEnum[];

            foreach (var goalieStatistic in enumValues)
            {

                var goalies = await nhlApi.GetGoaliesByStatisticTypeBySeasonAsync(goalieStatistic, SeasonYear.season20212022);

                var test = JsonConvert.SerializeObject(goalies);
                foreach (var goalie in goalies)
                {
                    Assert.IsNotNull(goalie);

                    Assert.IsNotNull(goalie.GoalieStatisticsData.SavePercentage);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.EvenSaves);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.Games);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.GamesStarted);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.TimeOnIcePerGame);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.PowerPlaySavePercentage);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.Wins);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.Losses);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.Shutouts);
                    Assert.IsNotNull(goalie.GoalieStatisticsData.ShotsAgainst);

                    Assert.IsNotNull(goalie.Player);
                    Assert.IsNotNull(goalie.Player.Id);
                    Assert.IsNotNull(goalie.Player.FullName);
                }
            }
        }
    }
}
