using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Common;

namespace Nhl.Api.Domain.Models.Team
{
	/// <summary>
	/// The current NHL team in an NHL player profile
	/// </summary>
	public class CurrentTeam : INhlApiMetaData
	{
		/// <summary>
		/// The id of the NHL team <br/>
		/// Example: Toronto Maple Leafs - 10
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// The name of the NHL team <br/>
		/// Example: Anaheim Ducks
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }
		/// <summary>
		/// The link to the NHL API endpoint for the NHL team information <br/>
		/// Example: /api/v1/teams/30
		/// </summary>
		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
