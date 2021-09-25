using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Game
{
	/// <summary>
	/// Identifies all of the different play types in an NHL game
	/// </summary>
	public class PlayType
	{
		/// <summary>
		/// The name of the NHL play type <br/>
		/// Example: Faceoff
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The id of the NHL play type <br/>
		/// Example: GOAL
		/// </summary>
		[JsonProperty("id")]
		public string Id { get; set; }

		/// <summary>
		/// The CMS key for the NHL game type <br/>
		/// Example: gamecenterMissedShot
		/// </summary>
		[JsonProperty("cmsKey")]
		public string CmsKey { get; set; }

		/// <summary>
		/// Returns a collection of all the player play types
		/// </summary>
		[JsonProperty("playerTypes")]
		public List<PlayerPlayType> PlayerTypes { get; set; }

		/// <summary>
		/// The code for the NHL player play type <br/>
		/// Example: Penalty
		/// </summary>
		[JsonProperty("code")]
		public string Code { get; set; }

		/// <summary>
		/// A collection of secondary event codes in an NHL player play type <br/>
		/// Example: ["shot_type", "soResult"]
		/// </summary>
		[JsonProperty("secondaryEventCodes")]
		public List<string> SecondaryEventCodes { get; set; }
	}
}
