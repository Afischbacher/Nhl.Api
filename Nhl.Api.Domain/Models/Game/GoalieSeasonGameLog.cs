using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game;


/// <summary>
/// An NHL goalie's game log information for a specific season, game type and player
/// </summary>
public class GoalieSeasonGameLog
{
    /// <summary>
    /// The season identifier for the NHL season for the NHL golie season game log <br/>
    /// Example: 20202021 for the 2020-2021 NHL season
    /// </summary>
    [JsonProperty("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// The game type identifier for the NHL goalie season game log <br/>
    /// Example: 2 for the regular season or 3 for the playoffs
    /// </summary>
    [JsonProperty("gameTypeId")]
    public int GameTypeId { get; set; }

    /// <summary>
    /// The goalie player collection of seasons and game types played for the NHL season <br/>
    /// Example:
    /// <code>
    ///   "playerStatsSeasons": [
    ///          {
    ///              "season": 20232024,
    ///              "gameTypes": [
    ///                  2
    ///              ]
    ///      },
    ///          {
    ///              "season": 20222023,
    ///              "gameTypes": [
    ///                  2,
    ///                  3
    ///              ]
    ///  },
    ///          {
    ///      "season": 20212022,
    ///              "gameTypes": [
    ///                  2
    ///              ]
    ///          }
    ///      ]
    /// </code>
    /// </summary>

    [JsonProperty("playerStatsSeasons")]
    public List<PlayerStatsSeason> GoalieStatsSeasons { get; set; }

    /// <summary>
    /// The collection of goalie game logs for the NHL season for an NHL goalie <br/>
    /// Example: 
    /// <code>
    ///  {
    ///      "gameId": 2022021167,
    ///      "teamAbbrev": "TOR",
    ///      "homeRoadFlag": "R",
    ///      "gameDate": "2023-03-26",
    ///      "goals": 0,
    ///      "assists": 0,
    ///      "commonName": {
    ///          "default": "Maple Leafs"
    ///      },
    ///      "opponentCommonName": {
    ///          "default": "Predators"
    ///      },
    ///      "gamesStarted": 1,
    ///      "decision": "W",
    ///      "shotsAgainst": 25,
    ///      "goalsAgainst": 2,
    ///      "savePctg": 0.92,
    ///      "shutouts": 0,
    ///      "opponentAbbrev": "NSH",
    ///      "pim": 0,
    ///      "toi": "59:55"
    ///  }
    /// </code>
    /// </summary>
    [JsonProperty("gameLog")]
    public List<GoalieGameLog> GoalieGameLogs { get; set; }
}

/// <summary>
/// A goalie's game log information for a specific game, season, game type and player <br/> 
/// includes stats such as wins, losses, goals against, save percentage and more 
/// </summary>
public class GoalieGameLog
{
    /// <summary>
    /// The NHL game id for the game a goalie played in <br/>
    /// Example: 2022021292
    /// </summary>
    [JsonProperty("gameId")]
    public int GameId { get; set; }

    /// <summary>
    /// The NHL team abbreviation for the team a goalie plays for <br/>
    /// Example: "EDM"
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public string TeamAbbrev { get; set; }

    /// <summary>
    /// The NHL team home or road flag for the team <br/>
    /// Example: "H" or "R" for "Home" or "Road"
    /// </summary>
    [JsonProperty("homeRoadFlag")]
    public string HomeRoadFlag { get; set; }

    /// <summary>
    /// The NHL game date for the game a player played in <br/>
    /// Example: "2023-11-13"
    /// </summary>
    [JsonProperty("gameDate")]
    public string GameDate { get; set; }

    /// <summary>
    /// The number of goals a player scored in the game <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The number of assists a player scored in the game <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The common name for the team a player plays for <br/>
    /// Example: "Maple Leafs"
    /// </summary>
    [JsonProperty("commonName")]
    public CommonName CommonName { get; set; }

    /// <summary>
    /// The opponent team common name information for the team a player plays against <br/>
    /// Example: "Canucks"
    /// </summary>
    [JsonProperty("opponentCommonName")]
    public OpponentCommonName OpponentCommonName { get; set; }

    /// <summary>
    /// The number of games a player started in the game <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("gamesStarted")]
    public int GamesStarted { get; set; }

    /// <summary>
    /// The outcome of the game for the goalie <br/>
    /// Example: W for win, L for loss, O for overtime
    /// </summary>
    [JsonProperty("decision")]
    public string Decision { get; set; }

    /// <summary>
    /// The number of shots against the goalie <br/>
    /// Example: 32
    /// </summary>
    [JsonProperty("shotsAgainst")]
    public int ShotsAgainst { get; set; }

    /// <summary>
    /// The number of goals against the goalie <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("goalsAgainst")]
    public int GoalsAgainst { get; set; }

    /// <summary>
    /// The save percentage for the goalie <br/>
    /// Example: 0.909091
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal SavePctg { get; set; }

    /// <summary>
    /// The number of shutouts for the goalie <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("shutouts")]
    public int Shutouts { get; set; }

    /// <summary>
    /// The oppenent team abbreviation for the team a player plays against <br/>
    /// Example: "VAN"
    /// </summary>
    [JsonProperty("opponentAbbrev")]
    public string OpponentAbbrev { get; set; }

    /// <summary>
    /// The number of penalty minutes a player received in the game <br/>
    /// Example : 2
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The total number of time on ice a player played in the game <br/>
    /// Example: "20:00"
    /// </summary>
    [JsonProperty("toi")]
    public string Toi { get; set; }
}
