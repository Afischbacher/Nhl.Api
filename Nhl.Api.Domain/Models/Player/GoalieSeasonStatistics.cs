using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Player
{
	public class GoalieSeasonStatistics
	{
		/// <summary>
		/// The goalie season statistics for an NHL goalie for a specific season
		/// </summary>
		[JsonProperty("stats")]
		public List<GoalieSeasonStat> Statistics { get; set; }
	}
}
