using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Season;
using Nhl.Api.Tests.Helpers.Attributes;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class SeasonTests
    {

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetLeagueStandingTypesAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandingTypes = await nhlApi.GetLeagueStandingTypesAsync();

            // Assert
            Assert.IsNotNull(leagueStandingTypes);
            CollectionAssert.AllItemsAreNotNull(leagueStandingTypes);

            foreach (var leagueStandingType in leagueStandingTypes)
            {
                Assert.IsNotNull(leagueStandingType.Description);
                Assert.IsNotNull(leagueStandingType.Name);
            }
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetSeasonBySeasonYearAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var season = await nhlApi.GetSeasonByYearAsync(SeasonYear.season20192020);

            // Assert
            Assert.IsNotNull(season);
            Assert.IsNotNull(season.ConferencesInUse);
            Assert.IsNotNull(season.DivisionsInUse);
            Assert.IsNotNull(season.NumberOfGames);
            Assert.IsNotNull(season.OlympicsParticipation);
            Assert.IsNotNull(season.RegularSeasonStartDate);
            Assert.IsNotNull(season.RegularSeasonEndDate);
            Assert.IsNotNull(season.SeasonEndDate);
            Assert.IsNotNull(season.SeasonId);

        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetCurrentSeasonAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var season = await nhlApi.GetCurrentSeasonAsync();

            // Assert
            Assert.IsNotNull(season);
            Assert.IsNotNull(season.ConferencesInUse);
            Assert.IsNotNull(season.DivisionsInUse);
            Assert.IsNotNull(season.NumberOfGames);
            Assert.IsNotNull(season.OlympicsParticipation);
            Assert.IsNotNull(season.RegularSeasonStartDate);
            Assert.IsNotNull(season.RegularSeasonEndDate);
            Assert.IsNotNull(season.SeasonEndDate);
            Assert.IsNotNull(season.SeasonId);

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetAllSeasonsAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var seasons = await nhlApi.GetSeasonsAsync();

            // Assert
            foreach (var season in seasons)
            {
                Assert.IsNotNull(season);
                Assert.IsNotNull(season.ConferencesInUse);
                Assert.IsNotNull(season.DivisionsInUse);
                Assert.IsNotNull(season.NumberOfGames);
                Assert.IsNotNull(season.OlympicsParticipation);
                Assert.IsNotNull(season.RegularSeasonStartDate);
                Assert.IsNotNull(season.RegularSeasonEndDate);
                Assert.IsNotNull(season.SeasonEndDate);
                Assert.IsNotNull(season.SeasonId);
            }

        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestIsSeasonActiveAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var isSeasonActive = await nhlApi.IsSeasonActiveAsync();

            // Assert
            Assert.IsNotNull(isSeasonActive);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestIsRegularSeasonActiveAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var isSeasonActive = await nhlApi.IsRegularSeasonActiveAsync();

            // Assert
            Assert.IsNotNull(isSeasonActive);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestIsPlayoffSeasonActiveAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var isSeasonActive = await nhlApi.IsPlayoffsActiveAsync();

            // Assert
            Assert.IsNotNull(isSeasonActive);
        }
    }
}
