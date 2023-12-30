using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Tests.Helpers.Attributes;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api.Tests;

[TestClass]
public class GameTests
{

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2022-11-12")]
    [DataRow("2022-11-13")]
    [DataRow("2023-11-14")]
    [DataRow("2023-12-03")]
    public async Task GetGameScoresByDateTimeAsync_Return_Valid_Score_Information(string date)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetGameScoresByDateTimeAsync(DateTimeOffset.Parse(date));

        // Assert
        Assert.IsNotNull(result);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetSourcesToWatchGamesAsync_Return_Valid_Information()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetSourcesToWatchGamesAsync();

        // Assert
        Assert.IsNotNull(results);
        Assert.IsTrue(results.Any());

    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGameScoreboardAsync_Return_Valid_Information()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameScoreboardAsync();

        // Assert
        Assert.IsNotNull(results);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(2023020204)]
    [DataRow(2023020205)]
    [DataRow(2023020206)]
    public async Task GetGameCenterPlayByPlayByGameIdAsync_Return_Valid_Information(int gameId)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameCenterPlayByPlayByGameIdAsync(gameId);

        // Assert
        Assert.IsNotNull(results);
        Assert.IsNotNull(results.GameDate);
        Assert.IsNotNull(results.GameType);
        Assert.IsNotNull(results.Id);
        Assert.IsNotNull(results.Clock);
        Assert.IsNotNull(results.Period);
        Assert.IsNotNull(results.AwayTeam);
        Assert.IsNotNull(results.HomeTeam);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(2023020204)]
    [DataRow(2023020205)]
    [DataRow(2023020206)]
    public async Task GetGameCenterBoxScoreByGameIdAsync_Return_Valid_Information(int gameId)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameCenterBoxScoreByGameIdAsync(gameId);

        // Assert
        Assert.IsNotNull(results);
        Assert.IsNotNull(results.GameDate);
        Assert.IsNotNull(results.GameType);
        Assert.IsNotNull(results.Id);
        Assert.IsNotNull(results.Clock);
        Assert.IsNotNull(results.Period);
        Assert.IsNotNull(results.AwayTeam);
        Assert.IsNotNull(results.HomeTeam);
        Assert.IsNotNull(results.GameOutcome);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2023-12-12")]
    [DataRow("2022-11-12")]
    [DataRow("2018-11-13")]
    [DataRow("2019-02-12")]
    public async Task GetTvScheduleBroadcastAsync_Return_Valid_Information(string date)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetTvScheduleBroadcastAsync(DateTimeOffset.Parse(date));

        // Assert
        Assert.IsNotNull(results);
        Assert.IsNotNull(results.StartDate);
        Assert.IsNotNull(results.EndDate);
        Assert.IsNotNull(results.Date);
        Assert.IsNotNull(results.Broadcasts);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetAllSeasonsAsync_Return_Valid_Information()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetAllSeasonsAsync();

        // Assert
        Assert.IsNotNull(results);
        Assert.IsTrue(results.Any());
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(2023020204)]
    [DataRow(2023020205)]
    [DataRow(2023020206)]
    public async Task GetGameMetadataByGameIdAsync_Return_Valid_Information(int gameId)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameMetadataByGameIdAsync(gameId);

        // Assert
        Assert.IsNotNull(results);
        Assert.IsNotNull(results.Teams);
        Assert.IsNotNull(results.SeasonStates);

    }
}