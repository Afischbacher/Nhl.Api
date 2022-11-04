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
        public void TestValidDateTimeOffsetHelper(string dateTimeString)
        {
            // Act/Arrange
            var dateTimeOffset = TimeStampHelper.ParseTimeStampToDateTimeOffset(dateTimeString);

            // Assert
            Assert.IsNotNull(dateTimeOffset);
        }

        [DataRow("20211105_201423232367644")]
        [DataRow("20201015_201424345643")]
        [DataRow("19950210_20142423234543")]
        [DataRow(" ")]
        [DataRow("19950210_201424232_34543")]
        [TestMethod]
        public void TestInValidDateTimeOffsetHelper(string dateTimeString)
        {
            // Act/Arrange
            var dateTimeOffset = TimeStampHelper.ParseTimeStampToDateTimeOffset(dateTimeString);

            // Assert
            Assert.IsNull(dateTimeOffset);
        }
    }
}
