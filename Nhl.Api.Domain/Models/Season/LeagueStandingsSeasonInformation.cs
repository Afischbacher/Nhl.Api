using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Season;
/// <summary>
/// The NHL league season information
/// </summary>
public class LeagueStandingsSeasonInformation
{
    /// <summary>
    /// Returns the current date
    /// </summary>
    [JsonProperty("currentDate")]
    public string CurrentDate { get; set; }

    /// <summary>
    /// Returns all the NHL seasons and their information
    /// </summary>
    [JsonProperty("seasons")]
    public List<LeagueSeason> Seasons { get; set; }
}

/// <summary>
/// An NHL league season with information of each season and the NHL league
/// </summary>
public class LeagueSeason
{
    /// <summary>
    /// The NHL league season identifier <br/>
    /// Example: 20192020
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The flag indicating if the NHL league season is using conferences <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("conferencesInUse")]
    public bool ConferencesInUse { get; set; }

    /// <summary>
    /// The flag indicating if the NHL league season is using divisions <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("divisionsInUse")]
    public bool DivisionsInUse { get; set; }

    /// <summary>
    /// The flag indicating if the NHL league season is using a point for an overtime loss <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("pointForOTlossInUse")]
    public bool PointForOTlossInUse { get; set; }

    /// <summary>
    /// The flag indicating if the NHL league season has regulation wins in use <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("regulationWinsInUse")]
    public bool RegulationWinsInUse { get; set; }

    /// <summary>
    /// Returns true or false if the row is in use <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("rowInUse")]
    public bool RowInUse { get; set; }

    /// <summary>
    /// Returns the end date of the NHL league standings <br/>
    /// Example: 2022-05-01
    /// </summary>
    [JsonProperty("standingsEnd")]
    public string StandingsEnd { get; set; }

    /// <summary>
    /// Returns the start date of the NHL league standings <br/>
    /// Example: 2021-10-12
    /// </summary>
    [JsonProperty("standingsStart")]
    public string StandingsStart { get; set; }

    /// <summary>
    /// The flag indicating if the NHL league season is using ties <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("tiesInUse")]
    public bool TiesInUse { get; set; }

    /// <summary>
    /// The flag indicating if the NHL league season is using wildcards <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("wildcardInUse")]
    public bool WildcardInUse { get; set; }
}
