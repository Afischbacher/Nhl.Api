using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Models.Enumerations.Prospect
{
    /// <summary>
    /// An NHL enum prospect helper for retrieving NHL prospects
    /// </summary>
    public static class ProspectEnumHelper
    {
        /// <summary>
        /// A method for retrieving all current NHL prospects
        /// </summary>
        /// <returns>Returns a collection of NHL prospect profiles</returns>
        public static List<ProspectProfile> GetAllProspects()
        {
            var nhlStatsApiHttpClient = new Api.Common.Http.NhlStatsApiHttpClient();

            return nhlStatsApiHttpClient.GetAsync<LeagueProspects>("/draft/prospects").Result.ProspectProfiles;
        }
    }
}
