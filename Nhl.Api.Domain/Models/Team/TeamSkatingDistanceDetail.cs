using System.Collections.Generic;
using Newtonsoft.Json;
using ScheduleGameOutcome = Nhl.Api.Models.Schedule.GameOutcome;
using SchedulePeriodDescriptor = Nhl.Api.Models.Schedule.PeriodDescriptor;

namespace Nhl.Api.Models.Team;

/// <summary>
/// The NHL Edge team skating distance detail response.
/// </summary>
public class TeamSkatingDistanceDetail
{
    /// <summary>
    /// The skating distance details for the last 10 games.
    /// </summary>
    [JsonProperty("skatingDistanceLast10")]
    public required List<TeamSkatingDistanceDetailLast10> SkatingDistanceLast10 { get; set; } = [];

    /// <summary>
    /// The skating distance details for all situations and positions.
    /// </summary>
    [JsonProperty("skatingDistanceDetails")]
    public required List<TeamSkatingDistanceDetailItem> SkatingDistanceDetails { get; set; } = [];
}

/// <summary>
/// The NHL Edge skating distance detail item for one of the last 10 games.
/// </summary>
public class TeamSkatingDistanceDetailLast10
{
    /// <summary>
    /// The game center link.
    /// </summary>
    [JsonProperty("gameCenterLink")]
    public required string GameCenterLink { get; set; }

    /// <summary>
    /// The game date.
    /// </summary>
    [JsonProperty("gameDate")]
    public required string GameDate { get; set; }

    /// <summary>
    /// Indicates whether the team was the home team.
    /// </summary>
    [JsonProperty("isHomeTeam")]
    public bool IsHomeTeam { get; set; }

    /// <summary>
    /// The time on ice for all situations, in seconds.
    /// </summary>
    [JsonProperty("toiAll")]
    public int ToiAll { get; set; }

    /// <summary>
    /// The distance skated in all situations.
    /// </summary>
    [JsonProperty("distanceSkatedAll")]
    public required TeamComparisonMeasurement DistanceSkatedAll { get; set; }

    /// <summary>
    /// The time on ice at even strength, in seconds.
    /// </summary>
    [JsonProperty("toiEven")]
    public int ToiEven { get; set; }

    /// <summary>
    /// The distance skated at even strength.
    /// </summary>
    [JsonProperty("distanceSkatedEven")]
    public required TeamComparisonMeasurement DistanceSkatedEven { get; set; }

    /// <summary>
    /// The time on ice on the power play, in seconds.
    /// </summary>
    [JsonProperty("toiPP")]
    public int ToiPP { get; set; }

    /// <summary>
    /// The distance skated on the power play.
    /// </summary>
    [JsonProperty("distanceSkatedPP")]
    public required TeamComparisonMeasurement DistanceSkatedPP { get; set; }

    /// <summary>
    /// The time on ice on the penalty kill, in seconds.
    /// </summary>
    [JsonProperty("toiPK")]
    public int ToiPK { get; set; }

    /// <summary>
    /// The distance skated on the penalty kill.
    /// </summary>
    [JsonProperty("distanceSkatedPK")]
    public required TeamComparisonMeasurement DistanceSkatedPK { get; set; }

    /// <summary>
    /// The home team for the game.
    /// </summary>
    [JsonProperty("homeTeam")]
    public required TeamSkatingDistanceDetailTeam HomeTeam { get; set; }

    /// <summary>
    /// The away team for the game.
    /// </summary>
    [JsonProperty("awayTeam")]
    public required TeamSkatingDistanceDetailTeam AwayTeam { get; set; }
}

/// <summary>
/// The NHL Edge skating distance detail item for a given strength and position.
/// </summary>
public class TeamSkatingDistanceDetailItem
{
    /// <summary>
    /// The strength code.
    /// </summary>
    [JsonProperty("strengthCode")]
    public required string StrengthCode { get; set; }

    /// <summary>
    /// The position code.
    /// </summary>
    [JsonProperty("positionCode")]
    public required string PositionCode { get; set; }

    /// <summary>
    /// The total distance skated.
    /// </summary>
    [JsonProperty("distanceTotal")]
    public required TeamSkatingDistanceDetailRankedMeasurement DistanceTotal { get; set; }

    /// <summary>
    /// The distance skated per 60 minutes.
    /// </summary>
    [JsonProperty("distancePer60")]
    public required TeamSkatingDistanceDetailRankedMeasurement DistancePer60 { get; set; }

