using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Draft;

/// <summary>
/// The NHL draft player category
/// </summary>
public class PlayerDraftCategory
{
    /// <summary>
    /// The ID of the player draft category
    /// </summary>
    [JsonProperty("id")]
    public int? Id { get; set; }

    /// <summary>
    /// The name of the player draft category
    /// </summary>
    [JsonProperty("name")]
    public string Name { get; set; }

    /// <summary>
    /// The consumer key of the player draft category
    /// </summary>
    [JsonProperty("consumerKey")]
    public string ConsumerKey { get; set; }
}

/// <summary>
/// The NHL draft player ranking for each prospective player
/// </summary>
public class PlayerDraftRanking
{
    /// <summary>
    /// The last name of the player
    /// </summary>
    [JsonProperty("lastName")]
    public string LastName { get; set; }

    /// <summary>
    /// The first name of the player
    /// </summary>
    [JsonProperty("firstName")]
    public string FirstName { get; set; }

    /// <summary>
    /// The position code of the player
    /// </summary>
    [JsonProperty("positionCode")]
    public string PositionCode { get; set; }

    /// <summary>
    /// The shooting or catching hand of the player
    /// </summary>
    [JsonProperty("shootsCatches")]
    public string ShootsCatches { get; set; }

    /// <summary>
    /// The height of the player in inches
    /// </summary>
    [JsonProperty("heightInInches")]
    public int? HeightInInches { get; set; }

    /// <summary>
    /// The weight of the player in pounds
    /// </summary>
    [JsonProperty("weightInPounds")]
    public int? WeightInPounds { get; set; }

    /// <summary>
    /// The last amateur club of the player
    /// </summary>
    [JsonProperty("lastAmateurClub")]
    public string LastAmateurClub { get; set; }

    /// <summary>
    /// The last amateur league of the player
    /// </summary>
    [JsonProperty("lastAmateurLeague")]
    public string LastAmateurLeague { get; set; }

    /// <summary>
    /// The birth date of the player
    /// </summary>
    [JsonProperty("birthDate")]
    public string BirthDate { get; set; }

    /// <summary>
    /// The birth city of the player
    /// </summary>
    [JsonProperty("birthCity")]
    public string BirthCity { get; set; }

    /// <summary>
    /// The birth state or province of the player
    /// </summary>
    [JsonProperty("birthStateProvince")]
    public string BirthStateProvince { get; set; }

    /// <summary>
    /// The birth country of the player
    /// </summary>
    [JsonProperty("birthCountry")]
    public string BirthCountry { get; set; }

    /// <summary>
    /// The midterm rank of the player
    /// </summary>
    [JsonProperty("midtermRank")]
    public int? MidtermRank { get; set; }

    /// <summary>
    /// The final rank of the player
    /// </summary>
    [JsonProperty("finalRank")]
    public int? FinalRank { get; set; }
}

/// <summary>
/// The NHL draft player draft year with all players and their information and rankings
/// </summary>
public class PlayerDraftYear
{
    /// <summary>
    /// The draft year
    /// </summary>
    [JsonProperty("draftYear")]
    public int? DraftYear { get; set; }

    /// <summary>
    /// The category ID
    /// </summary>
    [JsonProperty("categoryId")]
    public int? CategoryId { get; set; }

    /// <summary>
    /// The category key
    /// </summary>
    [JsonProperty("categoryKey")]
    public string? CategoryKey { get; set; }

    /// <summary>
    /// The list of draft years
    /// </summary>
    [JsonProperty("draftYears")]
    public List<int?> DraftYears { get; set; } = [];

    /// <summary>
    /// The list of player draft categories
    /// </summary>
    [JsonProperty("categories")]
    public List<PlayerDraftCategory> Categories { get; set; } = [];

    /// <summary>
    /// The list of player draft rankings
    /// </summary>
    [JsonProperty("rankings")]
    public List<PlayerDraftRanking> Rankings { get; set; } = [];
}
