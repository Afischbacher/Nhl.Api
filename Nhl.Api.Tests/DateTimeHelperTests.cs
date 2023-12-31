using Nhl.Api.Common.Helpers;

namespace Nhl.Api.Tests;


[TestClass]
public class DateTimeHelperTests
{

    [DataRow("20211105_201423")]
    [DataRow("20201015_201423")]
    [DataRow("19950210_201423")]
    [TestMethodWithRetry(RetryCount = 5)]
    public void TestValidDateTimeOffsetHelper(string dateTimeString)
    {
        // Act/Arrange
        var dateTimeOffset = TimeStampHelper.ParseTimeStampToDateTimeOffset(dateTimeString);

        // Assert
        Assert.IsNotNull(dateTimeOffset);
    }

    [DataRow("20211105_201423232367644")]
    [DataRow("20201015_201424345643234")]
    [DataRow("19950210_20142423234543")]
    [DataRow(" ")]
    [DataRow("19950210_201424232_34543")]
    [TestMethodWithRetry(RetryCount = 5)]
    public void TestInValidDateTimeOffsetHelper(string dateTimeString)
    {
        // Act/Arrange
        var dateTimeOffset = TimeStampHelper.ParseTimeStampToDateTimeOffset(dateTimeString);

        // Assert
        Assert.IsNull(dateTimeOffset);
    }

    [DataRow("7/22/2023 3:05:23 PM -04:00")]
    [DataRow("12/12/2021 8:25:53 AM -02:00")]
    [DataRow("4/02/1923 12:05:23 PM -07:00")]
    [DataRow("11/11/2003 6:25:13 PM -00:00")]
    [DataRow("02/12/1985 3:05:23 PM -04:00")]
    [DataRow("08/18/1995 10:05:23 PM +06:00")]
    [TestMethodWithRetry(RetryCount = 5)]
    public void TestDateTimeOffsetParsesToTimeStampString(string dateTimeOffsetAsString)
    {
        // Act/Arrange

        var dateTimeOffset = DateTimeOffset.Parse(dateTimeOffsetAsString);
        var result = TimeStampHelper.ParseDateTimeOffsetFromTimeStamp(dateTimeOffset);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Length == 15);
        StringAssert.StartsWith(result, dateTimeOffset.Year.ToString());
    }
}
