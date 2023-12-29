using Newtonsoft.Json;
using Nhl.Api.Models.Player;
using System.Collections.Generic;

namespace Nhl.Api.Models.Team
{

    /// <summary>
    /// The NHL team goalie's and their team statistics 
    /// </summary>
    public class TeamStatisticGoalie
    {

        /// <summary>
        /// The NHL team goalie player id <br/>
        /// Example: 8477465
        /// </summary>
        [JsonProperty("playerId")]
        public int PlayerId { get; set; }

        /// <summary>
        /// The NHL team goalie player headshot url <br/>
        /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/TOR/8470966.png">https://assets.nhle.com/mugs/nhl/20232024/TOR/8470966.png</a>
        /// </summary>
        [JsonProperty("headshot")]
        public string Headshot { get; set; }

        /// <summary>
        /// The NHL team goalie player first name <br/>
        /// Example: Frederik
        /// </summary>
        [JsonProperty("firstName")]
        public FirstName FirstName { get; set; }

        /// <summary>
        /// The NHL team goalie player last name <br/>
        /// Example: Andersen
        /// </summary>
        [JsonProperty("lastName")]
        public LastName LastName { get; set; }

        /// <summary>
        /// The NHL team goalie player number of games played <br/>
        /// Example: 60
        /// </summary>
        [JsonProperty("gamesPlayed")]
        public int GamesPlayed { get; set; }

        /// <summary>
        /// The NHL team goalie player number of games started <br/>
        /// Example: 60
        /// </summary>
        [JsonProperty("gamesStarted")]
        public int GamesStarted { get; set; }

        /// <summary>
        /// The NHL team goalie player number of wins <br/>
        /// Example: 36
        /// </summary>
        [JsonProperty("wins")]
        public int Wins { get; set; }

        /// <summary>
        /// The NHL team goalie player number of losses <br/>
        /// Example: 16
        /// </summary>
        [JsonProperty("losses")]
        public int Losses { get; set; }

        /// <summary>
        /// The NHL team goalie player number of ties <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("ties")]
        public int Ties { get; set; }

        /// <summary>
        /// The NHL team goalie player number of overtime losses <br/>
        /// Example: 6
        /// </summary>
        [JsonProperty("overtimeLosses")]
        public int OvertimeLosses { get; set; }

        /// <summary>
        /// The NHL team goalie player number of goals against <br/>
        /// Example: 2.55093
        /// </summary>
        [JsonProperty("goalsAgainstAverage")]
        public decimal GoalsAgainstAverage { get; set; }

        /// <summary>
        /// The NHL team goalie save percentage <br/>
        /// Example: 0.909825
        /// </summary>
        [JsonProperty("savePercentage")]
        public decimal SavePercentage { get; set; }

        /// <summary>
        /// The NHL goalie number of shots against <br/>
        /// Example: 114
        /// </summary>
        [JsonProperty("shotsAgainst")]
        public int ShotsAgainst { get; set; }

        /// <summary>
        /// The NHL goalie number of saves <br/>
        /// Example: 124
        /// </summary>
        [JsonProperty("saves")]
        public int Saves { get; set; }

        /// <summary>
        /// The NHL goalie number of goals against <br/>
        /// Example: 41
        /// </summary>
        [JsonProperty("goalsAgainst")]
        public int GoalsAgainst { get; set; }

        /// <summary>
        /// The NHL team goalie player number of shutouts <br/>
        /// Example: 4
        /// </summary>
        [JsonProperty("shutouts")]
        public int Shutouts { get; set; }

        /// <summary>
        /// The NHL team goalie number of goals <br/>
        /// Example: 0
        /// </summary>
        [JsonProperty("goals")]
        public int Goals { get; set; }

        /// <summary>
        /// The NHL team goalie number of assists <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// The NHL team goalie number of points <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        /// The NHL team goalie number of penalty minutes <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("penaltyMinutes")]
        public int PenaltyMinutes { get; set; }

        /// <summary>
        /// The NHL team goalie number of seconds on ice <br/>
        /// Example: 52793
        /// </summary>
        [JsonProperty("timeOnIce")]
        public int TimeOnIce { get; set; }
    }

    /// <summary>
    /// The NHL team statistics for the season and game type including the skaters and goalies
    /// </summary>
    public class TeamSeasonStatistics
    {
        /// <summary>
        /// The NHL team statistics season <br/>
        /// Example: 20232024
        /// </summary>
        [JsonProperty("season")]
        public string Season { get; set; }

        /// <summary>
        /// The NHL team statistics game type <br/>
        /// Example: 2 - Regular season or 3 - Playoffs
        /// </summary>
        [JsonProperty("gameType")]
        public int GameType { get; set; }

