using System.Collections.Generic;
using Newtonsoft.Json;
using PlayerFirstName = Nhl.Api.Models.Player.FirstName;
using PlayerLastName = Nhl.Api.Models.Player.LastName;
using ScheduleGameOutcome = Nhl.Api.Models.Schedule.GameOutcome;
using SchedulePeriodDescriptor = Nhl.Api.Models.Schedule.PeriodDescriptor;

namespace Nhl.Api.Models.Team;

/// <summary>
/// The NHL Edge team comparison response.
/// </summary>
public class TeamComparison
{
    /// <summary>
    /// The team metadata for the NHL Edge comparison response.
    /// </summary>
    [JsonProperty("team")]
    public required TeamComparisonTeam Team { get; set; }

    /// <summary>
    /// The seasons that contain NHL Edge statistics for the team.
    /// </summary>
    [JsonProperty("seasonsWithEdgeStats")]
    public required List<TeamDetailSeasonWithEdgeStats> SeasonsWithEdgeStats { get; set; } = [];

    /// <summary>
    /// The team shot speed comparison statistics.
    /// </summary>
    [JsonProperty("shotSpeedDetails")]
    public required TeamComparisonShotSpeedDetails ShotSpeedDetails { get; set; }

    /// <summary>
    /// The team skating speed comparison statistics.
    /// </summary>
    [JsonProperty("skatingSpeedDetails")]
    public required TeamComparisonSkatingSpeedDetails SkatingSpeedDetails { get; set; }

    /// <summary>
    /// The team's skating distance in the last ten games.
    /// </summary>
    [JsonProperty("skatingDistanceLast10")]
    public required List<TeamComparisonSkatingDistanceLast10> SkatingDistanceLast10 { get; set; } = [];

    /// <summary>
    /// The team shot location comparison details.
    /// </summary>
    [JsonProperty("shotLocationDetails")]
    public required List<TeamComparisonShotLocationDetail> ShotLocationDetails { get; set; } = [];

    /// <summary>
    /// The team shot location totals.
    /// </summary>
    [JsonProperty("shotLocationTotals")]
    public required List<TeamComparisonShotLocationTotal> ShotLocationTotals { get; set; } = [];

    /// <summary>
    /// The team zone time comparison details.
    /// </summary>
    [JsonProperty("zoneTimeDetails")]
    public required TeamComparisonZoneTimeDetails ZoneTimeDetails { get; set; }

    /// <summary>
    /// The team shot differential comparison details.
    /// </summary>
    [JsonProperty("shotDifferential")]
    public required TeamComparisonShotDifferential ShotDifferential { get; set; }
}

/// <summary>
/// The NHL Edge team metadata for a team comparison response.
/// </summary>
public class TeamComparisonTeam
{
    /// <summary>
    /// The NHL team identifier.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The team common name.
    /// </summary>
    [JsonProperty("commonName")]
    public required CommonName CommonName { get; set; }

    /// <summary>
    /// The team place name with preposition.
    /// </summary>
    [JsonProperty("placeNameWithPreposition")]
    public required TeamComparisonPlaceNameWithPreposition PlaceNameWithPreposition { get; set; }

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

    /// <summary>
    /// The team conference.
    /// </summary>
    [JsonProperty("conference")]
    public required string Conference { get; set; }

    /// <summary>
    /// The team division.
    /// </summary>
    [JsonProperty("division")]
    public required string Division { get; set; }

    /// <summary>
    /// The team wins.
    /// </summary>
    [JsonProperty("wins")]
    public int Wins { get; set; }

    /// <summary>
    /// The team losses.
    /// </summary>
    [JsonProperty("losses")]
    public int Losses { get; set; }

    /// <summary>
    /// The team overtime losses.
    /// </summary>
    [JsonProperty("otLosses")]
    public int OtLosses { get; set; }

    /// <summary>
    /// The team games played.
    /// </summary>
    [JsonProperty("gamesPlayed")]
    public int GamesPlayed { get; set; }

    /// <summary>
    /// The team points.
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }
}

