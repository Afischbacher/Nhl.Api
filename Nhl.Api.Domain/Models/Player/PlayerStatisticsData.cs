using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Player
{
	public class PlayerStatisticsData
	{
		[JsonProperty("timeOnIce")]
		public string TimeOnIce { get; set; }

		[JsonProperty("assists")]
		public int Assists { get; set; }

		[JsonProperty("goals")]
		public int Goals { get; set; }

		[JsonProperty("pim")]
		public int Pim { get; set; }

		[JsonProperty("shots")]
		public int Shots { get; set; }

		[JsonProperty("games")]
		public int Games { get; set; }

		[JsonProperty("hits")]
		public int Hits { get; set; }

		[JsonProperty("powerPlayGoals")]
		public int PowerPlayGoals { get; set; }

		[JsonProperty("powerPlayPoints")]
		public int PowerPlayPoints { get; set; }

		[JsonProperty("powerPlayTimeOnIce")]
		public string PowerPlayTimeOnIce { get; set; }

		[JsonProperty("evenTimeOnIce")]
		public string EvenTimeOnIce { get; set; }

		[JsonProperty("penaltyMinutes")]
		public string PenaltyMinutes { get; set; }

		[JsonProperty("faceOffPct")]
		public double FaceOffPct { get; set; }

		[JsonProperty("shotPct")]
		public double ShotPct { get; set; }

		[JsonProperty("gameWinningGoals")]
		public int GameWinningGoals { get; set; }

		[JsonProperty("overTimeGoals")]
		public int OverTimeGoals { get; set; }

		[JsonProperty("shortHandedGoals")]
		public int ShortHandedGoals { get; set; }

		[JsonProperty("shortHandedPoints")]
		public int ShortHandedPoints { get; set; }

		[JsonProperty("shortHandedTimeOnIce")]
		public string ShortHandedTimeOnIce { get; set; }

		[JsonProperty("blocked")]
		public int Blocked { get; set; }

		[JsonProperty("plusMinus")]
		public int PlusMinus { get; set; }

		[JsonProperty("points")]
		public int Points { get; set; }

		[JsonProperty("shifts")]
		public int Shifts { get; set; }

		[JsonProperty("timeOnIcePerGame")]
		public string TimeOnIcePerGame { get; set; }

		[JsonProperty("evenTimeOnIcePerGame")]
		public string EvenTimeOnIcePerGame { get; set; }

		[JsonProperty("shortHandedTimeOnIcePerGame")]
		public string ShortHandedTimeOnIcePerGame { get; set; }

		[JsonProperty("powerPlayTimeOnIcePerGame")]
		public string PowerPlayTimeOnIcePerGame { get; set; }
	}

}
