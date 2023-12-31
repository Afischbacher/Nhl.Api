using Nhl.Api.Enumerations.Game;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Team;
using System.Linq;

namespace Nhl.Api.Tests;

[TestClass]
public class LeagueTests
{
    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2023-12-01")]
    [DataRow("2023-12-02")]
    [DataRow("2020-02-23")]
    [DataRow("2015-11-05")]
    [DataRow("2010-11-06")]
    [DataRow("2005-11-07")]
    [DataRow("2000-11-08")]
    [DataRow("1995-11-09")]
    [DataRow("1990-11-10")]
    public async Task GetLeagueGameWeekScheduleByDateTimeAsync_Get_League_Schedule_Game_Week(string date)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var schedule = await nhlApi.GetLeagueGameWeekScheduleByDateTimeAsync(DateOnly.Parse(date));

        // Assert
        Assert.IsNotNull(schedule);
        Assert.IsNotNull(schedule.GameWeek);
        Assert.IsTrue(schedule.GameWeek.Count > 0);

        foreach (var game in schedule.GameWeek)
        {
            Assert.IsNotNull(game);
            Assert.IsNotNull(game.NumberOfGames);
            Assert.IsTrue(game.NumberOfGames > 0);
            Assert.IsNotNull(game.Games);

            if (game.Games.Count > 0)
            {
                var firstGame = game.Games.First();
                Assert.IsNotNull(firstGame.GameCenterLink);
                Assert.IsNotNull(firstGame.GameState);
                Assert.IsNotNull(firstGame.GameType);
                Assert.IsNotNull(firstGame.Season);
                Assert.IsNotNull(firstGame.Id);
                Assert.IsNotNull(firstGame.GameOutcome);
                Assert.IsNotNull(firstGame.GameOutcome.LastPeriodType);
                Assert.IsNotNull(firstGame.Venue);
                Assert.IsNotNull(firstGame.GameScheduleState);
            }
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task IsPreSeasonActiveAsync_Returns_Not_Null()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var isPreSeasonActive = await nhlApi.IsPreSeasonActiveAsync();

        // Assert
        Assert.IsNotNull(isPreSeasonActive);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task IsRegularSeasonActiveAsync_Returns_Not_Null()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var isRegularSeasonActive = await nhlApi.IsRegularSeasonActiveAsync();

        // Assert
        Assert.IsNotNull(isRegularSeasonActive);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task IsPlayoffSeasonActiveAsync_Returns_Not_Null()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var isPlayoffActive = await nhlApi.IsPlayoffSeasonActiveAsync();

        // Assert
        Assert.IsNotNull(isPlayoffActive);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(TeamCodes.MightyDucksofAnaheimAnaheimDucks, "20222023")]
    [DataRow(TeamCodes.ArizonaCoyotes, "20232024")]
    [DataRow(TeamCodes.AtlantaThrashers, "20032004")]
    [DataRow(TeamCodes.BostonBruins, "20052006")]
    [DataRow(TeamCodes.BuffaloSabres, "20052006")]
    [DataRow(TeamCodes.CalgaryFlames, "20062007")]
    [DataRow(TeamCodes.CarolinaHurricanes, "20072008")]
    [DataRow(TeamCodes.ChicagoBlackHawks, "20082009")]
    [DataRow(TeamCodes.ColoradoAvalanche, "20092010")]
    [DataRow(TeamCodes.ColumbusBlueJackets, "20112012")]
    [DataRow(TeamCodes.DallasStars, "20122013")]
    [DataRow(TeamCodes.DetroitRedWings, "20132014")]
    [DataRow(TeamCodes.EdmontonOilers, "20142015")]
    [DataRow(TeamCodes.FloridaPanthers, "20152016")]
    [DataRow(TeamCodes.LosAngelesKings, "20162017")]
    [DataRow(TeamCodes.MinnesotaWild, "20172018")]
    [DataRow(TeamCodes.MontrealCanadiens, "20182019")]
    [DataRow(TeamCodes.NashvillePredators, "20192020")]
    [DataRow(TeamCodes.NewJerseyDevils, "20202021")]
    [DataRow(TeamCodes.NewYorkIslanders, "20212022")]
    [DataRow(TeamCodes.NewYorkRangers, "20222023")]
    [DataRow(TeamCodes.OttawaSenators, "20232024")]
    [DataRow(TeamCodes.PhiladelphiaFlyers, "19992000")]
    [DataRow(TeamCodes.PittsburghPenguins, "19981999")]
    [DataRow(TeamCodes.SanJoseSharks, "19971998")]
    [DataRow(TeamCodes.StLouisBlues, "20162017")]
    [DataRow(TeamCodes.TampaBayLightning, "20152016")]
    [DataRow(TeamCodes.TorontoMapleLeafs, "20182019")]
    [DataRow(TeamCodes.VancouverCanucks, "20142015")]
    [DataRow(TeamCodes.VegasGoldenKnights, "20232024")]
    [DataRow(TeamCodes.WashingtonCapitals, "20222023")]
    [DataRow(TeamCodes.WinnipegJets, "20212022")]
    [DataRow(TeamCodes.SeattleKraken, "20232024")]
    public async Task GetTeamScheduleBySeasonAsync_Returns_Not_Null_With_Valid_Information(string teamCode, string seasonYear)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var leagueStandings = await nhlApi.GetTeamScheduleBySeasonAsync(teamCode, seasonYear);

