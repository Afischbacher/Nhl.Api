using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Common
{
	public abstract class NhlApiMetaData : INhlApiMetaData
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }

		[JsonProperty("link")]
		public string Link { get; set; }
	}
}
