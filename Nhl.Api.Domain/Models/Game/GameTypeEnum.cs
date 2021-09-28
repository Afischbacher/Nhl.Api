using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
	/// <summary>
	/// The NHL game type enumeration
	/// </summary>
	public class GameTypeEnum
	{
		/// <summary>
		/// The identifier for the NHL game type enum <br/>
		/// Example: P - Playoffs
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// The description for the NHL game type enum <br/>
		/// Example: World cup of hockey semifinals and finals
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Identifies if it is a post season event
		/// </summary>
		[JsonProperty("postseason")]
		public bool Postseason { get; set; }
	}
}
