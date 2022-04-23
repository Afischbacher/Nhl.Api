using Newtonsoft.Json;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Player Season Statistics Split 
    /// </summary>
    public class PlayerSeasonStatisticsSplitYearByYear : PlayerSeasonStatisticsSplit
    {
        /// <summary>
        /// Information about the NHL team for the NHL player
        /// </summary>
        [JsonProperty("team")]
        public TeamInformation Team { get; set; }

        /// <summary>
        /// Information about the league for the NHL player
        /// </summary>
        [JsonProperty("league")]
        public League.League League { get; set; }

        /// <summary>
        /// Information about the sequence number of the year by year statistic
        /// </summary>
        [JsonProperty("sequenceNumber")]
        public int SequenceNumber { get; set; }
    }
}
