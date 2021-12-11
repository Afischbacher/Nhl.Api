using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Award;
using System;
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
            using INhlApi nhlApi = new NhlApi();

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
        public async Task TestGetLeagueStandingsAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandings = await nhlApi.GetLeagueStandingsAsync();

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
        public async Task TestGetLeagueStandingsByConferenceAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandings = await nhlApi.GetLeagueStandingsByConferenceAsync();

            // Assert
            Assert.IsNotNull(leagueStandings);
            CollectionAssert.AllItemsAreNotNull(leagueStandings);

            foreach (var record in leagueStandings)
            {
                Assert.IsNotNull(record.Conference);
                Assert.IsNotNull(record.League);
                Assert.IsNotNull(record.StandingsType);
                Assert.IsNotNull(record.TeamRecords);
            }
        }


        [TestMethod]
        public async Task TestGetLeagueStandingsByDivisionAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandings = await nhlApi.GetLeagueStandingsByDivisionAsync();

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
        public async Task TestGetLeagueStandingsByDivisionWithDateAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandings = await nhlApi.GetLeagueStandingsByDivisionAsync(DateTime.Parse("1967-03-24"));

            // Assert
            Assert.IsNotNull(leagueStandings);
            CollectionAssert.AllItemsAreNotNull(leagueStandings);

            foreach (var record in leagueStandings)
            {
                Assert.IsNotNull(record.League);
                Assert.IsNotNull(record.StandingsType);
                Assert.IsNotNull(record.TeamRecords);
            }
        }

        [TestMethod]
        public async Task TestGetLeagueStandingsByConferenceWithDateAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandings = await nhlApi.GetLeagueStandingsByConferenceAsync(DateTime.Parse("1999-02-05"));

            // Assert
            Assert.IsNotNull(leagueStandings);
            CollectionAssert.AllItemsAreNotNull(leagueStandings);

            foreach (var record in leagueStandings)
            {
                Assert.IsNotNull(record.Conference);
                Assert.IsNotNull(record.League);
                Assert.IsNotNull(record.StandingsType);
                Assert.IsNotNull(record.TeamRecords);
            }
        }

        [TestMethod]
        public async Task TestGetLeagueStandingsByDivisionWithNullDateAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandings = await nhlApi.GetLeagueStandingsByDivisionAsync(null);

            // Assert
            Assert.IsNotNull(leagueStandings);
            CollectionAssert.AllItemsAreNotNull(leagueStandings);

            foreach (var record in leagueStandings)
            {
                Assert.IsNotNull(record.League);
                Assert.IsNotNull(record.StandingsType);
                Assert.IsNotNull(record.TeamRecords);
            }
        }

        [TestMethod]
        public async Task TestGetLeagueStandingsByConferenceWithNullDateAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandings = await nhlApi.GetLeagueStandingsByConferenceAsync(null);

            // Assert
            Assert.IsNotNull(leagueStandings);
            CollectionAssert.AllItemsAreNotNull(leagueStandings);

            foreach (var record in leagueStandings)
            {
                Assert.IsNotNull(record.Conference);
                Assert.IsNotNull(record.League);
                Assert.IsNotNull(record.StandingsType);
                Assert.IsNotNull(record.TeamRecords);
            }
        }


        [TestMethod]
        public async Task TestGetLeagueStandingsWithDateAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

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

        [TestMethod]
        public async Task TestGetLeagueAwardsAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueAwards = await nhlApi.GetLeagueAwardsAsync();

            // Assert
            Assert.IsNotNull(leagueAwards);
            CollectionAssert.AllItemsAreNotNull(leagueAwards);

            foreach (var award in leagueAwards)
            {
                Assert.IsNotNull(award.Description);
                Assert.IsNotNull(award.HomePageUrl);
                Assert.IsNotNull(award.ImageUrl);
                Assert.IsNotNull(award.Link);
                Assert.IsNotNull(award.Name);
                Assert.IsNotNull(award.RecipientType);
                Assert.IsNotNull(award.ShortName);
            }
        }

        [TestMethod]
        public async Task TestGetLeagueAwardsByIdAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueAward = await nhlApi.GetLeagueAwardByIdAsync(1);

            // Assert
            Assert.IsNotNull(leagueAward);

            Assert.IsNotNull(leagueAward.Description);
            Assert.IsNotNull(leagueAward.History);
            Assert.IsNotNull(leagueAward.HomePageUrl);
            Assert.IsNotNull(leagueAward.ImageUrl);
            Assert.IsNotNull(leagueAward.Link);
            Assert.IsNotNull(leagueAward.Name);
            Assert.IsNotNull(leagueAward.RecipientType);
            Assert.IsNotNull(leagueAward.ShortName);

        }

        [TestMethod]
        public async Task TestGetLeagueAwardsByIdEnumAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueAward = await nhlApi.GetLeagueAwardByIdAsync(AwardEnum.HartMemorialTrophy);

            // Assert
            Assert.IsNotNull(leagueAward);

            Assert.IsNotNull(leagueAward.Description);
            Assert.IsNotNull(leagueAward.History);
            Assert.IsNotNull(leagueAward.HomePageUrl);
            Assert.IsNotNull(leagueAward.ImageUrl);
            Assert.IsNotNull(leagueAward.Link);
            Assert.IsNotNull(leagueAward.Name);
            Assert.IsNotNull(leagueAward.RecipientType);
            Assert.IsNotNull(leagueAward.ShortName);

        }



        [TestMethod]
        public async Task TestGetEventTypesAsync()
        {
            // Arrange
            using INhlApi nhlApi = new NhlApi();

            // Act
            var eventTypes = await nhlApi.GetEventTypesAsync();

            // Assert
            Assert.IsNotNull(eventTypes);
            CollectionAssert.AllItemsAreNotNull(eventTypes);

            foreach (var eventType in eventTypes)
            {
                Assert.IsNotNull(eventType.Description);
                Assert.IsNotNull(eventType.Id);
            }
        }
    }
}
