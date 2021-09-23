using Newtonsoft.Json;

namespace Nhl.Api.Models.Common
{
	public class Content
	{
		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
