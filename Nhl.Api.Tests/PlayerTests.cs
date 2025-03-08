using System.Linq;
using System.Net.Http;
using Nhl.Api.Enumerations.Game;
using Nhl.Api.Models.Season;

namespace Nhl.Api.Tests;
[TestClass]
public class PlayerTests
{
    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("Wayne Gretzky", 99)]
    [DataRow("Alex Ovechkin", 8)]
    [DataRow("Connor McDavid", 97)]
    public async Task SearchAllPlayersAsync_Returns_Valid_Results(string query, int numberOfPlayer)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act 
        var results = await nhlApi.SearchAllPlayersAsync(query);

        // Assert
        Assert.IsNotNull(results);
        CollectionAssert.AllItemsAreNotNull(results);

        var playerSearchResult = results.First(r => r.PlayerNumber == numberOfPlayer);

        switch (query)
        {
            case "Wayne Gretzky":
                Assert.AreEqual("Brantford", playerSearchResult.BirthCity);
                Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                Assert.AreEqual("ON", playerSearchResult.BirthProvinceState);
                Assert.AreEqual("Wayne", playerSearchResult.FirstName);
                Assert.AreEqual("Gretzky", playerSearchResult.LastName);
                Assert.AreEqual("NYR", playerSearchResult.LastTeamAbbreviation);
                Assert.AreEqual("6\u00270\"", playerSearchResult.Height);
                Assert.AreEqual(false, playerSearchResult.IsActive);
                Assert.AreEqual(99, playerSearchResult.PlayerNumber);
                break;

            case "Alex Ovechkin":
                Assert.AreEqual("Moscow", playerSearchResult.BirthCity);
                Assert.AreEqual("RUS", playerSearchResult.BirthCountry);
                Assert.AreEqual("Russian Federation", playerSearchResult.FullBirthCountry);
                Assert.AreEqual(null, playerSearchResult.BirthProvinceState);
                Assert.AreEqual("Alex", playerSearchResult.FirstName);
                Assert.AreEqual("Ovechkin", playerSearchResult.LastName);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual("WSH", playerSearchResult.LastTeamAbbreviation);
                Assert.AreEqual("6\u00273\"", playerSearchResult.Height);
                Assert.AreEqual(8, playerSearchResult.PlayerNumber);
                break;

            case "Connor McDavid":
                Assert.AreEqual("Richmond Hill", playerSearchResult.BirthCity);
                Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                Assert.AreEqual("ON", playerSearchResult.BirthProvinceState);
                Assert.AreEqual("Connor", playerSearchResult.FirstName);
                Assert.AreEqual("McDavid", playerSearchResult.LastName);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual("EDM", playerSearchResult.LastTeamAbbreviation);
                Assert.AreEqual("6\u00271\"", playerSearchResult.Height);
                Assert.AreEqual(97, playerSearchResult.PlayerNumber);
                break;

            default:
                break;
        }

    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("Joseph Woll")]
    [DataRow("David Pastrnak")]
    [DataRow("Connor McDavid")]
    [DataRow("Frederik Andersen")]
    public async Task SearchAllActivePlayersAsync_Returns_Valid_Information(string query)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act 
        var results = await nhlApi.SearchAllActivePlayersAsync(query);

        // Assert
        Assert.IsNotNull(results);
        CollectionAssert.AllItemsAreNotNull(results);

        var playerSearchResult = results.First();

        switch (query)
        {
            case "David Pastrnak":
                Assert.AreEqual("Havirov", playerSearchResult.BirthCity);
                Assert.AreEqual("CZE", playerSearchResult.BirthCountry);
                Assert.AreEqual("Czech Republic", playerSearchResult.FullBirthCountry);
                Assert.AreEqual(null, playerSearchResult.BirthProvinceState);
                Assert.AreEqual("David", playerSearchResult.FirstName);
                Assert.AreEqual("Pastrnak", playerSearchResult.LastName);
                Assert.AreEqual("BOS", playerSearchResult.TeamAbbreviation);
                Assert.AreEqual("6\u00270\"", playerSearchResult.Height);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual(88, playerSearchResult.PlayerNumber);
                break;

            case "Joesph Woll":
                Assert.AreEqual("Dardenne Prairie", playerSearchResult.BirthCity);
                Assert.AreEqual("USA", playerSearchResult.BirthCountry);
                Assert.AreEqual("United States of America", playerSearchResult.FullBirthCountry);
                Assert.AreEqual("Missouri", playerSearchResult.BirthProvinceState);
                Assert.AreEqual("Joseph", playerSearchResult.FirstName);
                Assert.AreEqual("Woll", playerSearchResult.LastName);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual("TOR", playerSearchResult.TeamAbbreviation);
                Assert.AreEqual("6\u00273\"", playerSearchResult.Height);
                Assert.AreEqual(60, playerSearchResult.PlayerNumber);
                break;

            case "Connor McDavid":
                Assert.AreEqual("Richmond Hill", playerSearchResult.BirthCity);
                Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                Assert.AreEqual("ON", playerSearchResult.BirthProvinceState);
                Assert.AreEqual("Connor", playerSearchResult.FirstName);
                Assert.AreEqual("McDavid", playerSearchResult.LastName);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual("EDM", playerSearchResult.TeamAbbreviation);
                Assert.AreEqual("6\u00271\"", playerSearchResult.Height);
                Assert.AreEqual(97, playerSearchResult.PlayerNumber);
                break;

            case "Frederik Andersen":
                Assert.AreEqual("Herning", playerSearchResult.BirthCity);
                Assert.AreEqual("DNK", playerSearchResult.BirthCountry);
                Assert.AreEqual("Denmark", playerSearchResult.FullBirthCountry);
                Assert.AreEqual(null, playerSearchResult.BirthProvinceState);
                Assert.AreEqual("Frederik", playerSearchResult.FirstName);
                Assert.AreEqual("Andersen", playerSearchResult.LastName);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual("CAR", playerSearchResult.TeamAbbreviation);
                Assert.AreEqual("6\u00274\"", playerSearchResult.Height);
                Assert.AreEqual(31, playerSearchResult.PlayerNumber);
                break;
        }

    }

    [TestMethod]
    public async Task GetPlayerHeadshotImageAsync_PlayerEnum_InvalidSeasonYear_ThrowsArgumentException()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act & Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetPlayerHeadshotImageAsync(PlayerEnum.ConnorMcDavid8478402, "invalidYear"));
    }

    [TestMethod]
    public async Task GetPlayerHeadshotImageAsync_PlayerEnum_InvalidSeasonYear_ThrowsArgumentException_PlayerId()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act & Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetPlayerHeadshotImageAsync(8478402, "invalidYear"));
    }

    [TestMethod]
    public async Task GetPlayerHeadshotImageAsync_PlayerEnum_InvalidSeasonYear_layerId_Incorrect_Season_Year()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var headshot = await nhlApi.GetPlayerHeadshotImageAsync(8478402, SeasonYear.season19971998);

        // Assert
        Assert.IsNotNull(headshot);
        Assert.AreEqual(headshot.Length, 0);
    }

    [TestMethod]
    public async Task GetPlayerHeadshotImageAsync_PlayerEnum_InvalidSeasonYear_PlayerEnum_Incorrect_Season_Year()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var headshot = await nhlApi.GetPlayerHeadshotImageAsync(PlayerEnum.ConnorMcDavid8478402, SeasonYear.season19971998);

        // Assert
        Assert.IsNotNull(headshot);
        Assert.AreEqual(headshot.Length, 0);
    }

    [TestMethod]
    public async Task GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync_ThrowsArgumentException_ForNullSeasonYear()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var playerId = 8478402;
        var gameType = GameType.PreSeason;

        // Act & Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerId, null, gameType));
    }

    [TestMethod]
    public async Task GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync_ThrowsArgumentException_ForEmptySeasonYear()
    {
        // Arrange
        await using var nhlApi = new NhlApi();
        var playerId = 8478402;
        var gameType = GameType.RegularSeason;
        var emptySeasonYear = "";

        // Act & Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerId, emptySeasonYear, gameType));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.ConnorMcDavid8478402, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(PlayerEnum.SidneyCrosby8471675, SeasonYear.season20182019, GameType.RegularSeason)]
    [DataRow(PlayerEnum.AustonMatthews8479318, SeasonYear.season20182019, GameType.Playoffs)]
    public async Task GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync_Test_Player_Enum(PlayerEnum playerEnum, string seasonYear, GameType gameType)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var playerSeasonGameLog = await nhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerEnum, seasonYear, gameType);

        // Assert
        Assert.IsNotNull(playerSeasonGameLog);
        Assert.IsNotNull(playerSeasonGameLog.PlayerGameLogs);
        Assert.IsTrue(playerSeasonGameLog.PlayerGameLogs.Count > 0);

        foreach (var stat in playerSeasonGameLog.PlayerStatsSeasons)
        {
            Assert.IsNotNull(stat.Season);
            Assert.IsNotNull(stat.GameTypes);
        }

        foreach (var player in playerSeasonGameLog.PlayerGameLogs)
        {
            Assert.IsNotNull(player.Assists);
            Assert.IsNotNull(player.Goals);
            Assert.IsNotNull(player.Points);
            Assert.IsNotNull(player.HomeRoadFlag);
            Assert.IsNotNull(player.GameDate);
            Assert.IsNotNull(player.GameId);
            Assert.IsNotNull(player.OtGoals);
            Assert.IsNotNull(player.CommonName);
            Assert.IsNotNull(player.Shots);
            Assert.IsNotNull(player.Pim);
            Assert.IsNotNull(player.TeamAbbrev);
            Assert.IsNotNull(player.Toi);
            Assert.IsNotNull(player.OpponentAbbrev);
            Assert.IsNotNull(player.OpponentCommonName);
            Assert.IsNotNull(player.ShorthandedGoals);
            Assert.IsNotNull(player.GameWinningGoals);
            Assert.IsNotNull(player.PowerPlayGoals);
            Assert.IsNotNull(player.PlusMinus);
        }

    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerId()
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var playerSeasonGameLog = await nhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(8478402, SeasonYear.season20222023, GameType.RegularSeason);

        // Assert
        Assert.IsNotNull(playerSeasonGameLog);
        Assert.AreEqual(82, playerSeasonGameLog.PlayerGameLogs.Count);

    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(" ")]
    [DataRow("202520262027")]
    public async Task GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync_Test_InvalidSeasonYear(string seasonYear)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act / Assert
        await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(8478402, seasonYear, GameType.RegularSeason));
    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.MarcAndreFleury8470594, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(PlayerEnum.JuuseSaros8477424, SeasonYear.season20182019, GameType.RegularSeason)]
    [DataRow(PlayerEnum.JosephWoll8479361, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(PlayerEnum.AndreiVasilevskiy8476883, SeasonYear.season20212022, GameType.Playoffs)]

    public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerEnum(PlayerEnum playerEnum, string seasonYear, GameType gameType)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var goalieSeasonGameLog = await nhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerEnum, seasonYear, gameType);

        // Assert
        Assert.IsNotNull(goalieSeasonGameLog);
        // Assert
        Assert.IsNotNull(goalieSeasonGameLog);
        Assert.IsNotNull(goalieSeasonGameLog.GoalieGameLogs);
        Assert.IsTrue(goalieSeasonGameLog.GoalieGameLogs.Count > 0);

        foreach (var stat in goalieSeasonGameLog.GoalieStatsSeasons)
        {
            Assert.IsNotNull(stat.Season);
            Assert.IsNotNull(stat.GameTypes);
        }

        foreach (var goalieGameLog in goalieSeasonGameLog.GoalieGameLogs)
        {
            Assert.IsNotNull(goalieGameLog.Assists);
            Assert.IsNotNull(goalieGameLog.Goals);
            Assert.IsNotNull(goalieGameLog.Shutouts);
            Assert.IsNotNull(goalieGameLog.SavePctg);
            Assert.IsNotNull(goalieGameLog.ShotsAgainst);
            Assert.IsNotNull(goalieGameLog.Pim);
            Assert.IsNotNull(goalieGameLog.HomeRoadFlag);
            Assert.IsNotNull(goalieGameLog.GameDate);
            Assert.IsNotNull(goalieGameLog.GameId);
            Assert.IsNotNull(goalieGameLog.CommonName);
            Assert.IsNotNull(goalieGameLog.Pim);
            Assert.IsNotNull(goalieGameLog.TeamAbbrev);
            Assert.IsNotNull(goalieGameLog.Toi);
            Assert.IsNotNull(goalieGameLog.OpponentAbbrev);
            Assert.IsNotNull(goalieGameLog.OpponentCommonName);
        }

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.MarcAndreFleury8470594, GameType.RegularSeason)]
    [DataRow(PlayerEnum.JuuseSaros8477424, GameType.RegularSeason)]
    [DataRow(PlayerEnum.JosephWoll8479361, GameType.RegularSeason)]
    [DataRow(PlayerEnum.AndreiVasilevskiy8476883, GameType.Playoffs)]
    public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerEnum_Fails_Season_Year_Invalid_Format(PlayerEnum playerEnum, GameType gameType)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act / Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerEnum, "999999", gameType));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.MarcAndreFleury8470594, GameType.RegularSeason)]
    [DataRow(PlayerEnum.JuuseSaros8477424, GameType.RegularSeason)]
    [DataRow(PlayerEnum.JosephWoll8479361, GameType.RegularSeason)]
    [DataRow(PlayerEnum.AndreiVasilevskiy8476883, GameType.Playoffs)]
    public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerEnum_Fails_Season_Year_Empty(PlayerEnum playerEnum, GameType gameType)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act / Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerEnum, string.Empty, gameType));
    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8470594, GameType.RegularSeason)]
    [DataRow(8477424, GameType.RegularSeason)]
    [DataRow(8479361, GameType.RegularSeason)]
    [DataRow(8476883, GameType.Playoffs)]

    public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerId_Fails_Season_Year_Invalid_Format(int playerId, GameType gameType)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act / Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId, "999999", gameType));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8470594, GameType.RegularSeason)]
    [DataRow(8477424, GameType.RegularSeason)]
    [DataRow(8479361, GameType.RegularSeason)]
    [DataRow(8476883, GameType.Playoffs)]

    public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerId_Fails_Season_Year_Empty(int playerId, GameType gameType)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act / Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId, string.Empty, gameType));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieInformationAsync_Should_Return_Correct_Statistics()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var goalieInformation = await nhlApi.GetGoalieInformationAsync(PlayerEnum.MarcAndreFleury8470594);

        // Assert
        Assert.IsNotNull(goalieInformation);
        Assert.AreEqual("Marc-Andre", goalieInformation.FirstName.Default);
        Assert.AreEqual("Fleury", goalieInformation.LastName.Default);
        Assert.AreEqual("MIN", goalieInformation.CurrentTeamAbbrev);
        Assert.AreEqual("Minnesota Wild", goalieInformation.FullTeamName.Default);
        Assert.AreEqual("Sorel", goalieInformation.BirthCity.Default);
        Assert.AreEqual("CAN", goalieInformation.BirthCountry);
        Assert.AreEqual("Quebec", goalieInformation.BirthStateProvince.Default);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetGoalieInformationAsync_Should_Throw_Argument_Exception_For_Incorrect_Player_Type()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act / Assert
        _ = Assert.ThrowsExceptionAsync<HttpRequestException>(async () => await nhlApi.GetGoalieInformationAsync(PlayerEnum.SidneyCrosby8471675));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8470594, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(8477424, SeasonYear.season20182019, GameType.RegularSeason)]
    [DataRow(8479361, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(8476883, SeasonYear.season20212022, GameType.Playoffs)]

    public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerId(int playerId, string seasonYear, GameType gameType)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var goalieSeasonGameLog = await nhlApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId, seasonYear, gameType);

        // Assert
        Assert.IsNotNull(goalieSeasonGameLog);
        // Assert
        Assert.IsNotNull(goalieSeasonGameLog);
        Assert.IsNotNull(goalieSeasonGameLog.GoalieGameLogs);
        Assert.IsTrue(goalieSeasonGameLog.GoalieGameLogs.Count > 0);

        foreach (var stat in goalieSeasonGameLog.GoalieStatsSeasons)
        {
            Assert.IsNotNull(stat.Season);
            Assert.IsNotNull(stat.GameTypes);
        }

        foreach (var goalieGameLog in goalieSeasonGameLog.GoalieGameLogs)
        {
            Assert.IsNotNull(goalieGameLog.Assists);
            Assert.IsNotNull(goalieGameLog.Goals);
            Assert.IsNotNull(goalieGameLog.Shutouts);
            Assert.IsNotNull(goalieGameLog.SavePctg);
            Assert.IsNotNull(goalieGameLog.ShotsAgainst);
            Assert.IsNotNull(goalieGameLog.Pim);
            Assert.IsNotNull(goalieGameLog.HomeRoadFlag);
            Assert.IsNotNull(goalieGameLog.GameDate);
            Assert.IsNotNull(goalieGameLog.GameId);
            Assert.IsNotNull(goalieGameLog.CommonName);
            Assert.IsNotNull(goalieGameLog.Pim);
            Assert.IsNotNull(goalieGameLog.TeamAbbrev);
            Assert.IsNotNull(goalieGameLog.Toi);
            Assert.IsNotNull(goalieGameLog.OpponentAbbrev);
            Assert.IsNotNull(goalieGameLog.OpponentCommonName);
        }

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8471679)]
    [DataRow(8479361)]
    [DataRow(8476434)]
    public async Task GetGoalieInformationAsync_Test_PlayerId_Returns_Valid_Information(int playerId)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var goalieProfile = await nhlApi.GetGoalieInformationAsync(playerId);

        // Assert
        Assert.IsNotNull(goalieProfile);
        Assert.IsNotNull(goalieProfile.FirstName.Default);
        Assert.IsNotNull(goalieProfile.LastName.Default);
        Assert.IsNotNull(goalieProfile.TeamLogo);
        Assert.IsNotNull(goalieProfile.FullTeamName.Default);
        Assert.IsNotNull(goalieProfile.BirthCity.Default);
        Assert.IsNotNull(goalieProfile.BirthCountry);
        Assert.IsNotNull(goalieProfile.BirthStateProvince.Default);
        Assert.IsNotNull(goalieProfile.HeightInFeetAndInches);
        Assert.IsNotNull(goalieProfile.HeightInInches);
        Assert.IsNotNull(goalieProfile.Headshot);
        Assert.IsNotNull(goalieProfile.WeightInPounds);
        Assert.IsNotNull(goalieProfile.WeightInKilograms);
        Assert.IsNotNull(goalieProfile.BirthDate);
        Assert.IsNotNull(goalieProfile.Age);
        Assert.IsNotNull(goalieProfile.IsActive);
        Assert.IsNotNull(goalieProfile.InHHOF);
        Assert.IsNotNull(goalieProfile.InTop100AllTime);
        Assert.IsNotNull(goalieProfile.HeightInCentimeters);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.TonyMeagher8457344)]
    public async Task GetPlayerInformationAsync_Test_PlayerEnum_Returns_Valid_Information_Null_Age(PlayerEnum playerEnum)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var playerProfile = await nhlApi.GetPlayerInformationAsync(playerEnum);

        // Assert
        Assert.IsNotNull(playerProfile);
        Assert.IsNull(playerProfile.Age);
    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.FilipGustavsson8479406)]
    [DataRow(PlayerEnum.JosephWoll8479361)]
    [DataRow(PlayerEnum.JohnGibson8476434)]
    [DataRow(PlayerEnum.AndreiVasilevskiy8476883)]
    [DataRow(PlayerEnum.MarcAndreFleury8470594)]
    [DataRow(PlayerEnum.SergeiBobrovsky8475683)]
    [DataRow(PlayerEnum.JuuseSaros8477424)]
    public async Task GetGoalieInformationAsync_Test_PlayerEnum_Returns_Valid_Information(PlayerEnum playerEnum)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var goalieProfile = await nhlApi.GetGoalieInformationAsync(playerEnum);

        // Assert
        Assert.IsNotNull(goalieProfile);
        Assert.IsNotNull(goalieProfile.FirstName.Default);
        Assert.IsNotNull(goalieProfile.LastName.Default);
        Assert.IsNotNull(goalieProfile.TeamLogo);
        Assert.IsNotNull(goalieProfile.FullTeamName.Default);
        Assert.IsNotNull(goalieProfile.BirthCity.Default);
        Assert.IsNotNull(goalieProfile.BirthCountry);
        Assert.IsNotNull(goalieProfile.HeightInFeetAndInches);
        Assert.IsNotNull(goalieProfile.HeightInInches);
        Assert.IsNotNull(goalieProfile.Headshot);
        Assert.IsNotNull(goalieProfile.WeightInPounds);
        Assert.IsNotNull(goalieProfile.WeightInKilograms);
        Assert.IsNotNull(goalieProfile.BirthDate);
        Assert.IsNotNull(goalieProfile.Age);
        Assert.IsNotNull(goalieProfile.IsActive);
        Assert.IsNotNull(goalieProfile.InHHOF);
        Assert.IsNotNull(goalieProfile.InTop100AllTime);
        Assert.IsNotNull(goalieProfile.HeightInCentimeters);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8479406)]
    [DataRow(8479361)]
    [DataRow(8476434)]
    [DataRow(8476883)]
    [DataRow(8470594)]
    [DataRow(8475683)]
    [DataRow(8477424)]
    public async Task GetGoalieInformationAsync_Test_PlayerId(int playerId)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var goalieProfile = await nhlApi.GetGoalieInformationAsync(playerId);

        // Assert
        Assert.IsNotNull(goalieProfile);
        Assert.IsNotNull(goalieProfile.FirstName.Default);
        Assert.IsNotNull(goalieProfile.LastName.Default);
        Assert.IsNotNull(goalieProfile.TeamLogo);
        Assert.IsNotNull(goalieProfile.FullTeamName.Default);
        Assert.IsNotNull(goalieProfile.BirthCity.Default);
        Assert.IsNotNull(goalieProfile.BirthCountry);
        Assert.IsNotNull(goalieProfile.HeightInFeetAndInches);
        Assert.IsNotNull(goalieProfile.HeightInInches);
        Assert.IsNotNull(goalieProfile.Headshot);
        Assert.IsNotNull(goalieProfile.WeightInPounds);
        Assert.IsNotNull(goalieProfile.WeightInKilograms);
        Assert.IsNotNull(goalieProfile.BirthDate);
        Assert.IsNotNull(goalieProfile.Age);
        Assert.IsNotNull(goalieProfile.IsActive);
        Assert.IsNotNull(goalieProfile.InHHOF);
        Assert.IsNotNull(goalieProfile.InTop100AllTime);
        Assert.IsNotNull(goalieProfile.HeightInCentimeters);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8478402)]
    public async Task GetGoalieInformationAsync_Test_ThrowsArgumentExceptionWithPlayerId(int playerId)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act / Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetGoalieInformationAsync(playerId));
    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.ConnorMcDavid8478402)]
    [DataRow(PlayerEnum.SidneyCrosby8471675)]
    [DataRow(PlayerEnum.AustonMatthews8479318)]
    [DataRow(PlayerEnum.AlexOvechkin8471214)]
    public async Task GetPlayerInformationAsync_Test_PlayerEnum(PlayerEnum playerEnum)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var playerProfile = await nhlApi.GetPlayerInformationAsync(playerEnum);

        // Assert
        Assert.IsNotNull(playerProfile);
        Assert.IsNotNull(playerProfile.FirstName.Default);
        Assert.IsNotNull(playerProfile.LastName.Default);
        Assert.IsNotNull(playerProfile.TeamLogo);
        Assert.IsNotNull(playerProfile.FullTeamName.Default);
        Assert.IsNotNull(playerProfile.BirthCity.Default);
        Assert.IsNotNull(playerProfile.BirthCountry);
        Assert.IsNotNull(playerProfile.HeightInFeetAndInches);
        Assert.IsNotNull(playerProfile.HeightInInches);
        Assert.IsNotNull(playerProfile.Headshot);
        Assert.IsNotNull(playerProfile.WeightInPounds);
        Assert.IsNotNull(playerProfile.WeightInKilograms);
        Assert.IsNotNull(playerProfile.BirthDate);
        Assert.IsNotNull(playerProfile.Age);
        Assert.IsNotNull(playerProfile.IsActive);
        Assert.IsNotNull(playerProfile.InHHOF);
        Assert.IsNotNull(playerProfile.InTop100AllTime);
        Assert.IsNotNull(playerProfile.HeightInCentimeters);

        Assert.IsNotNull(playerProfile.DraftDetails.Round);
        Assert.IsNotNull(playerProfile.DraftDetails.PickInRound);
        Assert.IsNotNull(playerProfile.DraftDetails.OverallPick);
        Assert.IsNotNull(playerProfile.DraftDetails.TeamAbbrev);

        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.Goals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.FaceoffWinningPctg);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.Shots);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.GamesPlayed);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.Shots);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.PlusMinus);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.ShorthandedGoals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.GameWinningGoals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.Assists);

        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.Goals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.FaceoffWinningPctg);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.Shots);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.GamesPlayed);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.Shots);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.PlusMinus);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.ShorthandedGoals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.GameWinningGoals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.Assists);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(8478402)]
    [DataRow(8471675)]
    [DataRow(8479318)]
    [DataRow(8471214)]
    public async Task GetPlayerInformationAsync_Test_PlayerEnum(int playerId)
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var playerProfile = await nhlApi.GetPlayerInformationAsync(playerId);

        // Assert
        Assert.IsNotNull(playerProfile);
        Assert.IsNotNull(playerProfile.FirstName.Default);
        Assert.IsNotNull(playerProfile.LastName.Default);
        Assert.IsNotNull(playerProfile.TeamLogo);
        Assert.IsNotNull(playerProfile.FullTeamName.Default);
        Assert.IsNotNull(playerProfile.BirthCity.Default);
        Assert.IsNotNull(playerProfile.BirthCountry);
        Assert.IsNotNull(playerProfile.HeightInFeetAndInches);
        Assert.IsNotNull(playerProfile.HeightInInches);
        Assert.IsNotNull(playerProfile.Headshot);
        Assert.IsNotNull(playerProfile.WeightInPounds);
        Assert.IsNotNull(playerProfile.WeightInKilograms);
        Assert.IsNotNull(playerProfile.BirthDate);
        Assert.IsNotNull(playerProfile.Age);
        Assert.IsNotNull(playerProfile.IsActive);
        Assert.IsNotNull(playerProfile.InHHOF);
        Assert.IsNotNull(playerProfile.InTop100AllTime);
        Assert.IsNotNull(playerProfile.HeightInCentimeters);

        Assert.IsNotNull(playerProfile.DraftDetails.Round);
        Assert.IsNotNull(playerProfile.DraftDetails.PickInRound);
        Assert.IsNotNull(playerProfile.DraftDetails.OverallPick);
        Assert.IsNotNull(playerProfile.DraftDetails.TeamAbbrev);

        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.Goals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.FaceoffWinningPctg);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.Shots);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.GamesPlayed);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.Shots);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.PlusMinus);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.ShorthandedGoals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.GameWinningGoals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerRegularSeason.Assists);

        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.Goals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.FaceoffWinningPctg);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.Shots);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.GamesPlayed);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.Shots);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.PlusMinus);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.ShorthandedGoals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.GameWinningGoals);
        Assert.IsNotNull(playerProfile.CareerTotals.PlayerPlayoffs.Assists);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestSearchAllPlayersNoResultsAsync()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act 
        var results = await nhlApi.SearchAllPlayersAsync("");

        // Assert
        Assert.IsNotNull(results);
        Assert.AreEqual(0, results.Count);

    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestSearchAllActivePlayersNoResultsAsync()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act 
        var results = await nhlApi.SearchAllActivePlayersAsync("");

        // Assert
        Assert.IsNotNull(results);
        Assert.AreEqual(0, results.Count);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("20222023")]
    [DataRow("20182019")]
    [DataRow("20202021")]
    public async Task TestDownloadPlayerHeadshotImageAsync(string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var image = await nhlApi.GetPlayerHeadshotImageAsync(PlayerEnum.ConnorMcDavid8478402, seasonYear);

        // Assert
        Assert.IsNotNull(image);
        Assert.IsTrue(image.Length > 5000);
    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("20222023")]
    [DataRow("20182019")]
    [DataRow("20202021")]
    public async Task GetPlayerHeadshotImageAsync_TestDownload_PlayerHeadshot_ImageWithId(string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var image = await nhlApi.GetPlayerHeadshotImageAsync(8477932, seasonYear);

        // Assert
        Assert.IsNotNull(image);
        Assert.IsTrue(image.Length > 5000);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerHeadshotImageAsync_Test_Download_PlayerHeadshotImage_With_InvalidId()
    {
        // Arrange
        await using var nhlApi = new NhlApi();


        // Act / Assert
        _ = await Assert.ThrowsExceptionAsync<HttpRequestException>(async () =>
        {
            var image = await nhlApi.GetPlayerHeadshotImageAsync(999999, SeasonYear.season20232024);
        });
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetLiveGameFeedPlayerShiftsAsync_Test_Get_Player_Information()
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var playerShifts = await nhlApi.GetLiveGameFeedPlayerShiftsAsync(2021020087);

        // Assert
        Assert.IsNotNull(playerShifts);
        Assert.AreEqual(790, playerShifts.PlayerShifts.Count);

        var firstShift = playerShifts.PlayerShifts.OrderBy(ps => ps.EventNumber).First();
        Assert.AreEqual(8475883, firstShift.PlayerId);
        Assert.AreEqual(1, firstShift.ShiftNumber);
        Assert.AreEqual(1, firstShift.Period);
        Assert.AreEqual("00:00", firstShift.StartTime);
        Assert.AreEqual("20:00", firstShift.EndTime);
        Assert.AreEqual("20:00", firstShift.Duration);
        Assert.AreEqual("Carolina Hurricanes", firstShift.TeamName);
        Assert.AreEqual("CAR", firstShift.TeamAbbrev);
        Assert.AreEqual("Frederik", firstShift.FirstName);
        Assert.AreEqual("Andersen", firstShift.LastName);
        Assert.AreEqual(6, firstShift.EventNumber);
        Assert.AreEqual(12, firstShift.TeamId);
        Assert.AreEqual(0, firstShift.DetailCode);
    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetLiveGameFeedPlayerShiftsAsync_Test_Is_Player_Information_Empty()
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var playerShifts = await nhlApi.GetLiveGameFeedPlayerShiftsAsync(0);

        // Assert
        Assert.IsNotNull(playerShifts);
        Assert.AreEqual(0, playerShifts.PlayerShifts.Count);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerSpotlightAsync_Test_Get_Player_Spotlights_When_Season_Active()
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var playerSpotlight = await nhlApi.GetPlayerSpotlightAsync();

        var isLeagueActive = await nhlApi.IsLeagueActiveAsync();
        if (isLeagueActive)
        {
            // Assert
            Assert.IsTrue(playerSpotlight.Count > 0);

            foreach (var playerSpotlightPlayer in playerSpotlight)
            {
                Assert.IsNotNull(playerSpotlightPlayer.PlayerId);
                Assert.IsNotNull(playerSpotlightPlayer.Position);
                Assert.IsNotNull(playerSpotlightPlayer.PlayerSlug);
                Assert.IsNotNull(playerSpotlightPlayer.Position);
                Assert.IsNotNull(playerSpotlightPlayer.TeamLogo);
                Assert.IsNotNull(playerSpotlightPlayer.Headshot);
                Assert.IsNotNull(playerSpotlightPlayer.TeamTriCode);
                Assert.IsNotNull(playerSpotlightPlayer.TeamId);
            }
        }
    }

    [TestMethodWithRetry(RetryCount = 10, RetryDelayInSeconds = 10)]
    public async Task GetAllPlayersAsync_Returns_All_Players()
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act
        var players = await nhlApi.GetAllPlayersAsync();

        // Assert
        Assert.IsNotNull(players);
        Assert.IsTrue(players.Count > 22000);
    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task DisposeAsync_Should_Dispose_Of_Resources_Correctly()
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act / Assert
        await nhlApi.DisposeAsync();
    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task Dispose_Should_Dispose_Of_Resources_Correctly()
    {
        // Arrange 
        await using var nhlApi = new NhlApi();

        // Act / Assert
        nhlApi.Dispose();
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task Test_GetPlayerDraftRankingByYearAsync_Throws_Argument_Exception_For_Invalid_Season_Year()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act / Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetPlayerDraftRankingByYearAsync(" "));
    }


    [TestMethodWithRetry(RetryCount = 5)]
    public async Task Test_GetPlayerDraftRankingByYearAsync_Throws_Argument_Exception_For_Starting_Position()
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act / Assert
        _ = await Assert.ThrowsExceptionAsync<ArgumentException>(async () => await nhlApi.GetPlayerDraftRankingByYearAsync(SeasonYear.season20242025, startingPosition: 0, default));
    }

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("2008")]
    [DataRow("2009")]
    [DataRow("2010")]
    [DataRow("2011")]
    [DataRow("2012")]
    [DataRow("2013")]
    [DataRow("2014")]
    [DataRow("2015")]
    [DataRow("2016")]
    [DataRow("2017")]
    [DataRow("2018")]
    [DataRow("2019")]
    [DataRow("2020")]
    [DataRow("2021")]
    [DataRow("2022")]
    [DataRow("2023")]
    [DataRow("2024")]
    public async Task GetPlayerDraftRankingByYearAsync_Returns_Correct_Draft_Ranking_Information(string seasonYear)
    {
        // Arrange
        await using var nhlApi = new NhlApi();

        // Act
        var draft = await nhlApi.GetPlayerDraftRankingByYearAsync(seasonYear);

        // Assert
        Assert.IsNotNull(draft);
        Assert.IsNotNull(draft.Rankings);
        Assert.IsTrue(draft.Rankings.Count > 0);

        foreach (var playerDraftRanking in draft.Rankings)
        {
            Assert.IsNotNull(playerDraftRanking);
            Assert.IsNotNull(playerDraftRanking.FirstName);
            Assert.IsNotNull(playerDraftRanking.LastName);
            Assert.IsNotNull(playerDraftRanking.HeightInInches);
            Assert.IsNotNull(playerDraftRanking.WeightInPounds);
        }

    }

    [TestMethodWithRetry(RetryCount = 25)]
    public async Task PlayerEnumFileGeneratorHelper_Returns_Valid_Content() =>
        // Arrange
        await PlayerEnumFileGeneratorHelper.UpdatePlayerEnumToFile(string.Empty);
}
