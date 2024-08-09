using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Nhl.Api.Models.Player;
/// <summary>
/// An NHL player profile based on a landing of the players information
/// </summary>
public class GoalieProfile
{
    /// <summary>
    /// The identifier of the NHL goalie <br/>
    /// Example: 8479361 - Joseph Woll
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// Determines if the NHL goalie is active or not <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("isActive")]
    public bool IsActive { get; set; }

    /// <summary>
    /// The current team identifier of the NHL goalie <br/>
    /// Example: 5 - Pittsburgh Penguins
    /// </summary>
    [JsonProperty("currentTeamId")]
    public int CurrentTeamId { get; set; }

    /// <summary>
    /// The current team abbreviation of the NHL goalie <br/>
    /// Example: PIT - Pittsburgh Penguins
    /// </summary>
    [JsonProperty("currentTeamAbbrev")]
    public string CurrentTeamAbbrev { get; set; }

    /// <summary>
    /// The full team name of the NHL goalie <br/>
    /// Example: Pittsburgh Penguins
    /// </summary>
    [JsonProperty("fullTeamName")]
    public FullTeamName FullTeamName { get; set; }

    /// <summary>
    /// The first name of the NHL goalie <br/>
    /// Example: Joseph
    /// </summary>
    [JsonProperty("firstName")]
    public FirstName FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL goalie <br/>
    /// Example: Woll
    /// </summary>
    [JsonProperty("lastName")]
    public LastName LastName { get; set; }

    /// <summary>
    /// The link to the NHL team logo <br/>
    /// Example: https://assets.nhle.com/logos/nhl/svg/TOR_light.svg 
    /// </summary>
    [JsonProperty("teamLogo")]
    public string TeamLogo { get; set; }

    /// <summary>
    /// The NHL goalie 's jersey number <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int SweaterNumber { get; set; }

    /// <summary>
    /// The position of the NHL goalie <br/>
    /// Example: "G"
    /// </summary>
    [JsonProperty("position")]
    public string Position { get; set; }

    /// <summary>
    /// The url link to the NHL goalie 's headshot image <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/TOR/8479361.png">https://assets.nhle.com/mugs/nhl/20232024/TOR/8479361.png</a>
    /// </summary>
    [JsonProperty("headshot")]
    public string Headshot { get; set; }

    /// <summary>
    /// The url link to the NHL goalie 's action image <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/actionshots/1296x729/8479361.jpg">https://assets.nhle.com/mugs/actionshots/1296x729/8479361.jpg</a>
    /// </summary>
    [JsonProperty("heroImage")]
    public string HeroImage { get; set; }

    /// <summary>
    /// The height of the NHL goalie in inches <br/>
    /// Example: 72
    /// </summary>
    [JsonProperty("heightInInches")]
    public int? HeightInInches { get; set; }

    /// <summary>
    /// The height of the NHL goalie in centimeters <br/>
    /// Example: 182
    /// </summary>
    [JsonProperty("heightInCentimeters")]
    public int HeightInCentimeters { get; set; }

    /// <summary>
    /// The height of the NHL goalie in feet and inches <br/>
    /// Example: 6 ft 0 in
    /// </summary>
    public string? HeightInFeetAndInches => this.HeightInInches.HasValue ? $"{this.HeightInInches / 12} ft {this.HeightInInches % 12} in" : null;

    /// <summary>
    /// The weight of the NHL goalie in pounds <br/>
    /// Example: 202
    /// </summary>
    [JsonProperty("weightInPounds")]
    public int WeightInPounds { get; set; }

    /// <summary>
    /// The weight of the NHL goalie in kilograms <br/>
    /// Example: 92
    /// </summary>
    [JsonProperty("weightInKilograms")]
    public int WeightInKilograms { get; set; }

    /// <summary>
    /// The birth date of the NHL goalie <br/>
    /// Example: 1998-07-12
    /// </summary>
    [JsonProperty("birthDate")]
    public string? BirthDate { get; set; }

    /// <summary>
    /// The age of the NHL goalie <br/>
    /// Example: 24
    /// </summary>
    public int? Age => string.IsNullOrWhiteSpace(this.BirthDate) ? null : (DateTime.Now.Year - DateTime.Parse(this.BirthDate, CultureInfo.InvariantCulture).Year);

