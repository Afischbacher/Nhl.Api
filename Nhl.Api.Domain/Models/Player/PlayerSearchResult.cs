using Newtonsoft.Json;
using Nhl.Api.Common.Helpers;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Player;
/// <summary>
/// NHL Player Search Result
/// </summary>
public class PlayerSearchResult
{
    /// <summary>
    /// The NHL player id <br/>
    /// Example: 8447400
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The full name of the NHL player <br/>
    /// Example: Connor Bedard
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// First name of NHL player <br/>
    /// Example: Wayne
    /// </summary>
    public string? FirstName => this.Name?.Split(' ')[0];

    /// <summary>
    /// Last name of NHL player <br/>
    /// Example: Gretzky
    /// </summary>
    public string? LastName => this.Name?.Split(' ')[1];

    /// <summary>
    /// Height of the NHL player in feet and inches <br/>
    /// Example: 6\u0027 0\"
    /// </summary>
    [JsonProperty("height")]
    public required string Height { get; set; }

    /// <summary>
    /// Height of the NHL player in centimeters <br/>
    /// Example: 183
    /// </summary>  
    [JsonProperty("heightInCentimeters")]
    public required string HeightInCentimeters { get; set; }

    /// <summary>
    /// Weight of the NHL player in pounds <br/>
    /// Example: 185
    /// </summary>
    [JsonProperty("weightInPounds")]
    public required string Weight { get; set; }

    /// <summary>
    /// Weight of the NHL player in kilograms <br/>
    /// Example: 185
    /// </summary>
    [JsonProperty("weightInKilograms")]
    public required string WeightInKilograms { get; set; }


    /// <summary>
    /// City of birth for the NHL player <br/>
    /// Example: Brantford
    /// </summary>
    [JsonProperty("birthCity")]
    public required string BirthCity { get; set; }

    /// <summary>
    /// Province or state of birth for the NHL player <br/>
    /// Example: ON
    /// </summary>
    [JsonProperty("birthStateProvince")]
    public required string BirthProvinceState { get; set; }

    /// <summary>
    /// Country of birth for the NHL player <br/>
    /// Example: CAN
    /// </summary>
    [JsonProperty("birthCountry")]
    public required string BirthCountry { get; set; }

    /// <summary>
    /// The full name of the birth country of the NHL Player <br/>
    /// Example: Canada
    /// </summary>
    [JsonProperty("fullBirthCountry")]
    public string FullBirthCountry => CountryCodeHelper.ConvertThreeDigitCountryCodeToFullCountryName(this.BirthCountry);

    /// <summary>
    /// Is the player currently active in the NHL
    /// </summary>
    [JsonProperty("active")]
    public bool IsActive { get; set; }

    /// <summary>
    /// The 3 letter code for the NHL team the NHL player played with <br/>
    /// See <see cref="TeamCodes"/> for more information on 3 letter codes<br/>
    /// Example: NYR
    /// </summary>
    [JsonProperty("lastTeamOfPlay")]
    public required string LastTeamOfPlay { get; set; }

    /// <summary>
    /// The position for the NHL player <br/>
    /// Example: C
    /// </summary>
    [JsonProperty("positionCode")]
    public required string Position { get; set; }

    /// <summary>
    /// The jersey number for the NHL player <br/>
    /// Example: C
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int? PlayerNumber { get; set; }

    /// <summary>
    /// The team identifier for the NHL team the NHL player played with <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("teamId")]
    public required string TeamId { get; set; }

    /// <summary>
    /// The team abbreviation for the NHL team the NHL player played with <br/>
    /// Example: PIT
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public required string TeamAbbreviation { get; set; }

    /// <summary>
    /// The team name for the NHL team the NHL player played last with <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("lastTeamId")]
    public required string LastTeamId { get; set; }

    /// <summary>
    /// The last team abbreviation for the NHL team the NHL player played with <br/>
    /// Example: TOR
    /// </summary>
    [JsonProperty("lastTeamAbbrev")]
    public required string LastTeamAbbreviation { get; set; }

    /// <summary>
    /// The last season identifier for the NHL team the NHL player played with <br/>   
    /// Example: 20232024
    /// </summary>
    [JsonProperty("lastSeasonId")]
    public required object LastSeasonId { get; set; }


}
