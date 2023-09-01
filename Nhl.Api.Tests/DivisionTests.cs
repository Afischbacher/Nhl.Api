using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Models.Enumerations.Division;
using Nhl.Api.Tests.Helpers.Attributes;
using System.Threading.Tasks;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class DivisionTests
    {

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetAllDivisionsAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var divisions = await nhlApi.GetDivisionsAsync();

            // Assert
            Assert.IsNotNull(divisions);
            CollectionAssert.AllItemsAreNotNull(divisions);

            foreach (var division in divisions)
            {
                Assert.IsNotNull(division.Abbreviation);
                Assert.IsNotNull(division.Id);
                Assert.IsNotNull(division.Link);
                Assert.IsNotNull(division.Name);
                Assert.IsNotNull(division.NameShort);
            }
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetDivisionByIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var division = await nhlApi.GetDivisionByIdAsync(17);

            // Assert
            Assert.IsNotNull(division);
            Assert.IsNotNull(division.Abbreviation);
            Assert.IsNotNull(division.Id);
            Assert.IsNotNull(division.Link);
            Assert.IsNotNull(division.Name);
            Assert.IsNotNull(division.NameShort);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetDivisionByIdEnumAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var division = await nhlApi.GetDivisionByIdAsync(DivisionEnum.Metropolitan);

            // Assert
            Assert.IsNotNull(division);
            Assert.IsNotNull(division.Abbreviation);
            Assert.IsNotNull(division.Id);
            Assert.IsNotNull(division.Link);
            Assert.IsNotNull(division.Name);
            Assert.IsNotNull(division.NameShort);
        }

        [TestMethodWithRetry(RetryCount = 5)]
        public async Task TestGetDivisionWithInvalidIdAsync()
        {
            // Arrange
            await using INhlApi nhlApi = new NhlApi();

            // Act 
            var division = await nhlApi.GetDivisionByIdAsync(999);

            // Assert
            Assert.IsNull(division);
        }
    }
}

