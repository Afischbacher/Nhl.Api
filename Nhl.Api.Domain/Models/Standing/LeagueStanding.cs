using Newtonsoft.Json;
using Nhl.Api.Models.Team;
using System.Collections.Generic;

namespace Nhl.Api.Models.Standing;

/// <summary>
/// The NHL place name for the team
/// </summary>
public class PlaceName
{
    /// <summary>
    /// The NHL place name in English
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }

    /// <summary>
    /// The NHL place name in French
    /// </summary>
    [JsonProperty("fr")]
    public string Fr { get; set; }
}

/// <summary>
/// The NHL league standing information
/// </summary>
public class LeagueStanding
{
    /// <summary>
    /// The NHL league wild card indicator <br/>
    /// Example: true or false
    /// </summary>
    [JsonProperty("wildCardIndicator")]
    public bool WildCardIndicator { get; set; }

    /// <summary>
    /// A list of the NHL team standings for the league
    /// </summary>
    [JsonProperty("standings")]
    public List<Standing> Standings { get; set; }
}

/// <summary>
/// The NHL team standing information for a specific team
/// </summary>
public class Standing
{
    /// <summary>
    /// The NHL team conference abbreviation <br/>  
    /// Example: W - Western Conference
    /// </summary>
    [JsonProperty("conferenceAbbrev")]
    public string ConferenceAbbrev { get; set; }

    /// <summary>
    /// The NHL team conference home sequence <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("conferenceHomeSequence")]
    public int ConferenceHomeSequence { get; set; }

    /// <summary>
    /// The NHL team conference L10 sequence <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("conferenceL10Sequence")]
    public int ConferenceL10Sequence { get; set; }

    /// <summary>
    /// The NHL team conference name <br/>
    /// Example: Western
    /// </summary>
    [JsonProperty("conferenceName")]
    public string ConferenceName { get; set; }

    /// <summary>
    /// The NHL team conference road sequence <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("conferenceRoadSequence")]
    public int ConferenceRoadSequence { get; set; }

    /// <summary>
    /// The NHL team conference sequence <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("conferenceSequence")]
    public int ConferenceSequence { get; set; }

    /// <summary>
    /// The NHL team date for the standings <br/>
    /// Example: 2023-12-10
    /// </summary>
    [JsonProperty("date")]
    public string Date { get; set; }

    /// <summary>
    /// The NHL team division abbreviation <br/>
    /// Example P - Pacific Division
    /// </summary>
    [JsonProperty("divisionAbbrev")]
    public string DivisionAbbrev { get; set; }

    /// <summary>
    /// The NHL team division home sequence <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("divisionHomeSequence")]
    public int DivisionHomeSequence { get; set; }

    /// <summary>
    /// The NHL team division L10 sequence <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("divisionL10Sequence")]
    public int DivisionL10Sequence { get; set; }

    /// <summary>
    /// The NHL team division name <br/>
    /// Example: Pacific
    /// </summary>
    [JsonProperty("divisionName")]
    public string DivisionName { get; set; }

    /// <summary>
    /// The NHL team division road sequence <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("divisionRoadSequence")]
    public int DivisionRoadSequence { get; set; }

    /// <summary>
    /// The NHL team division sequence <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("divisionSequence")]
    public int DivisionSequence { get; set; }

    /// <summary>
    /// The NHL team game type identifier for the standings <br/>
    /// Example: 2 - Regular Season
    /// </summary>
    [JsonProperty("gameTypeId")]
    public int GameTypeId { get; set; }

    /// <summary>
    /// The NHL team games played in the season <br/>
    /// Example: 29
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The NHL team goal differential <br/>
    /// Example: 31
    /// </summary>
    [JsonProperty("goalDifferential")]
    public int GoalDifferential { get; set; }

    /// <summary>
    /// The NHL team goal differential percentage <br/>
    /// Example: 1.068966
    /// </summary>
    [JsonProperty("goalDifferentialPctg")]
    public decimal GoalDifferentialPctg { get; set; }

    /// <summary>
    /// The NHL team goals against <br/>
    /// Example: 75
    /// </summary>
    [JsonProperty("goalAgainst")]
    public int GoalAgainst { get; set; }

    /// <summary>
    /// The NHL team goals for <br/>
    /// Example: 106
    /// </summary>
    [JsonProperty("goalFor")]
    public int GoalFor { get; set; }

    /// <summary>
    /// The NHL team goals for percentage <br/>
    /// Example: 3.448276
    /// </summary>
    [JsonProperty("goalsForPctg")]
    public decimal GoalsForPctg { get; set; }

    /// <summary>
    /// The NHL team number of home games played <br/>
    /// Example: 14
    /// </summary>
    [JsonProperty("homeGamesPlayed")]
    public int HomeGamesPlayed { get; set; }

    /// <summary>
    /// The NHL team home goal differential <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("homeGoalDifferential")]
    public int HomeGoalDifferential { get; set; }

    /// <summary>
    /// The NHL team home goals against <br/>
    /// Example: 33
    /// </summary>
    [JsonProperty("homeGoalsAgainst")]
    public int HomeGoalsAgainst { get; set; }

