using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Player
{
	public class Stat
	{
		[JsonProperty("type")]
		public Type Type { get; set; }

		[JsonProperty("splits")]
		public List<PlayerStatisticsSplit> Splits { get; set; }
	}
}
