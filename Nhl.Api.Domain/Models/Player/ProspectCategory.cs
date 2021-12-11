using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
    public class ProspectCategory
    {
        /// <summary>
        /// The identifier for the prospect category <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The short name for the prospect category <br/>
        /// Example: Euro Skater
        /// </summary>
        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// The name for the prospect category <br/>
        /// Example: European Skater
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
