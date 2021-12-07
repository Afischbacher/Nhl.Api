using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Common.Exceptions;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using System;
using System.Collections.Generic;
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
            using INhlApi nhlApi = new NhlApi();

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

            Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Small));
            Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Medium));
            Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Large));


        }

        [TestMethod]
        public async Task TestGetPlayerByIdEnumAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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

            Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Small));
            Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Medium));
            Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Large));
        }

        [TestMethod]
        public async Task TestGetManyPlayersByIdEnumAsync()
        {
            // Arrange
            using  INhlApi nhlApi = new NhlApi();

            // Act 
            var players = await nhlApi.GetPlayersByIdAsync(new[] { PlayerEnum.WilliamNylander8477939, PlayerEnum.NicoHischier8480002, PlayerEnum.AndreiVasilevskiy8476883 });

            // Assert
            Assert.IsNotNull(players);
            foreach (var player in players)
            {

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

                Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Small));
                Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Medium));
                Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Large));
            }
        }

        [TestMethod]
        public async Task TestGetManyPlayersByIdAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var players = await nhlApi.GetPlayersByIdAsync(new[] { 8477939, 8480002, 8474141 });

            // Assert
            Assert.IsNotNull(players);
            foreach (var player in players)
            {

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

                Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Small));
                Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Medium));
                Assert.IsNotNull(player.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Large));
            }
        }


        [TestMethod]
        public async Task TestGetPlayerByInvalidIdAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var player = await nhlApi.GetPlayerByIdAsync(1000);

            // Assert
            Assert.IsNull(player);
        }

        [TestMethod]
        public async Task TestGetPlayerStatisticsByTypeAndSeasonAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
        [DataRow("Wayne Gretzky")]
        [DataRow("Alex Ovechkin")]
        [DataRow("Connor McDavid")]
        public async Task TestSearchAllPlayersAsync(string query)
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var results = await nhlApi.SearchAllPlayersAsync(query);

            // Assert
            Assert.IsNotNull(results);
            CollectionAssert.AllItemsAreNotNull(results);

            var playerSearchResult = results.First();

            switch (query)
            {
                case "Wayne Gretzky":
                    Assert.AreEqual("Brantford", playerSearchResult.BirthCity);
                    Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual("ON", playerSearchResult.BirthProvinceState);
                    Assert.AreEqual(DateTime.Parse("1961-01-26"), playerSearchResult.BirthDate);
                    Assert.AreEqual("Wayne", playerSearchResult.FirstName);
                    Assert.AreEqual("Gretzky", playerSearchResult.LastName);
                    Assert.AreEqual("NYR", playerSearchResult.LastTeamOfPlay);
                    Assert.AreEqual("6\u0027 0\"", playerSearchResult.Height);
                    Assert.AreEqual(false, playerSearchResult.IsActive);
                    Assert.AreEqual(99, playerSearchResult.PlayerNumber);
                    break;
                case "Alex Ovechkin":
                    Assert.AreEqual("Moscow", playerSearchResult.BirthCity);
                    Assert.AreEqual("RUS", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Russian Federation", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual("", playerSearchResult.BirthProvinceState);
                    Assert.AreEqual(DateTime.Parse("1985-09-17"), playerSearchResult.BirthDate);
                    Assert.AreEqual("Alex", playerSearchResult.FirstName);
                    Assert.AreEqual("Ovechkin", playerSearchResult.LastName);
                    Assert.AreEqual(true, playerSearchResult.IsActive);
                    Assert.AreEqual("WSH", playerSearchResult.LastTeamOfPlay);
                    Assert.AreEqual("6\u0027 3\"", playerSearchResult.Height);
                    Assert.AreEqual(8, playerSearchResult.PlayerNumber);
                    break;

                case "Connor McDavid":
                    Assert.AreEqual("Richmond Hill", playerSearchResult.BirthCity);
                    Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual("ON", playerSearchResult.BirthProvinceState);
                    Assert.AreEqual(DateTime.Parse("1997-01-13"), playerSearchResult.BirthDate);
                    Assert.AreEqual("Connor", playerSearchResult.FirstName);
                    Assert.AreEqual("McDavid", playerSearchResult.LastName);
                    Assert.AreEqual(true, playerSearchResult.IsActive);
                    Assert.AreEqual("EDM", playerSearchResult.LastTeamOfPlay);
                    Assert.AreEqual("6\u0027 1\"", playerSearchResult.Height);
                    Assert.AreEqual(97, playerSearchResult.PlayerNumber);
                    break;
            }

        }

        [TestMethod]
        public async Task TestSearchAllPlayersNoResultsAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var results = await nhlApi.SearchAllPlayersAsync("");

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(0, results.Count);

        }

        [TestMethod]
        public async Task TestPlayersByIdWithTasksAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var results = new List<Task<Player>>
            {
                nhlApi.GetPlayerByIdAsync(PlayerEnum.ConnorMcDavid8478402),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.SidneyCrosby8471675),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.AustonMatthews8479318),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.MitchellMarner8478483),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.NathanMacKinnon8477492),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.JacobMarkstrom8474593),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.ZackKassian8475178),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.AlexOvechkin8471214),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.StevenStamkos8474564),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.BraydenPoint8478010),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.TJMiller8473529),
                nhlApi.GetPlayerByIdAsync(PlayerEnum.EliasPettersson8480012)
            };

            var players = await Task.WhenAll(results);

            // Assert
            Assert.IsNotNull(players);
            Assert.AreEqual(12, players.Count());

        }


        [TestMethod]
        [DataRow(PlayerEnum.SidneyCrosby8471675)]
        [DataRow(PlayerEnum.ConnorMcDavid8478402)]
        [DataRow(PlayerEnum.AustonMatthews8479318)]
        [DataRow(PlayerEnum.AlexOvechkin8471214)]

        public async Task TestGetOnPaceRegularSeasonPlayerStatisticsWithEnumAsync(PlayerEnum playerEnum)
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var playerOnPaceRegularSeason = await nhlApi.GetOnPaceRegularSeasonPlayerStatisticsAsync(playerEnum);

            // Assert
            var isRegularSeasonActive = await nhlApi.IsRegularSeasonActiveAsync();
            if (isRegularSeasonActive)
            {
                Assert.IsNotNull(playerOnPaceRegularSeason);

                var playerStatisticSplits = playerOnPaceRegularSeason.Statistics.First().Splits.First().PlayerStatisticsData;
                Assert.IsNotNull(playerStatisticSplits);
                Assert.IsNotNull(playerStatisticSplits.Assists);
                Assert.IsNotNull(playerStatisticSplits.Games);
                Assert.IsNotNull(playerStatisticSplits.GameWinningGoals);
                Assert.IsNotNull(playerStatisticSplits.Shifts);
                Assert.IsNotNull(playerStatisticSplits.ShortHandedGoals);
                Assert.IsNotNull(playerStatisticSplits.ShortHandedPoints);
                Assert.IsNotNull(playerStatisticSplits.ShortHandedTimeOnIce);
                Assert.IsNotNull(playerStatisticSplits.Shots);
                Assert.IsNotNull(playerStatisticSplits.ShotPct);
                Assert.IsNotNull(playerStatisticSplits.Goals);
                Assert.IsNotNull(playerStatisticSplits.Hits);
                Assert.IsNotNull(playerStatisticSplits.OverTimeGoals);
                Assert.IsNotNull(playerStatisticSplits.Points);
                Assert.IsNotNull(playerStatisticSplits.PlusMinus);
                Assert.IsNotNull(playerStatisticSplits.PowerPlayGoals);
                Assert.IsNotNull(playerStatisticSplits.PowerPlayPoints);
                Assert.IsNotNull(playerStatisticSplits.PowerPlayTimeOnIce);
                Assert.IsNotNull(playerStatisticSplits.PowerPlayTimeOnIcePerGame);
                Assert.IsNotNull(playerStatisticSplits.TimeOnIce);
                Assert.IsNotNull(playerStatisticSplits.TimeOnIcePerGame);
                Assert.IsNotNull(playerStatisticSplits.Pim);
                Assert.IsNotNull(playerStatisticSplits.OverTimeGoals);
                Assert.IsNotNull(playerStatisticSplits.Blocked);
                Assert.IsNotNull(playerStatisticSplits.EvenTimeOnIce);
                Assert.IsNotNull(playerStatisticSplits.PenaltyMinutes);
                Assert.IsNotNull(playerStatisticSplits.FaceOffPct);
                Assert.IsNotNull(playerStatisticSplits.EvenTimeOnIcePerGame);
            }
            else
            {
                Assert.IsNotNull(playerOnPaceRegularSeason);
                Assert.IsNotNull(playerOnPaceRegularSeason.Statistics);
            }
        }

        [TestMethod]
        [DataRow(8471675)]
        [DataRow(8478402)]
        [DataRow(8479318)]
        [DataRow(8471214)]

        public async Task TestGetOnPaceRegularSeasonPlayerStatisticsWithIdAsync(int playerId)
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act 
            var playerOnPaceRegularSeason = await nhlApi.GetOnPaceRegularSeasonPlayerStatisticsAsync(playerId);

            // Assert
            var isSeasonActive = await nhlApi.IsRegularSeasonActiveAsync();
            if (isSeasonActive)
            {
                Assert.IsNotNull(playerOnPaceRegularSeason);

                var playerStatisticSplits = playerOnPaceRegularSeason.Statistics.First().Splits.First().PlayerStatisticsData;
                Assert.IsNotNull(playerStatisticSplits);
                Assert.IsNotNull(playerStatisticSplits.Assists);
                Assert.IsNotNull(playerStatisticSplits.Games);
                Assert.IsNotNull(playerStatisticSplits.GameWinningGoals);
                Assert.IsNotNull(playerStatisticSplits.Shifts);
                Assert.IsNotNull(playerStatisticSplits.ShortHandedGoals);
                Assert.IsNotNull(playerStatisticSplits.ShortHandedPoints);
                Assert.IsNotNull(playerStatisticSplits.ShortHandedTimeOnIce);
                Assert.IsNotNull(playerStatisticSplits.Shots);
                Assert.IsNotNull(playerStatisticSplits.ShotPct);
                Assert.IsNotNull(playerStatisticSplits.Goals);
                Assert.IsNotNull(playerStatisticSplits.Hits);
                Assert.IsNotNull(playerStatisticSplits.OverTimeGoals);
                Assert.IsNotNull(playerStatisticSplits.Points);
                Assert.IsNotNull(playerStatisticSplits.PlusMinus);
                Assert.IsNotNull(playerStatisticSplits.PowerPlayGoals);
                Assert.IsNotNull(playerStatisticSplits.PowerPlayPoints);
                Assert.IsNotNull(playerStatisticSplits.PowerPlayTimeOnIce);
                Assert.IsNotNull(playerStatisticSplits.PowerPlayTimeOnIcePerGame);
                Assert.IsNotNull(playerStatisticSplits.TimeOnIce);
                Assert.IsNotNull(playerStatisticSplits.TimeOnIcePerGame);
                Assert.IsNotNull(playerStatisticSplits.Pim);
                Assert.IsNotNull(playerStatisticSplits.OverTimeGoals);
                Assert.IsNotNull(playerStatisticSplits.Blocked);
                Assert.IsNotNull(playerStatisticSplits.EvenTimeOnIce);
                Assert.IsNotNull(playerStatisticSplits.PenaltyMinutes);
                Assert.IsNotNull(playerStatisticSplits.FaceOffPct);
                Assert.IsNotNull(playerStatisticSplits.EvenTimeOnIcePerGame);
            }
            else
            {
                Assert.IsNotNull(playerOnPaceRegularSeason);
                Assert.IsNotNull(playerOnPaceRegularSeason.Statistics);
            }
        }

        [TestMethod]
        public async Task TestGetGoalieStatisticsByTypeAndSeasonWithPlayerInvalidPlayerTypeAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

            // Act / Assert
            await Assert.ThrowsExceptionAsync<InvalidPlayerPositionException>(async () =>
            {
                var test = await nhlApi.GetGoalieStatisticsBySeasonAsync(8473986, SeasonYear.season20192020);
            });
        }

        [TestMethod]
        public async Task TestGetAllPlayersAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var players = await nhlApi.GetAllPlayersAsync();

            // Assert
            Assert.IsNotNull(players);
            CollectionAssert.AllItemsAreUnique(players);
            Assert.IsTrue(players.Any());
            Assert.IsTrue(players.Count() > 21000);

            var lastPlayer = players.Last();

            Assert.IsNotNull(lastPlayer);

            Assert.IsNotNull(lastPlayer.Active);
            Assert.IsNotNull(lastPlayer.AlternateCaptain);
            Assert.IsNotNull(lastPlayer.BirthCountry);
            Assert.IsNotNull(lastPlayer.BirthCity);

            Assert.IsNotNull(lastPlayer.BirthDate);
            Assert.IsNotNull(lastPlayer.Captain);
            Assert.IsNotNull(lastPlayer.CurrentAge);

            Assert.IsNotNull(lastPlayer.FirstName);
            Assert.IsNotNull(lastPlayer.LastName);
            Assert.IsNotNull(lastPlayer.FullName);
            Assert.IsNotNull(lastPlayer.Height);
            Assert.IsNotNull(lastPlayer.ShootsCatches);
            Assert.IsNotNull(lastPlayer.RosterStatus);
            Assert.IsNotNull(lastPlayer.Weight);
            Assert.IsNotNull(lastPlayer.Rookie);
            Assert.IsNotNull(lastPlayer.Nationality);
            Assert.IsNotNull(lastPlayer.Id);
            Assert.IsNotNull(lastPlayer.Link);
            Assert.IsNotNull(lastPlayer.PlayerHeadshotImageLink);
            Assert.IsNotNull(lastPlayer.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Small));
            Assert.IsNotNull(lastPlayer.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Medium));
            Assert.IsNotNull(lastPlayer.GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Large));
        }
    }
}
