using Newtonsoft.Json;
using Nhl.Api.Models.Game;

namespace Nhl.Api.Models.Team
{
    /// <summary>
    /// The NHL home and away teams
    /// </summary>
    public class Teams
    {
        /// <summary>
        /// The NHL away team
        /// </summary>
        [JsonProperty("away")]
        public AwayTeam AwayTeam { get; set; }

        /// <summary>
        /// The NHL home team
        /// </summary>
        [JsonProperty("home")]
        public HomeTeam HomeTeam { get; set; }
    }

}
