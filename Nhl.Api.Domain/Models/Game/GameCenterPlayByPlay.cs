using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Nhl.Api.Models.Player;

namespace Nhl.Api.Models.Game;


/// <summary>
/// The NHL away team for the game center play by play
/// </summary>
public class GameCenterAwayTeam
{
    /// <summary>
    /// The NHL away team identifier <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL away team name <br/>
    /// Example: Leafs
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The abbreviation of the NHL away team <br/>
    /// Example: MIN
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// The score of the NHL away team <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The number of shots on goal for the NHL away team <br/>
    /// Example: 23
    /// </summary>
    [JsonProperty("sog")]
    public int Sog { get; set; }

    /// <summary>
    /// The URL of the logo for the NHL away team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/MIN_light.svg">https://assets.nhle.com/logos/nhl/svg/MIN_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// The players on the ice for the NHL away team
    /// </summary>
    [JsonProperty("onIce")]
    public List<object> OnIce { get; set; }
}

/// <summary>
/// The NHL game center details for the play by play
/// </summary>
public class GameCenterDetails
{
    /// <summary>
    /// The event identifier for the NHL game center play by play <br/>
    /// Example: 104
    /// </summary>
    [JsonProperty("eventOwnerTeamId")]
    public int EventOwnerTeamId { get; set; }

    /// <summary>
    /// The losing player identifier for the NHL game center play by play <br/>
    /// Example: 8481522
    /// </summary>
    [JsonProperty("losingPlayerId")]
    public int? LosingPlayerId { get; set; }

    /// <summary>
    /// The winning player identifier for the NHL game center play by play <br/>
    /// Example: 8480980
    /// </summary>
    [JsonProperty("winningPlayerId")]
    public int? WinningPlayerId { get; set; }

    /// <summary>
    /// The x coordinate for the NHL game center play by play <br/>
    /// Example: -20
    /// </summary>
    [JsonProperty("xCoord")]
    public int? XCoord { get; set; }

    /// <summary>
    /// The Y coordinate for the NHL game center play by play <br/>
    /// Example: -22
    /// </summary>
    [JsonProperty("yCoord")]
    public int? YCoord { get; set; }

    /// <summary>
    /// The zone code for the NHL game center play by play <br/>
    /// Example: N/O/D - Neutral/Offensive/Defensive
    /// </summary>
    [JsonProperty("zoneCode")]
    public string ZoneCode { get; set; }

    /// <summary>
    /// The unique type code for the NHL game center play by play <br/>
    /// Example: 508 - blocked-shot
    /// </summary>
    [JsonProperty("typeCode")]
    public string TypeCode { get; set; }

    /// <summary>
    /// The description key for the NHL game center play by play <br/>
    /// Example: tripping
    /// </summary>
    [JsonProperty("descKey")]
    public string DescKey { get; set; }

    /// <summary>
    /// The duration for a penalty for the NHL game center play by play <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("duration")]
    public int? Duration { get; set; }

    /// <summary>
    /// The penalty committed by player identifier for the NHL game center play by play <br/>
    /// Example: 8478493
    /// </summary>
    [JsonProperty("committedByPlayerId")]
    public int? CommittedByPlayerId { get; set; }

    /// <summary>
    /// The penalty drawn by player identifier for the NHL game center play by play <br/>
    /// Example: 8481564
    /// </summary>
    [JsonProperty("drawnByPlayerId")]
    public int? DrawnByPlayerId { get; set; }

    /// <summary>
    /// The shot type when a player shoots the puck for the NHL game center play by play <br/>
    /// Example: 
    /// <code>
    /// slap | wrist | snap | tip-in | deflected
    /// </code>
    /// </summary>
    [JsonProperty("shotType")]
    public string ShotType { get; set; }

    /// <summary>
    /// The shooting player identifier for the NHL game center play by play <br/>
    /// Example: 8478402
    /// </summary>
    [JsonProperty("shootingPlayerId")]
    public int? ShootingPlayerId { get; set; }

    /// <summary>
    /// The goalie in the net player identifier for the NHL game center play by play <br/>
    /// Example: 8479406
    /// </summary>
    [JsonProperty("goalieInNetId")]
    public int? GoalieInNetId { get; set; }

    /// <summary>
    /// The away team shot on goal for the NHL game center play by play <br/>
    /// Example: 6
    /// </summary>
    [JsonProperty("awaySOG")]
    public int? AwaySOG { get; set; }

    /// <summary>
    /// The away team shot on goal for the NHL game center play by play <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("homeSOG")]
    public int? HomeSOG { get; set; }

