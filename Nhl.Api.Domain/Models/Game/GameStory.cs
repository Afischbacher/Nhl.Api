using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Nhl.Api.Models.Game;

/// <summary>
/// Represents the story of an NHL game, including teams, scoring, and statistics.
/// </summary>
public class GameStory
{
    /// <summary>
    /// The unique identifier for the NHL game.
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    /// <summary>
    /// The season of the NHL game.
    /// </summary>
    [JsonPropertyName("season")]
    public required int Season { get; set; }

    /// <summary>
    /// The type of the NHL game.
    /// </summary>
    [JsonPropertyName("gameType")]
    public required int GameType { get; set; }

    /// <summary>
    /// Indicates if the scoring is limited.
    /// </summary>
    [JsonPropertyName("limitedScoring")]
    public required bool LimitedScoring { get; set; }

    /// <summary>
    /// The date of the NHL game.
    /// </summary>
    [JsonPropertyName("gameDate")]
    public required string GameDate { get; set; }

    /// <summary>
    /// The venue of the NHL game.
    /// </summary>
    [JsonPropertyName("venue")]
    public required GameStoryVenue Venue { get; set; }

    /// <summary>
    /// The location of the venue for the NHL game.
    /// </summary>
    [JsonPropertyName("venueLocation")]
    public required GameStoryVenueLocation VenueLocation { get; set; }

    /// <summary>
    /// The start time of the NHL game in UTC.
    /// </summary>
    [JsonPropertyName("startTimeUTC")]
    public required DateTime StartTimeUTC { get; set; }

    /// <summary>
    /// The eastern UTC offset for the NHL game.
    /// </summary>
    [JsonPropertyName("easternUTCOffset")]
    public required string EasternUTCOffset { get; set; }

    /// <summary>
    /// The venue UTC offset for the NHL game.
    /// </summary>
    [JsonPropertyName("venueUTCOffset")]
    public required string VenueUTCOffset { get; set; }

    /// <summary>
    /// The timezone of the venue for the NHL game.
    /// </summary>
    [JsonPropertyName("venueTimezone")]
    public required string VenueTimezone { get; set; }

    /// <summary>
    /// A list of TV broadcasts for the NHL game.
    /// </summary>
    [JsonPropertyName("tvBroadcasts")]
    public required List<TvBroadcast> TvBroadcasts { get; set; }

    /// <summary>
    /// The state of the NHL game.
    /// </summary>
    [JsonPropertyName("gameState")]
    public required string GameState { get; set; }

    /// <summary>
    /// The schedule state of the NHL game.
    /// </summary>
    [JsonPropertyName("gameScheduleState")]
    public required string GameScheduleState { get; set; }

    /// <summary>
    /// The away team in the NHL game.
    /// </summary>
    [JsonPropertyName("awayTeam")]
    public required GameStoryTeam AwayTeam { get; set; }

    /// <summary>
    /// The home team in the NHL game.
    /// </summary>
    [JsonPropertyName("homeTeam")]
    public required GameStoryTeam HomeTeam { get; set; }

    /// <summary>
    /// Indicates if a shootout is in use for the NHL game.
    /// </summary>
    [JsonPropertyName("shootoutInUse")]
    public required bool ShootoutInUse { get; set; }

    /// <summary>
    /// The number of regulation periods in the NHL game.
    /// </summary>
    [JsonPropertyName("regPeriods")]
    public required int RegPeriods { get; set; }

    /// <summary>
    /// Indicates if overtime is in use for the NHL game.
    /// </summary>
    [JsonPropertyName("otInUse")]
    public required bool OtInUse { get; set; }

    /// <summary>
    /// Indicates if ties are in use for the NHL game.
    /// </summary>
    [JsonPropertyName("tiesInUse")]
    public required bool TiesInUse { get; set; }

    /// <summary>
    /// The summary of the NHL game, including scoring, three stars, and team stats.
    /// </summary>
    [JsonPropertyName("summary")]
    public required GameStorySummary Summary { get; set; }