        // Assert
        Assert.IsNotNull(leagueStandings);
        Assert.IsNotNull(leagueStandings.Games);
        Assert.IsTrue(leagueStandings.Games.Count > 0);

        foreach (var game in leagueStandings.Games)
        {
            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Id);
            Assert.IsNotNull(game.HomeTeam);
            Assert.IsNotNull(game.AwayTeam);
            Assert.IsNotNull(game.PeriodDescriptor);
            Assert.IsNotNull(game.EasternUTCOffset);
            Assert.IsNotNull(game.VenueTimezone);
            Assert.IsNotNull(game.GameType);
            Assert.IsNotNull(game.GameState);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(TeamCodes.MightyDucksofAnaheimAnaheimDucks, "2022-12-03")]
    [DataRow(TeamCodes.ArizonaCoyotes, "2022-03-11")]
    [DataRow(TeamCodes.AtlantaThrashers, "2002-12-03")]
    [DataRow(TeamCodes.BostonBruins, "2006-02-03")]
    [DataRow(TeamCodes.BuffaloSabres, "2008-02-04")]
    [DataRow(TeamCodes.CalgaryFlames, "2006-01-05")]
    [DataRow(TeamCodes.CarolinaHurricanes, "2007-02-06")]
    [DataRow(TeamCodes.ChicagoBlackHawks, "2008-03-07")]
    [DataRow(TeamCodes.ColoradoAvalanche, "2009-12-08")]
    [DataRow(TeamCodes.ColumbusBlueJackets, "2011-01-09")]
    [DataRow(TeamCodes.DallasStars, "2012-03-10")]
    [DataRow(TeamCodes.DetroitRedWings, "2013-10-11")]
    [DataRow(TeamCodes.EdmontonOilers, "2014-11-12")]
    [DataRow(TeamCodes.FloridaPanthers, "2015-12-13")]
    [DataRow(TeamCodes.LosAngelesKings, "2016-01-14")]
    [DataRow(TeamCodes.MinnesotaWild, "2017-02-15")]
    [DataRow(TeamCodes.MontrealCanadiens, "2018-03-16")]
    [DataRow(TeamCodes.NashvillePredators, "2019-01-17")]
    [DataRow(TeamCodes.NewJerseyDevils, "2022-01-18")]
    [DataRow(TeamCodes.NewYorkIslanders, "2022-02-19")]
    [DataRow(TeamCodes.NewYorkRangers, "2022-11-20")]
    [DataRow(TeamCodes.OttawaSenators, "2023-11-21")]
    [DataRow(TeamCodes.PhiladelphiaFlyers, "1999-01-22")]
    [DataRow(TeamCodes.PittsburghPenguins, "1998-01-23")]
    [DataRow(TeamCodes.SanJoseSharks, "1997-01-24")]
    [DataRow(TeamCodes.StLouisBlues, "2016-12-15")]
    [DataRow(TeamCodes.TampaBayLightning, "2015-01-26")]
    [DataRow(TeamCodes.TorontoMapleLeafs, "2018-02-27")]
    [DataRow(TeamCodes.VancouverCanucks, "2014-10-28")]
    [DataRow(TeamCodes.VegasGoldenKnights, "2022-04-29")]
    [DataRow(TeamCodes.WashingtonCapitals, "2022-03-10")]
    [DataRow(TeamCodes.WinnipegJets, "2019-03-01")]
    [DataRow(TeamCodes.SeattleKraken, "2023-02-02")]

    public async Task GetTeamWeekScheduleByDateTimeOffsetAsync_Returns_Not_Null_With_Valid_Information(string teamCode, string seasonYear)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var teamWeekSchedule = await nhlApi.GetTeamWeekScheduleByDateAsync(teamCode, DateOnly.Parse(seasonYear));

        // Assert
        Assert.IsNotNull(teamWeekSchedule);
        Assert.IsNotNull(teamWeekSchedule.PreviousStartDate);
        Assert.IsNotNull(teamWeekSchedule.NextStartDate);

        if (teamWeekSchedule.CalendarUrl != null)
        {
            Assert.IsNotNull(teamWeekSchedule.CalendarUrl);
        }

        Assert.IsNotNull(teamWeekSchedule.ClubTimezone);
        Assert.IsNotNull(teamWeekSchedule.Games);
        Assert.IsTrue(teamWeekSchedule.Games.Count > 0);

        foreach (var game in teamWeekSchedule.Games)
        {
            Assert.IsNotNull(game);
            Assert.IsNotNull(game.Id);
            Assert.IsNotNull(game.HomeTeam);
            Assert.IsNotNull(game.AwayTeam);
            Assert.IsNotNull(game.PeriodDescriptor);
            Assert.IsNotNull(game.EasternUTCOffset);
            Assert.IsNotNull(game.VenueTimezone);
            Assert.IsNotNull(game.GameType);
            Assert.IsNotNull(game.GameState);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2023-12-01")]
    [DataRow("2022-10-14")]
    [DataRow("2013-11-15")]
    [DataRow("2002-10-16")]
    [DataRow("1992-10-17")]
    [DataRow("1982-10-18")]
    public async Task GetLeagueStandingsByDateTimeOffsetAsync_Get_League_Information_For_Date(string date)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var leagueStandingByDate = await nhlApi.GetLeagueStandingsByDateAsync(DateOnly.Parse(date));

        // Assert
        Assert.IsNotNull(leagueStandingByDate);
        Assert.IsTrue(leagueStandingByDate.Standings.Count() > 0);

        foreach (var standing in leagueStandingByDate.Standings)
        {
            Assert.IsNotNull(standing);
            Assert.IsNotNull(standing.ConferenceAbbrev);
            Assert.IsNotNull(standing.SeasonId);
        }
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetLeagueStandingsSeasonInformationAsync_Get_Information_Is_Valid()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var leagueStandingsSeasonInformation = await nhlApi.GetLeagueStandingsSeasonInformationAsync();

        // Assert
        Assert.IsNotNull(leagueStandingsSeasonInformation);
        Assert.IsTrue(leagueStandingsSeasonInformation.Seasons.Count > 100);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(TeamEnum.AnaheimDucks, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.ArizonaCoyotes, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.BostonBruins, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.BuffaloSabres, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.CalgaryFlames, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.CarolinaHurricanes, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.ChicagoBlackhawks, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.ColoradoAvalanche, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.ColumbusBlueJackets, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.DallasStars, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.DetroitRedWings, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.EdmontonOilers, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.FloridaPanthers, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.LosAngelesKings, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.MinnesotaWild, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.MontrealCanadiens, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.NashvillePredators, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.NewJerseyDevils, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.NewYorkIslanders, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.NewYorkRangers, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.OttawaSenators, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.PhiladelphiaFlyers, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.PittsburghPenguins, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.SanJoseSharks, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.StLouisBlues, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.TampaBayLightning, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.TorontoMapleLeafs, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.VancouverCanucks, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.VegasGoldenKnights, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.WashingtonCapitals, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.WinnipegJets, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(TeamEnum.SeattleKraken, SeasonYear.season20232024, GameType.RegularSeason)]
    public async Task GetTeamStatisticsBySeasonAndGameTypeAsync_Return_Valid_Information(TeamEnum team, string seasonYear, GameType gameType)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var leagueStandingsSeasonInformation = await nhlApi.GetTeamStatisticsBySeasonAndGameTypeAsync(team, seasonYear, gameType);

        // Assert
        Assert.IsNotNull(leagueStandingsSeasonInformation);
        Assert.IsNotNull(leagueStandingsSeasonInformation.Skaters);
        foreach (var teamStatisticSkater in leagueStandingsSeasonInformation.Skaters)
        {
            Assert.IsNotNull(teamStatisticSkater.PlusMinus);
            Assert.IsNotNull(teamStatisticSkater.Goals);
            Assert.IsNotNull(teamStatisticSkater.GamesPlayed);
            Assert.IsNotNull(teamStatisticSkater.Assists);
            Assert.IsNotNull(teamStatisticSkater.PlayerId);
            Assert.IsNotNull(teamStatisticSkater.Points);
            Assert.IsNotNull(teamStatisticSkater.Shots);
            Assert.IsNotNull(teamStatisticSkater.PenaltyMinutes);
        }

        Assert.IsNotNull(leagueStandingsSeasonInformation.Goalies);
        foreach (var goalie in leagueStandingsSeasonInformation.Goalies)
        {
            Assert.IsNotNull(goalie);
            Assert.IsNotNull(goalie.PlayerId);
            Assert.IsNotNull(goalie.GamesPlayed);
            Assert.IsNotNull(goalie.Wins);
            Assert.IsNotNull(goalie.Losses);
            Assert.IsNotNull(goalie.OvertimeLosses);
            Assert.IsNotNull(goalie.GoalsAgainstAverage);
            Assert.IsNotNull(goalie.SavePercentage);
            Assert.IsNotNull(goalie.Shutouts);
        }

        Assert.IsNotNull(leagueStandingsSeasonInformation.GameType);
    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(24, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(53, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(6, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(7, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(20, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(12, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(16, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(21, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(23, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(3, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(18, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(19, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(22, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(25, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(26, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(27, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(28, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(29, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(30, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(52, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(54, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(1, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(2, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(4, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(5, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(8, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(9, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(10, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(11, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(13, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(14, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(15, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(17, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(50, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(51, SeasonYear.season20232024, GameType.RegularSeason)]
    [DataRow(55, SeasonYear.season20232024, GameType.RegularSeason)]
    public async Task GetTeamStatisticsBySeasonAndGameTypeAsync_Return_Valid_Information(int teamId, string seasonYear, GameType gameType)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var leagueStandingsSeasonInformation = await nhlApi.GetTeamStatisticsBySeasonAndGameTypeAsync(teamId, seasonYear, gameType);

        // Assert
        Assert.IsNotNull(leagueStandingsSeasonInformation);
        Assert.IsNotNull(leagueStandingsSeasonInformation.Skaters);
        foreach (var teamStatisticSkater in leagueStandingsSeasonInformation.Skaters)
        {
            Assert.IsNotNull(teamStatisticSkater.PlusMinus);
            Assert.IsNotNull(teamStatisticSkater.Goals);
            Assert.IsNotNull(teamStatisticSkater.GamesPlayed);
            Assert.IsNotNull(teamStatisticSkater.Assists);
            Assert.IsNotNull(teamStatisticSkater.PlayerId);
            Assert.IsNotNull(teamStatisticSkater.Points);
            Assert.IsNotNull(teamStatisticSkater.Shots);
            Assert.IsNotNull(teamStatisticSkater.PenaltyMinutes);
        }

        Assert.IsNotNull(leagueStandingsSeasonInformation.Goalies);
        foreach (var goalie in leagueStandingsSeasonInformation.Goalies)
        {
            Assert.IsNotNull(goalie);
            Assert.IsNotNull(goalie.PlayerId);
            Assert.IsNotNull(goalie.GamesPlayed);
            Assert.IsNotNull(goalie.Wins);
            Assert.IsNotNull(goalie.Losses);
            Assert.IsNotNull(goalie.OvertimeLosses);
            Assert.IsNotNull(goalie.GoalsAgainstAverage);
            Assert.IsNotNull(goalie.SavePercentage);
            Assert.IsNotNull(goalie.Shutouts);
        }

        Assert.IsNotNull(leagueStandingsSeasonInformation.GameType);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(TeamEnum.AnaheimDucks)]
    [DataRow(TeamEnum.ArizonaCoyotes)]
    [DataRow(TeamEnum.BostonBruins)]
    [DataRow(TeamEnum.BuffaloSabres)]
    [DataRow(TeamEnum.CalgaryFlames)]
    [DataRow(TeamEnum.CarolinaHurricanes)]
    [DataRow(TeamEnum.ChicagoBlackhawks)]
    [DataRow(TeamEnum.ColoradoAvalanche)]
    [DataRow(TeamEnum.ColumbusBlueJackets)]
    [DataRow(TeamEnum.DallasStars)]
    [DataRow(TeamEnum.DetroitRedWings)]
    [DataRow(TeamEnum.EdmontonOilers)]
    [DataRow(TeamEnum.FloridaPanthers)]
    [DataRow(TeamEnum.LosAngelesKings)]
    [DataRow(TeamEnum.MinnesotaWild)]
    [DataRow(TeamEnum.MontrealCanadiens)]
    [DataRow(TeamEnum.NashvillePredators)]
    [DataRow(TeamEnum.NewJerseyDevils)]
    [DataRow(TeamEnum.NewYorkIslanders)]
    [DataRow(TeamEnum.NewYorkRangers)]
    [DataRow(TeamEnum.OttawaSenators)]
    [DataRow(TeamEnum.PhiladelphiaFlyers)]
    [DataRow(TeamEnum.PittsburghPenguins)]
    [DataRow(TeamEnum.SanJoseSharks)]
    [DataRow(TeamEnum.StLouisBlues)]
    [DataRow(TeamEnum.TampaBayLightning)]
    [DataRow(TeamEnum.TorontoMapleLeafs)]
    [DataRow(TeamEnum.VancouverCanucks)]
    [DataRow(TeamEnum.VegasGoldenKnights)]
    [DataRow(TeamEnum.WashingtonCapitals)]
    [DataRow(TeamEnum.WinnipegJets)]
    [DataRow(TeamEnum.SeattleKraken)]
    public async Task GetTeamStatisticsBySeasonAsync_Return_Valid_Information_With_Enum(TeamEnum team)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var teamStatisticsBySeason = await nhlApi.GetTeamStatisticsBySeasonAsync(team);

        // Assert
        Assert.IsNotNull(teamStatisticsBySeason);
    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(24)]
    [DataRow(53)]
    [DataRow(6)]
    [DataRow(7)]
    [DataRow(20)]
    [DataRow(12)]
    [DataRow(16)]
    [DataRow(21)]
    [DataRow(23)]
    [DataRow(3)]
    [DataRow(18)]
    [DataRow(19)]
    [DataRow(22)]
    [DataRow(25)]
    [DataRow(26)]
    [DataRow(28)]
    [DataRow(29)]
    [DataRow(30)]
    [DataRow(52)]
    [DataRow(54)]
    [DataRow(1)]
    [DataRow(2)]
    [DataRow(4)]
    [DataRow(5)]
    [DataRow(8)]
    [DataRow(9)]
    [DataRow(10)]
    [DataRow(13)]
    [DataRow(14)]
    [DataRow(15)]
    [DataRow(17)]
    [DataRow(55)]
    public async Task GetTeamStatisticsBySeasonAsync_Return_Valid_Information_With_Id(int teamId)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var teamStatisticsBySeason = await nhlApi.GetTeamStatisticsBySeasonAsync(teamId);

        // Assert
        Assert.IsNotNull(teamStatisticsBySeason);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2023-10-11")]
    [DataRow("2022-10-12")]
    [DataRow("2021-10-13")]
    [DataRow("2019-10-14")]
    [DataRow("2018-10-15")]
    [DataRow("2017-10-16")]
    public async Task GetLeagueWeekScheduleByDateTimeAsync_Return_Valid_Information_With_Date(string date)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetLeagueWeekScheduleByDateTimeAsync(DateOnly.Parse(date));

        // Assert
        Assert.IsNotNull(result);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2023-10-11")]
    [DataRow("2022-10-12")]
    [DataRow("2021-10-13")]
    [DataRow("2019-10-14")]
    [DataRow("2018-10-15")]
    [DataRow("2017-10-16")]
    public async Task GetLeagueScheduleCalendarAsyncReturn_Valid_Information_With_Date(string date)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetLeagueScheduleCalendarAsync(DateOnly.Parse(date));

        // Assert
        Assert.IsNotNull(result);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2023-10-11")]
    [DataRow("2022-10-12")]
    [DataRow("2021-10-13")]
    [DataRow("2019-10-14")]
    [DataRow("2018-10-15")]
    [DataRow("2017-10-16")]
    public async Task GetGameScoresByDateTimeAsync_Valid_Information_With_Date(string date)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var result = await nhlApi.GetLeagueScheduleCalendarAsync(DateOnly.Parse(date));

        // Assert
        Assert.IsNotNull(result);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetLeagueMetadataInformation_Returns_Valid_Information_Both_Players_Teams()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var players = new List<int> { 8478402 };
        var teams = new List<string> { "EDM" };
        var result = await nhlApi.GetLeagueMetadataInformation(players, teams);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(result.Players.Count, 1);
        Assert.AreEqual(result.Teams.Count, 1);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetLeagueMetadataInformation_Returns_Valid_Information_Just_Teams()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var teams = new List<string> { "EDM", "TOR" };
        var result = await nhlApi.GetLeagueMetadataInformation(null, teams);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(result.Teams.Count, 2);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetLeagueMetadataInformation_Returns_Valid_Information_Just_Teams_Enum()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var teams = new List<TeamEnum> { TeamEnum.TorontoMapleLeafs, TeamEnum.ChicagoBlackhawks };
        var result = await nhlApi.GetLeagueMetadataInformation(null, teams);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(result.Teams.Count, 2);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetLeagueMetadataInformation_Returns_Valid_Information_Just_Players()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var players = new List<PlayerEnum> { PlayerEnum.ConnorBedard8484144 };
        var result = await nhlApi.GetLeagueMetadataInformation(players, null);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(result.Players.Count, 1);
    }
}
