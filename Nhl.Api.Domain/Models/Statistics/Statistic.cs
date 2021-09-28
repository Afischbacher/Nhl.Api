using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Statistics
{
	public class Statistic
	{
		/// <summary>
		/// The type of NHL statistic
		/// </summary>
		[JsonProperty("type")]
		public Type Type { get; set; }

		/// <summary>
		/// The splits of the NHL statistics, by place and by numerical value
		/// </summary>
		[JsonProperty("splits")]
		public List<Split> Splits { get; set; }
	}
}
