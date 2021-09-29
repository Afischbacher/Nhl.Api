using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player
{
	public class LeaguePlayers
	{
		/// <summary>
		/// A collection of NHL players
		/// </summary>
		[JsonProperty("people")]
		public List<Player> Players { get; set; } = new List<Player>();
	}
}