    /// <summary>
    /// The birth city of the NHL goalie <br/>
    /// Example:
    /// <code>
    /// "birthCity": {
    ///     "default": "Dardenne Prairie"
    /// }
    /// </code>
    /// </summary>
    [JsonProperty("birthCity")]
    public BirthCity BirthCity { get; set; }

    /// <summary>
    /// The birth state province of the NHL goalie <br/> 
    /// Example: 
    /// <code>
    /// "birthStateProvince": {
    ///        "default": "Missouri"
    /// }
    /// </code>
    /// </summary>
    [JsonProperty("birthStateProvince")]
    public BirthStateProvince BirthStateProvince { get; set; }

    /// <summary>
    /// The birth country of the NHL goalie <br/>
    /// Example: USA
    /// </summary>
    [JsonProperty("birthCountry")]
    public string BirthCountry { get; set; }

    /// <summary>
    /// The shoots or catches of the NHL goalie <br/>
    /// Example: "L" - Left or "R" - Right
    /// </summary>
    [JsonProperty("shootsCatches")]
    public string ShootsCatches { get; set; }

    /// <summary>
    /// The NHL draft details for the NHL goalie <br/>
    /// Example:
    /// <code>
    ///  "draftDetails": {
    ///    "year": 2016,
    ///    "teamAbbrev": "TOR",
    ///    "round": 3,
    ///    "pickInRound": 1,
    ///    "overallPick": 62
    /// }
    /// </code>
    /// </summary>
    [JsonProperty("draftDetails")]
    public DraftDetails DraftDetails { get; set; }

    /// <summary>
    /// The url link to the NHL goalie's official website on the NHL website <br/>
    /// Example: <a href="https://www.nhl.com/avalanche/player/alexandar-georgiev-8480382">alexandar-georgiev-8480382</a>
    /// </summary>
    [JsonProperty("playerSlug")]
    public string PlayerSlug { get; set; }

    /// <summary>
    /// Indicates if the NHL goalie is in the top 100 of all time in the NHL <br/>
    /// Example: 0 - No, 1 - Yes
    /// </summary>
    [JsonProperty("inTop100AllTime")]
    public int InTop100AllTime { get; set; }

    /// <summary>
    /// Indicates if the NHL goalie is in the Hockey Hall of Fame <br/>
    /// Example: 0 - No, 1 - Yes
    /// </summary>
    [JsonProperty("inHHOF")]
    public int InHHOF { get; set; }

    /// <summary>
    /// Returns the featured statistics for the NHL goalie <br/>
    /// Example: 
    /// <code>
    ///      "featuredStats": {
    ///       "season": 20232024,
    ///       "regularSeason": {
    ///           "subSeason": {
    ///               "gamesPlayed": 15,
    ///               "wins": 8,
    ///               "losses": 5,
    ///               "ties": 0,
    ///               "otLosses": 1,
    ///               "shutouts": 0,
    ///               "goalsAgainstAvg": 2.795825,
    ///               "savePctg": 0.916327
    ///           },
    ///           "career": {
    ///               "gamesPlayed": 26,
    ///               "wins": 17,
    ///               "losses": 7,
    ///               "otLosses": 1,
    ///               "shutouts": 1,
    ///               "goalsAgainstAvg": 2.616815,
    ///               "savePctg": 0.919471
    ///           }
    ///       }
    ///   }
    /// 
    /// </code>
    /// </summary>
    [JsonProperty("featuredStats")]
    public FeaturedGoalieStats FeaturedStats { get; set; }

    /// <summary>
    /// The NHL goalies career totals <br/>
    /// Example: 
    /// <code>
    /// "careerTotals": {
    ///   "regularSeason": {
    ///       "gamesPlayed": 26,
    ///       "goals": 0,
    ///       "assists": 0,
    ///       "pim": 2,
    ///       "gamesStarted": 24,
    ///       "wins": 17,
    ///       "losses": 7,
    ///       "otLosses": 1,
    ///       "shotsAgainst": 832,
    ///       "goalsAgainst": 67,
    ///       "goalsAgainstAvg": 2.616815,
    ///       "savePctg": 0.919471,
    ///       "shutouts": 1,
    ///       "timeOnIce": "1536:13"
    ///  }
    ///  </code>
    /// </summary>
    [JsonProperty("careerTotals")]
    public GoalieCareerTotals CareerTotals { get; set; }

