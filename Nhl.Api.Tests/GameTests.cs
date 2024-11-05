using System.Linq;
using System.Text.RegularExpressions;
using Nhl.Api.Common.Http;

namespace Nhl.Api.Tests;

[TestClass]
public class GameTests
{

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2022-11-12")]
    [DataRow("2022-11-13")]
    [DataRow("2023-11-14")]
    [DataRow("2023-12-03")]
    [DataRow("2019-03-03")]
    [DataRow("2018-03-04")]
    [DataRow("2014-03-04")]
    [DataRow("2016-03-04")]
    [DataRow("2011-03-04")]

    public async Task GetGameScoresByDateTimeAsync_Return_Valid_Score_Information(string date)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var dateOnly = DateOnly.ParseExact(date, "yyyy-MM-dd");
        var result = await nhlApi.GetGameScoresByDateAsync(date: dateOnly);

        // Assert
        Assert.IsNotNull(result);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetSourcesToWatchGamesAsync_Return_Valid_Information()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

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
        await using var nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameScoreboardAsync();

        // Assert
        Assert.IsNotNull(results);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(2023020204)]
    [DataRow(2023020205)]
    [DataRow(2023020206)]
    [DataRow(2023020207)]
    [DataRow(2017020205)]
    [DataRow(2018020206)]
    [DataRow(2019020207)]

    public async Task GetGameCenterPlayByPlayByGameIdAsync_Return_Valid_Information(int gameId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

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
    [DataRow(2023020207)]
    [DataRow(2017020205)]
    [DataRow(2018020206)]
    [DataRow(2019020207)]
    public async Task GetGameCenterBoxScoreByGameIdAsync_Return_Valid_Information(int gameId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameCenterBoxScoreByGameIdAsync(gameId);

        // Assert
        Assert.IsNotNull(results);
        Assert.IsNotNull(results.GameDate);
        Assert.IsNotNull(results.GameType);
        Assert.IsNotNull(results.Boxscore);

        Assert.IsNotNull(results.Boxscore.Linescore);
        Assert.IsNotNull(results.Boxscore.SeasonSeriesWins);
        Assert.IsNotNull(results.Boxscore.SeasonSeries);
        Assert.IsNotNull(results.Boxscore.TeamGameStatistics);
        Assert.IsNotNull(results.PlayerByGameStatistics);

        Assert.IsNotNull(results.Id);
        Assert.IsNotNull(results.Clock);
        Assert.IsNotNull(results.Period);
        Assert.IsNotNull(results.AwayTeam);
        Assert.IsNotNull(results.HomeTeam);
        Assert.IsNotNull(results.GameOutcome);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(2023020204)]
    [DataRow(2023020205)]
    [DataRow(2023020206)]
    [DataRow(2023020207)]
    [DataRow(2017020205)]
    [DataRow(2018020206)]
    [DataRow(2019020207)]
    public async Task GetGameCenterLandingByGameIdAsync_Return_Valid_Information(int gameId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameCenterLandingByGameIdAsync(gameId);

        // Assert
        Assert.IsNotNull(results);
        Assert.IsNotNull(results.GameDate);
        Assert.IsNotNull(results.GameType);
        Assert.IsNotNull(results.Id);
        Assert.IsNotNull(results.Clock);
        Assert.IsNotNull(results.AwayTeam);
        Assert.IsNotNull(results.HomeTeam);
    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2023-12-12")]
    [DataRow("2022-11-12")]
    [DataRow("2018-11-13")]
    [DataRow("2019-02-12")]
    public async Task GetTvScheduleBroadcastAsync_Return_Valid_Information(string date)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetTvScheduleBroadcastByDateAsync(DateOnly.Parse(date));

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
        await using var nhlApi = new NhlApi();

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
        await using var nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameMetadataByGameIdAsync(gameId);

        // Assert
        Assert.IsNotNull(results);
        Assert.IsNotNull(results.Teams);
        Assert.IsNotNull(results.SeasonStates);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(2000020004)]
    [DataRow(2001020004)]
    [DataRow(2002020004)]
    [DataRow(2003020004)]
    [DataRow(2005020037)]
    [DataRow(2006020046)]
    [DataRow(2007020055)]
    [DataRow(2008020074)]
    [DataRow(2009020090)]
    [DataRow(2010020090)]
    [DataRow(2011020090)]
    [DataRow(2012020090)]
    [DataRow(2013020090)]
    [DataRow(2014020090)]
    [DataRow(2015020090)]
    [DataRow(2016020090)]
    [DataRow(2017020090)]
    [DataRow(2018020090)]
    [DataRow(2023010110)]
    [DataRow(2019020090)]
    [DataRow(2020020090)]
    [DataRow(2021020090)]
    [DataRow(2022020090)]
    [DataRow(2023020090)]
    public async Task GetGameCenterPlayByPlayByGameIdAsync_Returns_Valid_Estimated_DateTime_Of_Play_Information(int gameId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var results = await nhlApi.GetGameCenterPlayByPlayByGameIdAsync(gameId, includeEventDateTime: true);

        // Assert
        Assert.IsNotNull(results);
        Assert.IsNotNull(results.GameDate);
        Assert.IsNotNull(results.GameType);
        Assert.IsNotNull(results.Id);
        Assert.IsNotNull(results.Clock);
        Assert.IsNotNull(results.Plays);
        Assert.IsTrue(results.Plays.All(p => p.EstimatedDateTimeOfPlay.HasValue));
    }
}
