using Nhl.Api.Enumerations.Game;
using Nhl.Api.Enumerations.Statistic;
using Nhl.Api.Models.Season;
using System.Collections.Concurrent;
using System.Linq;

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
        await using var nhlApi = new NhlApi();

        // Act
        var skaterStatistics = await nhlApi.GetSkaterStatisticsLeadersAsync(playerStatisticsType, gameType, seasonYear, limit);

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
        await using var nhlApi = new NhlApi();

        // Act
        var goalieStatistics = await nhlApi.GetGoalieStatisticsLeadersAsync(goalieStatisticsType, gameType, seasonYear, limit);

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

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8478402, PlayerGameCenterStatistic.MissedShot, "20222023")]
    [DataRow(8478402, PlayerGameCenterStatistic.Giveaway, "20222023")]
    [DataRow(8478402, PlayerGameCenterStatistic.Takeaway, "20222023")]
    [DataRow(8478402, PlayerGameCenterStatistic.DrawnPenalty, "20222023")]
    [DataRow(8478402, PlayerGameCenterStatistic.CommittedPenalty, "20222023")]
    [DataRow(8478402, PlayerGameCenterStatistic.FaceOffWon, "20222023")]
    [DataRow(8478402, PlayerGameCenterStatistic.BlockedShot, "20222023")]
    [DataRow(8478402, PlayerGameCenterStatistic.HitGiven, "20222023")]
    [DataRow(8478402, PlayerGameCenterStatistic.FaceOffWon, "20232024")]
    [DataRow(8478402, PlayerGameCenterStatistic.BlockedShot, "20232024")]
    [DataRow(8478402, PlayerGameCenterStatistic.HitGiven, "20232024")]
    [DataRow(8478402, PlayerGameCenterStatistic.HitReceived, "20232024")]
    [DataRow(8478402, PlayerGameCenterStatistic.FaceOffLost, "20232024")]

    public async Task GetNumberOfFaceoffsWonByPlayerIdAndSeasonAsync_Returns_Valid_Information_With_Id(int playerId, PlayerGameCenterStatistic playerGameCenterStatistic, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetTotalPlayerStatisticValueByTypeAndSeasonAsync(playerId, playerGameCenterStatistic, seasonYear);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result is not 0);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.ConnorMcDavid8478402, "20222023")]
    [DataRow(PlayerEnum.NathanMacKinnon8477492, "20232024")]
    [DataRow(PlayerEnum.TomWilson8476880, "20232024")]
    public async Task GetTotalPlayerStatisticValueByTypeAndSeasonAsync_Returns_Valid_Information_With_Enum(PlayerEnum playerEnum, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerEnum, seasonYear);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffWon] is not 0);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.BlockedShot] is not 0);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.HitGiven] is not 0);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.HitReceived] is not 0);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffLost] is not 0);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8478402, "20222023")]
    [DataRow(8477492, "20232024")]
    [DataRow(8476880, "20232024")]
    public async Task GetTotalPlayerStatisticValueByTypeAndSeasonAsync_Returns_Valid_Information_With_Player_Id(int playerId, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerId, seasonYear);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffWon] is not 0);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.BlockedShot] is not 0);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.HitGiven] is not 0);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.HitReceived] is not 0);
        Assert.IsTrue(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffLost] is not 0);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8471675, "20122013")]
    [DataRow(8479400, "20182019")]

    public async Task GetTotalPlayerStatisticValueByTypeAndSeasonAsync_Returns_Valid_Information_With_Player_Id_For_Previous_Season(int playerId, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerId, seasonYear, gameType: null);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.PlayerProfile);

        switch (playerId)
        {
            case 8471675:
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffWon], 625);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.BlockedShot], 25);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.HitGiven], 25);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.HitReceived], 54);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffLost], 553);

                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.MissedShot], 62);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.Giveaway], 69);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.Takeaway], 66);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.DrawnPenalty], 23);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.CommittedPenalty], 12);

                break;
            case 8479400:
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffWon], 544);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.BlockedShot], 59);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.HitGiven], 153);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.HitReceived], 166);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffLost], 716);

                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.MissedShot], 89);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.Giveaway], 117);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.Takeaway], 111);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.DrawnPenalty], 35);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.CommittedPenalty], 36);
                break;
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.SidneyCrosby8471675, "20122013")]
    [DataRow(PlayerEnum.PierreLucDubois8479400, "20182019")]

    public async Task GetTotalPlayerStatisticValueByTypeAndSeasonAsync_Returns_Valid_Information_With_Player_Id_For_Previous_Season(PlayerEnum playerEnum, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerEnum, seasonYear);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsNotNull(result.PlayerProfile);

        switch (playerEnum)
        {
            case PlayerEnum.SidneyCrosby8471675:
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffWon], 625);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.BlockedShot], 25);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.HitGiven], 25);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.HitReceived], 54);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffLost], 553);

                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.MissedShot], 62);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.Giveaway], 69);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.Takeaway], 66);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.DrawnPenalty], 23);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.CommittedPenalty], 12);

                break;
            case PlayerEnum.PierreLucDubois8479400:
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffWon], 544);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.BlockedShot], 59);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.HitGiven], 153);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.HitReceived], 166);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.FaceOffLost], 716);

                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.MissedShot], 89);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.Giveaway], 117);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.Takeaway], 111);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.DrawnPenalty], 35);
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.CommittedPenalty], 36);
                break;
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8478465, "20232024")]
    [DataRow(8482496, "20232024")]
    [DataRow(8481479, "20232024")]
    [DataRow(8477507, "20232024")]
    public async Task GetTotalPlayerStatisticValuesByTypeAndSeasonAsync_Returns_Valid_Information_With_Player_Id_Certain_Cases(int playerId, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerId, seasonYear, GameType.RegularSeason);

        // Assert
        Assert.IsNotNull(result);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.GuillaumeBrisebois8478465, "20232024")]
    [DataRow(PlayerEnum.NilsAman8482496, "20232024")]
    [DataRow(PlayerEnum.BroganRafferty8481479, "20232024")]
    [DataRow(PlayerEnum.NikitaZadorov8477507, "20232024")]
    public async Task GetTotalPlayerStatisticValuesByTypeAndSeasonAsync_Returns_Valid_Information_With_Player_Enum_Certain_Cases_For_Regular_Season(PlayerEnum playerEnum, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerEnum, seasonYear, GameType.RegularSeason);

        // Assert
        Assert.IsNotNull(result);
    }

    [TestMethodWithRetry(RetryCount = 10)]
    public async Task GetTotalPlayerStatisticValuesByTypeAndSeasonAsync_Returns_Valid_Information_For_Random_Players()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        var indexes = new HashSet<int>();
        Enumerable.Range(1,50).ToList().ForEach( i => indexes.Add(new Random().Next(0, 1000)));

        var concurrentCollection = new ConcurrentBag<PlayerEnum>(Enum.GetValues(typeof(PlayerEnum)).Cast<PlayerEnum>().ToList().Select((value, i) => 
        {
            if (indexes.Contains(i))
            {
                return value;
            }

            return default;

        }).Where(x => x != default));
        
        Parallel.ForEach(concurrentCollection, new ParallelOptions { MaxDegreeOfParallelism = 16 }, async (playerEnum) =>
        {
            // Act
            var result = await nhlApi.GetAllTotalPlayerStatisticValuesBySeasonAsync(playerEnum, "20232024", GameType.RegularSeason);

            // Assert
            Assert.IsNotNull(result);
        });
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8471675, "20122013")]
    [DataRow(8471214, "20182019")]
    public async Task GetTotalPlayerStatisticValueByTypeAndSeasonAsync_Returns_Valid_Information_With_Player_Id_For_Playoffs(int playerId, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetTotalPlayerStatisticValueByTypeAndSeasonAsync(playerId, PlayerGameCenterStatistic.MissedShot,  seasonYear, gameType: GameType.Playoffs);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result > 5);   
    }
}
