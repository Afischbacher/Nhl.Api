using Newtonsoft.Json;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL goalie season statistics split for each season year by year
    /// </summary>
    public class GoalieSeasonStatisticsSplitYearByYear : GoalieSeasonStatisticsSplit
    {
        /// <summary>
        /// Information about the NHL team for the NHL goalie
        /// </summary>
        [JsonProperty("team")]
        public TeamInformation Team { get; set; }

        /// <summary>
        /// Information about the league for the NHL goalie
        /// </summary>
        [JsonProperty("league")]
        public League.League League { get; set; }

        /// <summary>
        /// Information about the sequence number of the year by year statistics for the NHL goalie
        /// </summary>
        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }
    }
}
