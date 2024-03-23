namespace Nhl.Api.Tests;
using Nhl.Api.Common.Http;
using System.Linq;
using System.Text.RegularExpressions;

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
    public async Task NhlScoresHtmlReportsApiHttpClient_Can_Parse_Html_Report_For_Start_End_Period_Times()
    {
        var dictionary = new Dictionary<string, List<string>>
        {
            { "P1", new List<string>() },
            { "P2", new List<string>() },
            { "P3", new List<string>() },
            { "OT", new List<string>() },
            { "SH", new List<string>() },
        };

        var httpClient = new NhlScoresHtmlReportsApiHttpClient();
        var gameReport = await httpClient.GetStringAsync("/20232024/PL020206.HTM");

        var regex = Regex.Matches(gameReport, @"(?<=<td class="" \+ bborder"">)Period(.*?)(?=</td>)", RegexOptions.Compiled, TimeSpan.FromSeconds(30)).ToList();

        for (int i = 0; i < regex.Count; i++)
        {
            var match = regex[i].Value;
            var value = Regex.Match(match, @"([0-9]{1,2}:[0-9]{2}\s[A-Z]{3})", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(30)).Groups[0].Value;
            if (i <= 1)
            {
                dictionary["P1"].Add(value);
            }
            else if (i >= 2 && i <= 3)
            {
                dictionary["P2"].Add(value);
            }
            else if (i >= 4 && i <= 5)
            {
                dictionary["P3"].Add(value);
            }
            else if (i >= 6 && i <= 7)
            {
                dictionary["OT"].Add(value);
            }
            else if (i <= 9)
            {
                dictionary["SH"].Add(value);
            }
        }
    }
}