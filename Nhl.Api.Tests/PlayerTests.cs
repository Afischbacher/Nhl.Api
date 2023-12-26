using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Enumerations.Game;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Tests.Helpers.Attributes;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethodWithRetry(RetryCount = 5)]
        [DataRow("Wayne Gretzky", 99)]
        [DataRow("Alex Ovechkin", 8)]
        [DataRow("Connor McDavid", 97)]
        public async Task TestSearchAllPlayersAsync(string query, int numberOfPlayer)
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var results = await nhlApi.SearchAllPlayersAsync(query);

            // Assert
            Assert.IsNotNull(results);
            CollectionAssert.AllItemsAreNotNull(results);

            var playerSearchResult = results.First(r => r.PlayerNumber == numberOfPlayer);

            switch (query)
            {
                case "Wayne Gretzky":
                    Assert.AreEqual("Brantford", playerSearchResult.BirthCity);
                    Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual("Ontario", playerSearchResult.BirthProvinceState);
                    Assert.AreEqual("Wayne", playerSearchResult.FirstName);
                    Assert.AreEqual("Gretzky", playerSearchResult.LastName);
                    Assert.AreEqual("NYR", playerSearchResult.LastTeamAbbreviation);
                    Assert.AreEqual("6\u00270\"", playerSearchResult.Height);
                    Assert.AreEqual(false, playerSearchResult.IsActive);
                    Assert.AreEqual(99, playerSearchResult.PlayerNumber);
                    break;

                case "Alex Ovechkin":
                    Assert.AreEqual("Moscow", playerSearchResult.BirthCity);
                    Assert.AreEqual("RUS", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Russian Federation", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual(null, playerSearchResult.BirthProvinceState);
                    Assert.AreEqual("Alex", playerSearchResult.FirstName);
                    Assert.AreEqual("Ovechkin", playerSearchResult.LastName);
                    Assert.AreEqual(true, playerSearchResult.IsActive);
                    Assert.AreEqual("WSH", playerSearchResult.LastTeamAbbreviation);
                    Assert.AreEqual("6\u00273\"", playerSearchResult.Height);
                    Assert.AreEqual(8, playerSearchResult.PlayerNumber);
                    break;

                case "Connor McDavid":
                    Assert.AreEqual("Richmond Hill", playerSearchResult.BirthCity);
                    Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual("Ontario", playerSearchResult.BirthProvinceState);
                    Assert.AreEqual("Connor", playerSearchResult.FirstName);
                    Assert.AreEqual("McDavid", playerSearchResult.LastName);
                    Assert.AreEqual(true, playerSearchResult.IsActive);
                    Assert.AreEqual("EDM", playerSearchResult.LastTeamAbbreviation);
                    Assert.AreEqual("6\u00271\"", playerSearchResult.Height);
                    Assert.AreEqual(97, playerSearchResult.PlayerNumber);
                    break;
            }

        }


        [TestMethodWithRetry(RetryCount = 5)]
        [DataRow("Carter Hart")]
        [DataRow("Auston Matthews")]
        [DataRow("Connor McDavid")]
        [DataRow("Frederik Andersen")]
        public async Task TestSearchAllActivePlayersAsync(string query)
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var results = await nhlApi.SearchAllActivePlayersAsync(query);

            // Assert
            Assert.IsNotNull(results);
            CollectionAssert.AllItemsAreNotNull(results);

            var playerSearchResult = results.First();

            switch (query)
            {
                case "David Pastrnak":
                    Assert.AreEqual("Havirov", playerSearchResult.BirthCity);
                    Assert.AreEqual("CZE", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Czech Republic", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual("", playerSearchResult.BirthProvinceState);
                    Assert.AreEqual("David", playerSearchResult.FirstName);
                    Assert.AreEqual("Pastrnak", playerSearchResult.LastName);
                    Assert.AreEqual("BOS", playerSearchResult.TeamAbbreviation);
                    Assert.AreEqual("6\u00270\"", playerSearchResult.Height);
                    Assert.AreEqual(true, playerSearchResult.IsActive);
                    Assert.AreEqual(88, playerSearchResult.PlayerNumber);
                    break;

                case "Carter Hart":
                    Assert.AreEqual("Sherwood Park", playerSearchResult.BirthCity);
                    Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual("Alberta", playerSearchResult.BirthProvinceState);
                    Assert.AreEqual("Carter", playerSearchResult.FirstName);
                    Assert.AreEqual("Hart", playerSearchResult.LastName);
                    Assert.AreEqual(true, playerSearchResult.IsActive);
                    Assert.AreEqual("PHI", playerSearchResult.TeamAbbreviation);
                    Assert.AreEqual("6\u00272\"", playerSearchResult.Height);
                    Assert.AreEqual(79, playerSearchResult.PlayerNumber);
                    break;

                case "Connor McDavid":
                    Assert.AreEqual("Richmond Hill", playerSearchResult.BirthCity);
                    Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual("Ontario", playerSearchResult.BirthProvinceState);
                    Assert.AreEqual("Connor", playerSearchResult.FirstName);
                    Assert.AreEqual("McDavid", playerSearchResult.LastName);
                    Assert.AreEqual(true, playerSearchResult.IsActive);
                    Assert.AreEqual("EDM", playerSearchResult.TeamAbbreviation);
                    Assert.AreEqual("6\u00271\"", playerSearchResult.Height);
                    Assert.AreEqual(97, playerSearchResult.PlayerNumber);
                    break;

                case "Frederik Andersen":
                    Assert.AreEqual("Herning", playerSearchResult.BirthCity);
                    Assert.AreEqual("DNK", playerSearchResult.BirthCountry);
                    Assert.AreEqual("Denmark", playerSearchResult.FullBirthCountry);
                    Assert.AreEqual(null, playerSearchResult.BirthProvinceState);
                    Assert.AreEqual("Frederik", playerSearchResult.FirstName);
                    Assert.AreEqual("Andersen", playerSearchResult.LastName);
                    Assert.AreEqual(true, playerSearchResult.IsActive);
                    Assert.AreEqual("CAR", playerSearchResult.TeamAbbreviation);
                    Assert.AreEqual("6\u00274\"", playerSearchResult.Height);
                    Assert.AreEqual(31, playerSearchResult.PlayerNumber);
                    break;
            }

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync_Test_Player_Enum()
        {
            // Arrange 
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var playerSeasonGameLog = await nhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum.ConnorMcDavid8478402, SeasonYear.season20222023, GameType.RegularSeason);

            // Assert
            Assert.IsNotNull(playerSeasonGameLog);
            Assert.AreEqual(82, playerSeasonGameLog.PlayerGameLogs.Count);

        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerId()
        {
            // Arrange 
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var playerSeasonGameLog = await nhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(8478402, SeasonYear.season20222023, GameType.RegularSeason);

            // Assert
            Assert.IsNotNull(playerSeasonGameLog);
            Assert.AreEqual(82, playerSeasonGameLog.PlayerGameLogs.Count);

        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerEnum()
        {
            // Arrange 
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var goalieSeasonGameLog = await nhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum.JosephWoll8479361, SeasonYear.season20222023, GameType.RegularSeason);

            // Assert
            Assert.IsNotNull(goalieSeasonGameLog);

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerId()
        {
            // Arrange 
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var goalieSeasonGameLog = await nhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(8479361, SeasonYear.season20222023, GameType.RegularSeason);

            // Assert
            Assert.IsNotNull(goalieSeasonGameLog);

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task GetGoalieInformationAsync_Test_PlayerId()
        {
            // Arrange 
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var goalieProfile = await nhlApi.GetGoalieInformationAsync(8470594);

            // Assert
            Assert.IsNotNull(goalieProfile);

        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task GetGoalieInformationAsync_Test_PlayerEnum()
        {
            // Arrange 
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var goalieProfile = await nhlApi.GetGoalieInformationAsync(PlayerEnum.FilipGustavsson8479406);

            // Assert
            Assert.IsNotNull(goalieProfile);

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task GetPlayerInformationAsync_Test_PlayerId()
        {
            // Arrange 
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var playerProfile = await nhlApi.GetPlayerInformationAsync(8478402);

            // Assert
            Assert.IsNotNull(playerProfile);

        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task GetPlayerInformationAsync_Test_PlayerEnum()
        {
            // Arrange 
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var playerProfile = await nhlApi.GetPlayerInformationAsync(PlayerEnum.ConnorMcDavid8478402);

            // Assert
            Assert.IsNotNull(playerProfile);
        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestSearchAllPlayersNoResultsAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var results = await nhlApi.SearchAllPlayersAsync("");

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(0, results.Count);

        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestSearchAllActivePlayersNoResultsAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var results = await nhlApi.SearchAllActivePlayersAsync("");

            // Assert
            Assert.IsNotNull(results);
            Assert.AreEqual(0, results.Count);

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestDownloadPlayerHeadshotImageAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var image = await nhlApi.GetPlayerHeadshotImageAsync(PlayerEnum.ZackKassian8475178, PlayerHeadshotImageSize.Large);

            // Assert
            Assert.IsNotNull(image);
            Assert.IsTrue(image.Length > 5000);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestDownloadPlayerHeadshotImageWithIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var image = await nhlApi.GetPlayerHeadshotImageAsync(8477932, PlayerHeadshotImageSize.Large);

            // Assert
            Assert.IsNotNull(image);
            Assert.IsTrue(image.Length > 5000);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestDownloadPlayerHeadshotImageWithInvalidIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();


            // Act / Assert
            await Assert.ThrowsExceptionAsync<HttpRequestException>(async () =>
            {
                var image = await nhlApi.GetPlayerHeadshotImageAsync(999999, PlayerHeadshotImageSize.Large);
            });
        }
    }
}
