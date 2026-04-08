using System.Collections.Generic;
using Newtonsoft.Json;
using PlayerFirstName = Nhl.Api.Models.Player.FirstName;
using PlayerLastName = Nhl.Api.Models.Player.LastName;
using ScheduleGameOutcome = Nhl.Api.Models.Schedule.GameOutcome;
using SchedulePeriodDescriptor = Nhl.Api.Models.Schedule.PeriodDescriptor;

namespace Nhl.Api.Models.Team;

/// <summary>
/// The NHL Edge team detail response.
/// </summary>
public class TeamDetail
{
    /// <summary>
    /// The team metadata for the NHL Edge response.
    /// </summary>
    [JsonProperty("team")]
    public required TeamDetailTeam Team { get; set; }

    /// <summary>
    /// The seasons that contain NHL Edge statistics for the team.
    /// </summary>
    [JsonProperty("seasonsWithEdgeStats")]
    public required List<TeamDetailSeasonWithEdgeStats> SeasonsWithEdgeStats { get; set; } = [];

    /// <summary>
    /// The team shot speed statistics.
    /// </summary>
    [JsonProperty("shotSpeed")]
    public required TeamDetailShotSpeed ShotSpeed { get; set; }

    /// <summary>
    /// The team skating speed statistics.
    /// </summary>
    [JsonProperty("skatingSpeed")]
    public required TeamDetailSkatingSpeed SkatingSpeed { get; set; }

    /// <summary>
    /// The team distance skated statistics.
    /// </summary>
    [JsonProperty("distanceSkated")]
    public required TeamDetailDistanceSkated DistanceSkated { get; set; }

    /// <summary>
    /// The team shot-on-goal summary by location.
    /// </summary>
    [JsonProperty("sogSummary")]
    public required List<TeamDetailSogSummary> ShotsOnGoalSummary { get; set; } = [];

    /// <summary>
    /// The team shot-on-goal details by area.
    /// </summary>
    [JsonProperty("sogDetails")]
    public required List<TeamDetailSogDetail> ShotsOnGoalDetails { get; set; } = [];

    /// <summary>
    /// The team zone time details.
    /// </summary>
    [JsonProperty("zoneTimeDetails")]
    public required TeamDetailZoneTimeDetails ZoneTimeDetails { get; set; }
}

/// <summary>
/// The NHL Edge team metadata.
/// </summary>
public class TeamDetailTeam
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
    public required TeamDetailPlaceNameWithPreposition PlaceNameWithPreposition { get; set; }

    /// <summary>
    /// The team abbreviation.
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The team logo URLs.
    /// </summary>
    [JsonProperty("teamLogo")]
    public required TeamDetailTeamLogo TeamLogo { get; set; }

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
/// The team logo URLs for the NHL Edge team detail response.
/// </summary>
public class TeamDetailTeamLogo
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
public class TeamDetailPlaceNameWithPreposition
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
/// A season that includes NHL Edge statistics for a team.
/// </summary>
public class TeamDetailSeasonWithEdgeStats
{
    /// <summary>
    /// The season identifier.
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The game types available for the season.
    /// </summary>
    [JsonProperty("gameTypes")]
    public required List<int> GameTypes { get; set; } = [];
}

/// <summary>
/// The NHL Edge shot speed statistics for a team.
/// </summary>
public class TeamDetailShotSpeed
{
    /// <summary>
    /// The number of shot attempts over 90 miles per hour.
    /// </summary>
    [JsonProperty("shotAttemptsOver90")]
    public required TeamDetailRankedCount ShotAttemptsOver90 { get; set; }

    /// <summary>
    /// The top shot speed recorded by the team.
    /// </summary>
    [JsonProperty("topShotSpeed")]
    public required TeamDetailRankedMeasurement TopShotSpeed { get; set; }
}

/// <summary>
/// The NHL Edge skating speed statistics for a team.
/// </summary>
public class TeamDetailSkatingSpeed
{
    /// <summary>
    /// The number of bursts over 22 miles per hour.
    /// </summary>
    [JsonProperty("burstsOver22")]
    public required TeamDetailRankedCount BurstsOver22 { get; set; }

