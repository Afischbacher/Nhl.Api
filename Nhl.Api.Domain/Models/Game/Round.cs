using Newtonsoft.Json;

namespace Nhl.Api.Domain.Models.Game
{
	public class Round
	{
		/// <summary>
		/// Number of the NHL playoff round
		/// Example: 1
		/// </summary>
		[JsonProperty("number")]
		public int Number { get; set; }

		/// <summary>
		/// The code for the NHL playoff round <br/>
		/// Example: 2
		/// </summary>
		[JsonProperty("code")]
		public int Code { get; set; }
		
		/// <summary>
		/// The names for the NHL playoff round, see <see cref="Names.Names"/> for more information
		/// </summary>
		[JsonProperty("names")]
		public Names Names { get; set; }

		/// <summary>
		/// The format of the NHL playoff round, see <see cref="Format.Format"/> for more information
		/// </summary>
		[JsonProperty("format")]
		public Format Format { get; set; }
	}
}