    /// <summary>
    /// The NHL link to shop for the NHL goalie's merchandise <br/>
    /// </summary>
    [JsonProperty("shopLink")]
    public string ShopLink { get; set; }

    /// <summary>
    /// The NHL link to the twitter account of the NHL goalie <br/>
    /// </summary>
    [JsonProperty("twitterLink")]
    public string TwitterLink { get; set; }

    /// <summary>
    /// The NHL link to watch the NHL goalie's highlights <br/>
    /// </summary>
    [JsonProperty("watchLink")]
    public string WatchLink { get; set; }

    /// <summary>
    /// A collection of the last 5 games for the NHL goalie <br/>
    /// Example: 
    /// <code>
    /// {
    ///    "gameId": 2023020395,
    ///    "gameTypeId": 2,
    ///    "teamAbbrev": "TOR",
    ///    "homeRoadFlag": "R",
    ///    "gameDate": "2023-12-07",
    ///    "gamesStarted": 1,
    ///    "shotsAgainst": 31,
    ///    "goalsAgainst": 2,
    ///    "savePctg": 0.935484,
    ///    "penaltyMins": 0,
    ///    "opponentAbbrev": "OTT",
    ///    "toi": "50:22"
    /// }
    /// </code>
    /// </summary>
    [JsonProperty("last5Games")]
    public List<GoalieLast5Game> Last5Games { get; set; }

    /// <summary>
    /// The NHL goalie's season totals for each year the goalie played professionally <br/>
    /// Example: 
    /// <code>
    /// {
    ///     "season": 20102011,
    ///     "gameTypeId": 3,
    ///     "leagueAbbrev": "QC Int PW",
    ///     "teamName": {
    ///         "default": "St. Louis Jr. Blues"
    ///     },
    ///     "sequence": 10240335,
    ///     "gamesPlayed": 2,
    ///     "savePctg": 1,
    ///     "goalsAgainstAvg": 0
    /// }
    /// </code>
    /// </summary>
    [JsonProperty("seasonTotals")]
    public List<GoalieSeasonTotal> SeasonTotals { get; set; }

    /// <summary>
    /// A collection of all the NHL players and goalie's that are currently on the NHL team roster <br/>
    /// Example:
    /// <code>
    /// {
    ///     "playerId": 8481122,
    ///     "lastName": {
    ///         "default": "Benoit"
    ///     },
    ///     "firstName": {
    ///         "default": "Simon"
    ///     },
    ///     "playerSlug": "simon-benoit-8481122"
    /// }
    /// </code>
    /// </summary>
    [JsonProperty("currentTeamRoster")]
    public List<CurrentTeamRoster> CurrentTeamRoster { get; set; }
}

/// <summary>
/// The birth city of the NHL player or goalie
/// </summary>
public class BirthCity
{
    /// <summary>
    /// The default name of birth city of the NHL player or goalie
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }
}

/// <summary>
/// The birth state or province of the NHL player or goalie
/// </summary>
public class BirthStateProvince
{
    /// <summary>
    /// The default name of birth state or province of the NHL player or goalie
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }
}

/// <summary>
/// The current team roster of the NHL player or goalie
/// </summary>
public class CurrentTeamRoster
{
    /// <summary>
    /// The NHL player identifier <br/>
    /// Example: 8481122 - Simon Benoit
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The last name of the NHL player or goalie <br/>
    /// Example: Benoit
    /// </summary>
    [JsonProperty("lastName")]
    public LastName LastName { get; set; }

    /// <summary>
    /// The first name of the NHL player or goalie <br/>
    /// Example: Simon
    /// </summary>
    [JsonProperty("firstName")]
    public FirstName FirstName { get; set; }

