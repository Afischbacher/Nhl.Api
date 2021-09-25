using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Common
{
	public class Content
	{
		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
