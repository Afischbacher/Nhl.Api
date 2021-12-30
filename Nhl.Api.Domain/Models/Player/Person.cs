using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Person
    /// </summary>
    public class Person
    {
        /// <summary>
        /// Identifier of the person <br/>
        /// Example: 8478864
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Full name of the person <br/>
        /// Example: Sidney Crosby
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// NHL API link to the player profile <br/>
        /// Example: /api/v1/people/8478864
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }
}
