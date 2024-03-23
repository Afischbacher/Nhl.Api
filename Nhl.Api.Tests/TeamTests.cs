namespace Nhl.Api.Tests;
using Nhl.Api.Common.Helpers;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Team;
using Nhl.Api.Services;
using System.Linq;

[TestClass]
public class TeamTests
{

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestGetTeamColorsAsync()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamColor = await nhlApi.GetTeamColorsAsync(10);

        // Assert
        Assert.IsNotNull(teamColor);
        Assert.IsNotNull(teamColor.PrimaryColor);
        Assert.IsNotNull(teamColor.SecondaryColor);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestGetTeamColorsInvalidTeamIdAsync()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamColor = await nhlApi.GetTeamColorsAsync(99);

        // Assert
        Assert.IsNull(teamColor);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestGetTeamColorsEnumAsync()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamColor = await nhlApi.GetTeamColorsAsync(TeamEnum.ChicagoBlackhawks);

        // Assert
        Assert.IsNotNull(teamColor);
        Assert.IsNotNull(teamColor.PrimaryColor);
        Assert.IsNotNull(teamColor.SecondaryColor);
        Assert.IsNotNull(teamColor.TertiaryColor);
        Assert.IsNotNull(teamColor.QuinaryColor);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestGetAllTeamColorsEnumAsync()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teams = Enum.GetValues(typeof(TeamEnum)).Cast<TeamEnum>();
        foreach (var team in teams)
        {
            var teamColor = await nhlApi.GetTeamColorsAsync(team);
            // Assert
            Assert.IsNotNull(teamColor);
            Assert.IsNotNull(teamColor.PrimaryColor);
            Assert.IsNotNull(teamColor.SecondaryColor);
        }

    }

    [DataRow(TeamEnum.TorontoMapleLeafs)]
    [DataRow(TeamEnum.ArizonaCoyotes)]
    [DataRow(TeamEnum.DetroitRedWings)]
    [DataRow(TeamEnum.AnaheimDucks)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestGetTeamLogoLightAsync(TeamEnum teamEnum)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamLogo = await nhlApi.GetTeamLogoAsync(teamEnum, TeamLogoType.Light);

        // Assert
        Assert.IsNotNull(teamLogo);
        Assert.IsNotNull(teamLogo.Uri);
        Assert.IsNotNull(teamLogo.ImageAsByteArray);
        Assert.IsNotNull(teamLogo.ImageAsBase64String);

        Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 1000);
        Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 100);
    }


    [DataRow(TeamEnum.ColoradoAvalanche)]
    [DataRow(TeamEnum.SanJoseSharks)]
    [DataRow(TeamEnum.ColumbusBlueJackets)]
    [DataRow(TeamEnum.ChicagoBlackhawks)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestGetTeamLogoDarkAsync(TeamEnum teamEnum)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamLogo = await nhlApi.GetTeamLogoAsync(teamEnum, TeamLogoType.Dark);

        // Assert
        Assert.IsNotNull(teamLogo);
        Assert.IsNotNull(teamLogo.Uri);
        Assert.IsNotNull(teamLogo.ImageAsByteArray);
        Assert.IsNotNull(teamLogo.ImageAsBase64String);

        Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 1000);
        Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 100);
    }

    [DataRow(10)]
    [DataRow(55)]
    [DataRow(7)]
    [DataRow(24)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestGetTeamLogoLightAsIntAsync(int teamId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamLogo = await nhlApi.GetTeamLogoAsync(teamId, TeamLogoType.Light);

        // Assert
        Assert.IsNotNull(teamLogo);
        Assert.IsNotNull(teamLogo.Uri);
        Assert.IsNotNull(teamLogo.ImageAsByteArray);
        Assert.IsNotNull(teamLogo.ImageAsBase64String);

        Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 0);
        Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 0);
    }


    [DataRow(21)]
    [DataRow(28)]
    [DataRow(6)]
    [DataRow(5)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestGetTeamLogoDarkAsIntAsync(int teamId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamLogo = await nhlApi.GetTeamLogoAsync(teamId, TeamLogoType.Dark);

        // Assert
        Assert.IsNotNull(teamLogo);
        Assert.IsNotNull(teamLogo.Uri);
        Assert.IsNotNull(teamLogo.ImageAsByteArray);
        Assert.IsNotNull(teamLogo.ImageAsBase64String);

        Assert.IsTrue(teamLogo.ImageAsByteArray.Length > 0);
        Assert.IsTrue(teamLogo.ImageAsBase64String.Length > 0);
    }

    [DataRow(10)]
    [DataRow(55)]
    [DataRow(7)]
    [DataRow(24)]
    [DataRow(25)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetCurrentTeamScoreboardAsync_Get_Valid_Information_With_Id(int teamId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamScoreboard = await nhlApi.GetCurrentTeamScoreboardAsync(teamId);

        // Assert
        Assert.IsNotNull(teamScoreboard);

    }

    [DataRow(TeamEnum.BostonBruins)]
    [DataRow(TeamEnum.VegasGoldenKnights)]
    [DataRow(TeamEnum.TorontoMapleLeafs)]
    [DataRow(TeamEnum.SeattleKraken)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetCurrentTeamScoreboardAsync_Get_Valid_Information_With_Enum(TeamEnum team)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamScoreboard = await nhlApi.GetCurrentTeamScoreboardAsync(team);

        // Assert
        Assert.IsNotNull(teamScoreboard);

    }


    [DataRow(TeamEnum.BostonBruins, SeasonYear.season20132014)]
    [DataRow(TeamEnum.VegasGoldenKnights, SeasonYear.season20222023)]
    [DataRow(TeamEnum.TorontoMapleLeafs, SeasonYear.season19661967)]
    [DataRow(TeamEnum.SeattleKraken, SeasonYear.season20232024)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetCurrentTeamScoreboardAsync_Get_Valid_Information_With_Enum(TeamEnum team, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamRoster = await nhlApi.GetTeamRosterBySeasonYearAsync(team, seasonYear);

        // Assert
        Assert.IsNotNull(teamRoster);
        Assert.IsTrue(teamRoster.Forwards.Count > 0);
        Assert.IsTrue(teamRoster.Defensemen.Count > 0);
        Assert.IsTrue(teamRoster.Goalies.Count > 0);

    }

    [DataRow(6, SeasonYear.season20132014)]
    [DataRow(54, SeasonYear.season20222023)]
    [DataRow(10, SeasonYear.season19661967)]
    [DataRow(55, SeasonYear.season20232024)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetCurrentTeamScoreboardAsync_Get_Valid_Information_With_TeamId(int teamId, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamRoster = await nhlApi.GetTeamRosterBySeasonYearAsync(teamId, seasonYear);

        // Assert
        Assert.IsNotNull(teamRoster);
        Assert.IsTrue(teamRoster.Forwards.Count > 0);
        Assert.IsTrue(teamRoster.Defensemen.Count > 0);
        Assert.IsTrue(teamRoster.Goalies.Count > 0);

    }

    [DataRow(10)]
    [DataRow(55)]
    [DataRow(7)]
    [DataRow(24)]
    [DataRow(25)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetAllRosterSeasonsByTeamAsync_Get_Valid_Information_With_Id(int teamId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var rosterSeasons = await nhlApi.GetAllRosterSeasonsByTeamAsync(teamId);

        // Assert
        Assert.IsNotNull(rosterSeasons);
        Assert.IsTrue(rosterSeasons.Count > 0);
    }


    [DataRow(TeamEnum.BostonBruins)]
    [DataRow(TeamEnum.VegasGoldenKnights)]
    [DataRow(TeamEnum.TorontoMapleLeafs)]
    [DataRow(TeamEnum.PittsburghPenguins)]
    [DataRow(TeamEnum.SeattleKraken)]
    [DataRow(TeamEnum.AnaheimDucks)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetAllRosterSeasonsByTeamAsync_Get_Valid_Information_With_Enum(TeamEnum team)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var rosterSeasons = await nhlApi.GetAllRosterSeasonsByTeamAsync(team);

        // Assert
        Assert.IsNotNull(rosterSeasons);
        Assert.IsTrue(rosterSeasons.Count > 0);
    }


    [DataRow(10)]
    [DataRow(55)]
    [DataRow(7)]
    [DataRow(24)]
    [DataRow(25)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTeamProspectsByTeamAsync_Get_Valid_Information_With_Id(int teamId)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamProspects = await nhlApi.GetTeamProspectsByTeamAsync(teamId);

        // Assert
        Assert.IsNotNull(teamProspects);
        Assert.IsNotNull(teamProspects.Goalies);
        Assert.IsNotNull(teamProspects.Defensemen);
        Assert.IsNotNull(teamProspects.Forwards);
    }


    [DataRow(TeamEnum.BostonBruins)]
    [DataRow(TeamEnum.VegasGoldenKnights)]
    [DataRow(TeamEnum.TorontoMapleLeafs)]
    [DataRow(TeamEnum.PittsburghPenguins)]
    [DataRow(TeamEnum.SeattleKraken)]
    [DataRow(TeamEnum.AnaheimDucks)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTeamProspectsByTeamAsync_Get_Valid_Information_With_Enum(TeamEnum team)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamProspects = await nhlApi.GetTeamProspectsByTeamAsync(team);

        // Assert
        Assert.IsNotNull(teamProspects);
        Assert.IsNotNull(teamProspects.Goalies);
        Assert.IsNotNull(teamProspects.Defensemen);
        Assert.IsNotNull(teamProspects.Forwards);
    }

    [DataRow(6, SeasonYear.season20132014)]
    [DataRow(54, SeasonYear.season20222023)]
    [DataRow(10, SeasonYear.season19661967)]
    [DataRow(55, SeasonYear.season20232024)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTeamSeasonScheduleBySeasonYearAsync_Get_Valid_Information_With_TeamId(int teamId, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamRoster = await nhlApi.GetTeamSeasonScheduleBySeasonYearAsync(teamId, seasonYear);

        // Assert
        Assert.IsNotNull(teamRoster);
        Assert.IsNotNull(teamRoster.Games);
        Assert.IsTrue(teamRoster.Games.Count > 0);


    }

    [DataRow(TeamEnum.BostonBruins, SeasonYear.season20132014)]
    [DataRow(TeamEnum.VegasGoldenKnights, SeasonYear.season20222023)]
    [DataRow(TeamEnum.TorontoMapleLeafs, SeasonYear.season19661967)]
    [DataRow(TeamEnum.SeattleKraken, SeasonYear.season20232024)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTeamSeasonScheduleBySeasonYearAsync_Get_Valid_Information_With_Enum(TeamEnum team, string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamRoster = await nhlApi.GetTeamSeasonScheduleBySeasonYearAsync(team, seasonYear);

        // Assert
        Assert.IsNotNull(teamRoster);
        Assert.IsNotNull(teamRoster.Games);
        Assert.IsTrue(teamRoster.Games.Count > 0);
    }

    [DataRow(10, 10, 2023)]
    [DataRow(55, 10, 2023)]
    [DataRow(7, 10, 2023)]
    [DataRow(24, 10, 2023)]
    [DataRow(25, 10, 2023)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTeamSeasonScheduleByYearAndMonthAsync_Get_Valid_Information_With_Id(int teamId, int month, int seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamRoster = await nhlApi.GetTeamSeasonScheduleByYearAndMonthAsync(teamId, month, seasonYear);

        // Assert
        Assert.IsNotNull(teamRoster);
        Assert.IsNotNull(teamRoster.Games);
        Assert.IsTrue(teamRoster.Games.Count > 0);
    }

    [DataRow(TeamEnum.TorontoMapleLeafs, 10, 2023)]
    [DataRow(TeamEnum.VegasGoldenKnights, 10, 2023)]
    [DataRow(TeamEnum.BostonBruins, 10, 2023)]
    [DataRow(TeamEnum.SeattleKraken, 10, 2023)]
    [DataRow(TeamEnum.AnaheimDucks, 10, 2023)]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTeamSeasonScheduleByYearAndMonthAsync_Get_Valid_Information_With_Enum(TeamEnum teamEnum, int month, int seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamRoster = await nhlApi.GetTeamSeasonScheduleByYearAndMonthAsync(teamEnum, month, seasonYear);

        // Assert
        Assert.IsNotNull(teamRoster);
        Assert.IsNotNull(teamRoster.Games);
        Assert.IsTrue(teamRoster.Games.Count > 0);
    }

    [DataRow(10, "2003-10-11")]
    [DataRow(55, "2023-10-11")]
    [DataRow(7, "2016-10-11")]
    [DataRow(24, "2019-10-11")]
    [DataRow(25, "2022-10-11")]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTeamSeasonScheduleByDateTimeAsync_Get_Valid_Information_With_Id(int teamId, string date)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamRoster = await nhlApi.GetTeamWeekScheduleByDateAsync(teamId, DateOnly.Parse(date));

        // Assert
        Assert.IsNotNull(teamRoster);
        Assert.IsNotNull(teamRoster.Games);
        Assert.IsTrue(teamRoster.Games.Count > 0);
    }


    [DataRow(10, "2023-10-11")]
    [DataRow(55, "2023-10-11")]
    [DataRow(7, "2023-10-11")]
    [DataRow(24, "2015-01-20")]
    [DataRow(25, "2023-10-11")]
    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetTeamSeasonScheduleByDateTimeAsync_Get_Valid_Information_With_Team(TeamEnum team, string date)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var teamRoster = await nhlApi.GetTeamWeekScheduleByDateAsync(team, DateOnly.Parse(date));

        // Assert
        Assert.IsNotNull(teamRoster);
        Assert.IsNotNull(teamRoster.Games);
        Assert.IsTrue(teamRoster.Games.Count > 0);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public void TeamNames_Ensure_Each_Name_Is_Correct()
    {
        Assert.AreEqual(TeamNames.TampaBayLightning, "Tampa Bay Lightning");
        Assert.AreEqual(TeamNames.BostonBruins, "Boston Bruins");
        Assert.AreEqual(TeamNames.NewYorkIslanders, "New York Islanders");
        Assert.AreEqual(TeamNames.NewYorkRangers, "New York Rangers");
        Assert.AreEqual(TeamNames.PhiladelphiaFlyers, "Philadelphia Flyers");
        Assert.AreEqual(TeamNames.PittsburghPenguins, "Pittsburgh Penguins");
        Assert.AreEqual(TeamNames.WashingtonCapitals, "Washington Capitals");
        Assert.AreEqual(TeamNames.CarolinaHurricanes, "Carolina Hurricanes");
        Assert.AreEqual(TeamNames.ColumbusBlueJackets, "Columbus Blue Jackets");
        Assert.AreEqual(TeamNames.DetroitRedWings, "Detroit Red Wings");
        Assert.AreEqual(TeamNames.ChicagoBlackhawks, "Chicago Blackhawks");
        Assert.AreEqual(TeamNames.NashvillePredators, "Nashville Predators");
        Assert.AreEqual(TeamNames.StLouisBlues, "St. Louis Blues");
        Assert.AreEqual(TeamNames.CalgaryFlames, "Calgary Flames");
        Assert.AreEqual(TeamNames.ColoradoAvalanche, "Colorado Avalanche");
        Assert.AreEqual(TeamNames.EdmontonOilers, "Edmonton Oilers");
        Assert.AreEqual(TeamNames.VancouverCanucks, "Vancouver Canucks");
        Assert.AreEqual(TeamNames.VegasGoldenKnights, "Vegas Golden Knights");
        Assert.AreEqual(TeamNames.AnaheimDucks, "Anaheim Ducks");
        Assert.AreEqual(TeamNames.DallasStars, "Dallas Stars");
        Assert.AreEqual(TeamNames.LosAngelesKings, "Los Angeles Kings");
        Assert.AreEqual(TeamNames.SanJoseSharks, "San Jose Sharks");
        Assert.AreEqual(TeamNames.ArizonaCoyotes, "Arizona Coyotes");
        Assert.AreEqual(TeamNames.MinnesotaWild, "Minnesota Wild");
        Assert.AreEqual(TeamNames.WinnipegJets, "Winnipeg Jets");
        Assert.AreEqual(TeamNames.BuffaloSabres, "Buffalo Sabres");
        Assert.AreEqual(TeamNames.FloridaPanthers, "Florida Panthers");
        Assert.AreEqual(TeamNames.MontrealCanadiens, "Montreal Canadiens");
        Assert.AreEqual(TeamNames.OttawaSenators, "Ottawa Senators");
        Assert.AreEqual(TeamNames.TorontoMapleLeafs, "Toronto Maple Leafs");
        Assert.AreEqual(TeamNames.SeattleKraken, "Seattle Kraken");
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("Tampa Bay Lightning")]
    [DataRow("Boston Bruins")]
    [DataRow("New York Islanders")]
    [DataRow("New York Rangers")]
    [DataRow("Philadelphia Flyers")]
    [DataRow("Pittsburgh Penguins")]
    [DataRow("Washington Capitals")]
    [DataRow("Carolina Hurricanes")]
    [DataRow("Columbus Blue Jackets")]
    [DataRow("Detroit Red Wings")]
    [DataRow("Chicago Blackhawks")]
    [DataRow("Nashville Predators")]
    [DataRow("St. Louis Blues")]
    [DataRow("Calgary Flames")]
    [DataRow("Colorado Avalanche")]
    [DataRow("Edmonton Oilers")]
    [DataRow("Vancouver Canucks")]
    [DataRow("Vegas Golden Knights")]
    [DataRow("Anaheim Ducks")]
    [DataRow("Dallas Stars")]
    [DataRow("Los Angeles Kings")]
    [DataRow("San Jose Sharks")]
    [DataRow("Arizona Coyotes")]
    [DataRow("Minnesota Wild")]
    [DataRow("Winnipeg Jets")]
    [DataRow("Buffalo Sabres")]
    [DataRow("Florida Panthers")]
    [DataRow("Montreal Canadiens")]
    [DataRow("Ottawa Senators")]
    [DataRow("Toronto Maple Leafs")]
    [DataRow("Seattle Kraken")]
    public void TeamNames_Ensure_Each_TeamAbbreviation_Is_Correct(string teamName)
    {
        var nhlTeamService = new NhlTeamService();
        var teamAbbreviation = nhlTeamService.GetTeamCodeIdentifierByTeamName(teamName);

        Assert.IsNotNull(teamAbbreviation);
        Assert.AreEqual(teamAbbreviation.Length, 3);
    }
}
