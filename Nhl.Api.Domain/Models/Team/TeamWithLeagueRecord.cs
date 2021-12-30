using Newtonsoft.Json;
using Nhl.Api.Models.Game;

namespace Nhl.Api.Models.Team
{
    /// <summary>
    /// An NHL team with a league record
    /// </summary>
    public abstract class TeamWithLeagueRecord
    {
        /// <summary>
        /// The NHL team league record
        /// </summary>
        [JsonProperty("leagueRecord")]
        public LeagueRecord LeagueRecord { get; set; }

        /// <summary>
        /// The NHL game score for the team
        /// </summary>
        [JsonProperty("score")]
        public int Score { get; set; }

        /// <summary>
        /// The current NHL team information
        /// </summary>
        [JsonProperty("team")]
        public CurrentTeam Team { get; set; }
    }
}
