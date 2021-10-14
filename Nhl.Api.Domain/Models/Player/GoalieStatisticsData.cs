using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Player
{
	public class GoalieStatisticsData
	{
		/// <summary>
		/// The time on ice for the duration of the NHL goalie's season <br/>
		/// Example: 1478:45
		/// </summary>
		[JsonProperty("timeOnIce")]
		public string TimeOnIce { get; set; }

		/// <summary>
		/// The number of overtime wins for the duration of the NHL goalie's season <br/>
		/// Example: 5
		/// </summary>
		[JsonProperty("ot")]
		public int Ot { get; set; }

		/// <summary>
		/// The number of shutouts for the duration of the NHL goalie's season <br/>
		/// Example: 1
		/// </summary>
		[JsonProperty("shutouts")]
		public int Shutouts { get; set; }

		/// <summary>
		/// The number of ties for the duration of the NHL goalie's season <br/>
		/// Example: 0
		/// </summary>
		[JsonProperty("ties")]
		public int Ties { get; set; }

		/// <summary>
		/// The number of wins for the duration of the NHL goalie's season <br/>
		/// Example: 12
		/// </summary>
		[JsonProperty("wins")]
		public int Wins { get; set; }

		/// <summary>
		/// The number of losses for the duration of the NHL goalie's season <br/>
		/// Example: 7
		/// </summary>
		[JsonProperty("losses")]
		public int Losses { get; set; }

		/// <summary>
		/// The number of saves for the duration of the NHL goalie's season <br/>
		/// Example: 594
		/// </summary>
		[JsonProperty("saves")]
		public int Saves { get; set; }

		/// <summary>
		/// The number of power play saves for the duration of the NHL goalie's season <br/>
		/// Example: 104
		/// </summary>
		[JsonProperty("powerPlaySaves")]
		public int PowerPlaySaves { get; set; }

		/// <summary>
		/// The number of short handed saves for the duration of the NHL goalie's season <br/>
		/// Example: 14
		/// </summary>
		[JsonProperty("shortHandedSaves")]
		public int ShortHandedSaves { get; set; }

		/// <summary>
		/// The number of even strength saves for the duration of the NHL goalie's season <br/>
		/// Example: 476
		/// </summary>
		[JsonProperty("evenSaves")]
		public int EvenSaves { get; set; }

		/// <summary>
		/// The number of short handed shots for the duration of the NHL goalie's season <br/>
		/// Example: 15
		/// </summary>
		[JsonProperty("shortHandedShots")]
		public int ShortHandedShots { get; set; }

		/// <summary>
		/// The number of even strength shots for the duration of the NHL goalie's season <br/>
		/// Example: 518
		/// </summary>
		[JsonProperty("evenShots")]
		public int EvenShots { get; set; }

		/// <summary>
		/// The number of power play shots for the duration of the NHL goalie's season <br/>
		/// Example: 126
		/// </summary>
		[JsonProperty("powerPlayShots")]
		public int PowerPlayShots { get; set; }

		/// <summary>
		/// The save percentage for the duration of the NHL goalie's season <br/>
		/// Example: 0.901
		/// </summary>
		[JsonProperty("savePercentage")]
		public double SavePercentage { get; set; }

		/// <summary>
		/// The goals against average for the duration of the NHL goalie's season <br/>
		/// Example: 2.6374
		/// </summary>
		[JsonProperty("goalAgainstAverage")]
		public double GoalAgainstAverage { get; set; }

		/// <summary>
		/// The number of games played for the duration of the NHL goalie's season <br/>
		/// Example: 25
		/// </summary>
		[JsonProperty("games")]
		public int Games { get; set; }

		/// <summary>
		/// The number of games started for the duration of the NHL goalie's season <br/>
		/// Example: 25
		/// </summary>
		[JsonProperty("gamesStarted")]
		public int GamesStarted { get; set; }

		/// <summary>
		/// The number of shots against for the duration of the NHL goalie's season <br/>
		/// Example: 659
		/// </summary>
		[JsonProperty("shotsAgainst")]
		public int ShotsAgainst { get; set; }

		/// <summary>
		/// The number of goals against for the duration of the NHL goalie's season <br/>
		/// Example: 65
		/// </summary>
		[JsonProperty("goalsAgainst")]
		public int GoalsAgainst { get; set; }

		/// <summary>
		/// The number of minutes of time on ice per game for the duration of the NHL goalie's season <br/>
		/// Example: 59:09
		/// </summary>
		[JsonProperty("timeOnIcePerGame")]
		public string TimeOnIcePerGame { get; set; }

		/// <summary>
		/// The power play save percentage for the duration of the NHL goalie's season <br/>
		/// Example: 82.53968253968253
		/// </summary>
		[JsonProperty("powerPlaySavePercentage")]
		public double PowerPlaySavePercentage { get; set; }

		/// <summary>
		/// The short handed save percentage for the duration of the NHL goalie's season <br/>
		/// Example: 93.33333333333333
		/// </summary>
		[JsonProperty("shortHandedSavePercentage")]
		public double ShortHandedSavePercentage { get; set; }

		/// <summary>
		/// The even strength save percentage for the duration of the NHL goalie's season <br/>
		/// Example: 91.8918918918919
		/// </summary>
		[JsonProperty("evenStrengthSavePercentage")]
		public double EvenStrengthSavePercentage { get; set; }
	}
}
