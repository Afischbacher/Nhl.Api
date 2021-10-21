using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Domain.Models.Player
{
	public class PlayerSearchResponse
	{
		[JsonProperty("suggestions")]
		public List<string> Suggestions { get; set; }
	}
}
