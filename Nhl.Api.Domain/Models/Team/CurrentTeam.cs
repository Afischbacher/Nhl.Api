using Newtonsoft.Json;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.Team
{
    /// <summary>
    /// The current NHL team in an NHL player profile
    /// </summary>
    public class CurrentTeam : INhlApiMetaData
    {
        /// <summary>
        /// The id of the NHL team <br/>
        /// Example: Toronto Maple Leafs - 10
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the NHL team <br/>
        /// Example: Anaheim Ducks
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The link to the Nhl.Api endpoint for the NHL team information <br/>
        /// Example: /api/v1/teams/30
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Returns the team logo url as a light background <br/>
        /// Example: https://www-league.nhlstatic.com/images/logos/teams-current-primary-light/10.svg
        /// </summary>
        public string OfficalLightTeamLogoUrl
        {
            get
            {
                return $"{NhlStaticAssetsApiHttpClient.ClientApiUrl}/images/logos/teams-current-primary-light/{Id}.svg";
            }
        }

        /// <summary>
        /// Returns the team logo url as a dark background <br/>
        /// Example: https://www-league.nhlstatic.com/images/logos/teams-current-primary-dark/6.svg
        /// </summary>
        public string OfficalDarkTeamLogoUrl
        {
            get
            {
                return $"{NhlStaticAssetsApiHttpClient.ClientApiUrl}/images/logos/teams-current-primary-dark/{Id}.svg";
            }
        }
    }
}
