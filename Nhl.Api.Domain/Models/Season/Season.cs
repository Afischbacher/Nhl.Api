using Newtonsoft.Json;
using System;

namespace Nhl.Api.Models.Season
{
	public class Season
	{
		/// <summary>
		/// The identifier for the NHL season <br/>
		/// Example: 19171918
		/// </summary>
		[JsonProperty("seasonId")]
		public string SeasonId { get; set; }

		/// <summary>
		/// The NHL regular season start date <br/>
		/// Example: 2021-10-12
		/// </summary>
		[JsonProperty("regularSeasonStartDate")]
		public DateTime RegularSeasonStartDate { get; set; }

		/// <summary>
		/// The NHL regular season end date <br/>
		/// Example: 2022-04-30
		/// </summary>
		[JsonProperty("regularSeasonEndDate")]
		public DateTime RegularSeasonEndDate { get; set; }

		/// <summary>
		/// The NHL full season end date <br/>
		/// Example: 2022-06-29
		/// </summary>
		[JsonProperty("seasonEndDate")]
		public DateTime SeasonEndDate { get; set; }

		/// <summary>
		/// The number of NHL games in the NHL season <br/>
		/// Example: 56
		/// </summary>
		[JsonProperty("numberOfGames")]
		public int NumberOfGames { get; set; }

		/// <summary>
		/// The option of ties in use within the NHL season
		/// </summary>
		[JsonProperty("tiesInUse")]
		public bool TiesInUse { get; set; }

		/// <summary>
		/// The NHL season allowing the league to participate in the Olympics
		/// </summary>
		[JsonProperty("olympicsParticipation")]
		public bool OlympicsParticipation { get; set; }

		/// <summary>
		/// The NHL season using the concept of NHL conferences
		/// </summary>
		[JsonProperty("conferencesInUse")]
		public bool ConferencesInUse { get; set; }

		/// <summary>
		/// The NHL season using the concept of NHL divisions
		/// </summary>
		[JsonProperty("divisionsInUse")]
		public bool DivisionsInUse { get; set; }

		/// <summary>
		/// The NHL season using the concept of NHL wildcards
		/// </summary>
		[JsonProperty("wildCardInUse")]
		public bool WildCardInUse { get; set; }

	}
}