    /// <summary>
    /// The NHL team home goals for <br/>
    /// Example: 48
    /// </summary>
    [JsonProperty("homeGoalsFor")]
    public int HomeGoalsFor { get; set; }

    /// <summary>
    /// The NHL team home losses <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("homeLosses")]
    public int HomeLosses { get; set; }

    /// <summary>
    /// The NHL team home overtime losses <br/>
    /// Example: 1
    /// </summary>  
    [JsonProperty("homeOtLosses")]
    public int HomeOtLosses { get; set; }

    /// <summary>
    /// The NHL team home points <br/>
    /// Example: 31
    /// </summary>
    [JsonProperty("homePoints")]
    public int HomePoints { get; set; }

    /// <summary>
    /// The NHL team home regulation plus overtime wins <br/>
    /// Example: 12
    /// </summary>
    [JsonProperty("homeRegulationPlusOtWins")]
    public int HomeRegulationPlusOtWins { get; set; }

    /// <summary>
    /// The NHL team home regulation wins <br/>
    /// Example: 12
    /// </summary>
    [JsonProperty("homeRegulationWins")]
    public int HomeRegulationWins { get; set; }

    /// <summary>
    /// The NHL team home ties <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("homeTies")]
    public int HomeTies { get; set; }

    /// <summary>
    /// The NHL team home wins <br/>
    /// Example: 12
    /// </summary>
    [JsonProperty("homeWins")]
    public int HomeWins { get; set; }

    /// <summary>
    /// The NHL team last 10 games played <br/>
    /// Example: 10
    /// </summary>
    [JsonProperty("l10GamesPlayed")]
    public int L10GamesPlayed { get; set; }

    /// <summary>
    /// The NHL team last 10 games goal differential <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("l10GoalDifferential")]
    public int L10GoalDifferential { get; set; }

    /// <summary>
    /// The NHL team last 10 games goals against <br/>
    /// Example: 33
    /// </summary>
    [JsonProperty("l10GoalsAgainst")]
    public int L10GoalsAgainst { get; set; }

    /// <summary>
    /// Te NHL team last 10 games goals for <br/>
    /// Example: 48
    /// </summary>
    [JsonProperty("l10GoalsFor")]
    public int L10GoalsFor { get; set; }

    /// <summary>
    /// The NHL team last 10 games losses <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("l10Losses")]
    public int L10Losses { get; set; }

    /// <summary>
    /// The NHL team last 10 games overtime losses <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("l10OtLosses")]
    public int L10OtLosses { get; set; }

    /// <summary>
    /// The NHL team last 10 games points <br/>
    /// Example: 12
    /// </summary>
    [JsonProperty("l10Points")]
    public int L10Points { get; set; }

    /// <summary>
    /// The NHL team last 10 games regulation plus overtime wins <br/>
    /// Example: 7
    /// </summary>
    [JsonProperty("l10RegulationPlusOtWins")]
    public int L10RegulationPlusOtWins { get; set; }

    /// <summary>
    /// The NHL team last 10 games regulation wins <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("l10RegulationWins")]
    public int L10RegulationWins { get; set; }

    /// <summary>
    /// The NHL team last 10 games ties <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("l10Ties")]
    public int L10Ties { get; set; }

    /// <summary>
    /// The NHL team last 10 games wins <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("l10Wins")]
    public int L10Wins { get; set; }

    /// <summary>
    /// The NHL team league home sequence <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("leagueHomeSequence")]
    public int LeagueHomeSequence { get; set; }

    /// <summary>
    /// The NHL team league L10 sequence <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("leagueL10Sequence")]
    public int LeagueL10Sequence { get; set; }

    /// <summary>
    /// The NHL team league road sequence for the NHL team <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("leagueRoadSequence")]
    public int LeagueRoadSequence { get; set; }

    /// <summary>
    /// The NHL team league sequence <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("leagueSequence")]
    public int LeagueSequence { get; set; }

    /// <summary>
    /// The NHL team number of losses <br/>
    /// Example: 6
    /// </summary>
    [JsonProperty("losses")]
    public int Losses { get; set; }

    /// <summary>
    /// The NHL team number of overtime losses <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("otLosses")]
    public int OtLosses { get; set; }

    /// <summary>
    /// The NHL team place name <br/>
    /// Example: NY Rangers
    /// </summary>
    [JsonProperty("placeName")]
    public PlaceName PlaceName { get; set; }

    /// <summary>
    /// The NHL team point percentage <br/>
    /// Example:  0.75
    /// </summary>
    [JsonProperty("pointPctg")]
    public double PointPctg { get; set; }

    /// <summary>
    /// The NHL team number of points <br/>
    /// Example: 37
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The NHL team percentage of regulation plus overtime wins <br/>
    /// Example: 0.692308
    /// </summary>
    [JsonProperty("regulationPlusOtWinPctg")]
    public decimal RegulationPlusOtWinPctg { get; set; }

    /// <summary>
    /// The NHL team number of regulation plus overtime wins <br/>
    /// Example: 18
    /// </summary>
    [JsonProperty("regulationPlusOtWins")]
    public int RegulationPlusOtWins { get; set; }

