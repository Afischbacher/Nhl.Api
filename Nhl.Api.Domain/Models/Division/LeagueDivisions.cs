using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Division
{
    public class LeagueDivisions
    {
        /// <summary>
        /// A collection of all of the NHL divisions, see <see cref="Division"/> for more information
        /// </summary>
        [JsonProperty("divisions")]
        public List<Division> Divisions { get; set; } = new List<Division>();
    }
}
