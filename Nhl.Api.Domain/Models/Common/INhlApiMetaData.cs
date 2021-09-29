using Newtonsoft.Json;

namespace Nhl.Api.Models.Common
{
	/// <summary>
	/// An interface with common properties from the NHL API for various entities such as teams, players and more
	/// </summary>
	public interface INhlApiMetaData
	{
		[JsonProperty("id")]
		int Id { get; set; }

		[JsonProperty("name")]
		string Name { get; set; }

		[JsonProperty("link")]
		string Link { get; set; }
	}
}
