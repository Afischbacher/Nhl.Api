namespace Nhl.Api.Tests;
using Nhl.Api.Common.Extensions;
using Nhl.Api.Enumerations.Statistic;


[TestClass]
public class EnumExtensionsTests
{

    [TestMethod]
    [DataRow(GoalieStatisticsType.Wins, "wins")]
    [DataRow(GoalieStatisticsType.Shutouts, "shutouts")]
    [DataRow(GoalieStatisticsType.SavePercentage, "savePctg")]
    [DataRow(GoalieStatisticsType.GoalsAgainstAverage, "goalsAgainstAverage")]
    public void GetEnumMemberValue_EnumMemberAttribute_ReturnsEnumMemberValue(GoalieStatisticsType goalieStatisticsType, string value)
    {
        var enumMemberValue = goalieStatisticsType.GetEnumMemberValue();
        Assert.AreEqual(enumMemberValue, value);
    }

    [TestMethod]
    [DataRow(PlayerStatisticsType.Points, "points")]
    [DataRow(PlayerStatisticsType.Goals, "goals")]
    [DataRow(PlayerStatisticsType.Assists, "assists")]
    [DataRow(PlayerStatisticsType.PlusMinus, "plusMinus")]
    [DataRow(PlayerStatisticsType.PenaltyMinutes, "penaltyMins")]
    [DataRow(PlayerStatisticsType.TotalTimeOnIce, "toi")]
    [DataRow(PlayerStatisticsType.PowerPlayGoals, "goalsPp")]
    [DataRow(PlayerStatisticsType.ShortHandedGoals, "goalsSh")]
    public void GetEnumMemberValue_EnumMemberAttribute_ReturnsEnumMemberValue(PlayerStatisticsType goalieStatisticsType, string value)
    {
        var enumMemberValue = goalieStatisticsType.GetEnumMemberValue();
        Assert.AreEqual(enumMemberValue, value);
    }


}
