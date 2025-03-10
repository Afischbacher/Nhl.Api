using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Standing;

namespace Nhl.Api.Models.Game;
/// <summary>
/// An NHL game assist and information about the assist
/// </summary>
public class Assist
{
    /// <summary>
    /// The NHL player identifier for the player who made the assist <br/>
    /// Example: 8482671
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The first name of the NHL player who made the assist <br/>
    /// Example: Auston
    /// </summary>
    [JsonProperty("firstName")]
    public required FirstName FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL player who made the assist <br/>
    /// Example: Matthews
    /// </summary>
    [JsonProperty("lastName")]
    public required LastName LastName { get; set; }

    /// <summary>
    /// The number of assists the NHL player has made to date <br/>
    /// Example: 34
    /// </summary>
    [JsonProperty("assistsToDate")]
    public int AssistsToDate { get; set; }
}

/// <summary>
/// The NHL game center landing away team
/// </summary>
public class GameCenterLandingAwayTeam
{
    /// <summary>
    /// The NHL team identifier for the away team <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The name of the NHL away team <br/>
    /// Example: Wild
    /// </summary>
    [JsonProperty("name")]
    public required Name Name { get; set; }

    /// <summary>
    /// The abbreviation of the NHL away team <br/>
    /// Example: TOR
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The place name of the NHL away team <br/>
    /// Example: Toronto
    /// </summary>
    [JsonProperty("placeName")]
    public required PlaceName PlaceName { get; set; }

    /// <summary>
    /// The score of the NHL away team <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The shots on goal of the NHL away team <br/>
    /// Example: 30
    /// </summary>
    [JsonProperty("sog")]
    public int Sog { get; set; }

    /// <summary>
    /// The url link to the logo of the NHL away team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/MIN_light.svg">https://assets.nhle.com/logos/nhl/svg/MIN_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public required string Logo { get; set; }
}

/// <summary>
/// The NHL gamecenter landing by period break down
/// </summary>
public class ByPeriod
{
    /// <summary>
    /// The NHL game period <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The NHL period descriptor
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The NHL away team score for the period <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("away")]
    public int Away { get; set; }

    /// <summary>
    /// The NHL home team score for the period <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("home")]
    public int Home { get; set; }
}

/// <summary>
/// The NHL gamecenter game information
/// </summary>
public class GameInfo
{
    /// <summary>
    /// The collection of referees for the NHL game
    /// </summary>
    [JsonProperty("referees")]
    public required List<Referee> Referees { get; set; }

    /// <summary>
    /// The collection of linesmen for the NHL game
    /// </summary>
    [JsonProperty("linesmen")]
    public required List<Linesman> Linesmen { get; set; }

    /// <summary>
    /// The game center landing away team
    /// </summary>
    [JsonProperty("awayTeam")]
    public required GameCenterLandingGameInfoAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The game center landing home team
    /// </summary>
    [JsonProperty("homeTeam")]
    public required GameCenterLandingGameInfoHomeTeam HomeTeam { get; set; }
}

/// <summary>
/// The NHL gamecenter landing game information team
/// </summary>
public class GameCenterLandingGameInfoTeam
{
    /// <summary>
    /// The NHL team head coach
    /// </summary>
    [JsonProperty("headCoach")]
    public required HeadCoach HeadCoach { get; set; }

    /// <summary>
    /// The collection of scratches for the NHL team
    /// </summary>
    [JsonProperty("scratches")]
    public required List<Scratch> Scratches { get; set; }
}

/// <summary>
/// The NHL gamecenter landing game information home team
/// </summary>
public class GameCenterLandingGameInfoHomeTeam : GameCenterLandingGameInfoTeam { }

/// <summary>
/// The NHL gamecenter landing game information away team
/// </summary>
public class GameCenterLandingGameInfoAwayTeam : GameCenterLandingGameInfoTeam { }

/// <summary>
/// The NHL game center game video
/// </summary>
public class GameVideo
{
    /// <summary>
    /// The 3 minute recap of the NHL game identifier <br/>
    /// Example: 6343037420112
    /// </summary>
    [JsonProperty("threeMinRecap")]
    public long ThreeMinRecap { get; set; }

    /// <summary>
    /// The 3 minute recap of the NHL game identifier in French <br/>
    /// Example: 6343036928112
    /// </summary>
    [JsonProperty("threeMinRecapFr")]
    public long ThreeMinRecapFr { get; set; }

