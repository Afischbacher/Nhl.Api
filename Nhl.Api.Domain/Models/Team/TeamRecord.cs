using System;
using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Game;
using Nhl.Api.Domain.Models.Standing;

namespace Nhl.Api.Domain.Models.Team
{
	public class TeamRecord
	{
		[JsonProperty("team")]
		public TeamInformation Team { get; set; }

		[JsonProperty("leagueRecord")]
		public LeagueRecord LeagueRecord { get; set; }

		[JsonProperty("regulationWins")]
		public int RegulationWins { get; set; }

		[JsonProperty("goalsAgainst")]
		public int GoalsAgainst { get; set; }

		[JsonProperty("goalsScored")]
		public int GoalsScored { get; set; }

		[JsonProperty("points")]
		public int Points { get; set; }

		[JsonProperty("divisionRank")]
		public string DivisionRank { get; set; }

		[JsonProperty("divisionL10Rank")]
		public string DivisionL10Rank { get; set; }

		[JsonProperty("divisionRoadRank")]
		public string DivisionRoadRank { get; set; }

		[JsonProperty("divisionHomeRank")]
		public string DivisionHomeRank { get; set; }

		[JsonProperty("conferenceRank")]
		public string ConferenceRank { get; set; }

		[JsonProperty("conferenceL10Rank")]
		public string ConferenceL10Rank { get; set; }

		[JsonProperty("conferenceRoadRank")]
		public string ConferenceRoadRank { get; set; }

		[JsonProperty("conferenceHomeRank")]
		public string ConferenceHomeRank { get; set; }

		[JsonProperty("leagueRank")]
		public string LeagueRank { get; set; }

		[JsonProperty("leagueL10Rank")]
		public string LeagueL10Rank { get; set; }

		[JsonProperty("leagueRoadRank")]
		public string LeagueRoadRank { get; set; }

		[JsonProperty("leagueHomeRank")]
		public string LeagueHomeRank { get; set; }

		[JsonProperty("wildCardRank")]
		public string WildCardRank { get; set; }

		[JsonProperty("row")]
		public int Row { get; set; }

		[JsonProperty("gamesPlayed")]
		public int GamesPlayed { get; set; }

		[JsonProperty("streak")]
		public Streak Streak { get; set; }

		[JsonProperty("clinchIndicator")]
		public string ClinchIndicator { get; set; }

		[JsonProperty("pointsPercentage")]
		public double PointsPercentage { get; set; }

		[JsonProperty("ppDivisionRank")]
		public string PpDivisionRank { get; set; }

		[JsonProperty("ppConferenceRank")]
		public string PpConferenceRank { get; set; }

		[JsonProperty("ppLeagueRank")]
		public string PpLeagueRank { get; set; }

		[JsonProperty("lastUpdated")]
		public DateTime LastUpdated { get; set; }
	}

}
