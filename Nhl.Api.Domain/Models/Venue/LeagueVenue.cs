using Newtonsoft.Json;
using Nhl.Api.Domain.Models.Common;

namespace Nhl.Api.Domain.Models.Venue
{
	public class LeagueVenue : NhlApiMetaData
	{
		[JsonProperty("appEnabled")]
		public string AppEnabled { get; set; }
	}
}
