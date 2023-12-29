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
}