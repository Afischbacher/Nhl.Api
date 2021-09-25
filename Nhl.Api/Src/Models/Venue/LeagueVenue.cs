using Newtonsoft.Json;
using Nhl.Api.Models.Common;

namespace Nhl.Api.Models.Venue
{
	public class LeagueVenue : NhlApiMetaData
	{
		[JsonProperty("appEnabled")]
		public string AppEnabled { get; set; }
	}
}
