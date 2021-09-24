using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Statistics
{
	public class TeamStatistics
	{
		[JsonProperty("stats")]
		public List<Statistic> Stats { get; set; }
	}
}
