using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
	public class GameType
	{
		/// <summary>
		/// The identifier of the NHL game type <br/>
		/// Example: P - Playoffs
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// The description of the NHL game type <br/>
		/// Example: All-Star game
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// Identifies if the NHL game type is a post season game type
		/// </summary>
		[JsonProperty("postseason")]
		public bool Postseason { get; set; }

	}
}