    /// <summary>
    /// The condensed game of the NHL game identifier <br/>
    /// Example: 6343038579112
    /// </summary>
    [JsonProperty("condensedGame")]
    public long CondensedGame { get; set; }
}

/// <summary>
/// The NHL game center landing goal information
/// </summary>
public class Goal
{
    /// <summary>
    /// The situation code for the NHL game goal <br/>
    /// Example: 1551
    /// </summary>
    [JsonProperty("situationCode")]
    public required string SituationCode { get; set; }

    /// <summary>
    /// The strength of the play for the NHL game goal <br/>
    /// Example: ev
    /// </summary>
    [JsonProperty("strength")]
    public required string Strength { get; set; }

    /// <summary>
    /// The NHL player identifier for the player who scored the goal <br/>
    /// Example: 8475233
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The first name of the NHL player who scored the goal <br/>
    /// Example: David
    /// </summary>
    [JsonProperty("firstName")]
    public required FirstName FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL player who scored the goal <br/>
    /// Example: Pastrnak
    /// </summary>
    [JsonProperty("lastName")]
    public required LastName LastName { get; set; }

    /// <summary>
    /// The full name of the NHL player who scored the goal <br/>
    /// Example: D. Pastrnak
    /// </summary>
    [JsonProperty("name")]
    public required PlayerFullName Name { get; set; }

    /// <summary>
    /// The NHL team abbreviation for the team of the player who scored the goal <br/>
    /// Example: BOS
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public required TeamAbbrev TeamAbbrev { get; set; }

    /// <summary>
    /// The NHL headshot url link for the player who scored the goal <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/MTL/8475233.png">https://assets.nhle.com/mugs/nhl/20232024/MTL/8475233.png</a>
    /// </summary>
    [JsonProperty("headshot")]
    public required string Headshot { get; set; }

    /// <summary>
    /// The highlight clip of the NHL game goal <br/>
    /// Example: 6343003354112
    /// </summary>
    [JsonProperty("highlightClip")]
    public long HighlightClip { get; set; }

    /// <summary>
    /// The highlight clip of the NHL game goal in French <br/>
    /// Example: 6343002286112
    /// </summary>
    [JsonProperty("highlightClipFr")]
    public long HighlightClipFr { get; set; }

    /// <summary>
    /// The number of goals the NHL player has scored to date <br/>
    /// Example: 21
    /// </summary>
    [JsonProperty("goalsToDate")]
    public int GoalsToDate { get; set; }

    /// <summary>
    /// THe NHL away team score for the goal <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("awayScore")]
    public int AwayScore { get; set; }

    /// <summary>
    /// The NHL home team score for the goal <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("homeScore")]
    public int HomeScore { get; set; }

    /// <summary>
    /// The NHL leading team abbreviation for the goal <br/>
    /// Example: MTL
    /// </summary>
    [JsonProperty("leadingTeamAbbrev")]
    public required TeamAbbrev LeadingTeamAbbrev { get; set; }

    /// <summary>
    /// The NHL game time left in the period <br/>
    /// Example: 06:24
    /// </summary>
    [JsonProperty("timeInPeriod")]
    public required string TimeInPeriod { get; set; }

    /// <summary>
    /// The shot type of the NHL game goal <br/>
    /// Example: wrist
    /// </summary>
    [JsonProperty("shotType")]
    public required string ShotType { get; set; }

    /// <summary>
    /// The NHL game goal modifier if any required <br/>
    /// Example: none
    /// </summary>
    [JsonProperty("goalModifier")]
    public required string GoalModifier { get; set; }

    /// <summary>
    /// The collection of assists for the NHL game goal
    /// </summary>
    [JsonProperty("assists")]
    public required List<Assist> Assists { get; set; }
}

/// <summary>
/// The NHL game center landing head coach for the NHL team
/// </summary>
public class HeadCoach
{
    /// <summary>
    /// The name of the NHL team head coach <br/>
    /// Example: Mike Sullivan
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}

/// <summary>
/// The NHL gamecenter landing home team
/// </summary>
public class GameCenterLandingHomeTeam
{
    /// <summary>
    /// The NHL team identifier for the home team <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The name of the NHL home team <br/>
    /// Example: Wild
    /// </summary>
    [JsonProperty("name")]
    public required Name Name { get; set; }