    /// <summary>
    /// The player identifier that blocked the shot for the NHL game center play by play <br/>
    /// Example: 8480035
    /// </summary>
    [JsonProperty("blockingPlayerId")]
    public int? BlockingPlayerId { get; set; }

    /// <summary>
    /// The hitting player identifier for the NHL game center play by play <br/>
    /// Example: 8477451
    /// </summary>
    [JsonProperty("hittingPlayerId")]
    public int? HittingPlayerId { get; set; }

    /// <summary>
    /// The hittee player identifier for the NHL game center play by play <br/>
    /// Example: 8478402
    /// </summary>
    [JsonProperty("hitteePlayerId")]
    public int? HitteePlayerId { get; set; }

    /// <summary>
    /// The player identifier for the NHL game center play by play <br/>
    /// Example: 8478402
    /// </summary>
    [JsonProperty("playerId")]
    public int? PlayerId { get; set; }

    /// <summary>
    /// The reason for the event of the NHL game center play by play <br/>
    /// Example: puck-in-netting
    /// </summary>
    [JsonProperty("reason")]
    public string Reason { get; set; }

    /// <summary>
    /// The secondary reason for the event of the NHL game center play by play <br/>
    /// Example: video-review
    /// </summary>
    [JsonProperty("secondaryReason")]
    public string SecondaryReason { get; set; }
}


/// <summary>
/// The NHL home team for the game center play by play
/// </summary>
public class GameCenterHomeTeam
{
    /// <summary>
    /// The NHL home team identifier <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL home team name <br/>
    /// Example: Leafs
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The abbreviation of the NHL home team <br/>
    /// Example: MIN
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// The score of the NHL home team <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The number of shots on goal for the NHL home team <br/>
    /// Example: 23
    /// </summary>
    [JsonProperty("sog")]
    public int Sog { get; set; }

    /// <summary>
    /// The URL of the logo for the NHL home team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/MIN_light.svg">https://assets.nhle.com/logos/nhl/svg/MIN_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// The players on the ice for the NHL home team
    /// </summary>
    [JsonProperty("onIce")]
    public List<object> OnIce { get; set; }
}

/// <summary>
/// The NHL game center play
/// </summary>
public class GameCenterPlay
{
    /// <summary>
    /// The event identifier for the NHL game center play by play <br/>
    /// Example: 32
    /// </summary>
    [JsonProperty("eventId")]
    public int EventId { get; set; }

    /// <summary>
    /// The period number for the NHL game center play by play <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The period descriptor for the NHL game center play by play <br/>
    /// Example: 
    /// <code>
    ///  "periodDescriptor": {
    ///  "number": 2,
    ///         "periodType": "REG"
    ///  }
    /// </code>
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The time remaining in the period for the NHL game center play by play <br/>
    /// Example: 04:57
    /// </summary>
    [JsonProperty("timeInPeriod")]
    public string TimeInPeriod { get; set; }

    /// <summary>
    /// The time remaining in the game for the NHL game center play by play <br/>
    /// Example: 15:03
    /// </summary>
    [JsonProperty("timeRemaining")]
    public string TimeRemaining { get; set; }

    /// <summary>
    /// The situation code for the NHL game center play by play <br/>
    /// Example: 1441
    /// </summary>
    [JsonProperty("situationCode")]
    public string SituationCode { get; set; }

    /// <summary>
    /// The home team defending side for the NHL game center play by play <br/>
    /// Example: right
    /// </summary>
    [JsonProperty("homeTeamDefendingSide")]
    public string HomeTeamDefendingSide { get; set; }

    /// <summary>
    /// The type code for the NHL game center play by play <br/>
    /// Example: 505
    /// </summary>
    [JsonProperty("typeCode")]
    public int TypeCode { get; set; }

    /// <summary>
    /// The type description key for the NHL game center play by play <br/>
    /// Example: faceoff
    /// </summary>
    [JsonProperty("typeDescKey")]
    public string TypeDescKey { get; set; }

    /// <summary>
    /// The sort order identifier for the NHL game center play by play <br/>
    /// Example: 132
    /// </summary>
    [JsonProperty("sortOrder")]
    public int SortOrder { get; set; }

    /// <summary>
    /// The details of the game center play by play
    /// </summary>
    [JsonProperty("details")]
    public GameCenterDetails Details { get; set; }
}

/// <summary>
/// The NHL game center play by play information
/// </summary>
public class GameCenterPlayByPlay
{

