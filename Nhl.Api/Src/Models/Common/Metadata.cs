using Newtonsoft.Json;

namespace Nhl.Api.Models.Common
{
	public class MetaData
	{
		[JsonProperty("timeStamp")]
		public string TimeStamp { get; set; }
	}
}
