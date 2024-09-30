using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Game;
/// <summary>
/// The NHL game metadata information for the NHL game
/// </summary>
public class GameMetadata
{
    /// <summary>
    /// The list of NHL teams playing in the NHL game
    /// </summary>
    [JsonProperty("teams")]
    public List<GameMetadataTeam> Teams { get; set; }

    /// <summary>
    /// The season states for the NHL game
    /// </summary>
    [JsonProperty("seasonStates")]
    public SeasonStates SeasonStates { get; set; }
}

/// <summary>
/// The NHL game season states information
/// </summary>
public class SeasonStates
{
    /// <summary>
    /// The date of the NHL game <br/>
    /// Example: 2021-10-13
    /// </summary>
    [JsonProperty("date")]
    public string Date { get; set; }

    /// <summary>
    /// The NHL game type <br/>
    /// Example: 2 or 3
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }

    /// <summary>
    /// The NHL game season <br/>   
    /// Example: 20212022
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }
}

/// <summary>
/// The NHL game team information
/// </summary>
public class GameMetadataTeam
{
    /// <summary>
    /// The NHL game team information
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL team tri code <br/>
    /// Example: TOR
    /// </summary>
    [JsonProperty("tricode")]
    public string Tricode { get; set; }

    /// <summary>
    /// The NHL team id <br/>
    /// Example: 10
    /// </summary>
    [JsonProperty("teamId")]
    public int TeamId { get; set; }
}