    /// <summary>
    /// The NHL game identifier for the NHL game center play by play <br/>
    /// Example: 2023020204
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The season identifier for the NHL game center play by play <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The game type for the NHL game center play by play <br/>
    /// Example: 2 - Regular Season or 3 - Playoffs
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }

    /// <summary>
    /// The game date for the NHL game center play by play <br/>
    /// Example: 2023-11-10
    /// </summary>
    [JsonProperty("gameDate")]
    public string GameDate { get; set; }

    /// <summary>
    /// The venue for the NHL game center play by play
    /// </summary>
    [JsonProperty("venue")]
    public Venue Venue { get; set; }

    /// <summary>
    /// The NHL start time in UTC for a specific game for the NHL game center play by play <br/>
    /// Example: 2024-01-03T00:00:00Z
    /// </summary>
    [JsonProperty("startTimeUTC")]
    public DateTime StartTimeUTC { get; set; }

    /// <summary>
    /// The NHL eastern UTC offset for a specific game for the NHL game center play by play <br/>
    /// Example: -05:00
    /// </summary>
    [JsonProperty("easternUTCOffset")]
    public string EasternUTCOffset { get; set; }

    /// <summary>
    /// The NHL venue utc offset for a specific game for the NHL game center play by play <br/>
    /// Example: -08:00
    /// </summary>
    [JsonProperty("venueUTCOffset")]
    public string VenueUTCOffset { get; set; }

    /// <summary>
    /// The collection of NHL TV broadcasts for a specific game for the NHL game center play by play
    /// </summary>
    [JsonProperty("tvBroadcasts")]
    public List<TvBroadcast> TvBroadcasts { get; set; } = new();

    /// <summary>
    /// The NHL game state for a specific game for the NHL game center play by play <br/>
    /// Example: OFF or LIVE or FUT
    /// </summary>
    [JsonProperty("gameState")]
    public string GameState { get; set; }

    /// <summary>
    /// The NHL game schedule state for a specific game for the NHL game center play by play <br/>
    /// Example: OK
    /// </summary>
    [JsonProperty("gameScheduleState")]
    public string GameScheduleState { get; set; }

    /// <summary>
    /// The NHL period for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The period type for a specific game for the scoreboard for an NHL team 
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The NHL away team for the game center play by play
    /// </summary>
    [JsonProperty("awayTeam")]
    public GameCenterAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL home team for the game center play by play
    /// </summary>
    [JsonProperty("homeTeam")]
    public GameCenterHomeTeam HomeTeam { get; set; }

    /// <summary>
    /// The NHL game clock information for the NHL game center play by play
    /// </summary>
    [JsonProperty("clock")]
    public Clock Clock { get; set; }

    /// <summary>
    /// The collection of roster members from each NHL team for the NHL game center play by play
    /// </summary>
    [JsonProperty("rosterSpots")]
    public List<RosterSpot> RosterSpots { get; set; } = new();

    /// <summary>
    /// The display period within the NHL game center play by play <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("displayPeriod")]
    public int DisplayPeriod { get; set; }

    /// <summary>
    /// The NHL game outcome for the NHL game center play by play
    /// </summary>
    [JsonProperty("gameOutcome")]
    public GameOutcome GameOutcome { get; set; }

    /// <summary>
    /// The NHL game play by play information for the NHL game center play by play
    /// </summary>
    [JsonProperty("plays")]
    public List<GameCenterPlay> Plays { get; set; } = new();

}


/// <summary>
/// The roster spot for the NHL game center play by play
/// </summary>
public class RosterSpot
{
    /// <summary>
    /// The NHL team identifier for the NHL game center play by play <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("teamId")]
    public int TeamId { get; set; }

    /// <summary>
    /// The NHL player identifier for the NHL game center play by play <br/>
    /// Example: 8481557
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The first name of the NHL player for the NHL game center play by play <br/>
    /// Example: Matt
    /// </summary>
    [JsonProperty("firstName")]
    public FirstName FirstName { get; set; }

    /// <summary>
    /// The last name of the NHL player for the NHL game center play by play <br/>
    /// Example: Boldy
    /// </summary>
    [JsonProperty("lastName")]
    public LastName LastName { get; set; }

    /// <summary>
    /// The jersey number of the NHL player for the NHL game center play by play <br/>
    /// Example: 17
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int SweaterNumber { get; set; }

    /// <summary>
    /// The position code of the NHL player for the NHL game center play by play <br/>
    /// Example: L/R/C/D/G
    /// </summary>
    [JsonProperty("positionCode")]
    public string PositionCode { get; set; }

    /// <summary>
    /// The url link headshot of the NHL player for the NHL game center play by play <br/>
    /// Example: <a href="https://assets.nhle.com/mugs/nhl/20232024/BUF/8482175.png">https://assets.nhle.com/mugs/nhl/20232024/BUF/8482175.png</a>
    /// </summary>
    [JsonProperty("headshot")]
    public string Headshot { get; set; }
}
