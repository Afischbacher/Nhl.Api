using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Conference;
using Nhl.Api.Tests.Helpers.Attributes;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{
    [TestClass]
    public class ConferenceTests
    {

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetConferencesAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var conferences = await nhlApi.GetConferencesAsync();

            // Assert
            Assert.IsNotNull(conferences);
            CollectionAssert.AllItemsAreNotNull(conferences);

            foreach (var conference in conferences)
            {
                Assert.IsNotNull(conference.Id);
                Assert.IsNotNull(conference.Link);
                Assert.IsNotNull(conference.Name);
                Assert.IsNotNull(conference.Abbreviation);
                Assert.IsNotNull(conference.Active);
                Assert.IsNotNull(conference.ShortName);
            }
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetConferenceByIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var conference = await nhlApi.GetConferenceByIdAsync(6);

            // Assert
            Assert.IsNotNull(conference.Id);
            Assert.IsNotNull(conference.Link);
            Assert.IsNotNull(conference.Name);
            Assert.IsNotNull(conference.Abbreviation);
            Assert.IsNotNull(conference.Active);
            Assert.IsNotNull(conference.ShortName);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetConferenceByIdEnumAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var conference = await nhlApi.GetConferenceByIdAsync(ConferenceEnum.Western);

            // Assert
            Assert.IsNotNull(conference.Id);
            Assert.IsNotNull(conference.Link);
            Assert.IsNotNull(conference.Name);
            Assert.IsNotNull(conference.Abbreviation);
            Assert.IsNotNull(conference.Active);
            Assert.IsNotNull(conference.ShortName);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetConferenceWithInvalidIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var conference = await nhlApi.GetConferenceByIdAsync(999);

            // Assert
            Assert.IsNull(conference);
        }
    }
}
