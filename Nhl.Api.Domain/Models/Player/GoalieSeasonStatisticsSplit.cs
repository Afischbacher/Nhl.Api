using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Domain.Models.Player
{
	public class GoalieSeasonStatisticsSplit
	{
		/// <summary>
		/// The specific season for the NHL goalie statistics
		/// Example: 20202021
		/// </summary>
		[JsonProperty("season")]
		public string Season { get; set; }

		/// <summary>
		/// The specific NHL goalie data including statistics such as points, shots, time on ice, goals and more
		/// </summary>
		[JsonProperty("stat")]
		public GoalieStatisticsData GoalieStatisticsData { get; set; }
	}
}
