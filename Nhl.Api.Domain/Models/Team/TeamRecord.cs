using System;
using Newtonsoft.Json;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Standing;

namespace Nhl.Api.Models.Team
{
    public class TeamRecord
    {
        /// <summary>
        /// Information about the NHL team within the NHL record
        /// </summary>
        [JsonProperty("team")]
        public TeamInformation Team { get; set; }

        /// <summary>
        /// The league record for the NHL team
        /// </summary>
        [JsonProperty("leagueRecord")]
        public LeagueRecord LeagueRecord { get; set; }

        /// <summary>
        /// The number of NHL regulation wins
        /// </summary>
        [JsonProperty("regulationWins")]
        public int RegulationWins { get; set; }

        /// <summary>
        /// The total number of NHL goals against
        /// </summary>
        [JsonProperty("goalsAgainst")]
        public int GoalsAgainst { get; set; }

        /// <summary>
        /// The total number of NHL goals scored
        /// </summary>
        [JsonProperty("goalsScored")]
        public int GoalsScored { get; set; }

        /// <summary>
        /// The total number of NHL league points
        /// </summary>
        [JsonProperty("points")]
        public int Points { get; set; }

        /// <summary>
        /// The division rank in the NHL team
        /// </summary>
        [JsonProperty("divisionRank")]
        public string DivisionRank { get; set; }

        /// <summary>
        /// The division rank in the NHL team for the last 10 NHL games
        /// </summary>
        [JsonProperty("divisionL10Rank")]
        public string DivisionL10Rank { get; set; }

        /// <summary>
        /// The division rank in the NHL team for the teams road games
        /// </summary>
        [JsonProperty("divisionRoadRank")]
        public string DivisionRoadRank { get; set; }

        /// <summary>
        /// The division rank in the NHL team for the teams home games
        /// </summary>
        [JsonProperty("divisionHomeRank")]
        public string DivisionHomeRank { get; set; }

        /// <summary>
        /// The conference rank in the NHL team
        /// </summary>
        [JsonProperty("conferenceRank")]
        public string ConferenceRank { get; set; }

        /// <summary>
        /// The conference rank in the NHL for the last 10 NHL games
        /// </summary>
        [JsonProperty("conferenceL10Rank")]
        public string ConferenceL10Rank { get; set; }

        /// <summary>
        /// The conference rank in the NHL for the teams road games
        /// </summary>
        [JsonProperty("conferenceRoadRank")]
        public string ConferenceRoadRank { get; set; }

        /// <summary>
        /// The conference rank in the NHL for the teams home games
        /// </summary>
        [JsonProperty("conferenceHomeRank")]
        public string ConferenceHomeRank { get; set; }

        /// <summary>
        /// The league rank for the NHL team
        /// </summary>
        [JsonProperty("leagueRank")]
        public string LeagueRank { get; set; }

        /// <summary>
        /// The league rank for the NHL team within the last 10 NHL games
        /// </summary>
        [JsonProperty("leagueL10Rank")]
        public string LeagueL10Rank { get; set; }

        /// <summary>
        /// The league rank for the NHL team for the teams road games
        /// </summary>
        [JsonProperty("leagueRoadRank")]
        public string LeagueRoadRank { get; set; }

        /// <summary>
        /// The league rank for the NHL team for the teams home games
        /// </summary>
        [JsonProperty("leagueHomeRank")]
        public string LeagueHomeRank { get; set; }

        /// <summary>
        /// The wild rank card if applicable for the NHL team
        /// </summary>
        [JsonProperty("wildCardRank")]
        public string WildCardRank { get; set; }

        /// <summary>
        /// The row for the NHL team rank
        /// </summary>
        [JsonProperty("row")]
        public int Row { get; set; }

        /// <summary>
        /// The number of games played for the NHL team
        /// </summary>
        [JsonProperty("gamesPlayed")]
        public int GamesPlayed { get; set; }

        /// <summary>
        /// The NHL game streak for the NHL team
        /// </summary>
        [JsonProperty("streak")]
        public Streak Streak { get; set; }

        /// <summary>
        /// The NHL clich indicator for the NHL team <br/>
        /// Example: p
        /// </summary>
        [JsonProperty("clinchIndicator")]
        public string ClinchIndicator { get; set; }

        /// <summary>
        /// The NHL points percentage for the NHL team<br/>
        /// Example: 0.7321428571428571
        /// </summary>
        [JsonProperty("pointsPercentage")]
        public double PointsPercentage { get; set; }

        /// <summary>
        /// The NHL power play division rank <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("ppDivisionRank")]
        public string PpDivisionRank { get; set; }

        /// <summary>
        /// The NHL power play conference rank <br/>
        /// Example: 4
        /// </summary>
        [JsonProperty("ppConferenceRank")]
        public string PpConferenceRank { get; set; }

        /// <summary>
        /// The NHL power play conference rank <br/>
        /// Example: 15
        /// </summary>
        [JsonProperty("ppLeagueRank")]
        public string PpLeagueRank { get; set; }

        /// <summary>
        /// The timestamp for the last updated information
        /// </summary>
        [JsonProperty("lastUpdated")]
        public DateTime LastUpdated { get; set; }
    }

}
