namespace Nhl.Api.Models.Player;
using Newtonsoft.Json;
using System.Collections.Generic;


/// <summary>
/// NHL Live Game Feed Player Shifts
/// </summary>
public class LiveGameFeedPlayerShifts
{
    /// <summary>
    /// Returns a collection of each individual NHL player and their shift information
    /// </summary>
    [JsonProperty("data")]
    public List<PlayerShiftInformation> PlayerShifts { get; set; }

    /// <summary>
    /// Returns the total number of NHL player shifts within an NHL game <br/>
    /// Example: 827
    /// </summary>
    [JsonProperty("total")]
    public int Total { get; set; }
}

/// <summary>
/// Returns information about each player and the NHL individual shift information
/// </summary>
public class PlayerShiftInformation
{
    /// <summary>
    /// The identifier for the individual NHL player shift information <br/>
    /// Example: 10472188
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// Returns the detail code for the NHL player shift <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("detailCode")]
    public int DetailCode { get; set; }

    /// <summary>
    /// Returns the shift duration for the NHL player shift <br/>
    /// Example: 00:35
    /// </summary>
    [JsonProperty("duration")]
    public string Duration { get; set; }

    /// <summary>
    /// Returns the end time within the period "01:51"for the NHL player shift <br/>
    /// Example: 01:51
    /// </summary>
    [JsonProperty("endTime")]
    public string EndTime { get; set; }

    /// <summary>
    /// Returns the event description for the NHL player shift
    /// </summary>
    [JsonProperty("eventDescription")]
    public object EventDescription { get; set; }

    /// <summary>
    /// Returns the event details for the NHL player shift
    /// </summary>
    [JsonProperty("eventDetails")]
    public object EventDetails { get; set; }

    /// <summary>
    /// Returns the event number for the NHL player shift <br/>
    /// Example: 153
    /// </summary>
    [JsonProperty("eventNumber")]
    public int? EventNumber { get; set; }

    /// <summary>
    /// Returns the first name of the player for the NHL player shift <br/>
    /// Example: Alex
    /// </summary>
    [JsonProperty("firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// Returns the game id that is associated with the NHL player shift <br/>
    /// Example: 2020020239
    /// </summary>
    [JsonProperty("gameId")]
    public int GameId { get; set; }

    /// <summary>
    /// Returns the a hexadecimal value associated with the color of the NHL team for the NHL player shift <br/>
    /// Example: #862633
    /// </summary>
    [JsonProperty("hexValue")]
    public string HexValue { get; set; }

    /// <summary>
    /// Returns the last name of the player for the NHL player shift <br/>
    /// Example: Goligoski
    /// </summary>
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// Returns the period number for the NHL player shift <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// Returns the NHL player id for the NHL player shift <br/>
    /// Example: 8471274
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// Returns the shift number for NHL player within NHL player shift <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("shiftNumber")]
    public int ShiftNumber { get; set; }

    /// <summary>
    /// Returns the start time for the NHL player within the NHL player shift <br/>
    /// Example: 01:16
    /// </summary>
    [JsonProperty("startTime")]
    public string StartTime { get; set; }

    /// <summary>
    /// Returns the team abbreviation for the NHL player within the NHL player shift <br/>
    /// Example: ARI
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public string TeamAbbrev { get; set; }

    /// <summary>
    /// Returns the NHL team id for the NHL player shift <br/>
    /// Example: 53
    /// </summary>
    [JsonProperty("teamId")]
    public int TeamId { get; set; }

    /// <summary>
    /// Returns the NHL team name for the NHL player shift <br/>
    /// Example: Arizona Coyotes
    /// </summary>
    [JsonProperty("teamName")]
    public string TeamName { get; set; }

    /// <summary>
    /// Returns the type code for the NHL player shift <br/>
    /// Example: 517
    /// </summary>
    [JsonProperty("typeCode")]
    public int TypeCode { get; set; }
}
