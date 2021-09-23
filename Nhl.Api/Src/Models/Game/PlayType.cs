using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game
{
	public class PlayType
	{
		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("cmsKey")]
		public string CmsKey { get; set; }

		[JsonProperty("playerTypes")]
		public List<PlayerPlayType> PlayerTypes { get; set; }

		[JsonProperty("code")]
		public string Code { get; set; }

		[JsonProperty("secondaryEventCodes")]
		public List<string> SecondaryEventCodes { get; set; }
	}
}