    /// <summary>
    /// The abbreviation of the NHL home team <br/>
    /// Example: TOR
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The place name of the NHL home team <br/>
    /// Example: Toronto
    /// </summary>
    [JsonProperty("placeName")]
    public required PlaceName PlaceName { get; set; }

    /// <summary>
    /// The score of the NHL home team <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The shots on goal of the NHL home team <br/>
    /// Example: 30
    /// </summary>
    [JsonProperty("sog")]
    public int Sog { get; set; }

    /// <summary>
    /// The url link to the logo of the NHL home team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/MIN_light.svg">https://assets.nhle.com/logos/nhl/svg/MIN_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public required string Logo { get; set; }

}

/// <summary>
/// The NHL game center landing linescore information
/// </summary>
public class GameCenterLandingLinescore
{
    /// <summary>
    /// The collection of the periods for the NHL game and information about the period
    /// </summary>
    [JsonProperty("byPeriod")]
    public required List<ByPeriod> ByPeriod { get; set; }

    /// <summary>
    /// The total number of goals for the both NHL teams
    /// </summary>
    [JsonProperty("totals")]
    public required Totals Totals { get; set; }
}

/// <summary>
/// The NHL game center landing linesman information
/// </summary>
public class Linesman
{
    /// <summary>
    /// The name of the NHL linesman <br/>
    /// Example: Tyson Baker
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}

/// <summary>
/// The NHL game center landing penalty information
/// </summary>
public class GameCenterLandingPenalty
{
    /// <summary>
    /// The period for the NHL game penalty <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The period descriptor for the NHL game penalty
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

}

/// <summary>
/// The NHL game center landing penalty information
/// </summary>
public class Penalty
{
    /// <summary>
    /// The time in the period for the NHL game penalty <br/>
    /// Example: 14:53
    /// </summary>
    [JsonProperty("timeInPeriod")]
    public required string TimeInPeriod { get; set; }

    /// <summary>
    /// The type of penalty for the NHL game penalty <br/>
    /// Example: MIN
    /// </summary>
    [JsonProperty("type")]
    public required string Type { get; set; }

    /// <summary>
    /// The duration of the penalty for the NHL game penalty <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("duration")]
    public int Duration { get; set; }

    /// <summary>
    /// The player the committed the penalty for the NHL game penalty <br/>
    /// Example: Marcus Pettersson
    /// </summary>
    [JsonProperty("committedByPlayer")]
    public required string CommittedByPlayer { get; set; }

    /// <summary>
    /// The team abbreviation of the player who committed the penalty for the NHL game penalty <br/>
    /// Example: PIT
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public required string TeamAbbrev { get; set; }

    /// <summary>
    /// The player who had draw or won the penalty for the NHL game penalty <br/>
    /// Example: Cole Caufield
    /// </summary>
    [JsonProperty("drawnBy")]
    public required string DrawnBy { get; set; }

    /// <summary>
    /// The description of the penalty for the NHL game penalty <br/>
    /// Example: interference
    /// </summary>
    [JsonProperty("descKey")]
    public required string DescKey { get; set; }
}

/// <summary>
/// The NHL game center referee information
/// </summary>
public class Referee
{

    /// <summary>
    /// The name of the NHL referee <br/>
    /// Example: Jake Brenk
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}

/// <summary>
/// The NHL game center landing information
/// </summary>
public class GameCenterLanding
{

