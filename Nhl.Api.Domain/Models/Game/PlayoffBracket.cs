using System.Collections.Generic;

namespace Nhl.Api.Models.Game;

/// <summary>
/// Represents the NHL playoff bracket for a given season.
/// </summary>
public class PlayoffBracket
{
    /// <summary>
    /// The URL for the playoff bracket logo (English).
    /// </summary>
    public required string BracketLogo { get; set; }

    /// <summary>
    /// The URL for the playoff bracket logo (French).
    /// </summary>
    public required string BracketLogoFr { get; set; }

    /// <summary>
    /// The list of playoff series in the bracket.
    /// </summary>
    public required List<PlayoffSeries> Series { get; set; }
}

/// <summary>
/// Represents a single playoff series in the NHL playoff bracket.
/// </summary>
public class PlayoffSeries
{
    /// <summary>
    /// The URL for the playoff series details.
    /// </summary>
    public required string SeriesUrl { get; set; }

    /// <summary>
    /// The title of the playoff series (e.g., "1st Round").
    /// </summary>
    public required string SeriesTitle { get; set; }

    /// <summary>
    /// The abbreviation for the playoff series (e.g., "R1").
    /// </summary>
    public required string SeriesAbbrev { get; set; }

    /// <summary>
    /// The letter identifier for the playoff series (e.g., "A").
    /// </summary>
    public required string SeriesLetter { get; set; }

    /// <summary>
    /// The playoff round number.
    /// </summary>
    public required int PlayoffRound { get; set; }

    /// <summary>
    /// The rank of the top seed team.
    /// </summary>
    public required int TopSeedRank { get; set; }

    /// <summary>
    /// The abbreviation for the top seed rank.
    /// </summary>
    public required string TopSeedRankAbbrev { get; set; }

    /// <summary>
    /// The number of wins by the top seed team.
    /// </summary>
    public required int TopSeedWins { get; set; }

    /// <summary>
    /// The rank of the bottom seed team.
    /// </summary>
    public required int BottomSeedRank { get; set; }

    /// <summary>
    /// The abbreviation for the bottom seed rank.
    /// </summary>
    public required string BottomSeedRankAbbrev { get; set; }

    /// <summary>
    /// The number of wins by the bottom seed team.
    /// </summary>
    public required int BottomSeedWins { get; set; }

    /// <summary>
    /// The ID of the winning team.
    /// </summary>
    public required int WinningTeamId { get; set; }

    /// <summary>
    /// The ID of the losing team.
    /// </summary>
    public required int LosingTeamId { get; set; }

    /// <summary>
    /// The top seed team details.
    /// </summary>
    public required PlayoffTeam TopSeedTeam { get; set; }

    /// <summary>
    /// The bottom seed team details.
    /// </summary>
    public required PlayoffTeam BottomSeedTeam { get; set; }

    /// <summary>
    /// The URL for the series logo (optional).
    /// </summary>
    public string? SeriesLogo { get; set; }

    /// <summary>
    /// The URL for the series logo in French (optional).
    /// </summary>
    public string? SeriesLogoFr { get; set; }

    /// <summary>
    /// The conference abbreviation (optional).
    /// </summary>
    public string? ConferenceAbbrev { get; set; }

    /// <summary>
    /// The conference name (optional).
    /// </summary>
    public string? ConferenceName { get; set; }
}

/// <summary>
/// Represents a team in a playoff series.
/// </summary>
public class PlayoffTeam
{
    /// <summary>
    /// The team ID.
    /// </summary>
    public required int Id { get; set; }

    /// <summary>
    /// The team abbreviation (e.g., "TOR").
    /// </summary>
    public required string Abbrev { get; set; }

    /// <summary>
    /// The team name in different languages.
    /// </summary>
    public required PlayoffTeamName Name { get; set; }

    /// <summary>
    /// The common name for the team.
    /// </summary>
    public required PlayoffTeamCommonName CommonName { get; set; }

    /// <summary>
    /// The place name with preposition for the team.
    /// </summary>
    public required PlayoffTeamPlaceNameWithPreposition PlaceNameWithPreposition { get; set; }

    /// <summary>
    /// The URL for the team logo.
    /// </summary>
    public required string Logo { get; set; }

    /// <summary>
    /// The URL for the team's dark logo.
    /// </summary>
    public required string DarkLogo { get; set; }
}

/// <summary>
/// Represents the team name in different languages.
/// </summary>
public class PlayoffTeamName
{
    /// <summary>
    /// The default (English) team name.
    /// </summary>
    public required string Default { get; set; }

    /// <summary>
    /// The French team name.
    /// </summary>
    public required string Fr { get; set; }
}

/// <summary>
/// Represents the common name for a team.
/// </summary>
public class PlayoffTeamCommonName
{
    /// <summary>
    /// The default (English) common name.
    /// </summary>
    public required string Default { get; set; }
}

/// <summary>
/// Represents the place name with preposition for a team in different languages.
/// </summary>
public class PlayoffTeamPlaceNameWithPreposition
{
    /// <summary>
    /// The default (English) place name with preposition.
    /// </summary>
    public required string Default { get; set; }

    /// <summary>
    /// The French place name with preposition.
    /// </summary>
    public required string Fr { get; set; }
}
