using Newtonsoft.Json;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.Conference
{
	public class Conference : NhlApiMetaData
	{
		/// <summary>
		/// The abbreviation of the NHL conference <br/>
		/// Example: E - Eastern
		/// </summary>
		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		/// <summary>
		/// The short name for the NHL conference <br/>
		/// Example: West - Western
		/// </summary>
		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		/// <summary>
		/// Identifies if the NHL conference is active
		/// </summary>
		[JsonProperty("active")]
		public bool Active { get; set; }
	}
}
