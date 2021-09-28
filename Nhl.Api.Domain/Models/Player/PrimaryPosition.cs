using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
	public class PrimaryPosition
	{
		/// <summary>
		/// The positional code for the NHL player <br/>
		/// Example: C - Centre/Center
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// The name of the NHL player position <br/>
		/// Example: Defenseman
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The type of the NHL player position <br/>
		/// Example: Goalie
		/// </summary>
		[JsonProperty("type")]
		public string Type { get; set; }

		/// <summary>
		/// The abbreviation of the NHL player position <br/>
		/// Example: G
		/// </summary>
		[JsonProperty("abbreviation")]
		public string Abbreviation { get; set; }
	}
}
