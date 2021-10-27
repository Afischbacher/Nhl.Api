using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
	public class PlayerStatisticsData
	{
		/// <summary>
		/// The time on ice for the duration of the NHL player's season <br/>
		/// Example: 1236:40
		/// </summary>
		[JsonProperty("timeOnIce")]
		public string TimeOnIce { get; set; }

		/// <summary>
		/// The number of assists for the duration of the NHL player's season <br/>
		/// Example: 34
		/// </summary>
		[JsonProperty("assists")]
		public int Assists { get; set; }

		/// <summary>
		/// The number of goals for the duration of the NHL player's season <br/>
		///  Example: 10
		/// </summary>
		[JsonProperty("goals")]
		public int Goals { get; set; }

		/// <summary>
		/// The number of penalty minutes for the duration of the NHL player's season <br/>
		/// Example: 12
		/// </summary>
		[JsonProperty("pim")]
		public int Pim { get; set; }

		/// <summary>
		/// The number of shots for the duration of the NHL player's season <br/>
		/// Example: 128
		/// </summary>
		[JsonProperty("shots")]
		public int Shots { get; set; }

		/// <summary>
		/// The number of games played for the duration of the NHL player's season <br/>
		/// Example: 82
		/// </summary>
		[JsonProperty("games")]
		public int Games { get; set; }

		/// <summary>
		/// The number of hits for the duration of the NHL player's season <br/>
		/// Example: 56
		/// </summary>
		[JsonProperty("hits")]
		public int Hits { get; set; }

		/// <summary>
		/// The number of power play goals for the duration of the NHL player's season <br/>
		/// Example: 3
		/// </summary>
		[JsonProperty("powerPlayGoals")]
		public int PowerPlayGoals { get; set; }

		/// <summary>
		/// The number of power play points for the duration of the NHL player's season <br/> 
		/// Example: 15
		/// </summary>
		[JsonProperty("powerPlayPoints")]
		public int PowerPlayPoints { get; set; }

		/// <summary>
		/// The number of minutes of power play time on ice for the duration of the NHL player's season <br/>
		/// Example: 170:02
		/// </summary>
		[JsonProperty("powerPlayTimeOnIce")]
		public string PowerPlayTimeOnIce { get; set; }

		/// <summary>
		/// The number of minutes of even time on ice for the duration of the NHL player's season <br/>
		/// Example: 966:35
		/// </summary>
		[JsonProperty("evenTimeOnIce")]
		public string EvenTimeOnIce { get; set; }

		/// <summary>
		/// The number of penalty minutes for the duration of the NHL player's season <br/>
		/// Example: 12
		/// </summary>
		[JsonProperty("penaltyMinutes")]
		public string PenaltyMinutes { get; set; }

		/// <summary>
		/// The face off percentages for the duration of the NHL player's season <br/>
		/// Example: 53.56
		/// </summary>
		[JsonProperty("faceOffPct")]
		public double FaceOffPct { get; set; }

		/// <summary>
		/// The shot accuracy percentage for the duration of the NHL player's season <br/>
		/// Example: 15.1
		/// </summary>
		[JsonProperty("shotPct")]
		public double ShotPct { get; set; }

		/// <summary>
		/// The number of game winning goals for the duration of the NHL player's season <br/>
		/// Example: 5
		/// </summary>
		[JsonProperty("gameWinningGoals")]
		public int GameWinningGoals { get; set; }

		/// <summary>
		/// The number of overtime goals for the duration of the NHL player's season <br/>
		/// Example: 2
		/// </summary>
		[JsonProperty("overTimeGoals")]
		public int OverTimeGoals { get; set; }

		/// <summary>
		/// The number of short handed goals for the duration of the NHL player's season <br/>
		/// Example: 1
		/// </summary>
		[JsonProperty("shortHandedGoals")]
		public int ShortHandedGoals { get; set; }

		/// <summary>
		/// The number of short handed points for the duration of the NHL player's season <br/>
		/// Example: 1
		/// </summary>
		[JsonProperty("shortHandedPoints")]
		public int ShortHandedPoints { get; set; }

		/// <summary>
		/// The number of short handed time on ice for the duration of the NHL player's season <br/>
		/// Example: 08:22
		/// </summary>
		[JsonProperty("shortHandedTimeOnIce")]
		public string ShortHandedTimeOnIce { get; set; }

		/// <summary>
		/// The number of blocked shots within the duration of the NHL player's season <br/>
		/// Example: 28
		/// </summary>
		[JsonProperty("blocked")]
		public int Blocked { get; set; }

		/// <summary>
		/// The plus minus for the NHL player within the duration of the NHL player's season <br/>
		/// Example: 8
		/// </summary>
		[JsonProperty("plusMinus")]
		public int PlusMinus { get; set; }

		/// <summary>
		/// The number of points for the NHL player within the duration of the NHL player's season <br/>
		/// Example: 62
		/// </summary>
		[JsonProperty("points")]
		public int Points { get; set; }

		/// <summary>
		/// The number of shifts played for the duration of the NHL player's season <br/>
		/// Example: 1392
		/// </summary>
		[JsonProperty("shifts")]
		public int Shifts { get; set; }

		/// <summary>
		/// The number of minutes of ice time per game played for the duration of the NHL player's season <br/>
		/// Example: 20:23
		/// </summary>
		[JsonProperty("timeOnIcePerGame")]
		public string TimeOnIcePerGame { get; set; }

		/// <summary>
		/// The number of minutes of even ice time per game played for the duration of the NHL player's season <br/>
		/// Example: 17:13
		/// </summary>
		[JsonProperty("evenTimeOnIcePerGame")]
		public string EvenTimeOnIcePerGame { get; set; }

		/// <summary>
		/// The number of minutes of short handed ice time per game played for the duration of the NHL player's season <br/>
		/// Example: 00:09
		/// </summary>
		[JsonProperty("shortHandedTimeOnIcePerGame")]
		public string ShortHandedTimeOnIcePerGame { get; set; }

		/// <summary>
		/// The number of minutes of power play time on ice per game played for the duration of the NHL player's season <br/>
		/// Example: 03:01
		/// </summary>
		[JsonProperty("powerPlayTimeOnIcePerGame")]
		public string PowerPlayTimeOnIcePerGame { get; set; }
	}

}