    /// <summary>
    /// The number of bursts over 20 miles per hour.
    /// </summary>
    [JsonProperty("burstsOver20")]
    public required TeamDetailRankedCountWithLeagueAverage BurstsOver20 { get; set; }

    /// <summary>
    /// The maximum skating speed recorded by the team.
    /// </summary>
    [JsonProperty("speedMax")]
    public required TeamDetailRankedMeasurement SpeedMax { get; set; }
}

/// <summary>
/// The NHL Edge distance skated statistics for a team.
/// </summary>
public class TeamDetailDistanceSkated
{
    /// <summary>
    /// The team total distance skated.
    /// </summary>
    [JsonProperty("total")]
    public required TeamDetailRankedMeasurement Total { get; set; }
}

/// <summary>
/// A ranked count value.
/// </summary>
public class TeamDetailRankedCount
{
    /// <summary>
    /// The metric value.
    /// </summary>
    [JsonProperty("value")]
    public int Value { get; set; }

    /// <summary>
    /// The league rank.
    /// </summary>
    [JsonProperty("rank")]
    public int Rank { get; set; }
}

/// <summary>
/// A ranked count value with league average.
/// </summary>
public class TeamDetailRankedCountWithLeagueAverage
{
    /// <summary>
    /// The metric value.
    /// </summary>
    [JsonProperty("value")]
    public int Value { get; set; }

    /// <summary>
    /// The league rank.
    /// </summary>
    [JsonProperty("rank")]
    public int Rank { get; set; }

    /// <summary>
    /// The league average value.
    /// </summary>
    [JsonProperty("leagueAvg")]
    public required TeamDetailValueLeagueAverage LeagueAvg { get; set; }
}

/// <summary>
/// A ranked measurement with league average and optional overlay metadata.
/// </summary>
public class TeamDetailRankedMeasurement
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
    /// The league rank.
    /// </summary>
    [JsonProperty("rank")]
    public int Rank { get; set; }

    /// <summary>
    /// The league average measurement values.
    /// </summary>
    [JsonProperty("leagueAvg")]
    public required TeamDetailMeasurementLeagueAverage LeagueAvg { get; set; }

    /// <summary>
    /// The overlay game information for the selected measurement.
    /// </summary>
    [JsonProperty("overlay")]
    public TeamDetailMetricOverlay? Overlay { get; set; }
}

/// <summary>
/// The league average for a measurement.
/// </summary>
public class TeamDetailMeasurementLeagueAverage
{
    /// <summary>
    /// The imperial average.
    /// </summary>
    [JsonProperty("imperial")]
    public decimal Imperial { get; set; }

    /// <summary>
    /// The metric average.
    /// </summary>
    [JsonProperty("metric")]
    public decimal Metric { get; set; }
}

/// <summary>
/// The league average for a ranked count.
/// </summary>
public class TeamDetailValueLeagueAverage
{
    /// <summary>
    /// The league average value.
    /// </summary>
    [JsonProperty("value")]
    public int Value { get; set; }
}

/// <summary>
/// The overlay information for a ranked measurement.
/// </summary>
public class TeamDetailMetricOverlay
{
    /// <summary>
    /// The player associated with the overlay.
    /// </summary>
    [JsonProperty("player")]
    public required TeamDetailOverlayPlayer Player { get; set; }

    /// <summary>
    /// The game date for the overlay.
    /// </summary>
    [JsonProperty("gameDate")]
    public required string GameDate { get; set; }

    /// <summary>
    /// The away team for the overlay game.
    /// </summary>
    [JsonProperty("awayTeam")]
    public required TeamDetailOverlayTeam AwayTeam { get; set; }

    /// <summary>
    /// The home team for the overlay game.
    /// </summary>
    [JsonProperty("homeTeam")]
    public required TeamDetailOverlayTeam HomeTeam { get; set; }

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
/// The player in an overlay payload.
/// </summary>
public class TeamDetailOverlayPlayer
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
/// The team in an overlay payload.
/// </summary>
public class TeamDetailOverlayTeam
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
/// A shot-on-goal summary for a location.
/// </summary>
public class TeamDetailSogSummary
{
    /// <summary>
    /// The location code.
    /// </summary>
    [JsonProperty("locationCode")]
    public required string LocationCode { get; set; }