    /// <summary>
    /// The player slug linking to the NHL player or goalie's profile on the NHL website <br/>
    /// Example: <a href="https://www.nhl.com/avalanche/player/nathan-mackinnon-8477492">nathan-mackinnon-8477492</a>
    /// </summary>
    [JsonProperty("playerSlug")]
    public string PlayerSlug { get; set; }
}

/// <summary>
/// The details of the NHL goalie's draft information
/// </summary>
public class DraftDetails
{
    /// <summary>
    /// The year of the NHL draft <br/>
    /// Example: 2016
    /// </summary>
    [JsonProperty("year")]
    public int Year { get; set; }

    /// <summary>
    /// The team abbreviation of the NHL team that drafted the NHL goalie <br/>
    /// Example: TOR - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public string TeamAbbrev { get; set; }

    /// <summary>
    /// The round of the NHL draft the NHL goalie was drafted in <br/> 
    /// Example: 3
    /// </summary>
    [JsonProperty("round")]
    public int Round { get; set; }

    /// <summary>
    /// The pick in the round of the NHL draft the NHL goalie was drafted in <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("pickInRound")]
    public int PickInRound { get; set; }

    /// <summary>
    /// The overall pick in the NHL draft the NHL goalie was drafted in <br/>
    /// Example: 62
    /// </summary>
    [JsonProperty("overallPick")]
    public int OverallPick { get; set; }
}

/// <summary>
/// The NHL team's full name
/// </summary>
public class TeamName
{
    /// <summary>
    /// The full name of the NHL team <br/>
    /// Example: Toronto Maple Leafs
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }

    /// <summary>
    /// The french name of the NHL team <br/>
    /// Example: Maple Leafs de Toronto
    /// </summary>
    [JsonProperty("fr")]
    public string Fr { get; set; }
}

/// <summary>
/// The first name of the NHL player or goalie
/// </summary>
public class FirstName
{
    /// <summary>
    /// The default name of the NHL player or goalie <br/>
    /// Example: Nick
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }
}

/// <summary>
/// The NHL goalies career statistics
/// </summary>
public class GoalieCareer
{
    /// <summary>
    /// The number of games played in the NHL goalie's career <br/>
    /// Example: 123
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of wins in the NHL goalie's career <br/>
    /// Example: 56
    /// </summary>
    [JsonProperty("wins")]
    public int Wins { get; set; }

    /// <summary>
    /// The number of losses in the NHL goalie's career <br/>
    /// Example: 77
    /// </summary>
    [JsonProperty("losses")]
    public int Losses { get; set; }

    /// <summary>
    /// The number of overtime losses in the NHL goalie's career <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("otLosses")]
    public int OtLosses { get; set; }

    /// <summary>
    /// The number of shutouts against in the NHL goalie's career <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("shutouts")]
    public int Shutouts { get; set; }

    /// <summary>
    /// The number of goals against average in the NHL goalie's career <br/>
    /// Example: 3.75
    /// </summary>
    [JsonProperty("goalsAgainstAvg")]
    public decimal GoalsAgainstAvg { get; set; }

    /// <summary>
    /// The save percentage in the NHL goalie's career <br/>
    /// Example: 0.919
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal SavePctg { get; set; }
}

/// <summary>
/// The NHL goalies season total information and statistics
/// </summary>
public class GoalieSeasonTotal
{
    /// <summary>
    /// The season year of the NHL goalie <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The game type identifier of the NHL goalie <br/>
    /// Example: 2 - Regular Season, 3 - Playoffs
    /// </summary>
    [JsonProperty("gameTypeId")]
    public int GameTypeId { get; set; }

    /// <summary>
    /// The league abbreviation of the NHL goalie <br/>
    /// Example: "NHL" or "AHL"
    /// </summary>
    [JsonProperty("leagueAbbrev")]
    public string LeagueAbbrev { get; set; }

    /// <summary>
    /// The team name of the NHL goalie <br/>
    /// Example:  "Boston College"
    /// </summary>
    [JsonProperty("teamName")]
    public TeamName TeamName { get; set; }

    /// <summary>
    /// The sequence number for the NHL goalie <br/>
    /// Example: 13377
    /// </summary>
    [JsonProperty("sequence")]
    public int Sequence { get; set; }