    /// <summary>
    /// The NHL team regulation win percentage <br/>
    /// Example: 0.615385
    /// </summary>
    [JsonProperty("regulationWinPctg")]
    public decimal RegulationWinPctg { get; set; }

    /// <summary>
    /// The NHL team number of regulation wins <br/>
    /// Example: 16
    /// </summary>
    [JsonProperty("regulationWins")]
    public int RegulationWins { get; set; }

    /// <summary>
    /// The NHL team number of road games played <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("roadGamesPlayed")]
    public int RoadGamesPlayed { get; set; }

    /// <summary>
    /// The NHL team road goal differential <br/>
    /// Example: 16
    /// </summary>
    [JsonProperty("roadGoalDifferential")]
    public int RoadGoalDifferential { get; set; }

    /// <summary>
    /// The NHL team road goals against <br/>
    /// Example: 42
    /// </summary>
    [JsonProperty("roadGoalsAgainst")]
    public int RoadGoalsAgainst { get; set; }

    /// <summary>
    /// The NHL team road goals for <br/>
    /// Example: 58
    /// </summary>
    [JsonProperty("roadGoalsFor")]
    public int RoadGoalsFor { get; set; }

    /// <summary>
    /// The NHL team road losses <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("roadLosses")]
    public int RoadLosses { get; set; }

    /// <summary>
    /// The NHL team road overtime losses <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("roadOtLosses")]
    public int RoadOtLosses { get; set; }

    /// <summary>
    /// The NHL team road points <br/>
    /// Example: 18
    /// </summary>
    [JsonProperty("roadPoints")]
    public int RoadPoints { get; set; }

    /// <summary>
    /// The NHL team road regulation plus overtime wins <br/>
    /// Example: 6
    /// </summary>
    [JsonProperty("roadRegulationPlusOtWins")]
    public int RoadRegulationPlusOtWins { get; set; }

    /// <summary>
    /// The NHL team road regulation wins <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("roadRegulationWins")]
    public int RoadRegulationWins { get; set; }

    /// <summary>
    /// The NHL team road ties <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("roadTies")]
    public int RoadTies { get; set; }

    /// <summary>
    /// The NHL team road wins <br/>
    /// Example: 6
    /// </summary>
    [JsonProperty("roadWins")]
    public int RoadWins { get; set; }

    /// <summary>
    /// The NHL team season identifier <br/>
    /// Example: 20202021
    /// </summary>
    [JsonProperty("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// The NHL team shootout losses <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("shootoutLosses")]
    public int ShootoutLosses { get; set; }

    /// <summary>
    /// The NHL team shootout wins <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("shootoutWins")]
    public int ShootoutWins { get; set; }

    /// <summary>
    /// The NHL team streak code <br/>
    /// Example: W - Win or L - Loss
    /// </summary>
    [JsonProperty("streakCode")]
    public string StreakCode { get; set; }

    /// <summary>
    /// The NHL team streak number <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("streakCount")]
    public int StreakCount { get; set; }

    /// <summary>
    /// The NHL team name <br/>
    /// Example: New York Rangers
    /// </summary>
    [JsonProperty("teamName")]
    public TeamName TeamName { get; set; }

    /// <summary>
    /// The NHL team common name <br/>
    /// Example: Rangers
    /// </summary>
    [JsonProperty("teamCommonName")]
    public TeamCommonName TeamCommonName { get; set; }

    /// <summary>
    /// The NHL team abbreviation <br/>
    /// Example: NYR
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public TeamAbbrev TeamAbbrev { get; set; }

    /// <summary>
    /// The NHL team url link for the team logo <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/NYR_light.svg">https://assets.nhle.com/logos/nhl/svg/NYR_light.svg</a>
    /// </summary>
    [JsonProperty("teamLogo")]
    public string TeamLogo { get; set; }

    /// <summary>
    /// The NHL team number of ties <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("ties")]
    public int Ties { get; set; }

    /// <summary>
    /// The NHL teams waivers sequence <br/>
    /// Example: 12
    /// </summary>
    [JsonProperty("waiversSequence")]
    public int WaiversSequence { get; set; }

    /// <summary>
    /// The NHL team wild card sequence <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("wildcardSequence")]
    public int WildcardSequence { get; set; }

    /// <summary>
    /// The NHL team winning percentage <br/>
    /// Example: 0.730769
    /// </summary>
    [JsonProperty("winPctg")]
    public double WinPctg { get; set; }

    /// <summary>
    /// The NHL team number of wins <br/>
    /// Example: 19
    /// </summary>
    [JsonProperty("wins")]
    public int Wins { get; set; }
}

/// <summary>
/// The NHL team name abbreviation
/// </summary>
public class TeamAbbrev
{
    /// <summary>
    /// The NHL team name abbreviation in English
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }
}

/// <summary>
/// The NHL team common name
/// </summary>
public class TeamCommonName
{
    /// <summary>
    /// The NHL team common name in English
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }

    /// <summary>
    /// The NHL team common name in French
    /// </summary>
    [JsonProperty("fr")]
    public string Fr { get; set; }
}
