using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Common.Helpers;

namespace Nhl.Api.Tests
{

    [TestClass]
    public class DateTimeHelperTests
    {

        [DataRow("20211105_201423")]
        [DataRow("20201015_201423")]
        [DataRow("19950210_201423")]
        [TestMethod]
        public void TestDateTimeOffsetHelper(string dateTimeString)
        {
            // Act/Arrange
            var dateTimeOffset = TimeStampHelper.ParseTimeStampToDateTimeOffset(dateTimeString);

            // Assert
            Assert.IsNotNull(dateTimeOffset);
        }
    }
}
