using Newtonsoft.Json;
using Nhl.Api.Enumerations.Game;
using Nhl.Api.Enumerations.Statistic;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Team;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading;

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

    public async Task GetSkaterStatisticsLeadersAsync_Returns_Valid_Information(PlayerStatisticsType playerStatisticsType, GameType gameType, string seasonYear, int limit)
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
    public async Task GetGoalieStatisticsLeadersAsync_Returns_Valid_Information(GoalieStatisticsType goalieStatisticsType, GameType gameType, string seasonYear, int limit)
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
                Assert.AreEqual(result.StatisticsTotals[PlayerGameCenterStatistic.ShotOnGoal], 161);

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
    [DataRow(PlayerEnum.BrendanGallagher8475848, "20232024")]
    [DataRow(PlayerEnum.EliasPettersson8480012, "20232024")]

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
        Enumerable.Range(1, 50).ToList().ForEach(i => indexes.Add(new Random().Next(0, 1000)));

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
        var result = await nhlApi.GetTotalPlayerStatisticValueByTypeAndSeasonAsync(playerId, PlayerGameCenterStatistic.MissedShot, seasonYear, gameType: GameType.Playoffs);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result > 5);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetAllPlayersStatisticValuesBySeasonAsync_Returns_Valid_Information()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetAllPlayersStatisticValuesBySeasonAsync(SeasonYear.season20232024, GameType.RegularSeason);

        // Assert
        Assert.IsNotNull(result);

        Assert.IsTrue(result.Count > 0);
        Assert.IsTrue(result.Count > 500);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetAllPlayersStatisticValuesBySeasonAsync_Throws_Exception_Invalid_Season()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act/Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetAllPlayersStatisticValuesBySeasonAsync("56468548949864"));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTotalPlayerStatisticValuesByTypeAndSeasonAsync_Returns_Valid_Information_For_Playoffs()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        var schedule = await nhlApi.GetTeamScheduleBySeasonAsync("VAN", "20232024");
        schedule.Games = schedule.Games.Where(x => x.GameType == 2).ToList();

        var list = new List<GameCenterPlay>();

        foreach (var game in schedule.Games)
        {
            list.AddRange(
                (await nhlApi.GetGameCenterPlayByPlayByGameIdAsync(game.Id)).Plays
                .Where(p => p.Details?.BlockingPlayerId == 8480012)
                .Select(p => p)
                .ToList());
        }

        var item = JsonConvert.SerializeObject(list);
    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_Query()
    {
        // Arrange
        var expressionFilter = new PlayerFilterExpressionBuilder();

        // Act
        var expression = expressionFilter
            .AddFilter(PlayerStatisticsFilter.Assists)
            .GreaterThan(10)
            .And()
            .AddFilter(PlayerStatisticsFilter.ShootsCatches)
            .EqualTo(ShootsCatches.Left)
            .And()
            .AddFilter(PlayerStatisticsFilter.TeamAbbreviation)
            .EqualTo(TeamCodes.TorontoMapleLeafs)
            .Build();

        await using var nhlApi = new NhlApi();

        var result = await nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20232024, expression);

        // Act
        Assert.IsNotNull(expression);
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 9);

        foreach (var player in result.PlayerStatisticsResults)
        {
            Assert.IsTrue(player.Assists > 10);
            Assert.IsTrue(player.TeamAbbreviations == TeamCodes.TorontoMapleLeafs);
            Assert.IsTrue(player.ShootsCatches == ShootsCatches.Left);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_Query_For_2000_Season()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var expressionFilter = new PlayerFilterExpressionBuilder();

        // Act
        var expression = expressionFilter
            .AddFilter(PlayerStatisticsFilter.OvertimeGoals)
            .GreaterThan(1)
            .And()
            .AddFilter(PlayerStatisticsFilter.ShootsCatches)
            .EqualTo(ShootsCatches.Right)
            .Build();


        var result = await nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season19992000, expression);

        // Act
        Assert.IsNotNull(expression);
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 8);

        foreach (var player in result.PlayerStatisticsResults)
        {
            Assert.IsTrue(player.OvertimeGoals > 1);
            Assert.IsTrue(player.ShootsCatches == ShootsCatches.Right);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Empty_Expression()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var expressionFilter = new PlayerFilterExpressionBuilder();

        // Act
        var expression = expressionFilter.Build();

        var result = await nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20102011, expression);

        // Act
        Assert.IsNotNull(expression);
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 800);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_Query_For_Complex_Query_1()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var expressionFilter = new PlayerFilterExpressionBuilder();

        // Act
        var expression = expressionFilter
            .AddFilter(PlayerStatisticsFilter.OvertimeGoals)
            .GreaterThan(1)
            .And()
            .AddFilter(PlayerStatisticsFilter.ShootsCatches)
            .EqualTo(ShootsCatches.Right)
            .And()
            .AddFilter(PlayerStatisticsFilter.PointsPerGame)
            .GreaterThan(0.7)
            .And()
            .AddFilter(PlayerStatisticsFilter.Goals)
            .GreaterThanOrEqualTo(20)
            .And()
            .AddFilter(PlayerStatisticsFilter.Assists)
            .GreaterThanOrEqualTo(20)
            .And()
            .AddFilter(PlayerStatisticsFilter.PlusMinus)
            .GreaterThanOrEqualTo(10)
            .Build();


        var result = await nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20232024, expression);

        // Act
        Assert.IsNotNull(expression);
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 2);

        foreach (var player in result.PlayerStatisticsResults)
        {
            Assert.IsTrue(player.OvertimeGoals > 1);
            Assert.IsTrue(player.ShootsCatches == ShootsCatches.Right);
            Assert.IsTrue(player.PointsPerGame > 0.7m);
            Assert.IsTrue(player.Goals >= 20);
            Assert.IsTrue(player.Assists >= 20);
            Assert.IsTrue(player.PlusMinus >= 10);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_Query_For_Complex_Query_2()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var expressionFilter = new PlayerFilterExpressionBuilder();

        // Act
        var expression = expressionFilter
            .AddFilter(PlayerStatisticsFilter.OvertimeGoals)
            .GreaterThan(1)
            .And()
            .AddFilter(PlayerStatisticsFilter.ShootsCatches)
            .EqualTo(ShootsCatches.Right)
            .And()
            .AddFilter(PlayerStatisticsFilter.PointsPerGame)
            .GreaterThan(0.7)
            .And()
            .AddFilter(PlayerStatisticsFilter.Goals)
            .GreaterThanOrEqualTo(20)
            .And()
            .AddFilter(PlayerStatisticsFilter.Assists)
            .GreaterThanOrEqualTo(20)
            .And()
            .AddFilter(PlayerStatisticsFilter.PlusMinus)
            .GreaterThanOrEqualTo(10)
            .And()
            .StartGroup()
            .AddFilter(PlayerStatisticsFilter.PenaltyMinutes)
            .LessThanOrEqualTo(50)
            .Or()
            .AddFilter(PlayerStatisticsFilter.EvenGoals)
            .GreaterThan(10)
            .EndGroup()
            .Build();

        var result = await nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20232024, expression);

        // Act
        Assert.IsNotNull(expression);
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 2);

        foreach (var player in result.PlayerStatisticsResults)
        {
            Assert.IsTrue(player.OvertimeGoals > 1);
            Assert.IsTrue(player.ShootsCatches == ShootsCatches.Right);
            Assert.IsTrue(player.PointsPerGame > 0.7m);
            Assert.IsTrue(player.Goals >= 20);
            Assert.IsTrue(player.Assists >= 20);
            Assert.IsTrue(player.PlusMinus >= 10);
            Assert.IsTrue(player.PenaltyMinutes <= 50 || player.EvenStrengthGoals > 10);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_With_No_Query()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20232024, ExpressionPlayerFilter.Empty);

        // Act
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total > 800);

    }
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_Query_For_Simple_Query()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var expressionFilter = new GoalieFilterExpressionBuilder();

        // Act
        var expression = expressionFilter
            .AddFilter(GoalieStatisticsFilter.Wins)
            .GreaterThan(30)
            .And()
            .AddFilter(GoalieStatisticsFilter.GoalsAgainstAverage)
            .LessThanOrEqualTo(3.15)
            .Build();

        var result = await nhlApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20232024, expression);

        // Act
        Assert.IsNotNull(expression);
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 1);

        foreach (var player in result.GoalieStatisticsResults)
        {
            Assert.IsTrue(player.Wins > 30);
            Assert.IsTrue(player.GoalsAgainstAverage <= 3.15);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_Query_For_Empty_Query()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var expressionFilter = new GoalieFilterExpressionBuilder();

        // Act
        var result = await nhlApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20232024, ExpressionGoalieFilter.Empty);

        // Act
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 81);

    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_Query_For_Complex_Query()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var expressionFilter = new GoalieFilterExpressionBuilder();

        // Act
        var expression = expressionFilter
            .AddFilter(GoalieStatisticsFilter.Wins)
            .GreaterThan(10)
            .And()
            .AddFilter(GoalieStatisticsFilter.GoalsAgainstAverage)
            .LessThanOrEqualTo(3.5)
            .And()
            .AddFilter(GoalieStatisticsFilter.Shutouts)
            .GreaterThan(0)
            .And()
            .StartGroup()
            .AddFilter(GoalieStatisticsFilter.SavePercentage)
            .GreaterThanOrEqualTo(0.901)
            .Or()
            .AddFilter(GoalieStatisticsFilter.PenaltyMinutes)
            .GreaterThan(0)
            .EndGroup()
            .Build();

        var result = await nhlApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20232024, expression);

        // Act
        Assert.IsNotNull(expression);
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 1);

        foreach (var player in result.GoalieStatisticsResults)
        {
            Assert.IsTrue(player.Wins > 10);
            Assert.IsTrue(player.GoalsAgainstAverage <= 3.5);
            Assert.IsTrue(player.Shutouts > 0);
            Assert.IsTrue(player.SavePercentage >= 0.9 || player.PenaltyMinutes > 0);
        }
    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterAsync_Returns_Valid_Results_Based_On_Filter_Query_For_Complex_Query_2()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var expressionFilter = new GoalieFilterExpressionBuilder();

        // Act
        var expression = expressionFilter
            .AddFilter(GoalieStatisticsFilter.Wins)
            .LessThan(40)
            .And()
            .AddFilter(GoalieStatisticsFilter.GoalsAgainstAverage)
            .LessThanOrEqualTo(3.5)
            .And()
            .AddFilter(GoalieStatisticsFilter.Shutouts)
            .GreaterThan(0)
            .And()
            .StartGroup()
            .AddFilter(GoalieStatisticsFilter.SavePercentage)
            .GreaterThanOrEqualTo(0.900)
            .Or()
            .AddFilter(GoalieStatisticsFilter.PenaltyMinutes)
            .GreaterThan(0)
            .EndGroup()
            .And()
            .AddFilter(GoalieStatisticsFilter.GoalieFullName)
            .Contains("An")
            .And()
            .AddFilter(GoalieStatisticsFilter.GoalieFullName)
            .NotContains("Ze")
            .And()
            .AddFilter(GoalieStatisticsFilter.PlayerId)
            .NotEqualTo(8471214)
            .Build();

        var result = await nhlApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(SeasonYear.season20182019, expression);

        // Act
        Assert.IsNotNull(expression);
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Total >= 6);

        foreach (var player in result.GoalieStatisticsResults)
        {
            Assert.IsTrue(player.Wins < 40);
            Assert.IsTrue(player.GoalsAgainstAverage <= 3.5);
            Assert.IsTrue(player.Shutouts > 0);
            Assert.IsTrue(player.SavePercentage >= 0.9 || player.Assists > 0);
            Assert.IsTrue(player.GoalieFullName.Contains("An"));
            Assert.IsTrue(!player.GoalieFullName.Contains("Ze"));
            Assert.IsTrue(player.PlayerId != 8471214);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [ExpectedException(typeof(ArgumentException))]
    public async Task GetGoalieStatisticsLeadersAsync_EmptySeasonYear_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        var goalieStatisticsType = GoalieStatisticsType.Wins;
        var gameType = GameType.RegularSeason;
        string seasonYear = string.Empty;
        var limit = 10;
        var cancellationToken = CancellationToken.None;

        // Act / Assert
        await nhlApi.GetGoalieStatisticsLeadersAsync(goalieStatisticsType, gameType, seasonYear, limit, cancellationToken);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [ExpectedException(typeof(ArgumentException))]
    public async Task GetGoalieStatisticsLeadersAsync_InvalidSeasonYearLength_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        var goalieStatisticsType = GoalieStatisticsType.Wins;
        var gameType = GameType.RegularSeason;
        var seasonYear = "2023"; // Invalid length
        var limit = 10;
        var cancellationToken = CancellationToken.None;

        // Act / Assert
        await nhlApi.GetGoalieStatisticsLeadersAsync(goalieStatisticsType, gameType, seasonYear, limit, cancellationToken);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [ExpectedException(typeof(ArgumentException))]
    public async Task GetGoalieStatisticsLeadersAsync_LimitLessThanOne_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        var goalieStatisticsType = GoalieStatisticsType.Wins;
        var gameType = GameType.RegularSeason;
        var seasonYear = "20232024";
        var limit = 0; // Invalid limit
        var cancellationToken = CancellationToken.None;

        // Act / Assert
        await nhlApi.GetGoalieStatisticsLeadersAsync(goalieStatisticsType, gameType, seasonYear, limit, cancellationToken);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterExpressionAsync_ValidInput_ReturnsPlayerStatistics()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = "2023"; // Example season year
        var expressionPlayerFilter = ExpressionPlayerFilter.Empty; // Example filter
        PlayerStatisticsFilter playerStatisticsFilterToSortBy = PlayerStatisticsFilter.Points; // Example filter to sort by
        int limit = 10; // Example limit
        int offsetStart = 0; // Example offset
        CancellationToken cancellationToken = default;

        // Act
        var result = await nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken);

        // Assert
        Assert.IsNotNull(result);
        // Add more assertions based on expected result
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterExpressionAsync_NullSeasonYear_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = null;
        var expressionPlayerFilter = ExpressionPlayerFilter.Empty;
        PlayerStatisticsFilter playerStatisticsFilterToSortBy = PlayerStatisticsFilter.Points;

        int limit = 10;
        int offsetStart = 0;
        CancellationToken cancellationToken = default;

        // Act & Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(() => nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterExpressionAsync_NullPlayerFilter_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = "2023";
        ExpressionPlayerFilter expressionPlayerFilter = null;
        PlayerStatisticsFilter playerStatisticsFilterToSortBy = PlayerStatisticsFilter.Points;
        int limit = 10;
        int offsetStart = 0;
        CancellationToken cancellationToken = default;

        // Act & Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(() => nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterExpressionAsync_InvalidLimit_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = "2023";
        var expressionPlayerFilter = ExpressionPlayerFilter.Empty;
        var playerStatisticsFilterToSortBy = PlayerStatisticsFilter.Points;
        int limit = -5; // Invalid limit
        int offsetStart = 0;
        CancellationToken cancellationToken = default;

        // Act & Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(() => nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerStatisticsBySeasonAndFilterExpressionAsync_InvalidOffsetStart_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = "2023";
        var expressionPlayerFilter = ExpressionPlayerFilter.Empty;
        PlayerStatisticsFilter playerStatisticsFilterToSortBy = PlayerStatisticsFilter.Points;
        int limit = 10;
        int offsetStart = -3; // Invalid offset
        CancellationToken cancellationToken = default;

        // Act & Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(() => nhlApi.GetPlayerStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken));
    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterExpressionAsync_NullSeasonYear_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = null;
        var expressionPlayerFilter = ExpressionGoalieFilter.Empty;
        GoalieStatisticsFilter playerStatisticsFilterToSortBy = GoalieStatisticsFilter.Wins;

        int limit = 10;
        int offsetStart = 0;
        CancellationToken cancellationToken = default;

        // Act & Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(() => nhlApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterExpressionAsync_NullPlayerFilter_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = "2023";
        ExpressionGoalieFilter expressionPlayerFilter = null;
        GoalieStatisticsFilter playerStatisticsFilterToSortBy = GoalieStatisticsFilter.Wins;
        int limit = 10;
        int offsetStart = 0;
        CancellationToken cancellationToken = default;

        // Act & Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(() => nhlApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterExpressionAsync_InvalidLimit_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = "2023";
        var expressionPlayerFilter = ExpressionGoalieFilter.Empty;
        GoalieStatisticsFilter playerStatisticsFilterToSortBy = GoalieStatisticsFilter.Wins;
        int limit = -5; // Invalid limit
        int offsetStart = 0;
        CancellationToken cancellationToken = default;

        // Act & Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(() => nhlApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieStatisticsBySeasonAndFilterExpressionAsync_InvalidOffsetStart_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        string seasonYear = "2023";
        var expressionPlayerFilter = ExpressionGoalieFilter.Empty;
        GoalieStatisticsFilter playerStatisticsFilterToSortBy = GoalieStatisticsFilter.Wins;
        int limit = 10;
        int offsetStart = -3; // Invalid offset
        CancellationToken cancellationToken = default;

        // Act & Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(() => nhlApi.GetGoalieStatisticsBySeasonAndFilterExpressionAsync(seasonYear, expressionPlayerFilter, playerStatisticsFilterToSortBy, limit, offsetStart, cancellationToken));
    }
}