    /// <summary>
    /// The number of games played in the NHL goalie's season <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The average save percentage in the NHL goalie's season <br/>
    /// Example: 0.892
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal SavePctg { get; set; }

    /// <summary>
    /// The goals against average in the NHL goalie's season <br/>
    /// Example: 3.54
    /// </summary>
    [JsonProperty("goalsAgainstAvg")]
    public decimal GoalsAgainstAvg { get; set; }

    /// <summary>
    /// The number of wins in the NHL goalie's season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("wins")]
    public int? Wins { get; set; }

    /// <summary>
    /// The number of losses in the NHL goalie's season <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("losses")]
    public int? Losses { get; set; }

    /// <summary>
    /// The number of goals against in the NHL goalie's season <br/>
    /// Example: 11
    /// </summary>
    [JsonProperty("goalsAgainst")]
    public int? GoalsAgainst { get; set; }

    /// <summary>
    /// The time on ice in the NHL goalie's season <br/>
    /// Example: "239:30"
    /// </summary>
    [JsonProperty("timeOnIce")]
    public string TimeOnIce { get; set; }

    /// <summary>
    /// The number of ties in the NHL goalie's season <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("ties")]
    public int? Ties { get; set; }

    /// <summary>
    /// The number of shots against the NHL goalie's season <br/>
    /// Example: 462
    /// </summary>
    [JsonProperty("shotsAgainst")]
    public int? ShotsAgainst { get; set; }

    /// <summary>
    /// The number of goals in the NHL goalie's season <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("goals")]
    public int? Goals { get; set; }

    /// <summary>
    /// The number of assists in the NHL goalie's season <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("assists")]
    public int? Assists { get; set; }

    /// <summary>
    /// The number of games started in the NHL goalie's season <br/>
    /// Example: 12
    /// </summary>
    [JsonProperty("gamesStarted")]
    public int? GamesStarted { get; set; }

    /// <summary>
    /// The number of overtime losses in the NHL goalie's season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("otLosses")]
    public int? OtLosses { get; set; }

    /// <summary>
    /// The number of shutouts in the NHL goalie's season <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("shutouts")]
    public int? Shutouts { get; set; }

    /// <summary>
    /// The number of penalty minutes in the NHL goalie's season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("pim")]
    public int? Pim { get; set; }
}

/// <summary>
/// The NHL goalie's sub season information and statistics
/// </summary>
public class GoalieSubSeason
{
    /// <summary>
    /// The number of games played in the NHL goalie's sub season <br/>
    /// Exaample: 15
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of wins in the NHL goalie's sub season <br/>
    /// Example: 13
    /// </summary>
    [JsonProperty("wins")]
    public int Wins { get; set; }

    /// <summary>
    /// The number of losses in the NHL goalie's sub season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("losses")]
    public int Losses { get; set; }

    /// <summary>
    /// The number of ties in the NHL goalie's sub season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("ties")]
    public int Ties { get; set; }

    /// <summary>
    /// The number of OT losses in the NHL goalie's sub season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("otLosses")]
    public int OtLosses { get; set; }

    /// <summary>
    /// The number of shutouts in the NHL goalie's sub season <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("shutouts")]
    public int Shutouts { get; set; }

    /// <summary>
    /// The number of goals against average in the NHL goalie's sub season <br/>
    /// Example: 2.795825
    /// </summary>
    [JsonProperty("goalsAgainstAvg")]
    public decimal GoalsAgainstAvg { get; set; }

    /// <summary>
    /// The save percentage in the NHL goalie's sub season <br/>
    /// Example:  0.907
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal SavePctg { get; set; }
}

/// <summary>
/// The NHL goalie regular season information and statistics
/// </summary>
public class GoalieRegularSeason
{
    /// <summary>
    /// The NHL goalies sub season including information and statistics
    /// </summary>
    [JsonProperty("subSeason")]
    public GoalieSubSeason SubSeason { get; set; }

    /// <summary>
    /// The NHL goalies career information and statistics
    /// </summary>
    [JsonProperty("career")]
    public GoalieCareer Career { get; set; }

