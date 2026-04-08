using Newtonsoft.Json;

namespace Nhl.Api.Models.Team;

/// <summary>
/// The NHL Edge team skating distance top 10 response item.
/// </summary>
public class TeamSkatingDistanceTop10
{
    /// <summary>
    /// The team metadata for the top 10 skating distance response item.
    /// </summary>
    [JsonProperty("team")]
    public required TeamSkatingDistanceTop10Team Team { get; set; }

    /// <summary>
    /// The team's total distance skated.
    /// </summary>
    [JsonProperty("distanceTotal")]
    public required TeamComparisonMeasurement DistanceTotal { get; set; }

    /// <summary>
    /// The team's distance skated per 60 minutes.
    /// </summary>
    [JsonProperty("distancePer60")]
    public required TeamComparisonMeasurement DistancePer60 { get; set; }

    /// <summary>
    /// The team's maximum distance skated in a game.
    /// </summary>
    [JsonProperty("distanceMaxPerGame")]
    public required TeamComparisonMeasurementWithOverlay DistanceMaxPerGame { get; set; }

    /// <summary>
    /// The team's maximum distance skated in a period.
    /// </summary>
    [JsonProperty("distanceMaxPerPeriod")]
    public required TeamComparisonMeasurementWithOverlay DistanceMaxPerPeriod { get; set; }
}

/// <summary>
/// The NHL Edge team metadata for a top 10 skating distance response item.
/// </summary>
public class TeamSkatingDistanceTop10Team
{
    /// <summary>
    /// The team common name.
    /// </summary>
    [JsonProperty("commonName")]
    public required CommonName CommonName { get; set; }

    /// <summary>
    /// The team place name with preposition.
    /// </summary>
    [JsonProperty("placeNameWithPreposition")]
    public required TeamSkatingDistanceTop10PlaceNameWithPreposition PlaceNameWithPreposition { get; set; }

    /// <summary>
    /// The team abbreviation.
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The team logo URLs.
    /// </summary>
    [JsonProperty("teamLogo")]
    public required TeamComparisonTeamLogo TeamLogo { get; set; }

    /// <summary>
    /// The team slug.
    /// </summary>
    [JsonProperty("slug")]
    public required string Slug { get; set; }
}

/// <summary>
/// The team place name with preposition for a top 10 skating distance response item.
/// </summary>
public class TeamSkatingDistanceTop10PlaceNameWithPreposition
{
    /// <summary>
    /// The default place name with preposition.
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }

    /// <summary>
    /// The French place name with preposition when present.
    /// </summary>
    [JsonProperty("fr")]
    public string? Fr { get; set; }
}
