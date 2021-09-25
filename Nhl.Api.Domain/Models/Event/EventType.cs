using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Event
{
	public class EventType
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}

