using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player;

/// <summary>
/// The profile of an NHL player such as their height, weight, birth date, statistics and more
/// </summary>
public class PlayerProfile
{
    /// <summary>
    /// The unique identifier for the NHL player <br/>
    /// Example: 8478402
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// Determines if the NHL player is active or inactive <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("isActive")]
    public bool IsActive { get; set; }

    /// <summary>
    /// The current team id for the NHL player <br/>
    /// Example: 25 - Edmonton Oilers
    /// </summary>
    [JsonProperty("currentTeamId")]
    public int CurrentTeamId { get; set; }

    /// <summary>
    /// The current team abbreviation for the NHL player <br/>
    /// Example: EDM
    /// </summary>
    [JsonProperty("currentTeamAbbrev")]
    public string CurrentTeamAbbrev { get; set; }

    /// <summary>
    /// The full team name for the NHL player <br/>
    /// Example: Edmonton Oilers
    /// </summary>
    [JsonProperty("fullTeamName")]
    public FullTeamName FullTeamName { get; set; }

    /// <summary>
    /// The first name of the NHL player <br/>
    /// Example: Connor
    /// </summary>
    [JsonProperty("firstName")]
    public FirstName FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL player <br/>
    /// Example: McDavid
    /// </summary>
    [JsonProperty("lastName")]
    public LastName LastName { get; set; }

    /// <summary>
    /// The link url to the NHL team logo <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/EDM_light.svg">https://assets.nhle.com/logos/nhl/svg/EDM_light.svg</a>
    /// </summary>
    [JsonProperty("teamLogo")]
    public string TeamLogo { get; set; }

    /// <summary>
    /// The NHL players jersey number <br/>
    /// Example: 97
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int SweaterNumber { get; set; }

    /// <summary>
    /// The postion of the NHL player <br/>
    /// Example: C
    /// </summary>
    [JsonProperty("position")]
    public string Position { get; set; }

    /// <summary>
    /// The link url from the NHL for the NHL players headshot <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/EDM/8478402.png">https://assets.nhle.com/mugs/nhl/20232024/EDM/8478402.png</a> 
    /// </summary>
    [JsonProperty("headshot")]
    public string Headshot { get; set; }

    /// <summary>
    /// The link url for the NHL players action shot <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/actionshots/1296x729/8478402.jpg">https://assets.nhle.com/mugs/actionshots/1296x729/8478402.jpg</a>
    /// </summary>
    [JsonProperty("heroImage")]
    public string HeroImage { get; set; }

    /// <summary>
    /// The height of the NHL player in inches <br/>
    /// Example: 73
    /// </summary>
    [JsonProperty("heightInInches")]
    public int HeightInInches { get; set; }

    /// <summary>
    /// The height of the NHL player in feet and inches <br/>
    /// Example: 6 ft 1 in
    /// </summary>
    public string HeightInFeetAndInches => $"{HeightInInches / 12} ft {HeightInInches % 12} in";

    /// <summary>
    /// The height of the NHL player in centimeters <br/>
    /// Example: 185
    /// </summary>
    [JsonProperty("heightInCentimeters")]
    public int HeightInCentimeters { get; set; }

    /// <summary>
    /// The weight of the NHL player in pounds <br/>
    /// Example: 193
    /// </summary>
    [JsonProperty("weightInPounds")]
    public int WeightInPounds { get; set; }

    /// <summary>
    /// The weight of the NHL player in kilograms <br/>
    /// Example: 88
    /// </summary>
    [JsonProperty("weightInKilograms")]
    public int WeightInKilograms { get; set; }

    /// <summary>
    /// The date of birth for the NHL player <br/>
    /// Example: 1997-01-13
    /// </summary>
    [JsonProperty("birthDate")]
    public string BirthDate { get; set; }

    /// <summary>
    /// The age of the NHL player <br/>
    /// Example: 24
    /// </summary>
    public int Age => (DateTime.Now.Year - DateTime.Parse(BirthDate).Year);

    /// <summary>
    /// The birth city of the NHL player <br/>
    /// Example: Richmond Hill
    /// </summary>
    [JsonProperty("birthCity")]
    public BirthCity BirthCity { get; set; }

    /// <summary>
    /// The birth state or province of the NHL player <br/>
    /// Example: ON
    /// </summary>
    [JsonProperty("birthStateProvince")]
    public BirthStateProvince BirthStateProvince { get; set; }

    /// <summary>
    /// The birth country of the NHL player <br/>
    /// Example: CAN
    /// </summary>
    [JsonProperty("birthCountry")]
    public string BirthCountry { get; set; }