    /// <summary>
    /// The NHL game identifier for the game <br/>
    /// Example: 2023020204
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The season identifier for the NHL game <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The game type identifier for the NHL game <br/>
    /// Example: 2 - Regular Season or 3 - Playoffs
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }

    /// <summary>
    /// The game date for the NHL game <br/>
    /// Example: 2023-10-04
    /// </summary>
    [JsonProperty("gameDate")]
    public required string GameDate { get; set; }

    /// <summary>
    /// The information about the NHL game venue
    /// </summary>
    [JsonProperty("venue")]
    public required Venue Venue { get; set; }

    /// <summary>
    /// The start time in UTC for the NHL game <br/>
    /// Example: 2023-10-04T23:00:00Z
    /// </summary>
    [JsonProperty("startTimeUTC")]
    public DateTime StartTimeUTC { get; set; }

    /// <summary>
    /// The eastern UTC offset for the NHL game <br/>
    /// Example: -5:00
    /// </summary>
    [JsonProperty("easternUTCOffset")]
    public required string EasternUTCOffset { get; set; }

    /// <summary>
    /// The venue UTC offset for the NHL game <br/>
    /// Example: -5:00
    /// </summary>
    [JsonProperty("venueUTCOffset")]
    public required string VenueUTCOffset { get; set; }

    /// <summary>
    /// The venue timezone for the NHL game <br/>
    /// Example: US/Eastern
    /// </summary>
    [JsonProperty("venueTimezone")]
    public required string VenueTimezone { get; set; }

    /// <summary>
    /// The collection of the NHL game broadcasts
    /// </summary>
    [JsonProperty("tvBroadcasts")]
    public required List<TvBroadcast> TvBroadcasts { get; set; }

    /// <summary>
    /// The NHL game state for the game <br/>
    /// Example: OFF
    /// </summary>
    [JsonProperty("gameState")]
    public required string GameState { get; set; }

    /// <summary>
    /// The NHL game schedule state for the game <br/>
    /// Example: OK
    /// </summary>
    [JsonProperty("gameScheduleState")]
    public required string GameScheduleState { get; set; }

    /// <summary>
    /// The NHL away team for the game
    /// </summary>
    [JsonProperty("awayTeam")]
    public required GameCenterLandingAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL home team for the game
    /// </summary>
    [JsonProperty("homeTeam")]
    public required GameCenterLandingHomeTeam HomeTeam { get; set; }

    /// <summary>
    /// Returns if a shootout was in use for the NHL game <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("shootoutInUse")]
    public bool ShootoutInUse { get; set; }

    /// <summary>
    /// The maximum number of periods for the NHL game <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("maxPeriods")]
    public int MaxPeriods { get; set; }

    /// <summary>
    /// The number of regular periods for the NHL game <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("regPeriods")]
    public int RegPeriods { get; set; }

    /// <summary>
    /// Returns true or false if overtime was in use for the NHL game <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("otInUse")]
    public bool OtInUse { get; set; }

    /// <summary>
    /// Returns true or false if ties were in use for the NHL game <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("tiesInUse")]
    public bool TiesInUse { get; set; }

    /// <summary>
    /// The period clock information for the NHL game
    /// </summary>
    [JsonProperty("clock")]
    public required Clock Clock { get; set; }

    /// <summary>
    /// The summary of the NHL game
    /// </summary>
    [JsonProperty("summary")]
    public required Summary Summary { get; set; }
}

/// <summary>
/// The NHL game center scoring information
/// </summary>
public class Scoring
{
    /// <summary>
    /// The period for the NHL game scoring <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The period descriptor for the NHL game scoring
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The collection of goals for the NHL game
    /// </summary>
    [JsonProperty("goals")]
    public required List<Goal> Goals { get; set; }
}

/// <summary>
/// The NHL gamecenter landing player scratch
/// </summary>
public class Scratch
{
    /// <summary>
    /// The NHL player identifier for the player who is scratched <br/>
    /// Example: 8475750
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The first name of the NHL player who is scratched <br/>
    /// Example: Jon
    /// </summary>
    [JsonProperty("firstName")]
    public required FirstName FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL player who is scratched <br/>
    /// Example: Merrill
    /// </summary>
    [JsonProperty("lastName")]
    public required LastName LastName { get; set; }
}

