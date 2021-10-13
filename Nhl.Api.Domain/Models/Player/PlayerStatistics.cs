using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Player
{
	public class PlayerStatistics
	{
		[JsonProperty("stats")]
		public List<Stat> Statistics { get; set; }
	}
}