/// <summary>
/// The team metadata used inside comparison game history items.
/// </summary>
public class TeamComparisonGameTeam
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
    public required TeamComparisonPlaceNameWithPreposition PlaceNameWithPreposition { get; set; }

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
/// The team logo URLs for the NHL Edge team comparison response.
/// </summary>
public class TeamComparisonTeamLogo
{
    /// <summary>
    /// The light logo URL.
    /// </summary>
    [JsonProperty("light")]
    public required string Light { get; set; }

    /// <summary>
    /// The dark logo URL.
    /// </summary>
    [JsonProperty("dark")]
    public required string Dark { get; set; }
}

/// <summary>
/// The team place name with preposition.
/// </summary>
public class TeamComparisonPlaceNameWithPreposition
{
    /// <summary>
    /// The default place name with preposition.
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }

    /// <summary>
    /// The French place name with preposition.
    /// </summary>
    [JsonProperty("fr")]
    public required string Fr { get; set; }
}

/// <summary>
/// The NHL Edge shot speed comparison statistics for a team.
/// </summary>
public class TeamComparisonShotSpeedDetails
{
    /// <summary>
    /// The top shot speed recorded by the team.
    /// </summary>
    [JsonProperty("topShotSpeed")]
    public required TeamComparisonMeasurementWithOverlay TopShotSpeed { get; set; }

    /// <summary>
    /// The average shot speed recorded by the team.
    /// </summary>
    [JsonProperty("avgShotSpeed")]
    public required TeamComparisonMeasurement AvgShotSpeed { get; set; }

    /// <summary>
    /// The number of shot attempts over 100 miles per hour.
    /// </summary>
    [JsonProperty("shotAttemptsOver100")]
    public int ShotAttemptsOver100 { get; set; }

    /// <summary>
    /// The number of shot attempts between 90 and 100 miles per hour.
    /// </summary>
    [JsonProperty("shotAttempts90To100")]
    public int ShotAttempts90To100 { get; set; }

    /// <summary>
    /// The number of shot attempts between 80 and 90 miles per hour.
    /// </summary>
    [JsonProperty("shotAttempts80To90")]
    public int ShotAttempts80To90 { get; set; }

    /// <summary>
    /// The number of shot attempts between 70 and 80 miles per hour.
    /// </summary>
    [JsonProperty("shotAttempts70To80")]
    public int ShotAttempts70To80 { get; set; }
}

/// <summary>
/// The NHL Edge skating speed comparison statistics for a team.
/// </summary>
public class TeamComparisonSkatingSpeedDetails
{
    /// <summary>
    /// The maximum skating speed recorded by the team.
    /// </summary>
    [JsonProperty("maxSkatingSpeed")]
    public required TeamComparisonMeasurementWithOverlay MaxSkatingSpeed { get; set; }

    /// <summary>
    /// The number of bursts over 22 miles per hour.
    /// </summary>
    [JsonProperty("burstsOver22")]
    public int BurstsOver22 { get; set; }

    /// <summary>
    /// The number of bursts between 20 and 22 miles per hour.
    /// </summary>
    [JsonProperty("bursts20To22")]
    public int Bursts20To22 { get; set; }

    /// <summary>
    /// The number of bursts between 18 and 20 miles per hour.
    /// </summary>
    [JsonProperty("bursts18To20")]
    public int Bursts18To20 { get; set; }
}

/// <summary>
/// A skating distance comparison entry for one of the last ten games.
/// </summary>
public class TeamComparisonSkatingDistanceLast10
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
    /// The distance skated in the game.
    /// </summary>
    [JsonProperty("distanceSkated")]
    public required TeamComparisonMeasurement DistanceSkated { get; set; }

    /// <summary>
    /// The home team for the game.
    /// </summary>
    [JsonProperty("homeTeam")]
    public required TeamComparisonGameTeam HomeTeam { get; set; }

    /// <summary>
    /// The away team for the game.
    /// </summary>
    [JsonProperty("awayTeam")]
    public required TeamComparisonGameTeam AwayTeam { get; set; }
}

/// <summary>
/// A measurement with imperial and metric values.
/// </summary>
public class TeamComparisonMeasurement
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
}

/// <summary>
/// A measurement with imperial and metric values plus overlay metadata.
/// </summary>
public class TeamComparisonMeasurementWithOverlay
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
    /// The overlay information for the metric.
    /// </summary>
    [JsonProperty("overlay")]
    public TeamComparisonMetricOverlay? Overlay { get; set; }
}

