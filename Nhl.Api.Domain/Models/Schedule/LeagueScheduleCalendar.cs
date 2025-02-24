using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Schedule;
/// <summary>
/// The common name of the NHL team
/// </summary>
public class CommonName
{
    /// <summary>
    /// The default English name of the NHL team
    /// Example: Devils
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
    /// <summary>
    /// The French name of the NHL team
    /// Example: Devils
    /// </summary>
    [JsonProperty("fr")]
    public required string Fr { get; set; }
}

/// <summary>
/// The name of the NHL team
/// </summary>
public class Name
{
    /// <summary>
    /// The default English name of the NHL team
    /// Example: Tampa Bay Lightning
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }

    /// <summary>
    /// The French name of the NHL team
    /// Example: Lightning de Tampa Bay
    /// </summary>
    [JsonProperty("fr")]
    public required string Fr { get; set; }
}


/// <summary>
/// The NHL league schedule calendar information
/// </summary>
public class LeagueScheduleCalendar
{
    /// <summary>
    /// The end date of the NHL league schedule calendar
    /// Example: 2024-04-06
    /// </summary>
    [JsonProperty("endDate")]
    public required string EndDate { get; set; }

    /// <summary>
    /// The next start date of the NHL league schedule calendar
    /// Example: 2024-04-07
    /// </summary>
    [JsonProperty("nextStartDate")]
    public required string NextStartDate { get; set; }

    /// <summary>
    /// The previous start date of the NHL league schedule calendar
    /// Example: 2024-04-05
    /// </summary>
    [JsonProperty("previousStartDate")]
    public required string PreviousStartDate { get; set; }

    /// <summary>
    /// The start date of the NHL league schedule calendar
    /// Example: 2024-04-07
    /// </summary>
    [JsonProperty("startDate")]
    public required string StartDate { get; set; }

    /// <summary>
    /// The total number of items in the NHL league schedule calendar
    /// </summary>
    [JsonProperty("teams")]
    public required List<LeagueScheduleCalendarTeam> Teams { get; set; }
}

/// <summary>
/// The NHL league schedule calendar team information
/// </summary>
public class LeagueScheduleCalendarTeam
{
    /// <summary>
    /// The NHL team identifier for the team <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The season identifier for the NHL league schedule calendar team <br/>
    /// Example: 20242025
    /// </summary>
    [JsonProperty("seasonId")]
    public int SeasonId { get; set; }

    /// <summary>
    /// The common name of the NHL team
    /// </summary>
    [JsonProperty("commonName")]
    public required CommonName CommonName { get; set; }

    /// <summary>
    /// The abbreviation of the NHL team <br/>
    /// Example: NYR
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The name of the NHL team <br/>
    /// Example: New York Rangers
    /// </summary>
    [JsonProperty("name")]
    public required Name Name { get; set; }

    /// <summary>
    /// The place name of the NHL team <br/>
    /// Example: NY Rangers
    /// </summary>
    [JsonProperty("placeName")]
    public required PlaceName PlaceName { get; set; }

    /// <summary>
    /// The light logo of the NHL team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/NYR_light.svg">https://assets.nhle.com/logos/nhl/svg/NYR_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public required string Logo { get; set; }

    /// <summary>
    /// The dark logo of the NHL team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/NYR_dark.svg">https://assets.nhle.com/logos/nhl/svg/NYR_light.svg</a>
    /// </summary>
    [JsonProperty("darkLogo")]
    public required string DarkLogo { get; set; }

    /// <summary>
    /// Is the team an NHL team <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("isNhl")]
    public bool IsNhl { get; set; }

    /// <summary>
    /// Is the NHL team of French origin <br/>
    /// Example: false or true
    /// </summary>
    [JsonProperty("french")]
    public bool French { get; set; }
}