    /// <summary>
    /// The NHL player shooting or catching hand <br/>
    /// Example: L or R
    /// </summary>
    [JsonProperty("shootsCatches")]
    public string ShootsCatches { get; set; }

    /// <summary>
    /// The details of the NHL draft for the NHL player <br/>
    /// Example: 
    /// <code>
    ///  "draftDetails": {
    ///    "year": 2015,
    ///    "teamAbbrev": "EDM",
    ///    "round": 1,
    ///    "pickInRound": 1,
    ///    "overallPick": 1
    ///}
    /// </code>
    /// </summary>
    [JsonProperty("draftDetails")]
    public DraftDetails DraftDetails { get; set; }

    /// <summary>
    /// The NHL player slug for the NHL player link profile <br/>
    /// Example: connor-mcdavid-8478402
    /// </summary>
    [JsonProperty("playerSlug")]
    public string PlayerSlug { get; set; }

    /// <summary>
    /// Determines if the NHL player is a Top 100 player of all time <br/>
    /// Example: 1 or 0
    /// </summary>
    [JsonProperty("inTop100AllTime")]
    public int InTop100AllTime { get; set; }

    /// <summary>
    /// Determines if the NHL player is in the Hockey Hall of Fame
    /// Example: 1 or 0
    /// </summary>
    [JsonProperty("inHHOF")]
    public int InHHOF { get; set; }

    /// <summary>
    /// The NHL player's features statistics for the player's profile
    /// </summary>
    [JsonProperty("featuredStats")]
    public PlayerFeaturedStats FeaturedStats { get; set; }

    /// <summary>
    /// The NHL player's career totals for the player's profile <br/>
    /// </summary>
    [JsonProperty("careerTotals")]
    public PlayerCareerTotals CareerTotals { get; set; }

    /// <summary>
    /// The NHL players link to shop for the NHL player's merchandise
    /// </summary>
    [JsonProperty("shopLink")]
    public string ShopLink { get; set; }

    /// <summary>
    /// The NHL player's link to the NHL player's Twitter profile
    /// </summary>
    [JsonProperty("twitterLink")]
    public string TwitterLink { get; set; }

    /// <summary>
    /// The NHL player's link to the NHL player's highlight reels and action shots
    /// </summary>
    [JsonProperty("watchLink")]
    public string WatchLink { get; set; }

    /// <summary>
    /// A collection of the NHL player's last 5 games statistics
    /// </summary>
    [JsonProperty("last5Games")]
    public List<PlayerLast5Game> Last5Games { get; set; }

    /// <summary>
    /// A collection of the NHL player's season totals for each season played
    /// </summary>
    [JsonProperty("seasonTotals")]
    public List<PlayerSeasonTotal> SeasonTotals { get; set; }

    /// <summary>
    /// A collection of the NHL player's awards won throughout their career
    /// </summary>
    [JsonProperty("awards")]
    public List<PlayerAward> Awards { get; set; }

    /// <summary>
    /// A collection of the NHL player's current team roster
    /// </summary>
    [JsonProperty("currentTeamRoster")]
    public List<CurrentTeamRoster> CurrentTeamRoster { get; set; }

    /// <summary>
    /// Full name of the NHL player
    /// </summary>  
    public string FullName => $"{FirstName?.Default} {LastName?.Default}" ??    ;
}


/// <summary>
/// The NHL player's sub season statistics
/// </summary>
public class PlayerSubSeason
{
    /// <summary>
    /// The number of games played by the NHL player in the sub season
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of goals scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of points scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The plus minus statistic for the NHL player in the sub season
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The total number of penalty minutes by the NHL player in the sub season
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The number of game winning goals scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("gameWinningGoals")]
    public int GameWinningGoals { get; set; }

    /// <summary>
    /// The number of overtime goals scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("otGoals")]
    public int OtGoals { get; set; }

    /// <summary>
    /// The number of shots by the NHL player in the sub season
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The shooting percentage for the NHL player in the sub season
    /// </summary>
    [JsonProperty("shootingPctg")]
    public double ShootingPctg { get; set; }

    /// <summary>
    /// The number of power play goals scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public int PowerPlayGoals { get; set; }

    /// <summary>
    /// The number of power play points scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("powerPlayPoints")]
    public int PowerPlayPoints { get; set; }

    /// <summary>
    /// The number of shorthanded goals scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("shorthandedGoals")]
    public int ShorthandedGoals { get; set; }

    /// <summary>
    /// The number of shorthanded points scored by the NHL player in the sub season
    /// </summary>
    [JsonProperty("shorthandedPoints")]
    public int ShorthandedPoints { get; set; }
}

