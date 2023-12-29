using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Enumerations.Game;
using Nhl.Api.Enumerations.Statistic;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Season;
using Nhl.Api.Tests.Helpers.Attributes;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api.Tests;

[TestClass]
public class StatisticsTests
{

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerStatisticsType.Assists, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(PlayerStatisticsType.Goals, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(PlayerStatisticsType.Points, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(PlayerStatisticsType.PlusMinus, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(PlayerStatisticsType.PowerPlayGoals, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(PlayerStatisticsType.ShortHandedGoals, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(PlayerStatisticsType.PenaltyMinutes, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(PlayerStatisticsType.TotalTimeOnIce, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(PlayerStatisticsType.FaceOffPercentage, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    public async Task GetSkaterStatsisticsLeadersAsync_Returns_Valid_Information(PlayerStatisticsType playerStatisticsType, GameType gameType, string seasonYear, int limit)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var skaterStatistics = await nhlApi.GetSkaterStatsisticsLeadersAsync(playerStatisticsType, gameType, seasonYear, limit);

        // Assert
        Assert.IsNotNull(skaterStatistics);
        Assert.IsNotNull(skaterStatistics.Assists);
        Assert.IsNotNull(skaterStatistics.Goals);
        Assert.IsNotNull(skaterStatistics.Points);
        Assert.IsNotNull(skaterStatistics.GoalsPp);
        Assert.IsNotNull(skaterStatistics.GoalsSh);

        switch (playerStatisticsType)
        {
            case PlayerStatisticsType.Goals:
                Assert.AreEqual(10, skaterStatistics.Goals.Count);
                Assert.IsTrue(skaterStatistics.Goals.First().Value is 64);
                break;
            case PlayerStatisticsType.Assists:
                Assert.AreEqual(10, skaterStatistics.Assists.Count);
                Assert.IsTrue(skaterStatistics.Assists.First().Value is 89);
                break;
            case PlayerStatisticsType.Points:
                Assert.AreEqual(10, skaterStatistics.Points.Count);
                Assert.IsTrue(skaterStatistics.Points.First().Value is 153);
                break;
            case PlayerStatisticsType.PlusMinus:
                Assert.AreEqual(10, skaterStatistics.PlusMinus.Count);
                Assert.IsTrue(skaterStatistics.PlusMinus.First().Value is 49);
                break;
            case PlayerStatisticsType.PowerPlayGoals:
                Assert.AreEqual(10, skaterStatistics.GoalsPp.Count);
                Assert.IsTrue(skaterStatistics.GoalsPp.First().Value is 32);
                break;
            case PlayerStatisticsType.ShortHandedGoals:
                Assert.AreEqual(10, skaterStatistics.GoalsSh.Count);
                Assert.IsTrue(skaterStatistics.GoalsSh.First().Value is 5);
                break;
            case PlayerStatisticsType.PenaltyMinutes:
                Assert.AreEqual(10, skaterStatistics.PenaltyMinutes.Count);
                Assert.IsTrue(skaterStatistics.PenaltyMinutes.First().Value is 150);
                break;
            case PlayerStatisticsType.TotalTimeOnIce:
                Assert.AreEqual(10, skaterStatistics.TotalTimeOnIce.Count);
                Assert.IsTrue(skaterStatistics.TotalTimeOnIce.First().Value is 1582.8167M);
                break;
            case PlayerStatisticsType.FaceOffPercentage:
                Assert.AreEqual(10, skaterStatistics.FaceoffLeaders.Count);
                Assert.IsTrue(skaterStatistics.FaceoffLeaders.First().Value is 0.631243M);
                break;
            default:
                break;
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(GoalieStatisticsType.GoalsAgainstAverage, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(GoalieStatisticsType.SavePercentage, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(GoalieStatisticsType.Shutouts, GameType.RegularSeason, SeasonYear.season20222023, 10)]
    [DataRow(GoalieStatisticsType.Wins, GameType.RegularSeason, SeasonYear.season20222023, 10)]        
    public async Task GetGoalieStatsisticsLeadersAsync_Returns_Valid_Information(GoalieStatisticsType goalieStatisticsType, GameType gameType, string seasonYear, int limit)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var goalieStatistics = await nhlApi.GetGoalieStatsisticsLeadersAsync(goalieStatisticsType, gameType, seasonYear, limit);

        // Assert
        Assert.IsNotNull(goalieStatistics);
        Assert.IsNotNull(goalieStatistics.Wins);
        Assert.IsNotNull(goalieStatistics.SavePercentages);
        Assert.IsNotNull(goalieStatistics.Shutouts);
        Assert.IsNotNull(goalieStatistics.GoalsAgainstAverage);

        switch (goalieStatisticsType)
        {
            case GoalieStatisticsType.Wins:
                Assert.AreEqual(10, goalieStatistics.Wins.Count);
                Assert.IsTrue(goalieStatistics.Wins.First().Value is 40);
                break;
            case GoalieStatisticsType.SavePercentage:
                Assert.AreEqual(10, goalieStatistics.SavePercentages.Count);
                Assert.IsTrue(goalieStatistics.SavePercentages.First().Value is 0.937543M);
                break;
            case GoalieStatisticsType.Shutouts:
                Assert.AreEqual(10, goalieStatistics.Shutouts.Count);
                Assert.IsTrue(goalieStatistics.Shutouts.First().Value is 6);
                break;
            case GoalieStatisticsType.GoalsAgainstAverage:
                Assert.AreEqual(10, goalieStatistics.GoalsAgainstAverage.Count);
                Assert.IsTrue(goalieStatistics.GoalsAgainstAverage.First().Value is 1.894386M);
                break;
            default:
                break;
        
        }
    }
}