/// <summary>
/// The NHL gamecenter landing season series
/// </summary>
public class SeasonSeries
{
    /// <summary>
    /// The NHL game identifier for the game <br/>
    /// Example: 2023020204
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL seaaon identifier for the season <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The NHL game type identifier for the game <br/>
    /// Example: 2 - Regular Season or 3 - Playoffs
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }

    /// <summary>
    /// The NHL game date for the game <br/>
    /// Example: 2023-10-04
    /// </summary>
    [JsonProperty("gameDate")]
    public required string GameDate { get; set; }

    /// <summary>
    /// The NHL start time in UTC for the game <br/>
    /// Example: 2023-10-04T23:00:00Z
    /// </summary>
    [JsonProperty("startTimeUTC")]
    public DateTime StartTimeUTC { get; set; }

    /// <summary>
    /// The eastern UTC offset for the game <br/>
    /// Example: -5:00
    /// </summary>
    [JsonProperty("easternUTCOffset")]
    public required string EasternUTCOffset { get; set; }

    /// <summary>
    /// The venue UTC offset for the game <br/>
    /// Example: -5:00
    /// </summary>
    [JsonProperty("venueUTCOffset")]
    public required string VenueUTCOffset { get; set; }

    /// <summary>
    /// The NHL game state for the game <br/>
    /// Example: OFF
    /// </summary>
    [JsonProperty("gameState")]
    public required string GameState { get; set; }

    /// <summary>
    /// The NHL game schedule state for the game <br/>
    /// Example: OK
    /// </summary>
    [JsonProperty("gameScheduleState")]
    public required string GameScheduleState { get; set; }

    /// <summary>
    /// The NHL away team for the game
    /// </summary>
    [JsonProperty("awayTeam")]
    public required GameCenterLandingAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL home team for the game
    /// </summary>
    [JsonProperty("homeTeam")]
    public required GameCenterLandingHomeTeam HomeTeam { get; set; }

    /// <summary>
    /// The NHL time information for the game
    /// </summary>
    [JsonProperty("clock")]
    public required Clock Clock { get; set; }

    /// <summary>
    /// The period for the NHL game <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The period descriptor for the NHL game
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The NHL game outcome for the game
    /// </summary>
    [JsonProperty("gameOutcome")]
    public required GameOutcome GameOutcome { get; set; }
}

/// <summary>
/// The NHL gamecenter landing shots by period
/// </summary>
public class ShotsByPeriod
{
    /// <summary>
    /// The period for the NHL game <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The NHL period descriptor for the game
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The number of shots for the NHL away team <br/>
    /// Example: 10
    /// </summary>
    [JsonProperty("away")]
    public int Away { get; set; }

    /// <summary>
    /// The number of shots for the NHL home team <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("home")]
    public int Home { get; set; }
}

/// <summary>
/// The summary of the NHL gamecenter landing
/// </summary>
public class Summary
{
    /// <summary>
    /// The linescore for the NHL game
    /// </summary>
    [JsonProperty("linescore")]
    public required Linescore Linescore { get; set; }

    /// <summary>
    /// The scoring for the NHL game
    /// </summary>
    [JsonProperty("scoring")]
    public required List<Scoring> Scoring { get; set; }

    /// <summary>
    /// The shootout information
    /// </summary>
    [JsonProperty("shootout")]
    public required List<Shootout> Shootout { get; set; }


    /// <summary>
    /// The NHL team game statistics for the NHL game
    /// </summary>
    [JsonProperty("teamGameStats")]
    public required List<TeamGameStat> TeamGameStats { get; set; }

    /// <summary>
    /// The breakdown of the NHL game shots by period
    /// </summary>
    [JsonProperty("shotsByPeriod")]
    public required List<ShotsByPeriod> ShotsByPeriod { get; set; }

    /// <summary>
    /// The penalties for the NHL game
    /// </summary>
    [JsonProperty("penalties")]
    public required List<GameCenterLandingPenalty> Penalties { get; set; }

    /// <summary>
    /// The season series for the NHL game between both teams
    /// </summary>
    [JsonProperty("seasonSeries")]
    public required List<SeasonSeries> SeasonSeries { get; set; }

    /// <summary>
    /// The NHL game information
    /// </summary>
    [JsonProperty("gameInfo")]
    public required GameInfo GameInfo { get; set; }

    /// <summary>
    /// The NHL game video information
    /// </summary>
    [JsonProperty("gameVideo")]
    public required GameVideo GameVideo { get; set; }
}


/// <summary>
/// The NHL game center landing shootout information
/// </summary>
public class Shootout
{
    /// <summary>
    /// The shootout away deciding goal for the NHL game <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("awayDecidingGoal")]
    public int AwayDecidingGoal { get; set; }

    /// <summary>
    /// The shootout away conversions for the NHL game <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("awayConversions")]
    public int AwayConversions { get; set; }

    /// <summary>
    /// The shootout away attempts for the NHL game <br/>
    /// Example: 13
    /// </summary>
    [JsonProperty("awayAttempts")]
    public int AwayAttempts { get; set; }

    /// <summary>
    /// The home shootout deciding goal for the NHL game <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("homeDecidingGoal")]
    public int HomeDecidingGoal { get; set; }

