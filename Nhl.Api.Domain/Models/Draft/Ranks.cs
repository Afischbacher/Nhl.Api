namespace Nhl.Api.Models.Draft;
using Newtonsoft.Json;

/// <summary>
/// NHL Prospect Ranks
/// </summary>
public class Ranks
{
    /// <summary>
    /// The final rank for the NHL prospect <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("finalRank")]
    public int FinalRank { get; set; }

    /// <summary>
    /// The draft year for the NHL prospect <br/>
    /// Example: 2021
    /// </summary>
    [JsonProperty("draftYear")]
    public int DraftYear { get; set; }
}
