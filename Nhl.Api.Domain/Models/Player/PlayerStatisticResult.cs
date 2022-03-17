using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Player Statistics Result
    /// </summary>
    public class PlayerStatisticResult
    {
        /// <summary>
        /// Returns NHL player information including identifier, name, date of birth and more
        /// </summary>
        [JsonProperty("player")]
        public Player Player { get; set; }

        /// <summary>
        /// Returns statistics about a specific player including shots, goals, points, assists, blocked shots, penalty minutes and more
        /// </summary>
        [JsonProperty("playerStatisticsData")]
        public PlayerStatisticsData PlayerStatisticsData { get; set; }

    }
}
