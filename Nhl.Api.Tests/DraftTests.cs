using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Draft;
using Nhl.Api.Tests.Helpers.Attributes;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class DraftTests
    {

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetDraftByYearAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueStandingTypes = await nhlApi.GetDraftByYearAsync(DraftYear.draftYear2010);

            // Assert
            Assert.IsNotNull(leagueStandingTypes);
            CollectionAssert.AllItemsAreNotNull(leagueStandingTypes.Drafts);

            foreach (var draft in leagueStandingTypes.Drafts)
            {
                Assert.IsNotNull(draft.DraftYear);

                foreach (var round in draft.Rounds)
                {
                    Assert.IsNotNull(round.DraftRound);
                    Assert.IsNotNull(round.Picks);
                    Assert.IsNotNull(round.RoundNumber);

                    foreach (var pick in round.Picks)
                    {
                        Assert.IsNotNull(pick.PickInRound);
                        Assert.IsNotNull(pick.PickOverall);
                        Assert.IsNotNull(pick.Prospect);
                        Assert.IsNotNull(pick.Prospect.Id);
                        Assert.IsNotNull(pick.Prospect.Link);
                        Assert.IsNotNull(pick.Team);
                        Assert.IsNotNull(pick.Year);
                    }
                }
            }
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetProspectsAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var leagueProspects = await nhlApi.GetLeagueProspectsAsync();

            // Assert
            Assert.IsNotNull(leagueProspects);
            CollectionAssert.AllItemsAreNotNull(leagueProspects);

            foreach (var prospect in leagueProspects.Take(5))
            {
                Assert.IsNotNull(prospect);
                Assert.IsNotNull(prospect.DraftStatus);
                Assert.IsNotNull(prospect.ShootsCatches);
                Assert.IsNotNull(prospect.Weight);
                Assert.IsNotNull(prospect.Id);
                Assert.IsNotNull(prospect.AmateurLeague);
                Assert.IsNotNull(prospect.AmateurTeam);
                Assert.IsNotNull(prospect.FullName);
                Assert.IsNotNull(prospect.FirstName);
                Assert.IsNotNull(prospect.LastName);
            }
        }


        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetProspectsByIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act
            var prospect = await nhlApi.GetLeagueProspectByIdAsync(84055);

            // Assert
            Assert.IsNotNull(prospect.BirthCountry);
            Assert.IsNotNull(prospect.DraftStatus);
            Assert.IsNotNull(prospect.ShootsCatches);
            Assert.IsNotNull(prospect.Weight);
            Assert.IsNotNull(prospect.FullName);
            Assert.IsNotNull(prospect.Height);
            Assert.IsNotNull(prospect.Id);
            Assert.IsNotNull(prospect.AmateurLeague);
            Assert.IsNotNull(prospect.AmateurTeam);
            Assert.IsNotNull(prospect.BirthCity);
            Assert.IsNotNull(prospect.FullName);
            Assert.IsNotNull(prospect.FirstName);
            Assert.IsNotNull(prospect.LastName);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetProspectsByIdEnumAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            var prospect = await nhlApi.GetLeagueProspectByIdAsync(Models.Enumerations.Prospect.ProspectEnum.AakeLeppa98973);

            // Assert
            Assert.IsNotNull(prospect.BirthCountry);
            Assert.IsNotNull(prospect.DraftStatus);
            Assert.IsNotNull(prospect.ShootsCatches);
            Assert.IsNotNull(prospect.Weight);
            Assert.IsNotNull(prospect.FullName);
            Assert.IsNotNull(prospect.Height);
            Assert.IsNotNull(prospect.Id);
            Assert.IsNotNull(prospect.AmateurLeague);
            Assert.IsNotNull(prospect.AmateurTeam);
            Assert.IsNotNull(prospect.FullName);
            Assert.IsNotNull(prospect.FirstName);
            Assert.IsNotNull(prospect.LastName);
        }
    }
}
