﻿using Newtonsoft.Json;

namespace Nhl.Api.Models.Game;
/// <summary>
/// NHL Team League Record
/// </summary>
public class LeagueRecord
{
    /// <summary>
    /// Number of NHL team wins
    /// </summary>
    [JsonProperty("wins")]
    public int Wins { get; set; }

    /// <summary>
    /// Number of NHL team losses
    /// </summary>
    [JsonProperty("losses")]
    public int Losses { get; set; }

    /// <summary>
    /// Number of NHL team over time games
    /// </summary>
    [JsonProperty("ot")]
    public int Ot { get; set; }

    /// <summary>
    /// The type of record within the NHL <br/>
    /// Example: league
    /// </summary>
    [JsonProperty("type")]
    public required string Type { get; set; }
}
