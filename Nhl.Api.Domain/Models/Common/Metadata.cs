using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Common
{
	public class MetaData
	{
		[JsonProperty("timeStamp")]
		public string TimeStamp { get; set; }
	}
}
