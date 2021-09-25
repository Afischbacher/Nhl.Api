using System;
using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Common;
using Nhl.Api.Domain.Models.Team;

namespace Nhl.Api.Domain.Models.Game
{
	public class Game
	{
		[JsonProperty("gamePk")]
		public int GamePk { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }

		[JsonProperty("gameType")]
		public string GameType { get; set; }

		[JsonProperty("season")]
		public string Season { get; set; }

		[JsonProperty("gameDate")]
		public DateTime GameDate { get; set; }

		[JsonProperty("status")]
		public GameStatus Status { get; set; }

		[JsonProperty("teams")]
		public Teams Teams { get; set; }

		[JsonProperty("venue")]
		public Venue.Venue Venue { get; set; }

		[JsonProperty("content")]
		public Content Content { get; set; }
	}
}
