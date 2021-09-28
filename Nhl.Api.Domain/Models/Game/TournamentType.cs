using Newtonsoft.Json;

namespace Nhl.Api.Models.Game
{
	/// <summary>
	/// Identifies an NHL tournament type
	/// </summary>
	public class TournamentType
	{
		/// <summary>
		/// The description of the tournament type <br/>
		/// Example: Playoffs
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// The game type enumeration with information <br/>
		/// Example: Playoffs
		/// </summary>
		[JsonProperty("gameTypeEnum")]
		public GameTypeEnum GameTypeEnum { get; set; }

		/// <summary>
		/// Identifies the parameter of the NHL tournament type <br/>
		/// Example: olympics
		/// </summary>
		[JsonProperty("parameter")]
		public string Parameter { get; set; }
	}
}