    /// <summary>
    /// The number of games played in the NHL goalie's regular season <br/>
    /// Example: 57
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of goals in the NHL goalie's regular season <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists in the NHL goalie's regular season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of penalty minutes in the NHL goalie's regular season <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The number of games started in the NHL goalie's regular season <br/>
    /// Example: 62
    /// </summary>
    [JsonProperty("gamesStarted")]
    public int GamesStarted { get; set; }

    /// <summary>
    /// The number of wins in the NHL goalie's regular season <br/>
    /// Example: 32
    /// </summary>
    [JsonProperty("wins")]
    public int Wins { get; set; }

    /// <summary>
    /// The number of losses in the NHL goalie's regular season <br/>
    /// Example: 24
    /// </summary>
    [JsonProperty("losses")]
    public int Losses { get; set; }

    /// <summary>
    /// The number of OT losses in the NHL goalie's regular season <br/>
    /// Example: 6
    /// </summary>
    [JsonProperty("otLosses")]
    public int OtLosses { get; set; }

    /// <summary>
    /// The number of shots against in the NHL goalie's regular season <br/>
    /// Example: 1892
    /// </summary>
    [JsonProperty("shotsAgainst")]
    public int ShotsAgainst { get; set; }

    /// <summary>
    /// The number of goals against in the NHL goalie's regular season <br/>
    /// Example: 167
    /// </summary>
    [JsonProperty("goalsAgainst")]
    public int GoalsAgainst { get; set; }

    /// <summary>
    /// The goals against average in the NHL goalie's regular season <br/>
    /// Example: 2.37
    /// </summary>
    [JsonProperty("goalsAgainstAvg")]
    public decimal GoalsAgainstAvg { get; set; }

    /// <summary>
    /// The save percentage in the NHL goalie's regular season <br/>
    /// Example:  0.914894
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal SavePctg { get; set; }

    /// <summary>
    /// The number of shutouts in the NHL goalie's regular season <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("shutouts")]
    public int Shutouts { get; set; }

    /// <summary>
    /// The time on ice in the NHL goalie's regular season <br/>
    /// Example; "1238:00"
    /// </summary>
    [JsonProperty("timeOnIce")]
    public string TimeOnIce { get; set; }
}

/// <summary>
/// The NHL goalies featured statistics
/// </summary>
public class FeaturedGoalieStats
{
    /// <summary>
    /// The season year of the NHL goalie <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The NHL goalies regular season information and statistics
    /// </summary>
    [JsonProperty("regularSeason")]
    public GoalieRegularSeason GoalieRegularSeason { get; set; }
}

/// <summary>
/// The NHL goalie career totals
/// </summary>
public class GoalieCareerTotals
{
    /// <summary>
    /// The NHL goalies regular season information and statistics
    /// </summary>
    [JsonProperty("regularSeason")]
    public GoalieRegularSeason RegularSeason { get; set; }

    /// <summary>
    /// The NHL goalie playoffs information and statistics
    /// </summary>
    [JsonProperty("playoffs")]
    public GoaliePlayoffs Playoffs { get; set; }
}

/// <summary>
/// The NHL goalie playoffs information and statistics
/// </summary>
public class GoaliePlayoffs
{
    /// <summary>
    /// The number of games played in the NHL goalie's playoffs season <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The number of goals in the NHL goalie's playoffs season <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists in the NHL goalie's playoffs season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The number of penalty minutes in the NHL goalie's playoffs season <br/>
    /// Example: 23
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The number of games started in the NHL goalie's playoffs season <br/>
    /// Example: 17
    /// </summary>
    [JsonProperty("gamesStarted")]
    public int GamesStarted { get; set; }

    /// <summary>
    /// The number of wins in the NHL goalie's playoffs season <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("wins")]
    public int Wins { get; set; }

    /// <summary>
    /// The number of losses in the NHL goalie's playoffs season <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("losses")]
    public int Losses { get; set; }

    /// <summary>
    /// The number of OT losses in the NHL goalie's playoffs season <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("otLosses")]
    public int OtLosses { get; set; }

