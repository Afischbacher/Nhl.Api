using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Statistics
{
	public class TeamStatistics
	{
		/// <summary>
		/// The collection of all the NHL team statistics
		/// </summary>
		[JsonProperty("stats")]
		public List<Statistic> Statistics { get; set; }
	}
}
