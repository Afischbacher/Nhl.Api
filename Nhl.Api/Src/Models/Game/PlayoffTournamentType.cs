using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game
{
	public class Names
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("shortName")]
		public string ShortName { get; set; }
	}

	public class Format
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }

		[JsonProperty("numberOfGames")]
		public int NumberOfGames { get; set; }

		[JsonProperty("numberOfWins")]
		public int NumberOfWins { get; set; }
	}

	public class Round
	{
		[JsonProperty("number")]
		public int Number { get; set; }

		[JsonProperty("code")]
		public int Code { get; set; }

		[JsonProperty("names")]
		public Names Names { get; set; }

		[JsonProperty("format")]
		public Format Format { get; set; }
	}

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
