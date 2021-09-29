using Newtonsoft.Json;

namespace Nhl.Api.Models.Common
{
	public class MetaData
	{
		/// <summary>
		/// The time-stamp of the current time for the NHL game schedule
		/// </summary>
		[JsonProperty("timeStamp")]
		public string TimeStamp { get; set; }
	}
}
