using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Draft
{

	public class Round
	{
		[JsonProperty("roundNumber")]
		public int RoundNumber { get; set; }

		[JsonProperty("round")]
		public string DraftRound { get; set; }

		[JsonProperty("picks")]
		public List<Pick> Picks { get; set; }
	}

}
