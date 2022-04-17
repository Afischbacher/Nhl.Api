using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
    /// <summary>
    /// Provides links to NHL game ticket providers for NHL games
    /// </summary>
    public class Ticket
    {
        /// <summary>
        /// This provides information about the NHL game ticket type
        /// </summary>
        [JsonProperty("ticketType")]
        public string TicketType { get; set; }

        /// <summary>
        /// This provides information about the ticket link to purchase an NHL game ticket
        /// </summary>
        [JsonProperty("ticketLink")]
        public string TicketLink { get; set; }
    }
}
