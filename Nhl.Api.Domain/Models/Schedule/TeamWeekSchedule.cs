﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Schedule;
/// <summary>
/// An NHL team's week based schedule with the start and end date for the week and games for the week
/// </summary>
public class TeamWeekSchedule
{
    /// <summary>
    /// The previous start date of the weeks schedule <br/>
    /// Example: 2023-11-07
    /// </summary>
    [JsonProperty("previousStartDate")]
    public required string PreviousStartDate { get; set; }

    /// <summary>
    /// The next start date of the weeks schedule <br/>
    /// Example: 2023-11-21
    /// </summary>
    [JsonProperty("nextStartDate")]
    public required string NextStartDate { get; set; }

    /// <summary>
    /// The calendar url for all of the NHL teams games using Rokt Calendar <br/>
    /// Example: <a href="https://nhl.calreplyapp.com/maple-leafs">https://nhl.calreplyapp.com/maple-leafs</a>
    /// </summary>
    [JsonProperty("calendarUrl")]
    public required string CalendarUrl { get; set; }

    /// <summary>
    /// This returns the NHL team's time zone <br/>
    /// Example: America/Toronto
    /// </summary>
    [JsonProperty("clubTimezone")]
    public required string ClubTimezone { get; set; }

    /// <summary>
    /// This returns the NHL team's time zone offset in hours <br/>
    ///  Example: -05:00
    /// </summary>
    [JsonProperty("clubUTCOffset")]
    public required string ClubUTCOffset { get; set; }

    /// <summary>
    /// The NHL team's schedule for the season in a list of games
    /// </summary>
    [JsonProperty("games")]
    public List<Game> Games { get; set; } = [];
}
