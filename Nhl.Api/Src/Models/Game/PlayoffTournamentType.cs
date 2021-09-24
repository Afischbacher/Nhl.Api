using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game
{
	public class PlayoffTournamentType
	{

		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("season")]
		public string Season { get; set; }

		[JsonProperty("defaultRound")]
		public int DefaultRound { get; set; }

		[JsonProperty("rounds")]
		public List<Round> Rounds { get; set; }
	}
}
