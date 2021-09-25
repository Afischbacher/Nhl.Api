using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Common;


namespace Nhl.Api.Domain.Models.Division
{
	public class Division : NhlApiMetaData
	{
		[JsonProperty("nameShort")]
		public string NameShort { get; set; }

		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }
	}
}
