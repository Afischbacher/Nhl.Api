using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nhl.Api.Enumerations.Game;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Tests.Helpers.Attributes;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Nhl.Api.Tests;

[TestClass]
public class PlayerTests
{
    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("Wayne Gretzky", 99)]
    [DataRow("Alex Ovechkin", 8)]
    [DataRow("Connor McDavid", 97)]
    public async Task TestSearchAllPlayersAsync(string query, int numberOfPlayer)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

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
                Assert.AreEqual("Ontario", playerSearchResult.BirthProvinceState);
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
                Assert.AreEqual("Ontario", playerSearchResult.BirthProvinceState);
                Assert.AreEqual("Connor", playerSearchResult.FirstName);
                Assert.AreEqual("McDavid", playerSearchResult.LastName);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual("EDM", playerSearchResult.LastTeamAbbreviation);
                Assert.AreEqual("6\u00271\"", playerSearchResult.Height);
                Assert.AreEqual(97, playerSearchResult.PlayerNumber);
                break;
        }

    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow("Carter Hart")]
    [DataRow("Auston Matthews")]
    [DataRow("Connor McDavid")]
    [DataRow("Frederik Andersen")]
    public async Task TestSearchAllActivePlayersAsync(string query)
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

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
                Assert.AreEqual("", playerSearchResult.BirthProvinceState);
                Assert.AreEqual("David", playerSearchResult.FirstName);
                Assert.AreEqual("Pastrnak", playerSearchResult.LastName);
                Assert.AreEqual("BOS", playerSearchResult.TeamAbbreviation);
                Assert.AreEqual("6\u00270\"", playerSearchResult.Height);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual(88, playerSearchResult.PlayerNumber);
                break;

            case "Carter Hart":
                Assert.AreEqual("Sherwood Park", playerSearchResult.BirthCity);
                Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                Assert.AreEqual("Alberta", playerSearchResult.BirthProvinceState);
                Assert.AreEqual("Carter", playerSearchResult.FirstName);
                Assert.AreEqual("Hart", playerSearchResult.LastName);
                Assert.AreEqual(true, playerSearchResult.IsActive);
                Assert.AreEqual("PHI", playerSearchResult.TeamAbbreviation);
                Assert.AreEqual("6\u00272\"", playerSearchResult.Height);
                Assert.AreEqual(79, playerSearchResult.PlayerNumber);
                break;

            case "Connor McDavid":
                Assert.AreEqual("Richmond Hill", playerSearchResult.BirthCity);
                Assert.AreEqual("CAN", playerSearchResult.BirthCountry);
                Assert.AreEqual("Canada", playerSearchResult.FullBirthCountry);
                Assert.AreEqual("Ontario", playerSearchResult.BirthProvinceState);
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

    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.ConnorMcDavid8478402, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(PlayerEnum.SidneyCrosby8471675, SeasonYear.season20182019, GameType.RegularSeason)]
    [DataRow(PlayerEnum.AustonMatthews8479318, SeasonYear.season20182019, GameType.Playoffs)]
    public async Task GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync_Test_Player_Enum(PlayerEnum playerEnum, string seasonYear, GameType gameType)
    {
        // Arrange 
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var playerSeasonGameLog = await nhlApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(8478402, SeasonYear.season20222023, GameType.RegularSeason);

        // Assert
        Assert.IsNotNull(playerSeasonGameLog);
        Assert.AreEqual(82, playerSeasonGameLog.PlayerGameLogs.Count);

    }


    [TestMethodWithRetry(RetryCount = 5)]
    [DataRow(PlayerEnum.MarcAndreFleury8470594, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(PlayerEnum.JuuseSaros8477424, SeasonYear.season20182019, GameType.RegularSeason)]
    [DataRow(PlayerEnum.JosephWoll8479361, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(PlayerEnum.AndreiVasilevskiy8476883, SeasonYear.season20212022, GameType.Playoffs)]

    public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerEnum(PlayerEnum playerEnum, string seasonYear, GameType gameType)
    {
        // Arrange 
        await using INhlApi nhlApi = new NhlApi();

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
    [DataRow(8470594, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(8477424, SeasonYear.season20182019, GameType.RegularSeason)]
    [DataRow(8479361, SeasonYear.season20222023, GameType.RegularSeason)]
    [DataRow(8476883, SeasonYear.season20212022, GameType.Playoffs)]

    public async Task GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync_Test_PlayerId(int playerId, string seasonYear, GameType gameType)
    {
        // Arrange 
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

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
    [DataRow(PlayerEnum.ConnorMcDavid8478402)]
    [DataRow(PlayerEnum.SidneyCrosby8471675)]
    [DataRow(PlayerEnum.AustonMatthews8479318)]
    [DataRow(PlayerEnum.AlexOvechkin8471214)]
    public async Task GetPlayerInformationAsync_Test_PlayerEnum(PlayerEnum playerEnum)
    {
        // Arrange 
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

        // Act 
        var results = await nhlApi.SearchAllActivePlayersAsync("");

        // Assert
        Assert.IsNotNull(results);
        Assert.AreEqual(0, results.Count);

    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task TestDownloadPlayerHeadshotImageAsync()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var image = await nhlApi.GetPlayerHeadshotImageAsync(PlayerEnum.ZackKassian8475178, PlayerHeadshotImageSize.Large);

        // Assert
        Assert.IsNotNull(image);
        Assert.IsTrue(image.Length > 5000);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerHeadshotImageAsync_TestDownload_PlayerHeadshot_ImageWithId()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();

        // Act
        var image = await nhlApi.GetPlayerHeadshotImageAsync(8477932, PlayerHeadshotImageSize.Large);

        // Assert
        Assert.IsNotNull(image);
        Assert.IsTrue(image.Length > 5000);
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetPlayerHeadshotImageAsync_Test_Download_PlayerHeadshotImage_With_InvalidId()
    {
        // Arrange
        await using INhlApi nhlApi = new NhlApi();


        // Act / Assert
        await Assert.ThrowsExceptionAsync<HttpRequestException>(async () =>
        {
            var image = await nhlApi.GetPlayerHeadshotImageAsync(999999, PlayerHeadshotImageSize.Large);
        });
    }

    [TestMethodWithRetry(RetryCount = 5)]
    public async Task GetLiveGameFeedPlayerShiftsAsync_Test_Get_Player_Information()
    {
        // Arrange 
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

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
        await using INhlApi nhlApi = new NhlApi();

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
}
