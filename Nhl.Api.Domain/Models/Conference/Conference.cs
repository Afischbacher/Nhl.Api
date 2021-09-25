using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Common;

namespace Nhl.Api.Domain.Models.Conference
{
	public class Conference : NhlApiMetaData
	{
		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }

		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		[JsonProperty("active")]
		public bool Active { get; set; }
	}
}
