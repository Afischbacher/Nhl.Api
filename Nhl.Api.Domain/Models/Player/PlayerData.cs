﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Player;
/// <summary>
/// The NHL player search result
/// </summary>
public class PlayerDataSearchResult
{
    /// <summary>
    /// The unique identifier for the NHL player <br/>
    /// Example: 8478402 - Connor McDavid
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The current team identifier for the NHL player <br/>
    /// Example: 14 - Tampa Bay Lightning
    /// </summary>
    [JsonProperty("currentTeamId")]
    public int? CurrentTeamId { get; set; }

    /// <summary>
    /// The first name of the NHL player <br/>
    /// Example: Connor
    /// </summary>
    [JsonProperty("firstName")]
    public required string FirstName { get; set; }

    /// <summary>
    /// The full name of the NHL player <br/>
    /// Example: Connor McDavid
    /// </summary>
    [JsonProperty("fullName")]
    public required string FullName { get; set; }

    /// <summary>
    /// The last name of the NHL player <br/>
    /// Example: McDavid
    /// </summary>
    [JsonProperty("lastName")]
    public required string LastName { get; set; }

    /// <summary>
    /// The position code of the NHL player <br/>
    /// Excample: C - Center    
    /// </summary>
    [JsonProperty("positionCode")]
    public required string PositionCode { get; set; }

    /// <summary>
    /// The sweater number of the NHL player <br/>
    /// Example: 97 - Connor McDavid
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int? SweaterNumber { get; set; }
}

/// <summary>
/// The NHL player data model for the returned NHL API player data
/// </summary>
public class PlayerData
{
    /// <summary>
    /// The list of NHL players in the response of the search
    /// </summary>
    [JsonProperty("data")]
    public List<PlayerDataSearchResult> Data { get; set; } = [];

    /// <summary>
    /// The total number of NHL players in the NHL 
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }
}
