using Newtonsoft.Json;
using Nhl.Api.Models.Common;


namespace Nhl.Api.Models.Division
{
	public class Division : NhlApiMetaData
	{
		/// <summary>
		/// The short name for the NHL division <br/>
		/// Example: ATL - Atlantic
		/// </summary>
		[JsonProperty("nameShort")]
		public string NameShort { get; set; }

		/// <summary>
		/// The abbreviation for the NHL division <br/>
		/// Example: M - Metropolitan
		/// </summary>
		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }
	}
}
