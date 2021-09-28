using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Draft
{

	public class Round
	{
		/// <summary>
		/// The round number for the NHL draft <br/>
		/// Example: 1
		/// </summary>
		[JsonProperty("roundNumber")]
		public int RoundNumber { get; set; }

		/// <summary>
		/// The round number for the NHL draft <br/>
		/// Example: 1
		/// </summary>
		[JsonProperty("round")]
		public string DraftRound { get; set; }

		/// <summary>
		/// The collection of all the picks for the NHL Draft round, <see cref="Pick"/> for more information
		/// </summary>
		[JsonProperty("picks")]
		public List<Pick> Picks { get; set; }
	}

}