/// <summary>
/// The NHL player's career totals for the regular season and playoffs
/// </summary>
public class PlayerCareerTotals
{
    /// <summary>
    /// The NHL player's career totals for the regular season
    /// </summary>
    [JsonProperty("regularSeason")]
    public PlayerRegularSeason PlayerRegularSeason { get; set; }

    /// <summary>
    /// The NHL player's career totals for the playoffs
    /// </summary>
    [JsonProperty("playoffs")]
    public PlayerPlayoffs PlayerPlayoffs { get; set; }
}

/// <summary>
/// The NHL player's career totals for the playoffs
/// </summary>
public class PlayerPlayoffs
{
    /// <summary>
    /// The number of games played by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of goals scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of penalty minutes by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The number of points scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The plus minus statistic for the NHL player in the playoffs
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The number of power play goals scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public int PowerPlayGoals { get; set; }

    /// <summary>
    /// The number of power play points scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("powerPlayPoints")]
    public int PowerPlayPoints { get; set; }

    /// <summary>
    /// The number of shorthanded points scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("shorthandedPoints")]
    public int ShorthandedPoints { get; set; }

    /// <summary>
    /// The number of game winning goals scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("gameWinningGoals")]
    public int GameWinningGoals { get; set; }

    /// <summary>
    /// The number of overtime goals scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("otGoals")]
    public int OtGoals { get; set; }

    /// <summary>
    /// The number of shots by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The shooting percentage for the NHL player in the playoffs
    /// </summary>
    [JsonProperty("shootingPctg")]
    public double ShootingPctg { get; set; }

    /// <summary>
    /// The faceoffwinning percentage for the NHL player in the playoffs
    /// </summary>
    [JsonProperty("faceoffWinningPctg")]
    public double FaceoffWinningPctg { get; set; }

    /// <summary>
    /// The average time on ice for the NHL player in the playoffs
    /// </summary>
    [JsonProperty("avgToi")]
    public string AvgToi { get; set; }

    /// <summary>
    /// The number of shorthanded goals scored by the NHL player in the playoffs
    /// </summary>
    [JsonProperty("shorthandedGoals")]
    public int ShorthandedGoals { get; set; }
}

/// <summary>
/// The NHL player's career totals for the regular season
/// </summary>
public class PlayerRegularSeason
{
    /// <summary>
    /// The NHL player's sub season statistics
    /// </summary>
    [JsonProperty("subSeason")]
    public PlayerSubSeason SubSeason { get; set; }

    /// <summary>
    /// The NHL player's career information for the season
    /// </summary>
    [JsonProperty("career")]
    public PlayerCareer Career { get; set; }

    /// <summary>
    /// The NHL player's number of games played in the season
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The NHL player's number of goals scored in the season
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The NHL player's number of assists scored in the season
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The NHL player's number of penalty minutes in the season
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The NHL player's number of points scored in the season
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The NHL player's plus minus statistic in the season
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The NHL player's number of power play goals scored in the season
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public int PowerPlayGoals { get; set; }

    /// <summary>
    /// The number of power play points scored by the NHL player in the season
    /// </summary>
    [JsonProperty("powerPlayPoints")]
    public int PowerPlayPoints { get; set; }

    /// <summary>
    /// The number of short handed points scored by the NHL player in the season
    /// </summary>
    [JsonProperty("shorthandedPoints")]
    public int ShorthandedPoints { get; set; }

    /// <summary>
    /// The number of game winning goals scored by the NHL player in the season
    /// </summary>
    [JsonProperty("gameWinningGoals")]
    public int GameWinningGoals { get; set; }

    /// <summary>
    /// The number of overtime goals scored by the NHL player in the season
    /// </summary>
    [JsonProperty("otGoals")]
    public int OtGoals { get; set; }

    /// <summary>
    /// The number of shots by the NHL player in the season
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The shooting percentage for the NHL player in the season
    /// </summary>
    [JsonProperty("shootingPctg")]
    public decimal ShootingPctg { get; set; }

    /// <summary>
    /// The faceoff winning percentage for the NHL player in the season
    /// </summary>
    [JsonProperty("faceoffWinningPctg")]
    public double FaceoffWinningPctg { get; set; }