    /// <summary>
    /// The period descriptor for the NHL game.
    /// </summary>
    [JsonPropertyName("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The clock for the NHL game.
    /// </summary>
    [JsonPropertyName("clock")]
    public required GameStoryClock Clock { get; set; }
}

/// <summary>
/// Represents the venue for an NHL game.
/// </summary>
public class GameStoryVenue
{
    /// <summary>
    /// The default name of the venue.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }
}

/// <summary>
/// Represents the location of the venue for an NHL game.
/// </summary>
public class GameStoryVenueLocation
{
    /// <summary>
    /// The default location of the venue.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }
}

/// <summary>
/// Represents a team in an NHL game story.
/// </summary>
public class GameStoryTeam
{
    /// <summary>
    /// The unique identifier for the team.
    /// </summary>
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    /// <summary>
    /// The name of the team.
    /// </summary>
    [JsonPropertyName("name")]
    public required GameStoryTeamName Name { get; set; }

    /// <summary>
    /// The abbreviation for the team.
    /// </summary>
    [JsonPropertyName("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The place name of the team.
    /// </summary>
    [JsonPropertyName("placeName")]
    public required GameStoryPlaceName PlaceName { get; set; }

    /// <summary>
    /// The score of the team.
    /// </summary>
    [JsonPropertyName("score")]
    public required int Score { get; set; }

    /// <summary>
    /// The shots on goal for the team.
    /// </summary>
    [JsonPropertyName("sog")]
    public required int Sog { get; set; }

    /// <summary>
    /// The URL of the team's logo.
    /// </summary>
    [JsonPropertyName("logo")]
    public required string Logo { get; set; }
}

/// <summary>
/// Represents the name of a team in an NHL game story.
/// </summary>
public class GameStoryTeamName
{
    /// <summary>
    /// The default name of the team.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }
}

/// <summary>
/// Represents the place name of a team in an NHL game story.
/// </summary>
public class GameStoryPlaceName
{
    /// <summary>
    /// The default place name of the team.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }
}

/// <summary>
/// Represents the summary of an NHL game story.
/// </summary>
public class GameStorySummary
{
    /// <summary>
    /// A list of scoring plays in the game.
    /// </summary>
    [JsonPropertyName("scoring")]
    public required List<GameStoryScoring> Scoring { get; set; }

    /// <summary>
    /// A list of shootout attempts in the game.
    /// </summary>
    [JsonPropertyName("shootout")]
    public required List<object> Shootout { get; set; }

    /// <summary>
    /// The three stars of the game.
    /// </summary>
    [JsonPropertyName("threeStars")]
    public required List<ThreeStar> ThreeStars { get; set; }

    /// <summary>
    /// The game statistics for each team.
    /// </summary>
    [JsonPropertyName("teamGameStats")]
    public required List<TeamGameStat> TeamGameStats { get; set; }
}

/// <summary>
/// Represents a scoring play in an NHL game.
/// </summary>
public class GameStoryScoring
{
    /// <summary>
    /// The period descriptor for the scoring play.
    /// </summary>
    [JsonPropertyName("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// A list of goals in the period.
    /// </summary>
    [JsonPropertyName("goals")]
    public required List<GameStoryGoal> Goals { get; set; }
}

/// <summary>
/// Represents a goal in an NHL game.
/// </summary>
public class GameStoryGoal
{
    /// <summary>
    /// The situation code for the goal.
    /// </summary>
    [JsonPropertyName("situationCode")]
    public required string SituationCode { get; set; }

    /// <summary>
    /// The event identifier for the goal.
    /// </summary>
    [JsonPropertyName("eventId")]
    public required int EventId { get; set; }

    /// <summary>
    /// The strength of the team when the goal was scored.
    /// </summary>
    [JsonPropertyName("strength")]
    public required string Strength { get; set; }

    /// <summary>
    /// The unique identifier for the player who scored the goal.
    /// </summary>
    [JsonPropertyName("playerId")]
    public required int PlayerId { get; set; }

    /// <summary>
    /// The first name of the player who scored the goal.
    /// </summary>
    [JsonPropertyName("firstName")]
    public required PlayerName FirstName { get; set; }

    /// <summary>
    /// The last name of the player who scored the goal.
    /// </summary>
    [JsonPropertyName("lastName")]
    public required PlayerName LastName { get; set; }

    /// <summary>
    /// The name of the player who scored the goal.
    /// </summary>
    [JsonPropertyName("name")]
    public required PlayerName Name { get; set; }

    /// <summary>
    /// The NHL goal scorer's full name, combining first and last names. <br/>
    /// Example: Clayton Keller
    /// </summary>
    public string FullName => $"{this.FirstName.Default} {this.LastName.Default}";

    /// <summary>
    /// The abbreviation of the team that scored the goal.
    /// </summary>
    [JsonPropertyName("teamAbbrev")]
    public required TeamAbbrev TeamAbbrev { get; set; }

    /// <summary>
    /// The URL of the player's headshot.
    /// </summary>
    [JsonPropertyName("headshot")]
    public required string Headshot { get; set; }

    /// <summary>
    /// The URL for sharing the highlight clip of the goal.
    /// </summary>
    [JsonPropertyName("highlightClipSharingUrl")]
    public required string HighlightClipSharingUrl { get; set; }

    /// <summary>
    /// The highlight clip identifier for the goal.
    /// </summary>
    [JsonPropertyName("highlightClip")]
    public long? HighlightClip { get; set; }

    /// <summary>
    /// The discrete clip identifier for the goal.
    /// </summary>
    [JsonPropertyName("discreteClip")]
    public long? DiscreteClip { get; set; }

    /// <summary>
    /// The French discrete clip identifier for the goal.
    /// </summary>
    [JsonPropertyName("discreteClipFr")]
    public long? DiscreteClipFr { get; set; }

    /// <summary>
    /// The URL for sharing the French highlight clip of the goal.
    /// </summary>
    [JsonPropertyName("highlightClipSharingUrlFr")]
    public required string HighlightClipSharingUrlFr { get; set; }

    /// <summary>
    /// The French highlight clip identifier for the goal.
    /// </summary>
    [JsonPropertyName("highlightClipFr")]
    public long? HighlightClipFr { get; set; }

    /// <summary>
    /// The number of goals to date for the player.
    /// </summary>
    [JsonPropertyName("goalsToDate")]
    public required int GoalsToDate { get; set; }

    /// <summary>
    /// The score of the away team after the goal.
    /// </summary>
    [JsonPropertyName("awayScore")]
    public required int AwayScore { get; set; }

    /// <summary>
    /// The score of the home team after the goal.
    /// </summary>
    [JsonPropertyName("homeScore")]
    public required int HomeScore { get; set; }

    /// <summary>
    /// The abbreviation of the leading team after the goal.
    /// </summary>
    [JsonPropertyName("leadingTeamAbbrev")]
    public required TeamAbbrev LeadingTeamAbbrev { get; set; }

    /// <summary>
    /// The time in the period when the goal was scored.
    /// </summary>
    [JsonPropertyName("timeInPeriod")]
    public required string TimeInPeriod { get; set; }

    /// <summary>
    /// The type of shot for the goal.
    /// </summary>
    [JsonPropertyName("shotType")]
    public required string ShotType { get; set; }

    /// <summary>
    /// The modifier for the goal (e.g., "empty-net").
    /// </summary>
    [JsonPropertyName("goalModifier")]
    public required string GoalModifier { get; set; }

    /// <summary>
    /// A list of assists on the goal.
    /// </summary>
    [JsonPropertyName("assists")]
    public required List<GameStoryAssist> Assists { get; set; }

    /// <summary>
    /// The side of the ice the home team was defending.
    /// </summary>
    [JsonPropertyName("homeTeamDefendingSide")]
    public required string HomeTeamDefendingSide { get; set; }

    /// <summary>
    /// Indicates if the goal was scored by the home team.
    /// </summary>
    [JsonPropertyName("isHome")]
    public required bool IsHome { get; set; }
}

/// <summary>
/// Represents an assist on a goal.
/// </summary>
public class GameStoryAssist
{
    /// <summary>
    /// The unique identifier for the player who assisted.
    /// </summary>
    [JsonPropertyName("playerId")]
    public required int PlayerId { get; set; }

    /// <summary>
    /// The first name of the player who assisted.
    /// </summary>
    [JsonPropertyName("firstName")]
    public required PlayerNameSimple FirstName { get; set; }

    /// <summary>
    /// The last name of the player who assisted.
    /// </summary>
    [JsonPropertyName("lastName")]
    public required PlayerNameSimple LastName { get; set; }

    /// <summary>
    /// The full name of the player who assisted.
    /// </summary>
    [JsonPropertyName("name")]
    public required PlayerNameSimple Name { get; set; }

    /// <summary>
    /// The NHL player who made the assist's full name, combining first and last names. <br/>
    /// Example: Clayton Keller
    /// </summary>
    public string FullName => $"{this.FirstName.Default} {this.LastName.Default}";

    /// <summary>
    /// The number of assists to date for the player.
    /// </summary>
    [JsonPropertyName("assistsToDate")]
    public required int AssistsToDate { get; set; }

    /// <summary>
    /// The sweater number of the player.
    /// </summary>
    [JsonPropertyName("sweaterNumber")]
    public required int SweaterNumber { get; set; }
}

/// <summary>
/// Represents the name of a player with different language variations.
/// </summary>
public class PlayerName
{
    /// <summary>
    /// The default name.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }

    /// <summary>
    /// The name in Czech.
    /// </summary>
    [JsonPropertyName("cs")]
    public required string Cs { get; set; }

    /// <summary>
    /// The name in Finnish.
    /// </summary>
    [JsonPropertyName("fi")]
    public required string Fi { get; set; }

    /// <summary>
    /// The name in Slovak.
    /// </summary>
    [JsonPropertyName("sk")]
    public required string Sk { get; set; }
}

/// <summary>
/// Represents the abbreviation of a team.
/// </summary>
public class TeamAbbrev
{
    /// <summary>
    /// The default abbreviation.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }
}

/// <summary>
/// Represents a simple player name.
/// </summary>
public class PlayerNameSimple
{
    /// <summary>
    /// The default name.
    /// </summary>
    [JsonPropertyName("default")]
    public required string Default { get; set; }
}

/// <summary>
/// Represents the game clock.
/// </summary>
public class GameStoryClock
{
    /// <summary>
    /// The time remaining on the clock.
    /// </summary>
    [JsonPropertyName("timeRemaining")]
    public required string TimeRemaining { get; set; }

    /// <summary>
    /// The seconds remaining on the clock.
    /// </summary>
    [JsonPropertyName("secondsRemaining")]
    public required int SecondsRemaining { get; set; }

    /// <summary>
    /// Indicates if the clock is running.
    /// </summary>
    [JsonPropertyName("running")]
    public required bool Running { get; set; }

    /// <summary>
    /// Indicates if the game is in an intermission.
    /// </summary>
    [JsonPropertyName("inIntermission")]
    public required bool InIntermission { get; set; }
}