    /// <summary>
    /// The number of shootout home conversions for the NHL game <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("homeConversions")]
    public int HomeConversions { get; set; }

    /// <summary>
    /// The shootout home attempts for the NHL game <br/>
    /// Example: 13
    /// </summary>
    [JsonProperty("homeAttempts")]
    public int HomeAttempts { get; set; }
}


/// <summary>
/// The NHL game center landing team game statistics
/// </summary>
public class TeamGameStat
{
    /// <summary>
    /// The category of the NHL game statistic <br/>
    /// Example: sog - shots on goal
    /// </summary>
    [JsonProperty("category")]
    public required string Category { get; set; }

    /// <summary>
    /// The NHL away team value for the team game statistic <br/>
    /// Example: 30
    /// </summary>
    [JsonProperty("awayValue")]
    public required string AwayValue { get; set; }

    /// <summary>
    /// The NHL home team value for the team game statistic <br/>
    /// Example: 35
    /// </summary>
    [JsonProperty("homeValue")]
    public required string HomeValue { get; set; }
}

/// <summary>
/// The NHL game center landing 3 stars of the game
/// </summary>
public class ThreeStar
{
    /// <summary>
    /// The number of the star for the NHL game <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("star")]
    public int Star { get; set; }

    /// <summary>
    /// The NHL player identifier for the player who is the star of the game <br/>
    /// Example: 8471675
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL Team abbreviation for the team of the star of the game <br/>
    /// Example: PIT
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public string? TeamAbbrev { get; set; }

    /// <summary>
    /// The url link to the headshot of the NHL player who is the star of the game <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/PIT/8471675.png">https://assets.nhle.com/mugs/nhl/20232024/PIT/8471675.png</a>
    /// </summary>
    [JsonProperty("headshot")]
    public string? Headshot { get; set; }

    /// <summary>
    /// The full name of the NHL player who is the star of the game <br/>
    /// Example: S. Crosby
    /// </summary>
    [JsonProperty("name")]
    public string? Name { get; set; }

    /// <summary>
    /// The first name of the NHL player who is the star of the game <br/>
    /// Example: Sidney
    /// </summary>
    [JsonProperty("firstName")]
    public string? FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL player who is the star of the game <br/>
    /// Example: Crosby
    /// </summary>
    [JsonProperty("lastName")]
    public string? LastName { get; set; }

    /// <summary>
    /// The sweater number of the NHL player who is the star of the game <br/>
    /// Example: 87
    /// </summary>
    [JsonProperty("sweaterNo")]
    public int SweaterNo { get; set; }

    /// <summary>
    /// The position of the NHL player who is the star of the game <br/>
    /// Example: C
    /// </summary>
    [JsonProperty("position")]
    public string? Position { get; set; }

    /// <summary>
    /// The goalie goals against average of the NHL player who is the star of the game <br/>
    /// Example: 2.77
    /// </summary>
    [JsonProperty("goalsAgainstAverage")]
    public decimal? GoalsAgainstAverage { get; set; }

    /// <summary>
    /// The save percentage of the NHL player who is the star of the game <br/>
    /// Example: 0.912
    /// </summary>
    [JsonProperty("savePctg")]
    public decimal? SavePctg { get; set; }

    /// <summary>
    /// The number of goals of the NHL player who is the star of the game <br/>
    /// Example: 15
    /// </summary>
    [JsonProperty("goals")]
    public int? Goals { get; set; }

    /// <summary>
    /// The number of assists of the NHL player who is the star of the game <br/>
    /// Example: 54
    /// </summary>
    [JsonProperty("assists")]
    public int? Assists { get; set; }

    /// <summary>
    /// The number of points of the NHL player who is the star of the game <br/>
    /// Example: 69
    /// </summary>
    [JsonProperty("points")]
    public int? Points { get; set; }
}

/// <summary>
/// The NHL game center landing team totals
/// </summary>
public class Totals
{
    /// <summary>
    /// The NHL away team goal total's for the NHL game <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("away")]
    public int Away { get; set; }


    /// <summary>
    /// The NHL home team goal total's for the NHL game <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("home")]
    public int Home { get; set; }
}

/// <summary>
/// The NHL player full name
/// </summary>
public class PlayerFullName
{
    /// <summary>
    /// The default full name of the NHL player <br/>
    /// Example: Sidney Crosby
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}