    /// <summary>
    /// The average time on ice for the NHL player in the season
    /// </summary>
    [JsonProperty("avgToi")]
    public string AvgToi { get; set; }

    /// <summary>
    /// The number of shorthanded goals scored by the NHL player in the season
    /// </summary>
    [JsonProperty("shorthandedGoals")]
    public int ShorthandedGoals { get; set; }
}


/// <summary>
/// The award won by an NHL player and the seasons the award was won
/// </summary>
public class PlayerAward
{

    /// <summary>
    /// The trophy won by the NHL player and it's information
    /// </summary>
    [JsonProperty("trophy")]
    public Trophy Trophy { get; set; }

    /// <summary>
    /// The seasons the NHL player won the award with statistics
    /// </summary>
    [JsonProperty("seasons")]
    public List<PlayerAwardSeason> Seasons { get; set; }
}

/// <summary>
/// An NHL player award season and the statistics for the award season
/// </summary>
public class PlayerAwardSeason
{

    /// <summary>
    /// The season identifier for the NHL player award season
    /// </summary>
    [JsonProperty("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// The number of games played by the NHL player in the award season
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The game type identifier for the NHL player award season
    /// </summary>
    [JsonProperty("gameTypeId")]
    public int GameTypeId { get; set; }

    /// <summary>
    /// The number of goals scored by the NHL player in the award season
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists scored by the NHL player in the award season
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of points scored by the NHL player in the award season
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The plus minus statistic for the NHL player in the award season
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The number of hits by the NHL player in the award season
    /// </summary>
    [JsonProperty("hits")]
    public int Hits { get; set; }

    /// <summary>
    /// The number of blocked shots by the NHL player in the award season
    /// </summary>
    [JsonProperty("blockedShots")]
    public int BlockedShots { get; set; }

    /// <summary>
    /// The number of penalty minutes by the NHL player in the award season
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }
}

/// <summary>
/// The trophy won by an NHL player
/// </summary>
public class Trophy
{
    /// <summary>
    /// The default name of the trophy
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }
}

/// <summary>
/// 
/// </summary>
public class PlayerCareer
{
    /// <summary>
    /// The number of games played by the NHL player in the career
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of goals scored by the NHL player in the career
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists scored by the NHL player in the career
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of points scored by the NHL player in the career
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The plus minus statistic for the NHL player in the career
    /// 
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The penalty minutes by the NHL player in the career <br/>
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The number of game winning goals scored by the NHL player in the career
    /// </summary>
    [JsonProperty("gameWinningGoals")]
    public int GameWinningGoals { get; set; }

    /// <summary>
    /// The number of overtime goals scored by the NHL player in the career
    /// </summary>
    [JsonProperty("otGoals")]
    public int OtGoals { get; set; }

    /// <summary>
    /// The number of shots by the NHL player in the career
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The shooting percentage for the NHL player in the career
    /// </summary>
    [JsonProperty("shootingPctg")]
    public double ShootingPctg { get; set; }

    /// <summary>
    /// The number of power play goals scored by the NHL player in the career
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public int PowerPlayGoals { get; set; }

    /// <summary>
    /// The number of power play points scored by the NHL player in the career
    /// </summary>
    [JsonProperty("powerPlayPoints")]
    public int PowerPlayPoints { get; set; }

    /// <summary>
    /// The number of shorthanded goals scored by the NHL player in the career
    /// </summary>
    [JsonProperty("shorthandedGoals")]
    public int ShorthandedGoals { get; set; }

    /// <summary>
    /// The number of shorthanded points scored by the NHL player in the career
    /// </summary>
    [JsonProperty("shorthandedPoints")]
    public int ShorthandedPoints { get; set; }
}

/// <summary>
/// The statistics for the last 5 games played by the NHL player
/// </summary>
public class PlayerLast5Game
{
    /// <summary>
    /// The NHL game identifier for the game
    /// </summary>
    [JsonProperty("gameId")]
    public int GameId { get; set; }

    /// <summary>
    /// The NHL game type identifier for the game
    /// </summary>
    [JsonProperty("gameTypeId")]
    public int GameTypeId { get; set; }

    /// <summary>
    /// The NHL team abbreviation for the team the NHL player played for in the game
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public string TeamAbbrev { get; set; }

    /// <summary>
    /// The NHL home or road flag for the team the NHL player played for in the game
    /// </summary>
    [JsonProperty("homeRoadFlag")]
    public string HomeRoadFlag { get; set; }

    /// <summary>
    /// The NHL game date for the game
    /// </summary>
    [JsonProperty("gameDate")]
    public string GameDate { get; set; }

