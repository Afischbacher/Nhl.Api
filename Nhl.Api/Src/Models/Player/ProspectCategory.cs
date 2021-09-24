using Newtonsoft.Json;

namespace Nhl.Api.Models.Player
{
	public class ProspectCategory
	{
		[JsonProperty("id")]
		public int Id { get; set; }

		[JsonProperty("shortName")]
		public string ShortName { get; set; }

		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
