using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Statistics
{
	public class Statistic
	{
		[JsonProperty("type")]
		public Type Type { get; set; }

		[JsonProperty("splits")]
		public List<Split> Splits { get; set; }
	}
}
