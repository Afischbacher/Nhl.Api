using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Models.Player
{
	public class GoalieSeasonStat
	{
		/// <summary>
		/// The specific type for the NHL player statistics
		/// </summary>
		[JsonProperty("type")]
		public Api.Models.Statistics.Type Type { get; set; }

		/// <summary>
		/// The collection of splits for the NHL goalie statistics for the specific season
		/// </summary>
		[JsonProperty("splits")]
		public List<GoalieSeasonStatisticsSplit> Splits { get; set; }
	}
}
