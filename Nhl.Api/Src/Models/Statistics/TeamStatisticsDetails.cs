using Newtonsoft.Json;

namespace Nhl.Api.Models.Statistics
{
	public class TeamStatisticsDetails
	{

		[JsonProperty("gamesPlayed")]
		public int GamesPlayed { get; set; }

		[JsonProperty("wins")]
		public string Wins { get; set; }

		[JsonProperty("losses")]
		public string Losses { get; set; }

		[JsonProperty("ot")]
		public string Ot { get; set; }

		[JsonProperty("pts")]
		public string Pts { get; set; }

		[JsonProperty("ptPctg")]
		public string PtPctg { get; set; }

		[JsonProperty("goalsPerGame")]
		public string GoalsPerGame { get; set; }

		[JsonProperty("goalsAgainstPerGame")]
		public string GoalsAgainstPerGame { get; set; }

		[JsonProperty("evGGARatio")]
		public string EvGGARatio { get; set; }

		[JsonProperty("powerPlayPercentage")]
		public string PowerPlayPercentage { get; set; }

		[JsonProperty("powerPlayGoals")]
		public string PowerPlayGoals { get; set; }

		[JsonProperty("powerPlayGoalsAgainst")]
		public string PowerPlayGoalsAgainst { get; set; }

		[JsonProperty("powerPlayOpportunities")]
		public string PowerPlayOpportunities { get; set; }

		[JsonProperty("penaltyKillPercentage")]
		public string PenaltyKillPercentage { get; set; }

		[JsonProperty("shotsPerGame")]
		public string ShotsPerGame { get; set; }

		[JsonProperty("shotsAllowed")]
		public string ShotsAllowed { get; set; }

		[JsonProperty("winScoreFirst")]
		public string WinScoreFirst { get; set; }

		[JsonProperty("winOppScoreFirst")]
		public string WinOppScoreFirst { get; set; }

		[JsonProperty("winLeadFirstPer")]
		public string WinLeadFirstPer { get; set; }

		[JsonProperty("winLeadSecondPer")]
		public string WinLeadSecondPer { get; set; }

		[JsonProperty("winOutshootOpp")]
		public string WinOutshootOpp { get; set; }

		[JsonProperty("winOutshotByOpp")]
		public string WinOutshotByOpp { get; set; }

		[JsonProperty("faceOffsTaken")]
		public string FaceOffsTaken { get; set; }

		[JsonProperty("faceOffsWon")]
		public string FaceOffsWon { get; set; }

		[JsonProperty("faceOffsLost")]
		public string FaceOffsLost { get; set; }

		[JsonProperty("faceOffWinPercentage")]
		public string FaceOffWinPercentage { get; set; }

		[JsonProperty("shootingPctg")]
		public decimal ShootingPctg { get; set; }

		[JsonProperty("savePctg")]
		public decimal SavePctg { get; set; }

		[JsonProperty("penaltyKillOpportunities")]
		public string PenaltyKillOpportunities { get; set; }

		[JsonProperty("savePctRank")]
		public string SavePctRank { get; set; }

		[JsonProperty("shootingPctRank")]
		public string ShootingPctRank { get; set; }
	}
}
