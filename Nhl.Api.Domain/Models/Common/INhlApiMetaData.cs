using Newtonsoft.Json;

namespace Nhl.Api.Models.Common
{
    /// <summary>
    /// An interface with common properties from the Nhl.Api for various entities such as teams, players and more
    /// </summary>
    public interface INhlApiMetaData
    {
        /// <summary>
        /// Identifier
        /// </summary>
        [JsonProperty("id")]
        int Id { get; set; }

        /// <summary>
        /// Name
        /// </summary>
        [JsonProperty("name")]
        string Name { get; set; }

        /// <summary>
        /// Link
        /// </summary>
        [JsonProperty("link")]
        string Link { get; set; }
    }
}
