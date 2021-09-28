using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Game
{ 
	public class PlayoffTournamentType
	{
		/// <summary>
		/// Identifier for the playoff tournament type <br/>
		/// Example: 1 - Playoffs
		/// </summary>
		[JsonProperty("id")]
		public int Id { get; set; }

		/// <summary>
		/// Name of the NHL playoff torunament <br/>
		/// Example: Second Round
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// Current NHL season <br/>
		/// Example: "20202021"
		/// </summary>
		[JsonProperty("season")]
		public string Season { get; set; }

		/// <summary>
		/// The default round code <br/>
		/// Example: 4
		/// </summary>
		[JsonProperty("defaultRound")]
		public int DefaultRound { get; set; }

		/// <summary>
		/// A collection of all of the NHL playoff rounds
		/// </summary>
		[JsonProperty("rounds")]
		public List<Round> Rounds { get; set; }
	}
}
