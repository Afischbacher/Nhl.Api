using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Common.Exceptions;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using System;
using System.Linq;
using System.Threading.Tasks;

[assembly: Parallelize(Workers = 0, Scope = ExecutionScope.MethodLevel)]
namespace Nhl.Api.Tests
{
    [TestClass]
    public class GameTests
    {

        [TestMethod]
        public async Task TestGetGameTypesAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
            using INhlApi nhlApi = new NhlApi();

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
        public async Task TestGetPlayoffTournamentTypesAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var playoffTournamentTypes = await nhlApi.GetPlayoffTournamentTypesAsync();

            // Assert
            Assert.IsNotNull(playoffTournamentTypes);
        }


        [TestMethod]
        public async Task TestGetGetGameScheduleByDateAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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
        public async Task TestGetGetGameScheduleByDateNotNullAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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

            var game = gameSchedule.Dates.First(date => date.Games.Count > 0).Games.First();

            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Content);
            Assert.IsNotNull(game.Teams);
            Assert.IsNotNull(game.Teams.AwayTeam);
            Assert.IsNotNull(game.Teams.HomeTeam);
            Assert.IsNotNull(game.Venue);
            Assert.IsNotNull(game.Season);
            Assert.IsNotNull(game.Content);
        }


        [TestMethod]
        public async Task TestGetGetGameScheduleAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var gameSchedule = await nhlApi.GetGameScheduleAsync();

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
        public async Task TestGetGetGameScheduleByDateNotNullWithIntegerAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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

            var game = gameSchedule.Dates.First(date => date.Games.Count > 0).Games.First();

            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Content);
            Assert.IsNotNull(game.Teams);
            Assert.IsNotNull(game.Teams.AwayTeam);
            Assert.IsNotNull(game.Teams.HomeTeam);
            Assert.IsNotNull(game.Venue);
            Assert.IsNotNull(game.Season);
            Assert.IsNotNull(game.Content);
        }


        [TestMethod]
        public async Task TestGetGetGameScheduleByDateWithTeamEnumAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var gameSchedule = await nhlApi.GetGameScheduleForTeamByDateAsync(TeamEnum.ColoradoAvalanche, DateTime.Parse("2018-10-15"), DateTime.Parse("2019-02-15"));

            // Assert
            Assert.IsNotNull(gameSchedule);
            Assert.IsNotNull(gameSchedule.MetaData);
            Assert.IsNotNull(gameSchedule.MetaData.TimeStamp);
            Assert.IsNotNull(gameSchedule.MetaData.TimeStampAsDateTimeOffset);
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

            var game = gameSchedule.Dates.First(date => date.Games.Count > 0).Games.First();

            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Content);
            Assert.IsNotNull(game.Teams);
            Assert.IsNotNull(game.Teams.AwayTeam);
            Assert.IsNotNull(game.Teams.HomeTeam);
            Assert.IsNotNull(game.Venue);
            Assert.IsNotNull(game.Season);
            Assert.IsNotNull(game.Content);
        }

        [DataRow("19831984", false)]
        [DataRow("19971998", true)]
        [DataRow("20092010", true)]
        [DataRow("20202021", false)]
        [TestMethod]
        public async Task TestGetGetGameSchedulesBySeasonAsync(string seasonYear, bool includePlayoffGames)
        {

            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var gameSchedule = await nhlApi.GetGameScheduleBySeasonAsync(seasonYear, includePlayoffGames);

            // Assert
            Assert.IsNotNull(gameSchedule);
            Assert.IsNotNull(gameSchedule.MetaData);
            Assert.IsNotNull(gameSchedule.MetaData.TimeStamp);
            Assert.IsNotNull(gameSchedule.MetaData.TimeStampAsDateTimeOffset);
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

            var game = gameSchedule.Dates.First(date => date.Games.Count > 0).Games.First();

            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Content);
            Assert.IsNotNull(game.Teams);
            Assert.IsNotNull(game.Teams.AwayTeam);
            Assert.IsNotNull(game.Teams.HomeTeam);
            Assert.IsNotNull(game.Venue);
            Assert.IsNotNull(game.Season);
        }

        [TestMethod]
        public async Task TestGetGetGameSchedulesBySeasonInvalidSeasonYearLengthAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act / Assert
            await Assert.ThrowsExceptionAsync<ArgumentException>(async () =>
            {
                var gameSchedule = await nhlApi.GetGameScheduleBySeasonAsync("123456789");

            });
            
        }

        [TestMethod]
        public async Task TestGetGetGameSchedulesBySeasonInvalidSeasonYearValueAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act / Assert
            await Assert.ThrowsExceptionAsync<InvalidSeasonException>(async () =>
            {
                var gameSchedule = await nhlApi.GetGameScheduleBySeasonAsync("18991900");

            });
        }

        [TestMethod]
        public async Task TestGetGetGameScheduleByDateWithTeamIdAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var gameSchedule = await nhlApi.GetGameScheduleForTeamByDateAsync(22, DateTime.Parse("1984-11-25"), DateTime.Parse("1985-04-06"));

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

            var game = gameSchedule.Dates.First(date => date.Games.Count > 0).Games.First();

            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Content);
            Assert.IsNotNull(game.Teams);
            Assert.IsNotNull(game.Teams.AwayTeam);
            Assert.IsNotNull(game.Teams.HomeTeam);
            Assert.IsNotNull(game.Venue);
            Assert.IsNotNull(game.Season);
            Assert.IsNotNull(game.Content);
        }



        [TestMethod]
        public async Task TestGetLiveGameFeedWithConfigurationSettingsAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 2021020149;
            var liveGameFeedResult = await nhlApi.GetLiveGameFeedByIdAsync(_gamePkId, new LiveGameFeedConfiguration
            {
                IsEnabled = true,
                MaxNumberOfAttempts = 500,
                PollTimeInMilliseconds = 10000
            });

            // Assert
            Assert.IsNotNull(liveGameFeedResult);
            Assert.IsNotNull(liveGameFeedResult.Configuration);
            Assert.AreEqual(true, liveGameFeedResult.Configuration.IsEnabled);
            Assert.AreEqual(500, liveGameFeedResult.Configuration.MaxNumberOfAttempts);
            Assert.AreEqual(10000, liveGameFeedResult.Configuration.PollTimeInMilliseconds);

        }

        [TestMethod]
        public async Task TestGetLiveGameFeedWithConfigurationSettingsWithCancellationAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 2021020149;
            var liveGameFeedResult = await nhlApi.GetLiveGameFeedByIdAsync(_gamePkId, new LiveGameFeedConfiguration
            {
                IsEnabled = true,
                MaxNumberOfAttempts = 500,
                PollTimeInMilliseconds = 10000
            });

            liveGameFeedResult.CancelOnLiveGameFeedChange(500);

            // Assert
            Assert.IsNotNull(liveGameFeedResult);
            Assert.IsNotNull(liveGameFeedResult.Configuration);
            Assert.AreEqual(true, liveGameFeedResult.Configuration.IsEnabled);
            Assert.AreEqual(500, liveGameFeedResult.Configuration.MaxNumberOfAttempts);
            Assert.AreEqual(10000, liveGameFeedResult.Configuration.PollTimeInMilliseconds);

        }

        [TestMethod]
        public async Task TestGetLiveGameFeedWithDefaultConfigurationSettingsAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 2021020149;
            var liveGameFeedResult = await nhlApi.GetLiveGameFeedByIdAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(liveGameFeedResult);
            Assert.IsNotNull(liveGameFeedResult.Configuration);
            Assert.AreEqual(false, liveGameFeedResult.Configuration.IsEnabled);
            Assert.AreEqual(1000, liveGameFeedResult.Configuration.MaxNumberOfAttempts);
            Assert.AreEqual(5000, liveGameFeedResult.Configuration.PollTimeInMilliseconds);

        }

        [TestMethod]
        public async Task TestGetLiveGameFeedAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 2021020149;
            var liveGameFeedResult = await nhlApi.GetLiveGameFeedByIdAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(liveGameFeedResult);

            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.MetaData.TimeStampAsDateTimeOffset);

            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.Link);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GamePk);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.LiveData);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.MetaData);

            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Datetime.DateTime);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Datetime.EndDateTime);

            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Game.Type);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Game.Pk);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Game.Season);

            CollectionAssert.AllItemsAreNotNull(liveGameFeedResult.LiveGameFeed.GameData.Players);
            Assert.IsTrue(liveGameFeedResult.LiveGameFeed.GameData.Players.Count > 0);

            var playerKey = liveGameFeedResult.LiveGameFeed.GameData.Players.Keys.First();
            Assert.IsNotNull(playerKey);

            var playerValue = liveGameFeedResult.LiveGameFeed.GameData.Players.Values.First();
            Assert.IsNotNull(playerValue);
            Assert.IsTrue(playerValue.Active);
            Assert.IsNotNull(playerValue.AlternateCaptain);
            Assert.IsNotNull(playerValue.BirthCity);
            Assert.IsNotNull(playerValue.BirthCountry);
            Assert.IsNotNull(playerValue.PrimaryNumber);
            Assert.IsNotNull(playerValue.PrimaryPosition);
            Assert.IsNotNull(playerValue.PrimaryPosition.Code);
            Assert.IsNotNull(playerValue.PrimaryPosition.Abbreviation);
            Assert.IsNotNull(playerValue.Weight);
            Assert.IsNotNull(playerValue.RosterStatus);
            Assert.IsNotNull(playerValue.Rookie);
            Assert.IsNotNull(playerValue.Nationality);
            Assert.IsNotNull(playerValue.LastName);
            Assert.IsNotNull(playerValue.FirstName);
            Assert.IsNotNull(playerValue.FullName);
            Assert.IsNotNull(playerValue.BirthDate);
            Assert.IsNotNull(playerValue.CurrentAge);
            Assert.IsNotNull(playerValue.CurrentTeam);
            Assert.IsNotNull(playerValue.CurrentTeam.Id);
            Assert.IsNotNull(playerValue.CurrentTeam.Name);
            Assert.IsNotNull(playerValue.CurrentTeam.Link);
            Assert.IsNotNull(playerValue.CurrentTeam.OfficalDarkTeamLogoUrl);
            Assert.IsNotNull(playerValue.CurrentTeam.OfficalLightTeamLogoUrl);
            Assert.IsFalse(playerValue.IsGoalie);
            Assert.IsFalse(playerValue.Captain);

            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Status.StartTimeTBD);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Status.DetailedState);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Status.AbstractGameState);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Status.CodedGameState);

            Assert.AreEqual("Final", liveGameFeedResult.LiveGameFeed.GameData.Status.DetailedState);
            Assert.AreEqual("7", liveGameFeedResult.LiveGameFeed.GameData.Status.CodedGameState);

            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Teams.Home);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed.GameData.Teams.Away);

            var homeTeam = liveGameFeedResult.LiveGameFeed.GameData.Teams.Home;
            Assert.IsNotNull(homeTeam.FirstYearOfPlay);
            Assert.IsNotNull(homeTeam.Abbreviation);
            Assert.IsNotNull(homeTeam.Active);
            Assert.IsNotNull(homeTeam.Conference);
            Assert.IsNotNull(homeTeam.TriCode);
            Assert.IsNotNull(homeTeam.TeamName);
            Assert.IsNotNull(homeTeam.OfficialSiteUrl);
            Assert.IsTrue(homeTeam.Active);
            Assert.IsNotNull(homeTeam.Division);
            Assert.IsNotNull(homeTeam.Franchise);
            Assert.IsNotNull(homeTeam.FranchiseId);
            Assert.IsNotNull(homeTeam.Id);
            Assert.IsNotNull(homeTeam.Link);
            Assert.IsNotNull(homeTeam.Venue);
            Assert.IsNotNull(homeTeam.ShortName);
            Assert.IsNotNull(homeTeam.LocationName);

            var venue = liveGameFeedResult.LiveGameFeed.GameData.Venue;
            Assert.IsNotNull(venue);
            Assert.IsNotNull(venue.Name);


            var liveData = liveGameFeedResult.LiveGameFeed.LiveData;
            Assert.IsNotNull(liveData.Boxscore);
            Assert.IsNotNull(liveData.Boxscore.Teams);

            Assert.IsNotNull(liveData.Boxscore.Teams.Home);
            Assert.IsNotNull(liveData.Boxscore.Teams.Away);
            Assert.IsNotNull(liveData.Boxscore.Officials);
            CollectionAssert.AllItemsAreNotNull(liveData.Boxscore.Officials);

            var official = liveData.Boxscore.Officials.First();
            Assert.IsNotNull(official);
            Assert.IsNotNull(official.OfficialType);
            Assert.IsNotNull(official.Official.FullName);
            Assert.IsNotNull(official.Official.Link);
            Assert.IsNotNull(official.Official.Id);

            Assert.IsNotNull(liveData.Plays);
            Assert.IsNotNull(liveData.Plays.PlaysByPeriod);
            CollectionAssert.AllItemsAreUnique(liveData.Plays.PlaysByPeriod);
            CollectionAssert.AllItemsAreUnique(liveData.Plays.ScoringPlays);
            CollectionAssert.AllItemsAreUnique(liveData.Plays.AllPlays);
            CollectionAssert.AllItemsAreUnique(liveData.Plays.PenaltyPlays);
            Assert.IsNotNull(liveData.Plays.CurrentPlay);

            var liveGameFeedPlay = liveData.Plays.AllPlays[50];
            Assert.IsNotNull(liveGameFeedPlay.About.EventIdx);
            Assert.IsNotNull(liveGameFeedPlay.About.PeriodTime);
            Assert.IsNotNull(liveGameFeedPlay.About.DateTime);
            Assert.IsNotNull(liveGameFeedPlay.About.PeriodTimeRemaining);
            Assert.IsNotNull(liveGameFeedPlay.About.EventId);
            Assert.IsNotNull(liveGameFeedPlay.About.Period);
            Assert.IsNotNull(liveGameFeedPlay.About.OrdinalNum);

            Assert.IsNotNull(liveGameFeedPlay.Team.Id);
            Assert.IsNotNull(liveGameFeedPlay.Team.Name);
            Assert.IsNotNull(liveGameFeedPlay.Team.Link);
            Assert.IsNotNull(liveGameFeedPlay.Coordinates);
            Assert.IsNotNull(liveGameFeedPlay.Result);
            Assert.IsNotNull(liveGameFeedPlay.Result.EventTypeId);
            Assert.IsNotNull(liveGameFeedPlay.Result.EventCode);
            Assert.IsNotNull(liveGameFeedPlay.Result.Description);

            Assert.IsNotNull(liveGameFeedPlay.Players);

            Assert.IsNotNull(liveData.Linescore);
            Assert.IsNotNull(liveData.Linescore.CurrentPeriod);
            Assert.IsNotNull(liveData.Linescore.CurrentPeriodOrdinal);
            Assert.IsNotNull(liveData.Linescore.CurrentPeriodTimeRemaining);
            Assert.IsNotNull(liveData.Linescore.ShootoutInfo);

            Assert.IsNotNull(liveData.Decisions);
            Assert.IsNotNull(liveData.Decisions.ThirdStar);
            Assert.IsNotNull(liveData.Decisions.FirstStar);
            Assert.IsNotNull(liveData.Decisions.SecondStar);

            var firstStar = liveData.Decisions.FirstStar;
            Assert.IsNotNull(firstStar.Id);
            Assert.IsNotNull(firstStar.FullName);
            Assert.IsNotNull(firstStar.Link);
        }

        [TestMethod]
        public async Task TestGetLiveGameFeedInvalidGamePkAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 9999999;
            var liveGameFeedResult = await nhlApi.GetLiveGameFeedByIdAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(liveGameFeedResult);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed);
            Assert.IsNotNull(liveGameFeedResult.LiveGameFeed);
            Assert.IsNull(liveGameFeedResult.LiveGameFeed.Link);
            Assert.IsNull(liveGameFeedResult.LiveGameFeed.GameData);
            Assert.IsNull(liveGameFeedResult.LiveGameFeed.LiveData);
            Assert.IsNull(liveGameFeedResult.LiveGameFeed.MetaData);

        }

        [DataRow(2010020008)]
        [DataRow(2010020011)]
        [DataRow(2010020012)]
        [DataRow(2010020015)]
        [DataRow(2010020019)]
        [DataRow(2010020020)]
        [DataRow(2010020022)]
        [DataRow(2010020023)]
        [DataRow(2010020024)]
        [DataRow(2010020026)]
        [DataRow(2010020028)]
        [DataRow(2010020033)]
        [DataRow(2010020044)]
        [DataRow(2010020057)]
        [DataRow(2011020003)]
        [DataRow(2011020007)]
        [DataRow(2011020009)]
        [DataRow(2011020014)]
        [DataRow(2011020022)]
        [DataRow(2011020024)]
        [DataRow(2011020027)]
        [DataRow(2011020038)]
        [DataRow(2011020043)]
        [DataRow(2011020051)]
        [DataRow(2011020055)]
        [DataRow(2011020057)]
        [DataRow(2011020061)]
        [DataRow(2011020067)]
        [DataRow(2011020076)]
        [DataRow(2011020077)]
        [DataRow(2011020088)]
        [DataRow(2011020090)]
        [DataRow(2011020096)]
        [DataRow(2011020107)]
        [DataRow(2011020114)]
        [DataRow(2011020117)]
        [DataRow(2011020119)]
        [DataRow(2011020120)]
        [DataRow(2011020124)]
        [DataRow(2012020006)]
        [DataRow(2012020019)]
        [DataRow(2012020021)]
        [DataRow(2012020025)]
        [DataRow(2012020035)]
        [DataRow(2012020039)]
        [DataRow(2012020048)]
        [DataRow(2012020059)]
        [DataRow(2012020062)]
        [DataRow(2012020074)]
        [DataRow(2012020075)]
        [DataRow(2012020076)]
        [DataRow(2012020090)]
        [DataRow(2012020096)]
        [DataRow(2012020114)]
        [DataRow(2012020115)]
        [DataRow(2013020003)]
        [DataRow(2013020013)]
        [DataRow(2013020018)]
        [DataRow(2013020024)]
        [DataRow(2013020035)]
        [DataRow(2013020038)]
        [DataRow(2013020055)]
        [DataRow(2013020068)]
        [DataRow(2013020083)]
        [DataRow(2013020093)]
        [DataRow(2013020098)]
        [DataRow(2013020117)]
        [DataRow(2013020120)]
        [DataRow(2013020123)]
        [DataRow(2013020130)]
        [DataRow(2013020131)]
        [DataRow(2013020136)]
        [DataRow(2013020147)]
        [DataRow(2013020150)]
        [DataRow(2013020160)]
        [DataRow(2013020164)]
        [DataRow(2013020168)]
        [DataRow(2013020176)]
        [DataRow(2013020182)]
        [DataRow(2013020183)]
        [DataRow(2013020190)]
        [DataRow(2013020204)]
        [DataRow(2014020015)]
        [DataRow(2014020023)]
        [DataRow(2014020025)]
        [DataRow(2014020042)]
        [DataRow(2014020050)]
        [DataRow(2014020058)]
        [DataRow(2014020061)]
        [DataRow(2014020078)]
        [DataRow(2014020081)]
        [DataRow(2014020091)]
        [DataRow(2014020104)]
        [DataRow(2014020110)]
        [DataRow(2014020123)]
        [DataRow(2014020125)]
        [DataRow(2014020128)]
        [DataRow(2014020137)]
        [DataRow(2014020148)]
        [DataRow(2014020163)]
        [DataRow(2014020176)]
        [DataRow(2014020208)]
        [DataRow(2014020221)]
        [DataRow(2014020240)]
        [DataRow(2015020013)]
        [DataRow(2015020015)]
        [DataRow(2015020033)]
        [DataRow(2015020046)]
        [DataRow(2015020050)]
        [DataRow(2015020056)]
        [DataRow(2015020059)]
        [DataRow(2015020071)]
        [DataRow(2015020084)]
        [DataRow(2015020090)]
        [DataRow(2015020101)]
        [DataRow(2015020104)]
        [DataRow(2015020120)]
        [DataRow(2015020121)]
        [DataRow(2015020137)]
        [DataRow(2015020144)]
        [DataRow(2015020161)]
        [DataRow(2015020163)]
        [DataRow(2015020167)]
        [DataRow(2016020077)]
        [DataRow(2016020559)]
        [DataRow(2016020562)]
        [DataRow(2016020908)]
        [DataRow(2017020498)]
        [DataRow(2017021005)]
        [DataRow(2018020192)]
        [DataRow(2018020401)]
        [DataRow(2018020461)]
        [DataRow(2018020953)]
        [DataRow(2019020249)]
        [DataRow(2019020902)]
        [DataRow(2020020290)]
        [DataRow(2021020590)]
        [DataRow(2021020592)]
        [DataRow(2021020594)]
        [DataRow(2021020597)]
        [DataRow(2021020599)]
        [DataRow(2021020600)]
        [DataRow(2021020602)]
        [DataRow(2021020668)]
        [DataRow(2021020670)]
        [DataRow(2021020674)]
        [DataRow(2021020677)]
        [DataRow(2021020678)]
        [DataRow(2021020682)]
        [TestMethod]
        public async Task TestGetLiveGameFeedGetCorrectRinkSideAsync(int gameId)
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var liveGameFeedResult = await nhlApi.GetLiveGameFeedByIdAsync(gameId);

            if (!liveGameFeedResult.LiveGameFeed.LiveData.Plays.AllPlays.Any())
            {
                return;
            }

            var homeCorrectedRinkSide = liveGameFeedResult.LiveGameFeed.LiveData.Linescore.Periods.First().Home.CorrectedRinkSide;
            var awayCorrectedRinkSide = liveGameFeedResult.LiveGameFeed.LiveData.Linescore.Periods.First().Away.CorrectedRinkSide;

            var homeRinkSide = liveGameFeedResult.LiveGameFeed.LiveData.Linescore.Periods.First().Home.RinkSide;
            var awayRinkSide = liveGameFeedResult.LiveGameFeed.LiveData.Linescore.Periods.First().Away.RinkSide;

            // Assert
            Assert.IsNotNull(homeCorrectedRinkSide);
            Assert.IsNotNull(awayCorrectedRinkSide);
            Assert.AreNotEqual(homeRinkSide, homeCorrectedRinkSide);
            Assert.AreNotEqual(awayRinkSide, awayCorrectedRinkSide);
        }

        [TestMethod]
        public async Task TestGetLineScoreAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 2021020197;
            var lineScore = await nhlApi.GetLineScoreByIdAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(lineScore);
            Assert.IsNotNull(lineScore.Teams);
            Assert.IsNotNull(lineScore.Teams.Home);
            Assert.IsNotNull(lineScore.Teams.Away);

            Assert.IsNotNull(lineScore.Teams.Home.Team);
            Assert.IsNotNull(lineScore.Teams.Away.Team);
            Assert.IsNotNull(lineScore.Teams.Home.Team.Id);
            Assert.IsNotNull(lineScore.Teams.Away.Team.Id);
            Assert.IsNotNull(lineScore.Teams.Home.Team.Name);
            Assert.IsNotNull(lineScore.CurrentPeriod);
            Assert.IsNotNull(lineScore.CurrentPeriodOrdinal);
            Assert.IsNotNull(lineScore.CurrentPeriod);
            Assert.IsNotNull(lineScore.CurrentPeriodTimeRemaining);
            Assert.IsNotNull(lineScore.PowerPlayInfo);
            Assert.IsNotNull(lineScore.PowerPlayStrength);
            Assert.IsNotNull(lineScore.IntermissionInfo);
            Assert.IsFalse(lineScore.HasShootout);

        }

        [TestMethod]
        public async Task TestGetLineScoreWithInvalidIdAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 99999999;
            var lineScore = await nhlApi.GetLineScoreByIdAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(lineScore);
            Assert.IsNull(lineScore.Teams);
            Assert.IsNull(lineScore.Periods);

        }


        [TestMethod]
        public async Task TestGetBoxScoreAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 2021020197;
            var boxScore = await nhlApi.GetBoxScoreByIdAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(boxScore);

            foreach (var referee in boxScore.Officials)
            {
                Assert.IsNotNull(referee.Official.Id);
                Assert.IsNotNull(referee.Official.FullName);
                Assert.IsNotNull(referee.Official.Link);
            }

            Assert.IsNotNull(boxScore.Teams);
            Assert.IsNotNull(boxScore.Teams.Home);
            Assert.IsNotNull(boxScore.Teams.Away);

            Assert.IsNotNull(boxScore.Teams.Home.TeamStats.TeamSkaterStats.Shots);
            Assert.IsNotNull(boxScore.Teams.Home.TeamStats.TeamSkaterStats.FaceOffWinPercentage);
            Assert.IsNotNull(boxScore.Teams.Home.TeamStats.TeamSkaterStats.Hits);
            Assert.IsNotNull(boxScore.Teams.Home.TeamStats.TeamSkaterStats.Goals);
            Assert.IsNotNull(boxScore.Teams.Home.TeamStats.TeamSkaterStats.Pim);
            Assert.IsNotNull(boxScore.Teams.Home.TeamStats.TeamSkaterStats.PowerPlayOpportunities);

            Assert.IsNotNull(boxScore.Teams.Away.TeamStats.TeamSkaterStats.Shots);
            Assert.IsNotNull(boxScore.Teams.Away.TeamStats.TeamSkaterStats.FaceOffWinPercentage);
            Assert.IsNotNull(boxScore.Teams.Away.TeamStats.TeamSkaterStats.Hits);
            Assert.IsNotNull(boxScore.Teams.Away.TeamStats.TeamSkaterStats.Goals);
            Assert.IsNotNull(boxScore.Teams.Away.TeamStats.TeamSkaterStats.Pim);
            Assert.IsNotNull(boxScore.Teams.Away.TeamStats.TeamSkaterStats.PowerPlayOpportunities);

            Assert.IsNotNull(boxScore.Teams.Away.Coaches.First().Person);
            Assert.IsNotNull(boxScore.Teams.Home.Coaches.First().Person);


        }

        [TestMethod]
        public async Task TestGetBoxScoreWithInvalidIdAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 99999999;
            var boxScore = await nhlApi.GetBoxScoreByIdAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(boxScore);
            Assert.IsNull(boxScore.Teams);

        }

        [TestMethod]
        public async Task TestGetLiveGameFeedShiftChartAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 2021020197;
            var liveGameFeedPlayerShifts = await nhlApi.GetLiveGameFeedPlayerShiftsAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(liveGameFeedPlayerShifts);
            Assert.IsTrue(liveGameFeedPlayerShifts.PlayerShifts.Any());

            var firstShift = liveGameFeedPlayerShifts.PlayerShifts[0];

            Assert.IsNotNull(firstShift.EndTime);
            Assert.IsNotNull(firstShift.StartTime);
            Assert.IsNotNull(firstShift.ShiftNumber);
            Assert.IsNotNull(firstShift.TeamId);
            Assert.IsNotNull(firstShift.TeamAbbrev);
            Assert.IsNotNull(firstShift.PlayerId);
            Assert.IsNotNull(firstShift.FirstName);
            Assert.IsNotNull(firstShift.LastName);
            Assert.IsNotNull(firstShift.HexValue);
        }

        [TestMethod]
        public async Task TestGetLiveGameFeedShiftChartInvalidGameIdAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 9999999;
            var liveGameFeedPlayerShifts = await nhlApi.GetLiveGameFeedPlayerShiftsAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(liveGameFeedPlayerShifts);
            Assert.IsFalse(liveGameFeedPlayerShifts.PlayerShifts.Any());

        }


        [TestMethod]
        public async Task TestGetLiveGameFeedContentAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            const int _gamePkId = 2021020566;
            var liveGameFeedContent = await nhlApi.GetLiveGameFeedContentByIdAsync(_gamePkId);

            // Assert
            Assert.IsNotNull(liveGameFeedContent);
        }
    }
}