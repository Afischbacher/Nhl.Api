﻿using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Game;
/// <summary>
/// The NHL TV schedule broadcast information
/// </summary>
public class TvScheduleBroadcastInformation
{
    /// <summary>
    /// The start time of the NHL broadcast <br/>
    /// Example: 2021-10-13T23:00:00Z
    /// </summary>
    [JsonProperty("startTime")]
    public DateTime StartTime { get; set; }

    /// <summary>
    /// The end time of the NHL broadcast <br/>
    /// Example: 2021-10-14T01:30:00Z
    /// </summary>
    [JsonProperty("endTime")]
    public DateTime EndTime { get; set; }

    /// <summary>
    /// The duration of the NHL broadcast in seconds <br/>
    /// Example: 3600
    /// </summary>
    [JsonProperty("durationSeconds")]
    public int DurationSeconds { get; set; }

    /// <summary>
    /// The title of the NHL broadcast <br/>
    /// Example: NHL Tonight: Pre-Game Skate
    /// </summary>
    [JsonProperty("title")]
    public required string Title { get; set; }

    /// <summary>
    /// The description of the NHL broadcast <br/>
    /// Example: NHL Tonight: Pre-Game Skate
    /// </summary>
    [JsonProperty("description")]
    public required string Description { get; set; }

    /// <summary>
    /// The broadcast house number <br/>
    /// Example: HPGS24R111023LV
    /// </summary>
    [JsonProperty("houseNumber")]
    public required string HouseNumber { get; set; }

    /// <summary>
    /// The NHL broadcast type <br/>
    /// Example: HD
    /// </summary>
    [JsonProperty("broadcastType")]
    public required string BroadcastType { get; set; }

    /// <summary>
    /// The NHL broadcast status <br/>
    /// Example: LIVE
    /// </summary>
    [JsonProperty("broadcastStatus")]
    public required string BroadcastStatus { get; set; }

    /// <summary>
    /// The NHL broadcast image URL <br/>
    /// Example: onthefly.png
    /// </summary>
    [JsonProperty("broadcastImageUrl")]
    public required string BroadcastImageUrl { get; set; }
}

/// <summary>
/// The NHL TV schedule broadcast
/// </summary>
public class TvScheduleBroadcast
{
    /// <summary>
    /// The date of the TV broadcast schedule <br/>
    /// Example: 2021-11-10
    /// </summary>
    [JsonProperty("date")]
    public required string Date { get; set; }

    /// <summary>
    /// The start date of the TV broadcast schedule <br/>
    /// Example: 2021-11-10
    /// </summary>
    [JsonProperty("startDate")]
    public required string StartDate { get; set; }

    /// <summary>
    /// The end date of the TV broadcast schedule <br/>
    /// Example: 2021-11-10
    /// </summary>
    [JsonProperty("endDate")]
    public required string EndDate { get; set; }

    /// <summary>
    /// The collection of NHL TV schedule broadcasts
    /// </summary>
    [JsonProperty("broadcasts")]
    public required List<TvScheduleBroadcastInformation> Broadcasts { get; set; }
}
