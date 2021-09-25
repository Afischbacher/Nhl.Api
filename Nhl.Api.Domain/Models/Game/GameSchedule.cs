using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Common;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Game
{
	public class GameSchedule
	{

		[JsonProperty("totalItems")]
		public int TotalItems { get; set; }

		[JsonProperty("totalEvents")]
		public int TotalEvents { get; set; }

		[JsonProperty("totalGames")]
		public int TotalGames { get; set; }

		[JsonProperty("totalMatches")]
		public int TotalMatches { get; set; }

		[JsonProperty("metaData")]
		public MetaData MetaData { get; set; }

		[JsonProperty("wait")]
		public int Wait { get; set; }

		[JsonProperty("dates")]
		public List<GameDate> Dates { get; set; }
	}
}
