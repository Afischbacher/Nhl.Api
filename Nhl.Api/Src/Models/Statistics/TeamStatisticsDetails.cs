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
		public decimal GoalsPerGame { get; set; }

		[JsonProperty("goalsAgainstPerGame")]
		public decimal GoalsAgainstPerGame { get; set; }

		[JsonProperty("evGGARatio")]
		public decimal EvGGARatio { get; set; }

		[JsonProperty("powerPlayPercentage")]
		public string PowerPlayPercentage { get; set; }

		[JsonProperty("powerPlayGoals")]
		public decimal PowerPlayGoals { get; set; }

		[JsonProperty("powerPlayGoalsAgainst")]
		public decimal PowerPlayGoalsAgainst { get; set; }

		[JsonProperty("powerPlayOpportunities")]
		public decimal PowerPlayOpportunities { get; set; }

		[JsonProperty("penaltyKillPercentage")]
		public string PenaltyKillPercentage { get; set; }

		[JsonProperty("shotsPerGame")]
		public decimal ShotsPerGame { get; set; }

		[JsonProperty("shotsAllowed")]
		public decimal ShotsAllowed { get; set; }

		[JsonProperty("winScoreFirst")]
		public decimal WinScoreFirst { get; set; }

		[JsonProperty("winOppScoreFirst")]
		public decimal WinOppScoreFirst { get; set; }

		[JsonProperty("winLeadFirstPer")]
		public decimal WinLeadFirstPer { get; set; }

		[JsonProperty("winLeadSecondPer")]
		public decimal WinLeadSecondPer { get; set; }

		[JsonProperty("winOutshootOpp")]
		public decimal WinOutshootOpp { get; set; }

		[JsonProperty("winOutshotByOpp")]
		public decimal WinOutshotByOpp { get; set; }

		[JsonProperty("faceOffsTaken")]
		public decimal FaceOffsTaken { get; set; }

		[JsonProperty("faceOffsWon")]
		public decimal FaceOffsWon { get; set; }

		[JsonProperty("faceOffsLost")]
		public decimal FaceOffsLost { get; set; }

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