        /// <summary>
        /// The collection of NHL team skaters and their statistics for the team and the season and game type
        /// </summary>
        [JsonProperty("skaters")]
        public List<TeamStatisticSkater> Skaters { get; set; }

        /// <summary>
        /// The collection of NHL team goalies and their statistics for the team and the season and game type
        /// </summary>
        [JsonProperty("goalies")]
        public List<TeamStatisticGoalie> Goalies { get; set; }
    }

    /// <summary>
    /// The NHL team skaters's and their team statistics 
    /// </summary>
    public class TeamStatisticSkater
    {
        /// <summary>
        /// The NHL player id for the skater <br/>
        /// Example: 8471675
        /// </summary>
        [JsonProperty("playerId")]
        public int PlayerId { get; set; }

        /// <summary>
        /// The NHL player headshot url for the skater <br/>
        /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/PIT/8471675.png">https://assets.nhle.com/mugs/nhl/20232024/PIT/8471675.png</a>
        /// </summary>
        [JsonProperty("headshot")]
        public string Headshot { get; set; }

        /// <summary>
        /// The NHL player first name for the skater <br/>
        /// Example: Sidney
        /// </summary>
        [JsonProperty("firstName")]
        public FirstName FirstName { get; set; }

        /// <summary>
        /// The NHL player last name for the skater <br/>
        /// Example: Crosby
        /// </summary>
        [JsonProperty("lastName")]
        public LastName LastName { get; set; }

        /// <summary>
        /// The NHL player position code for the skater <br/>
        /// Example: C - Center
        /// </summary>
        [JsonProperty("positionCode")]
        public string PositionCode { get; set; }

        /// <summary>
        /// The NHL player number of games played for the skater <br/>
        /// Example: 55
        /// </summary>
        [JsonProperty("gamesPlayed")]
        public int GamesPlayed { get; set; }

        /// <summary>
        /// The NHL player number of goals for the skater <br/>
        /// Example: 29
        /// </summary>
        [JsonProperty("goals")]
        public int Goals { get; set; }

        /// <summary>
        /// The NHL player number of assists for the skater <br/>
        /// Example: 39
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// The NHL player number of points for the skater <br/>
        /// Example: 68
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        /// The NHL player plus minus for the skater <br/>
        /// Example: 18
        /// </summary>
        [JsonProperty("plusMinus")]
        public int PlusMinus { get; set; }

        /// <summary>
        /// The NHL player number of penalty minutes for the skater <br/>
        /// Example: 24
        /// </summary>
        [JsonProperty("penaltyMinutes")]
        public int PenaltyMinutes { get; set; }

        /// <summary>
        /// The NHL player number of power play goals for the skater <br/>
        /// Example: 9
        /// </summary>
        [JsonProperty("powerPlayGoals")]
        public int PowerPlayGoals { get; set; }

        /// <summary>
        /// The NHL player number of short handed goals for the skater <br/>
        /// Example: 0
        /// </summary>
        [JsonProperty("shorthandedGoals")]
        public int ShorthandedGoals { get; set; }

        /// <summary>
        /// The NHL player number of game winning goals for the skater <br/>
        /// Example: 4
        /// </summary>
        [JsonProperty("gameWinningGoals")]
        public int GameWinningGoals { get; set; }

        /// <summary>
        /// The NHL player number of overtime goals for the skater <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("overtimeGoals")]
        public int OvertimeGoals { get; set; }

        /// <summary>
        /// The NHL player number of shots for the skater <br/>
        /// Example: 146
        /// </summary>
        [JsonProperty("shots")]
        public int Shots { get; set; }

        /// <summary>
        /// The NHL player shooting percentage for the skater <br/>
        /// Example: 0.119048
        /// </summary>
        [JsonProperty("shootingPctg")]
        public decimal ShootingPctg { get; set; }

        /// <summary>
        /// The NHL player average time on ice per game for the skater <br/>
        /// Example: 1229.5172
        /// </summary>
        [JsonProperty("avgTimeOnIcePerGame")]
        public decimal AvgTimeOnIcePerGame { get; set; }

        /// <summary>
        /// The NHL player average shifts per game for the skater <br/>
        /// Example: 23.069
        /// </summary>
        [JsonProperty("avgShiftsPerGame")]
        public decimal AvgShiftsPerGame { get; set; }

        /// <summary>
        /// The NHL player faceoff win percentage for the skater <br/>
        /// Example: 0.514161
        /// </summary>
        [JsonProperty("faceoffWinPctg")]
        public decimal FaceoffWinPctg { get; set; }
    }
}
