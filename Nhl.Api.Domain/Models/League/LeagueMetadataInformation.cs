using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.League;
/// <summary>
/// The current NHL team for the player metadata
/// </summary>
public class CurrentTeam
{
    /// <summary>
    /// The NHL team identifier for the player metadata <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("teamId")]
    public int TeamId { get; set; }

    /// <summary>
    /// The NHL team name for the player metadata <br/>
    /// Example: TOR
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// Force the player metadata to be updated <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("force")]
    public bool Force { get; set; }
}

/// <summary>
/// The NHL metadata player name
/// </summary>
public class MetadataName
{
    /// <summary>
    /// The default player name <br/>
    /// Example: Auston Matthews
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }

    /// <summary>
    /// The player name in French <br/>
    /// Example: Auston Matthews
    /// </summary>
    [JsonProperty("fr")]
    public string Fr { get; set; }
}

/// <summary>
/// The NHL player metadata
/// </summary>
public class Player
{
    /// <summary>
    /// The NHL player identifier <br/>
    /// Example: 8478403 - Jack Eichel
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL player slug <br/>
    /// Example: jack-eichel-8478403
    /// </summary>
    [JsonProperty("playerSlug")]
    public string PlayerSlug { get; set; }

    /// <summary>
    /// The NHL player action shot link url <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/actionshots/1296x729/8478402.jpg">https://assets.nhle.com/mugs/actionshots/1296x729/8478402.jpg</a>
    /// </summary>
    [JsonProperty("actionShot")]
    public string ActionShot { get; set; }

    /// <summary>
    /// The name of the NHL player <br/>
    /// Example: Jack Eichel
    /// </summary>
    [JsonProperty("name")]
    public MetadataName Name { get; set; }

    /// <summary>
    /// The collection of current NHL teams for the player metadata
    /// </summary>
    [JsonProperty("currentTeams")]
    public List<CurrentTeam> CurrentTeams { get; set; }
}

/// <summary>
/// The NHL league metadata information
/// </summary>
public class LeagueMetadataInformation
{
    /// <summary>
    /// The collection of NHL players for the metadata
    /// </summary>
    [JsonProperty("players")]
    public List<Player> Players { get; set; }

    /// <summary>
    /// The collection of NHL teams for the metadata
    /// </summary>
    [JsonProperty("teams")]
    public List<LeagueMetadataTeam> Teams { get; set; }

    /// <summary>
    /// The collection of NHL seasons for the metadata
    /// </summary>
    [JsonProperty("seasonStates")]
    public List<object> SeasonStates { get; set; }
}

/// <summary>
/// The NHL league metadata team
/// </summary>
public class LeagueMetadataTeam
{
    /// <summary>
    /// The NHL team name for the metadata <br/>
    /// Example: Edmonton Oilers
    /// </summary>
    [JsonProperty("name")]
    public MetadataName Name { get; set; }

    /// <summary>
    /// The NHL team abbreviation for the metadata <br/>
    /// Example: EDM
    /// </summary>
    [JsonProperty("tricode")]
    public string Tricode { get; set; }

    /// <summary>
    /// The NHL team identifier for the metadata <br/>
    /// Example: 22 - Edmonton Oilers
    /// </summary>
    [JsonProperty("teamId")]
    public int TeamId { get; set; }
}