/// <summary>
/// The overlay information for a comparison measurement.
/// </summary>
public class TeamComparisonMetricOverlay
{
    /// <summary>
    /// The player associated with the overlay.
    /// </summary>
    [JsonProperty("player")]
    public required TeamComparisonOverlayPlayer Player { get; set; }

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
    /// The time in period for the overlay game.
    /// </summary>
    [JsonProperty("timeInPeriod")]
    public required string TimeInPeriod { get; set; }

    /// <summary>
    /// The game type for the overlay game.
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }
}

/// <summary>
/// The player in a comparison overlay payload.
/// </summary>
public class TeamComparisonOverlayPlayer
{
    /// <summary>
    /// The player's first name.
    /// </summary>
    [JsonProperty("firstName")]
    public required PlayerFirstName FirstName { get; set; }

    /// <summary>
    /// The player's last name.
    /// </summary>
    [JsonProperty("lastName")]
    public required PlayerLastName LastName { get; set; }
}

/// <summary>
/// The team in a comparison overlay payload.
/// </summary>
public class TeamComparisonOverlayTeam
{
    /// <summary>
    /// The team abbreviation.
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The team score.
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }
}

/// <summary>
/// A shot location comparison detail.
/// </summary>
public class TeamComparisonShotLocationDetail
{
    /// <summary>
    /// The shot location area.
    /// </summary>
    [JsonProperty("area")]
    public required string Area { get; set; }

    /// <summary>
    /// The shots on goal.
    /// </summary>
    [JsonProperty("sog")]
    public int Sog { get; set; }

    /// <summary>
    /// The goals.
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The shooting percentage.
    /// </summary>
    [JsonProperty("shootingPctg")]
    public decimal ShootingPctg { get; set; }
}

/// <summary>
/// A shot location comparison total.
/// </summary>
public class TeamComparisonShotLocationTotal
{
    /// <summary>
    /// The location code.
    /// </summary>
    [JsonProperty("locationCode")]
    public required string LocationCode { get; set; }

    /// <summary>
    /// The shots on goal.
    /// </summary>
    [JsonProperty("sog")]
    public int Sog { get; set; }

    /// <summary>
    /// The goals.
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The shooting percentage.
    /// </summary>
    [JsonProperty("shootingPctg")]
    public decimal ShootingPctg { get; set; }
}

/// <summary>
/// The zone time details for an NHL Edge team comparison response.
/// </summary>
public class TeamComparisonZoneTimeDetails
{
    /// <summary>
    /// The offensive zone percentage.
    /// </summary>
    [JsonProperty("offensiveZonePctg")]
    public decimal OffensiveZonePctg { get; set; }

    /// <summary>
    /// The offensive zone league average percentage.
    /// </summary>
    [JsonProperty("offensiveZoneLeagueAvg")]
    public decimal OffensiveZoneLeagueAvg { get; set; }

    /// <summary>
    /// The neutral zone percentage.
    /// </summary>
    [JsonProperty("neutralZonePctg")]
    public decimal NeutralZonePctg { get; set; }

    /// <summary>
    /// The neutral zone league average percentage.
    /// </summary>
    [JsonProperty("neutralZoneLeagueAvg")]
    public decimal NeutralZoneLeagueAvg { get; set; }

    /// <summary>
    /// The defensive zone percentage.
    /// </summary>
    [JsonProperty("defensiveZonePctg")]
    public decimal DefensiveZonePctg { get; set; }

    /// <summary>
    /// The defensive zone league average percentage.
    /// </summary>
    [JsonProperty("defensiveZoneLeagueAvg")]
    public decimal DefensiveZoneLeagueAvg { get; set; }
}

/// <summary>
/// The shot differential comparison details.
/// </summary>
public class TeamComparisonShotDifferential
{
    /// <summary>
    /// The shot attempt differential.
    /// </summary>
    [JsonProperty("shotAttemptDifferential")]
    public decimal ShotAttemptDifferential { get; set; }

    /// <summary>
    /// The shots on goal differential.
    /// </summary>
    [JsonProperty("sogDifferential")]
    public decimal SogDifferential { get; set; }
}
