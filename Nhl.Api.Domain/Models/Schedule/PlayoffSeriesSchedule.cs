using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Schedule;


/// <summary>
/// Represents the base class of a seeded team.
/// </summary>
public abstract class Seed
{
    /// <summary>
    /// Gets or sets the unique identifier for the team.<br/>
    /// Example: 13
    /// </summary>
    [JsonProperty("id")]
    public int? Id { get; set; }

    /// <summary>
    /// Gets or sets the abbreviated team name.<br/>
    /// Example: "FLA"
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// Gets or sets the number of wins for the team.<br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("wins")]
    public int? Wins { get; set; }

    /// <summary>
    /// Gets or sets the URL of the team's light mode logo.<br/>
    /// Example: "https://assets.nhle.com/logos/nhl/svg/FLA_light.svg"
    /// </summary>
    [JsonProperty("logo")]
    public required string Logo { get; set; }

    /// <summary>
    /// Gets or sets the URL of the team's dark mode logo.<br/>
    /// Example: "https://assets.nhle.com/logos/nhl/svg/FLA_dark.svg"
    /// </summary>
    [JsonProperty("darkLogo")]
    public required string DarkLogo { get; set; }
}

/// <summary>
/// Represents the details of a bottom seeded team.
/// </summary>
public class BottomSeed : Seed
{
}

/// <summary>
/// Represents the details of a top seeded team.
/// </summary>
public class TopSeed : Seed
{
}

/// <summary>
/// Represents the schedule for playoff series within a season.
/// </summary>
public class PlayoffSeriesSchedule
{
    /// <summary>
    /// Gets or sets the identifier for the season.<br/>
    /// Example: 20242025
    /// </summary>
    [JsonProperty("seasonId")]
    public int? SeasonId { get; set; }

    /// <summary>
    /// Gets or sets the current round of the playoffs.<br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("currentRound")]
    public int? CurrentRound { get; set; }

    /// <summary>
    /// Gets or sets the list of rounds in the playoff series schedule.<br/>
    /// Example: new List&lt;Round&gt; { /* Round objects */ }
    /// </summary>
    [JsonProperty("rounds")]
    public List<Round> Rounds { get; set; } = [];
}

/// <summary>
/// Represents a single round in the playoff schedule.
/// </summary>
public class Round
{
    /// <summary>
    /// Gets or sets the number of the round.<br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("roundNumber")]
    public int? RoundNumber { get; set; }

    /// <summary>
    /// Gets or sets the label for the round (e.g., "1st-round").<br/>
    /// Example: "1st-round"
    /// </summary>
    [JsonProperty("roundLabel")]
    public required string RoundLabel { get; set; }

    /// <summary>
    /// Gets or sets the abbreviated label for the round (e.g., "R1").<br/>
    /// Example: "R1"
    /// </summary>
    [JsonProperty("roundAbbrev")]
    public required string RoundAbbrev { get; set; }

    /// <summary>
    /// Gets or sets the list of playoff series in this round.<br/>
    /// Example: new List&lt;Series&gt; { /* Series objects */ }
    /// </summary>
    [JsonProperty("series")]
    public List<Series> Series { get; set; } = new List<Series>();
}

/// <summary>
/// Represents a playoff series between two teams.
/// </summary>
public class Series
{
    /// <summary>
    /// Gets or sets the series letter (e.g., "A", "B", etc.).<br/>
    /// Example: "A"
    /// </summary>
    [JsonProperty("seriesLetter")]
    public required string SeriesLetter { get; set; }

    /// <summary>
    /// Gets or sets the round number associated with the series.<br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("roundNumber")]
    public int? RoundNumber { get; set; }

    /// <summary>
    /// Gets or sets the label for the series.<br/>
    /// Example: "1st-round"
    /// </summary>
    [JsonProperty("seriesLabel")]
    public required string SeriesLabel { get; set; }

    /// <summary>
    /// Gets or sets the URL link for the series details.<br/>
    /// Example: "/schedule/playoff-series/2025/series-a/bluejackets-vs-panthers"
    /// </summary>
    [JsonProperty("seriesLink")]
    public required string SeriesLink { get; set; }

    /// <summary>
    /// Gets or sets the details of the bottom seeded team in the series.<br/>
    /// Example: <code> new BottomSeed { Id = 29, Abbrev = "CBJ", Wins = 0, Logo = "https://assets.nhle.com/logos/nhl/svg/CBJ_light.svg", DarkLogo = "https://assets.nhle.com/logos/nhl/svg/CBJ_dark.svg" } </code>
    /// </summary>
    [JsonProperty("bottomSeed")]
    public required BottomSeed BottomSeed { get; set; }

    /// <summary>
    /// Gets or sets the details of the top seeded team in the series.<br/>
    /// Example: <code> new TopSeed { Id = 13, Abbrev = "FLA", Wins = 0, Logo = "https://assets.nhle.com/logos/nhl/svg/FLA_light.svg", DarkLogo = "https://assets.nhle.com/logos/nhl/svg/FLA_dark.svg" } </code> 
    /// </summary>
    [JsonProperty("topSeed")]
    public required TopSeed TopSeed { get; set; }

    /// <summary>
    /// Gets or sets the number of wins required to win the series.<br/>Example: 4
    /// </summary>
    [JsonProperty("neededToWin")]
    public int? NeededToWin { get; set; }
}
