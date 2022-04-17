namespace Nhl.Api.Models.Game
{
    /// <summary>
    /// A configuration for the NHL game schedule to include various points of additional information
    /// </summary>
    public class GameScheduleConfiguration
    {
        /// <summary>
        /// Includes the line score to the NHL scheduled games, default value is false
        /// </summary>
        public bool IncludeLinescore { get; set; } = false;

        /// <summary>
        /// Includes the broadcast information to the NHL scheduled games, default value is false
        /// </summary>
        public bool IncludeBroadcasts { get; set; } = false;

        /// <summary>
        /// Includes the ticket purchasing options for the NHL scheduled games, default value is false
        /// </summary>
        public bool IncludeTicketPurchasingOptions { get; set; } = false;

    }
}
