using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Domain.Models.Player
{
	public class LeaguePlayers
	{
		[JsonProperty("people")]
		public List<Player> Players { get; set; } = new List<Player>();
	}
}
