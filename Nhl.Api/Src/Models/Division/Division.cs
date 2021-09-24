using Newtonsoft.Json;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.Division
{
	public class Division : NhlApiMetaData
	{
		[JsonProperty("nameShort")]
		public string NameShort { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }
	}
}
