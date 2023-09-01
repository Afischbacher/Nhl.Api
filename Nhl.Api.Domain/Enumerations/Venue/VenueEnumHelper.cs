using Nhl.Api.Models.Venue;
using System.Collections.Generic;
using System.Linq;

namespace Nhl.Api.Models.Enumerations.Team
{
    /// <summary>
    /// An NHL enumeration venue helper for retrieving NHL venues
    /// </summary>
    public static class VenueEnumHelper
    {
        /// <summary>
        /// A method for retrieving all current NHL venues
        /// </summary>
        /// <returns>Returns a collection of NHL venues</returns>
        public static IReadOnlyList<LeagueVenue> GetAllVenues()
        {
            var nhlStatsApiHttpClient = new Api.Common.Http.NhlStatsApiHttpClient();
            var nhlVenues = new List<LeagueVenue>();

            // No venue identifier for the Climate Pledge Arena for the Seattle Kraken
            var nhlVenueIds = new[]
            {
                5034,
                5145,
                5026,
                5027,
                5028,
                5054,
                5039,
                5081,
                5030,
                5031,
                5058,
                5059,
                5072,
                5073,
                5074,
                5075,
                5076,
                5100,
                5043,
                5046,
                5047,
                5172,
                5178,
                5085,
                5064,
                5066,
                5092,
                5094,
                5096,
                5098,
                5017,
                5019
            };

            foreach (var nhlVenueId in nhlVenueIds)
            {
                nhlVenues.Add(nhlStatsApiHttpClient.GetAsync<LeagueVenues>($"/venues/{nhlVenueId}").Result.Venues.FirstOrDefault());
            }

            return nhlVenues.Where(venue => venue != null).ToList();
        }
    }
}
