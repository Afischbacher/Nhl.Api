using System.Collections.Generic;
using Newtonsoft.Json;
using Nhl.Api.Models.Player;

namespace Nhl.Api.Models.Team;
/// <summary>
/// An NHL team roster by season with forwards, defensemen and goalies
/// </summary>
public class TeamSeasonRoster
{
    /// <summary>
    /// The NHL team season roster forwards
    /// </summary>
    [JsonProperty("forwards")]
    public required List<TeamSeasonRosterForward> Forwards { get; set; }

    /// <summary>
    /// The NHL team season roster defensemen
    /// </summary>
    [JsonProperty("defensemen")]
    public required List<TeamSeasonRosterDefenseman> Defensemen { get; set; }

    /// <summary>
    /// The NHL team season roster goalies
    /// </summary>
    [JsonProperty("goalies")]
    public required List<TeamSeasonRosterGoalie> Goalies { get; set; }
}

/// <summary>
/// The NHL birth city for the NHL player
/// </summary>
public class BirthCity
{
    /// <summary>
    /// The English name of the NHL birth city for the NHL player <br/>
    /// Example: Toronto
    /// </summary>  
    [JsonProperty("default")]
    public required string Default { get; set; }

    /// <summary>
    /// The French name of the NHL birth city for the NHL player <br/>
    /// Example: Sainte-Marie
    /// </summary>
    [JsonProperty("fr")]
    public required string Fr { get; set; }
}

/// <summary>
/// The NHL player birth state or province
/// </summary>
public class BirthStateProvince
{
    /// <summary>
    /// The English name of the NHL birth state or province for the NHL player <br/>
    /// Example: Ontario
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }

    /// <summary>
    /// The French name of the NHL birth state or province for the NHL player <br/>
    /// Example: Californie
    /// </summary>
    [JsonProperty("fr")]
    public required string Fr { get; set; }
}

/// <summary>
/// The NHL team season roster member information for a specific NHL team
/// </summary>
public abstract class TeamRosterPlayer
{
    /// <summary>
    /// The NHL player identifier <br/>
    /// Example: 8478402
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL player headshot image link url <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/TOR/8479318.png">https://assets.nhle.com/mugs/nhl/20232024/TOR/8479318.png</a>
    /// </summary>
    [JsonProperty("headshot")]
    public required string Headshot { get; set; }

    /// <summary>
    /// The first name of the NHL player <br/>
    /// Example: Auston
    /// </summary>
    [JsonProperty("firstName")]
    public required FirstName FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL player <br/>
    /// Example: Matthews
    /// </summary>
    [JsonProperty("lastName")]
    public required LastName LastName { get; set; }

    /// <summary>
    /// The NHL player jersey number <br/>
    /// Example: 34
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int SweaterNumber { get; set; }

    /// <summary>
    /// The NHL player position code <br/>
    /// Example: C
    /// </summary>
    [JsonProperty("positionCode")]
    public required string PositionCode { get; set; }

    /// <summary>
    /// The NHL player shoots or catches position <br/>
    /// Example: L or R
    /// </summary>
    [JsonProperty("shootsCatches")]
    public required string ShootsCatches { get; set; }

    /// <summary>
    /// The NHL player height in inches <br/>
    /// Example: 73
    /// </summary>
    [JsonProperty("heightInInches")]
    public int HeightInInches { get; set; }

    /// <summary>
    /// The NHL player weight in pounds <br/>
    /// Example: 203
    /// </summary>
    [JsonProperty("weightInPounds")]
    public int WeightInPounds { get; set; }

    /// <summary>
    /// The NHL player height in centimeters <br/>
    /// Example: 185
    /// </summary>
    [JsonProperty("heightInCentimeters")]
    public int HeightInCentimeters { get; set; }

    /// <summary>
    /// The NHL player weight in kilograms <br/>
    /// Example: 92
    /// </summary>
    [JsonProperty("weightInKilograms")]
    public int WeightInKilograms { get; set; }

    /// <summary>
    /// The NHL player birth date <br/>
    /// Example: 1997-09-17
    /// </summary>
    [JsonProperty("birthDate")]
    public required string BirthDate { get; set; }

    /// <summary>
    /// The NHL player birth city 
    /// </summary>
    [JsonProperty("birthCity")]
    public required BirthCity BirthCity { get; set; }

    /// <summary>
    /// The NHL playter birth country <br/>
    /// Example: CAN or USA
    /// </summary>
    [JsonProperty("birthCountry")]
    public required string BirthCountry { get; set; }

    /// <summary>
    /// The NHL player birth state or province <br/>
    /// Example: Ontario
    /// </summary>
    [JsonProperty("birthStateProvince")]
    public required BirthStateProvince BirthStateProvince { get; set; }

    /// <summary>
    /// The NHL player full name
    /// </summary>  
    public string FullName => $"{this.FirstName?.Default} {this.LastName?.Default}";
}

/// <summary>
/// The NHL team season roster defenseman information for a specific NHL team
/// </summary>
public class TeamSeasonRosterDefenseman : TeamRosterPlayer
{

}

/// <summary>
/// The NHL team season roster forward information for a specific NHL team
/// </summary>
public class TeamSeasonRosterForward : TeamRosterPlayer
{

}

/// <summary>
/// The NHL team season roster goalie information for a specific NHL team
/// </summary>
public class TeamSeasonRosterGoalie : TeamRosterPlayer
{

}
