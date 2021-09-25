using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Game
{
	public class GameDate
	{
		[JsonProperty("date")]
		public string Date { get; set; }

		[JsonProperty("totalItems")]
		public int TotalItems { get; set; }

		[JsonProperty("totalEvents")]
		public int TotalEvents { get; set; }

		[JsonProperty("totalGames")]
		public int TotalGames { get; set; }

		[JsonProperty("totalMatches")]
		public int TotalMatches { get; set; }

		[JsonProperty("games")]
		public List<Game> Games { get; set; }

		//@todo Match these types
		[JsonProperty("events")]
		public List<object> Events { get; set; }

		//@todo Match these types
		[JsonProperty("matches")]
		public List<object> Matches { get; set; }
	}
}
