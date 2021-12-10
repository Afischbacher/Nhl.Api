using Newtonsoft.Json;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.Team
{
    public class TeamInformation : INhlApiMetaData
    {
        /// <summary>
        /// The identifier for the NHL team <br/>
        /// Example: 21 - Colorado Avalanche
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The name of the NHL team <br/>
        /// Example: Colorado Avalanche
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The NHL API link to the NHL team <br/>
        /// Example: /api/v1/teams/21
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
        /// Returns the team logo url as a dark background 
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
