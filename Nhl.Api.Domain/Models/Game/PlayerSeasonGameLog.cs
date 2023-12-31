using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game
{
    /// <summary>
    /// A players team common name for the team a player plays for
    /// </summary>
    public class CommonName
    {
        /// <summary>
        /// The default common name for the team a player plays for <br/>
        /// Example: "Oilers"
        /// </summary>
        [JsonProperty("default")]
        public string Default { get; set; }
    }

    /// <summary>
    /// A player's game log information with specific statistics for a specific season, game type and player, including <br/> 
    /// goals, assists, points, plus/minus, power play goals, power play points, game winning goals, overtime goals, shots, shifts, short handed goals, short handed points, penalty minutes and time on ice
    /// </summary>
    public class PlayerGameLog
    {
        /// <summary>
        /// The NHL game id for the game a player played in <br/>
        /// Example: 2022021292
        /// </summary>
        [JsonProperty("gameId")]
        public int GameId { get; set; }

        /// <summary>
        /// The NHL team abbreviation for the team a player plays for <br/>
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
        /// The number of points a player scored in the game <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        ///  The plus/minus statistic for a player in the game <br/>
        ///  Example: -1
        /// </summary>
        [JsonProperty("plusMinus")]
        public int PlusMinus { get; set; }

        /// <summary>
        /// The number of power play goals a player scored in the game <br/>
        /// Example: 0
        /// </summary>
        [JsonProperty("powerPlayGoals")]
        public int PowerPlayGoals { get; set; }

        /// <summary>
        /// The number of power play points a player scored in the game <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("powerPlayPoints")]
        public int PowerPlayPoints { get; set; }

        /// <summary>
        /// The number of game winning goals a player scored in the game <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("gameWinningGoals")]
        public int GameWinningGoals { get; set; }

        /// <summary>
        /// The number of overtime goals a player scored in the game <br/>
        /// Example: 0
        /// </summary>
        [JsonProperty("otGoals")]
        public int OtGoals { get; set; }

        /// <summary>
        /// The number of shots a player took in the game <br/>
        /// </summary>
        [JsonProperty("shots")]
        public int Shots { get; set; }

        /// <summary>
        /// The number of shifts a player took in the game <br/>
        /// Example: 23
        /// </summary>
        [JsonProperty("shifts")]
        public int Shifts { get; set; }

        /// <summary>
        /// The number of short handed goals a player scored in the game <br/>
        /// Example: 0
        /// </summary>
        [JsonProperty("shorthandedGoals")]
        public int ShorthandedGoals { get; set; }

        /// <summary>
        /// The number of short handed points a player scored in the game <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("shorthandedPoints")]
        public int ShorthandedPoints { get; set; }

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

    /// <summary>
    /// A player's opponent team common name information for a specific season, game type and player
    /// </summary>
    public class OpponentCommonName
    {
        /// <summary>
        /// The default common name for the opponent team a player plays against <br/>
        /// Example: "Sharks"
        /// </summary>
        [JsonProperty("default")]
        public string Default { get; set; }

        /// <summary>
        /// The French common name for the opponent team a player plays against <br/>
        /// Example: "Requins"
        /// </summary>
        [JsonProperty("fr")]
        public string Fr { get; set; }

        /// <summary>
        /// The Spanish common name for the opponent team a player plays against <br/>
        /// Example: "Tiburones"
        /// </summary>
        [JsonProperty("es")]
        public string Es { get; set; }
    }

    /// <summary>
    /// A player's game log information for a specific season and game type
    /// </summary>
    public class PlayerStatsSeason
    {
        /// <summary>
        /// The NHL season for the game log information <br/>
        /// Example: 20222023
        /// </summary>
        [JsonProperty("season")]
        public int Season { get; set; }

        /// <summary>
        /// The collection of game types for the game log information <br/>
        /// Example: [2,3]
        /// </summary>
        [JsonProperty("gameTypes")]
        public List<int> GameTypes { get; set; }

    }

    /// <summary>
    /// An NHL player's game log information for a specific season, game type and player
    /// </summary>
    public class PlayerSeasonGameLog
    {
        /// <summary>
        /// The season id for the player game log information <br/>
        /// Example: 20232024
        /// </summary>
        [JsonProperty("seasonId")]
        public int SeasonId { get; set; }

        /// <summary>
        /// The game type identifier for the player game log information <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("gameTypeId")]
        public int GameTypeId { get; set; }

        /// <summary>
        /// The collection for player statistics for the player game log information <br/>
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
        public List<PlayerStatsSeason> PlayerStatsSeasons { get; set; }

        /// <summary>
        /// The collection of player game logs including all the information
        /// for the player from each game based on the season and game type <br/>
        /// Example:
        /// <code>
        ///   {
        ///      "gameId": 2022020082,
        ///      "teamAbbrev": "TOR",
        ///      "homeRoadFlag": "R",
        ///      "gameDate": "2022-10-22",
        ///      "goals": 0,
        ///      "assists": 3,
        ///      "commonName": {
        ///          "default": "Maple Leafs"
        ///      },
        ///      "opponentCommonName": {
        ///          "default": "Jets"
        ///      },
        ///      "points": 3,
        ///      "plusMinus": 1,
        ///      "powerPlayGoals": 0,
        ///      "powerPlayPoints": 2,
        ///      "gameWinningGoals": 0,
        ///      "otGoals": 0,
        ///      "shots": 4,
        ///      "shifts": 22,
        ///      "shorthandedGoals": 0,
        ///      "shorthandedPoints": 0,
        ///      "opponentAbbrev": "WPG",
        ///      "pim": 0,
        ///      "toi": "19:27"
        ///  }
        ///  <br/>
        /// </code>
        /// </summary>
        [JsonProperty("gameLog")]
        public List<PlayerGameLog> PlayerGameLogs { get; set; }
    }

}
