using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
    public class Names
    {
        /// <summary>
        /// The full name of the NHL playoff round <br/>
        /// Example: Stanley Cup Semifinals
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The short name of the NHL playoff round <br/>
        /// Example: SCF (Stanley Cup Final)
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }
    }
}