    /// <summary>
    /// The number of goals scored by the NHL player in the game
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists scored by the NHL player in the game
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of points scored by the NHL player in the game
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The total plus minus statistic for the NHL player in the game
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The number of power play goals scored by the NHL player in the game
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public int PowerPlayGoals { get; set; }

    /// <summary>
    /// The number of shots by the NHL player in the game
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The number of shifts by the NHL player in the game
    /// </summary>
    [JsonProperty("shifts")]
    public int Shifts { get; set; }

    /// <summary>
    /// The number of shorthanded goals scored by the NHL player in the game
    /// </summary>
    [JsonProperty("shorthandedGoals")]
    public int ShorthandedGoals { get; set; }

    /// <summary>
    /// The total number of penalty minutes by the NHL player in the game
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The opponent team abbreviation for the team the NHL player played against in the game
    /// </summary>
    [JsonProperty("opponentAbbrev")]
    public string OpponentAbbrev { get; set; }

    /// <summary>
    /// The total minutes on the 
    /// </summary>
    [JsonProperty("toi")]
    public string Toi { get; set; }
}

/// <summary>
/// The featured statistics for the NHL player
/// </summary>
public class PlayerFeaturedStats
{
    /// <summary>
    /// The NHL season identifier for the season
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The NHL player regular season statistics for the featured statistics
    /// </summary>
    [JsonProperty("regularSeason")]
    public PlayerRegularSeason RegularSeason { get; set; }
}

/// <summary>
/// The NHL player's season totals for each season played
/// </summary>
public class PlayerSeasonTotal
{
    /// <summary>
    /// The NHL season identifier for the season
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The NHL game type identifier for the game
    /// </summary>
    [JsonProperty("gameTypeId")]
    public int GameTypeId { get; set; }

    /// <summary>
    /// The NHL players league abbreviation for the season for the league they played in
    /// </summary>
    [JsonProperty("leagueAbbrev")]
    public string LeagueAbbrev { get; set; }

    /// <summary>
    /// The team name for the NHL player for the season
    /// </summary>
    [JsonProperty("teamName")]
    public TeamName TeamName { get; set; }

    /// <summary>
    /// The sequence number for the NHL player for the season
    /// </summary>
    [JsonProperty("sequence")]
    public int Sequence { get; set; }

    /// <summary>
    /// The number of games played by the NHL player in the season
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of goals scored by the NHL player in the season
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists scored by the NHL player in the season
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of points scored by the NHL player in the season
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The number of penalty minutes by the NHL player in the season
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The total plus minus statistic for the NHL player in the season
    /// </summary>
    [JsonProperty("plusMinus")]
    public int? PlusMinus { get; set; }

    /// <summary>
    /// The total power play goals scored by the NHL player in the season
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public int? PowerPlayGoals { get; set; }

    /// <summary>
    /// The total game winning goals scored by the NHL player in the season
    /// </summary>
    [JsonProperty("gameWinningGoals")]
    public int? GameWinningGoals { get; set; }

    /// <summary>
    /// The total shorthanded goals scored by the NHL player in the season
    /// </summary>
    [JsonProperty("shorthandedGoals")]
    public int? ShorthandedGoals { get; set; }

    /// <summary>
    /// The total number of shots by the NHL player in the season
    /// </summary>
    [JsonProperty("shots")]
    public int? Shots { get; set; }

    /// <summary>
    /// The total power play points scored by the NHL player in the season
    /// </summary>
    [JsonProperty("powerPlayPoints")]
    public int? PowerPlayPoints { get; set; }

    /// <summary>
    /// The total short handed points scored by the NHL player in the season
    /// </summary>
    [JsonProperty("shorthandedPoints")]
    public int? ShorthandedPoints { get; set; }

    /// <summary>
    /// The total overtime goals scored by the NHL player in the season
    /// </summary>
    [JsonProperty("otGoals")]
    public int? OtGoals { get; set; }

    /// <summary>
    /// The shooting percentage for the NHL player in the season
    /// </summary>
    [JsonProperty("shootingPctg")]
    public decimal? ShootingPctg { get; set; }

    /// <summary>
    /// The faceoff winning percentage for the NHL player in the season
    /// </summary>
    [JsonProperty("faceoffWinningPctg")]
    public decimal? FaceoffWinningPctg { get; set; }

    /// <summary>
    /// The average time on ice for the NHL player in the season
    /// </summary>
    [JsonProperty("avgToi")]
    public string AvgToi { get; set; }
}
