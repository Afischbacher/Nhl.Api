namespace Nhl.Api.Models.Team;
using Newtonsoft.Json;
using Nhl.Api.Models.Player;
using System.Collections.Generic;

/// <summary>
/// An NHL team roster by season with forwards, defensemen and goalies
/// </summary>
public class TeamSeasonRoster
{
    /// <summary>
    /// The NHL team season roster forwards
    /// </summary>
    [JsonProperty("forwards")]
    public List<TeamSeasonRosterForward> Forwards { get; set; }

    /// <summary>
    /// The NHL team season roster defensemen
    /// </summary>
    [JsonProperty("defensemen")]
    public List<TeamSeasonRosterDefenseman> Defensemen { get; set; }

    /// <summary>
    /// The NHL team season roster goalies
    /// </summary>
    [JsonProperty("goalies")]
    public List<TeamSeasonRosterGoalie> Goalies { get; set; }
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
    public string Default { get; set; }

    /// <summary>
    /// The French name of the NHL birth city for the NHL player <br/>
    /// Example: Sainte-Marie
    /// </summary>
    [JsonProperty("fr")]
    public string Fr { get; set; }
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
    public string Default { get; set; }

    /// <summary>
    /// The French name of the NHL birth state or province for the NHL player <br/>
    /// Example: Californie
    /// </summary>
    [JsonProperty("fr")]
    public string Fr { get; set; }
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
    public string Headshot { get; set; }

    /// <summary>
    /// The first name of the NHL player <br/>
    /// Example: Auston
    /// </summary>
    [JsonProperty("firstName")]
    public FirstName FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL player <br/>
    /// Example: Matthews
    /// </summary>
    [JsonProperty("lastName")]
    public LastName LastName { get; set; }

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
    public string PositionCode { get; set; }

    /// <summary>
    /// The NHL player shoots or catches position <br/>
    /// Example: L or R
    /// </summary>
    [JsonProperty("shootsCatches")]
    public string ShootsCatches { get; set; }

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
    public string BirthDate { get; set; }

    /// <summary>
    /// The NHL player birth city 
    /// </summary>
    [JsonProperty("birthCity")]
    public BirthCity BirthCity { get; set; }

    /// <summary>
    /// The NHL playter birth country <br/>
    /// Example: CAN or USA
    /// </summary>
    [JsonProperty("birthCountry")]
    public string BirthCountry { get; set; }

    /// <summary>
    /// The NHL player birth state or province <br/>
    /// Example: Ontario
    /// </summary>
    [JsonProperty("birthStateProvince")]
    public BirthStateProvince BirthStateProvince { get; set; }

    /// <summary>
    /// The NHL player full name
    /// </summary>  
    public string FullName => $"{FirstName?.Default} {LastName?.Default}";
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
