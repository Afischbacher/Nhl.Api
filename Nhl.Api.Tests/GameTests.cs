using System.Globalization;
using System.Linq;

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
        Assert.IsTrue(results.Count != 0);

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
    [DataRow(2024010050)]
    [DataRow(2024010055)]
    [DataRow(2024010060)]

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
        Assert.IsNotNull(results.PlayerByGameStatistics);

        Assert.IsNotNull(results.Id);
        Assert.IsNotNull(results.Clock);
        Assert.IsNotNull(results.Period);
        Assert.IsNotNull(results.AwayTeam);
        Assert.IsNotNull(results.HomeTeam);
        Assert.IsNotNull(results.GameOutcome);

        if (results.Boxscore != null)
        {
            Assert.IsNotNull(results.Boxscore);
            Assert.IsNotNull(results.Boxscore.Linescore);
            Assert.IsNotNull(results.Boxscore.SeasonSeriesWins);
            Assert.IsNotNull(results.Boxscore.SeasonSeries);
            Assert.IsNotNull(results.Boxscore.TeamGameStatistics);
        }
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
        var results = await nhlApi.GetTvScheduleBroadcastByDateAsync(DateOnly.Parse(date, CultureInfo.InvariantCulture));

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
        Assert.IsTrue(results.Count != 0);
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

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(2023020204)]
    [DataRow(2023020205)]
    [DataRow(2023020206)]
    [DataRow(2023020207)]
    [DataRow(2017020205)]
    [DataRow(2018020206)]
    [DataRow(2019020207)]
    public async Task GetGameStoryByGameIdAsync_Return_Valid_Information(int gameId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetGameStoryByGameIdAsync(gameId);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsTrue(result.Id > 0);
        Assert.IsTrue(result.Season > 0);
        Assert.IsTrue(result.GameType > 0);
        Assert.IsFalse(string.IsNullOrWhiteSpace(result.GameDate));
        Assert.IsNotNull(result.Venue);
        Assert.IsFalse(string.IsNullOrWhiteSpace(result.Venue.Default));
        Assert.IsNotNull(result.VenueLocation);
        Assert.IsFalse(string.IsNullOrWhiteSpace(result.VenueLocation.Default));
        Assert.IsNotNull(result.StartTimeUTC);
        Assert.IsFalse(string.IsNullOrWhiteSpace(result.EasternUTCOffset));
        Assert.IsFalse(string.IsNullOrWhiteSpace(result.VenueUTCOffset));
        Assert.IsFalse(string.IsNullOrWhiteSpace(result.VenueTimezone));
        Assert.IsNotNull(result.TvBroadcasts);
        Assert.IsNotNull(result.GameState);
        Assert.IsNotNull(result.GameScheduleState);
        Assert.IsNotNull(result.AwayTeam);
        Assert.IsNotNull(result.HomeTeam);
        Assert.IsNotNull(result.Summary);
        Assert.IsNotNull(result.Clock);
        Assert.IsNotNull(result.PeriodDescriptor);
        Assert.IsNotNull(result.Summary.Scoring);
        Assert.IsNotNull(result.Summary.ThreeStars);
        Assert.IsNotNull(result.Summary.TeamGameStats);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(2023)]
    [DataRow(2022)]
    [DataRow(2021)]
    [DataRow(2020)]
    public async Task GetPlayoffBracketAsync_Returns_Valid_Information(int year)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetPlayoffBracketAsync(year);

        // Assert
        Assert.IsNotNull(result);
        Assert.IsFalse(string.IsNullOrWhiteSpace(result.BracketLogo));
        Assert.IsFalse(string.IsNullOrWhiteSpace(result.BracketLogoFr));
        Assert.IsNotNull(result.Series);
        Assert.IsTrue(result.Series.Count > 0);

        foreach (var series in result.Series)
        {
            Assert.IsNotNull(series);
            Assert.IsFalse(string.IsNullOrWhiteSpace(series.SeriesUrl));
            Assert.IsFalse(string.IsNullOrWhiteSpace(series.SeriesTitle));
            Assert.IsFalse(string.IsNullOrWhiteSpace(series.SeriesAbbrev));
            Assert.IsFalse(string.IsNullOrWhiteSpace(series.SeriesLetter));
            Assert.IsTrue(series.PlayoffRound >= 0);
            Assert.IsTrue(series.TopSeedRank > 0);
            Assert.IsFalse(string.IsNullOrWhiteSpace(series.TopSeedRankAbbrev));
            Assert.IsTrue(series.TopSeedWins >= 0);
            Assert.IsTrue(series.BottomSeedRank > 0);
            Assert.IsFalse(string.IsNullOrWhiteSpace(series.BottomSeedRankAbbrev));
            Assert.IsTrue(series.BottomSeedWins >= 0);
            Assert.IsTrue(series.WinningTeamId > 0);
            Assert.IsTrue(series.LosingTeamId > 0);

            Assert.IsNotNull(series.TopSeedTeam);
            Assert.IsNotNull(series.BottomSeedTeam);

            // SeriesLogo, SeriesLogoFr, ConferenceAbbrev, ConferenceName are optional
            foreach (var team in new[] { series.TopSeedTeam, series.BottomSeedTeam })
            {
                Assert.IsTrue(team.Id > 0);
                Assert.IsFalse(string.IsNullOrWhiteSpace(team.Abbrev));
                Assert.IsNotNull(team.Name);
                Assert.IsFalse(string.IsNullOrWhiteSpace(team.Name.Default));
                Assert.IsFalse(string.IsNullOrWhiteSpace(team.Name.Fr));
                Assert.IsNotNull(team.CommonName);
                Assert.IsFalse(string.IsNullOrWhiteSpace(team.CommonName.Default));
                Assert.IsNotNull(team.PlaceNameWithPreposition);
                Assert.IsFalse(string.IsNullOrWhiteSpace(team.PlaceNameWithPreposition.Default));
                Assert.IsFalse(string.IsNullOrWhiteSpace(team.PlaceNameWithPreposition.Fr));
                Assert.IsFalse(string.IsNullOrWhiteSpace(team.Logo));
                Assert.IsFalse(string.IsNullOrWhiteSpace(team.DarkLogo));
            }
        }
    }
}
