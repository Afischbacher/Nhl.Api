using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Game
{
	/// <summary>
	/// The NHL player play type information
	/// </summary>
	public class PlayerPlayType
	{
		/// <summary>
		/// A description of the player play type <br/>
		/// Example: Winner
		/// </summary>
		[JsonProperty("playerType")]
		public string PlayerType { get; set; }
	}
}