    /// <summary>
    /// The number of shots against in the NHL goalie's playoffs season <br/>
    /// Example: 289
    /// </summary>
    [JsonProperty("shotsAgainst")]
    public int ShotsAgainst { get; set; }

    /// <summary>
    /// The number of goals against in the NHL goalie's playoffs season <br/>
    /// Example: 27
    /// </summary>
    [JsonProperty("goalsAgainst")]
    public int GoalsAgainst { get; set; }

    /// <summary>
    /// The number of goals against average in the NHL goalie's playoffs season <br/>
    /// Example: 2.37
    /// </summary>
    [JsonProperty("goalsAgainstAvg")]
    public decimal GoalsAgainstAvg { get; set; }

    /// <summary>
    /// The save percentage in the NHL goalie's playoffs season <br/>
    /// Example: 0.911314
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal SavePctg { get; set; }

    /// <summary>
    /// The number of shutouts in the NHL goalie's playoffs season <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("shutouts")]
    public int Shutouts { get; set; }

    /// <summary>
    /// The number of minutes played in the NHL goalie's playoffs season <br/>
    /// Example: "1238:00"
    /// </summary>
    [JsonProperty("timeOnIce")]
    public string TimeOnIce { get; set; }
}

/// <summary>
/// The NHL full team name
/// </summary>
public class FullTeamName
{
    /// <summary>
    /// The default name of the NHL team <br/>
    /// Example: Vegas Golden Knights
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }

    /// <summary>
    /// The french name of the NHL team <br/>
    /// Example: Golden Knights de Vegas
    /// </summary>
    [JsonProperty("fr")]
    public string Fr { get; set; }
}

/// <summary>
/// A model representing the last 5 games for an NHL goalie for each individual game
/// </summary>
public class GoalieLast5Game
{
    /// <summary>
    /// The NHL game identifier <br/>
    /// Example: 2023020410
    /// </summary>
    [JsonProperty("gameId")]
    public int GameId { get; set; }

    /// <summary>
    /// The game type identifier <br/>
    /// Example: 2 - Regular Season, 3 - Playoffs
    /// </summary>
    [JsonProperty("gameTypeId")]
    public int GameTypeId { get; set; }

    /// <summary>
    /// The NHL team abbreviation <br/>
    /// Example: VGK - Vegas Golden Knights
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public string TeamAbbrev { get; set; }

    /// <summary>
    /// The home or road flag <br/>
    /// Example: "R" - Road, "H" - Home
    /// </summary>
    [JsonProperty("homeRoadFlag")]
    public string HomeRoadFlag { get; set; }

    /// <summary>
    /// The date of the NHL game <br/>
    /// Example: "2023-12-07"
    /// </summary>
    [JsonProperty("gameDate")]
    public string GameDate { get; set; }

    /// <summary>
    /// The number of games started in the NHL game <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("gamesStarted")]
    public int GamesStarted { get; set; }

    /// <summary>
    /// The decision of the NHL game <br/>
    /// Example: "W" - Win, "L" - Loss, "O" - Overtime Loss
    /// </summary>
    [JsonProperty("decision")]
    public string Decision { get; set; }

    /// <summary>
    /// The number of shots against in the NHL game <br/>
    /// Example: 43
    /// </summary>
    [JsonProperty("shotsAgainst")]
    public int ShotsAgainst { get; set; }

    /// <summary>
    /// The number of goals against in the NHL game <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("goalsAgainst")]
    public int GoalsAgainst { get; set; }

    /// <summary>
    /// The save percentage in the NHL game <br/>
    /// Example: 0.930233
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal SavePctg { get; set; }

    /// <summary>
    /// The number of penalty minutes in the NHL game <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("penaltyMins")]
    public int PenaltyMins { get; set; }

    /// <summary>
    /// The NHL opponent team abbreviation <br/>
    /// Example; "OTT" - Ottawa Senators
    /// </summary>
    [JsonProperty("opponentAbbrev")]
    public string OpponentAbbrev { get; set; }

    /// <summary>
    /// The number of minutes of time on the ice played in the NHL game <br/>
    /// Example: "60:00"
    /// </summary>
    [JsonProperty("toi")]
    public string Toi { get; set; }
}