    /// <summary>
    /// The number of shots.
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The shot rank.
    /// </summary>
    [JsonProperty("shotsRank")]
    public int ShotsRank { get; set; }

    /// <summary>
    /// The league average shots.
    /// </summary>
    [JsonProperty("shotsLeagueAvg")]
    public decimal ShotsLeagueAvg { get; set; }

    /// <summary>
    /// The shooting percentage.
    /// </summary>
    [JsonProperty("shootingPctg")]
    public decimal ShootingPctg { get; set; }

    /// <summary>
    /// The shooting percentage rank.
    /// </summary>
    [JsonProperty("shootingPctgRank")]
    public int ShootingPctgRank { get; set; }

    /// <summary>
    /// The league average shooting percentage.
    /// </summary>
    [JsonProperty("shootingPctgLeagueAvg")]
    public decimal ShootingPctgLeagueAvg { get; set; }

    /// <summary>
    /// The number of goals.
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The goals rank.
    /// </summary>
    [JsonProperty("goalsRank")]
    public int GoalsRank { get; set; }

    /// <summary>
    /// The league average goals.
    /// </summary>
    [JsonProperty("goalsLeagueAvg")]
    public decimal GoalsLeagueAvg { get; set; }
}

/// <summary>
/// A shot-on-goal detail for a location.
/// </summary>
public class TeamDetailSogDetail
{
    /// <summary>
    /// The area name.
    /// </summary>
    [JsonProperty("area")]
    public required string Area { get; set; }

    /// <summary>
    /// The number of shots.
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The shot rank.
    /// </summary>
    [JsonProperty("shotsRank")]
    public int ShotsRank { get; set; }
}

/// <summary>
/// The zone time details for an NHL Edge team detail response.
/// </summary>
public class TeamDetailZoneTimeDetails
{
    /// <summary>
    /// The offensive zone percentage.
    /// </summary>
    [JsonProperty("offensiveZonePctg")]
    public decimal OffensiveZonePctg { get; set; }

    /// <summary>
    /// The offensive zone rank.
    /// </summary>
    [JsonProperty("offensiveZoneRank")]
    public int OffensiveZoneRank { get; set; }

    /// <summary>
    /// The offensive zone league average percentage.
    /// </summary>
    [JsonProperty("offensiveZoneLeagueAvg")]
    public decimal OffensiveZoneLeagueAvg { get; set; }

    /// <summary>
    /// The offensive zone even-strength percentage.
    /// </summary>
    [JsonProperty("offensiveZoneEvPctg")]
    public decimal OffensiveZoneEvPctg { get; set; }

    /// <summary>
    /// The offensive zone even-strength rank.
    /// </summary>
    [JsonProperty("offensiveZoneEvRank")]
    public int OffensiveZoneEvRank { get; set; }

    /// <summary>
    /// The offensive zone even-strength league average percentage.
    /// </summary>
    [JsonProperty("offensiveZoneEvLeagueAvg")]
    public decimal OffensiveZoneEvLeagueAvg { get; set; }

    /// <summary>
    /// The neutral zone percentage.
    /// </summary>
    [JsonProperty("neutralZonePctg")]
    public decimal NeutralZonePctg { get; set; }

    /// <summary>
    /// The neutral zone rank.
    /// </summary>
    [JsonProperty("neutralZoneRank")]
    public int NeutralZoneRank { get; set; }

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
    /// The defensive zone rank.
    /// </summary>
    [JsonProperty("defensiveZoneRank")]
    public int DefensiveZoneRank { get; set; }

    /// <summary>
    /// The defensive zone league average percentage.
    /// </summary>
    [JsonProperty("defensiveZoneLeagueAvg")]
    public decimal DefensiveZoneLeagueAvg { get; set; }
}