    /// <summary>
    /// The maximum distance skated in a game.
    /// </summary>
    [JsonProperty("distanceMaxGame")]
    public required TeamSkatingDistanceDetailRankedMeasurementWithOverlay DistanceMaxGame { get; set; }

    /// <summary>
    /// The maximum distance skated in a period.
    /// </summary>
    [JsonProperty("distanceMaxPeriod")]
    public required TeamSkatingDistanceDetailRankedMeasurementWithOverlay DistanceMaxPeriod { get; set; }
}

/// <summary>
/// The NHL Edge team metadata for a skating distance detail response item.
/// </summary>
public class TeamSkatingDistanceDetailTeam
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
    public required TeamSkatingDistanceDetailPlaceNameWithPreposition PlaceNameWithPreposition { get; set; }

    /// <summary>
    /// The team logo URLs.
    /// </summary>
    [JsonProperty("teamLogo")]
    public required TeamComparisonTeamLogo TeamLogo { get; set; }
}

/// <summary>
/// The team place name with preposition for a skating distance detail response item.
/// </summary>
public class TeamSkatingDistanceDetailPlaceNameWithPreposition
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

/// <summary>
/// A ranked distance measurement with league average.
/// </summary>
public class TeamSkatingDistanceDetailRankedMeasurement
{
    /// <summary>
    /// The imperial value.
    /// </summary>
    [JsonProperty("imperial")]
    public decimal Imperial { get; set; }

    /// <summary>
    /// The metric value.
    /// </summary>
    [JsonProperty("metric")]
    public decimal Metric { get; set; }

    /// <summary>
    /// The rank.
    /// </summary>
    [JsonProperty("rank")]
    public int Rank { get; set; }

    /// <summary>
    /// The league average value.
    /// </summary>
    [JsonProperty("leagueAvg")]
    public required TeamSkatingDistanceDetailMeasurementLeagueAverage LeagueAvg { get; set; }
}

/// <summary>
/// A ranked distance measurement with league average and overlay.
/// </summary>
public class TeamSkatingDistanceDetailRankedMeasurementWithOverlay
{
    /// <summary>
    /// The imperial value.
    /// </summary>
    [JsonProperty("imperial")]
    public decimal Imperial { get; set; }

    /// <summary>
    /// The metric value.
    /// </summary>
    [JsonProperty("metric")]
    public decimal Metric { get; set; }

    /// <summary>
    /// The rank.
    /// </summary>
    [JsonProperty("rank")]
    public int Rank { get; set; }

    /// <summary>
    /// The league average value.
    /// </summary>
    [JsonProperty("leagueAvg")]
    public required TeamSkatingDistanceDetailMeasurementLeagueAverage LeagueAvg { get; set; }

    /// <summary>
    /// The overlay for the measurement.
    /// </summary>
    [JsonProperty("overlay")]
    public TeamSkatingDistanceDetailMetricOverlay? Overlay { get; set; }
}

/// <summary>
/// The league average for a skating distance measurement.
/// </summary>
public class TeamSkatingDistanceDetailMeasurementLeagueAverage
{
    /// <summary>
    /// The imperial league average value.
    /// </summary>
    [JsonProperty("imperial")]
    public decimal Imperial { get; set; }

    /// <summary>
    /// The metric league average value.
    /// </summary>
    [JsonProperty("metric")]
    public decimal Metric { get; set; }
}

/// <summary>
/// The overlay information for a skating distance detail measurement.
/// </summary>
public class TeamSkatingDistanceDetailMetricOverlay
{
    /// <summary>
    /// The game date for the overlay.
    /// </summary>
    [JsonProperty("gameDate")]
    public required string GameDate { get; set; }

    /// <summary>
    /// The away team for the overlay game.
    /// </summary>
    [JsonProperty("awayTeam")]
    public required TeamComparisonOverlayTeam AwayTeam { get; set; }

    /// <summary>
    /// The home team for the overlay game.
    /// </summary>
    [JsonProperty("homeTeam")]
    public required TeamComparisonOverlayTeam HomeTeam { get; set; }

    /// <summary>
    /// The game outcome for the overlay game.
    /// </summary>
    [JsonProperty("gameOutcome")]
    public required ScheduleGameOutcome GameOutcome { get; set; }

    /// <summary>
    /// The period descriptor for the overlay game.
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required SchedulePeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The game type for the overlay game.
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }
}
