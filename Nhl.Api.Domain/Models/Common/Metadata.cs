using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Common
{
	public class MetaData
	{
		/// <summary>
		/// The timestamp of the current time for the NHL game schedule
		/// </summary>
		[JsonProperty("timeStamp")]
		public string TimeStamp { get; set; }
	}
}
