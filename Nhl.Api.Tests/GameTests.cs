using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
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
		public async Task TestGetPlayoffTournamentTypesAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			var playoffTournamentTypes = await nhlApi.GetPlayoffTournamentTypesAsync();

			// Assert
			Assert.IsNotNull(playoffTournamentTypes);
		}


		[TestMethod]
		public async Task TestGetGetGameScheduleByDateAsync()
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
		public async Task TestGetGetGameScheduleByDateNotNullAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			var test = await nhlApi.GetGameScheduleByDateAsync(DateTime.Now);

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
		public async Task TestGetGetGameScheduleByDateNotNullWithInAsync()
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


		[TestMethod]
		public async Task TestGetLiveGameFeedAsync()
		{
			// Arrange
			INhlApi nhlApi = new NhlApi();

			// Act
			const int _gamePkId = 2021020149;
			var liveGameFeedResult = await nhlApi.GetLiveGameFeedById(_gamePkId);

			// Assert
			Assert.IsNotNull(liveGameFeedResult);

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
	}
}