using Newtonsoft.Json;

namespace Nhl.Api.Models.Event
{
	public class EventType
	{
		[JsonProperty("id")]
		public string Id { get; set; }

		[JsonProperty("description")]
		public string Description { get; set; }
	}
}

