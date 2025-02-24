using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Game;
/// <summary>
/// The NHL away team for the game scores information
/// </summary>
public class GameScoreAwayTeam
{
    /// <summary>
    /// The NHL team identifier for the away team <br/>
    /// Example: 17 - Detroit Red Wings
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The name of the NHL team for the away team
    /// Example: Red Wings
    /// </summary>
    [JsonProperty("name")]
    public required Name Name { get; set; }

    /// <summary>
    /// The abbreviation of the NHL team for the away team <br/>
    /// Example: DET
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The score of the NHL team for the away team <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The number of shots on goal for the NHL team for the away team <br/>
    /// Example: 30
    /// </summary>
    [JsonProperty("sog")]
    public int ShotsOnGoal { get; set; }

    /// <summary>
    /// The logo of the NHL team for the away team <br/>
    /// Example: https://assets.nhle.com/logos/nhl/svg/WPG_light.svg
    /// </summary>
    [JsonProperty("logo")]
    public required string Logo { get; set; }
}

/// <summary>
/// The NHL game score clock information for live games
/// </summary>
public class Clock
{
    /// <summary>
    /// The time remaining in the period for the NHL game score clock information <br/>
    /// Example: 12:32
    /// </summary>
    [JsonProperty("timeRemaining")]
    public required string TimeRemaining { get; set; }

    /// <summary>
    /// The number of seconds remaining in the period for the NHL game score clock information <br/>
    /// Example: 20
    /// </summary>
    [JsonProperty("secondsRemaining")]
    public int SecondsRemaining { get; set; }

    /// <summary>
    /// The clock running for the NHL game score clock information <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("running")]
    public bool Running { get; set; }

    /// <summary>
    /// Is the NHL game score clock information in intermission <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("inIntermission")]
    public bool InIntermission { get; set; }
}

/// <summary>
/// The NHL game score information for the game
/// </summary>
public class GameScoreGame
{

    /// <summary>
    /// The NHL game identifier for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 2023020585
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL game season for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The NHL game type for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }

    /// <summary>
    /// The NHL game date for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 2024-01-02
    /// </summary>
    [JsonProperty("gameDate")]
    public required string GameDate { get; set; }

    /// <summary>
    /// The NHL game center link for a specific game for the scoreboard for an NHL team <br/>
    /// Example: <a href="https://www.nhl.com/gamecenter/lak-vs-tor/2024/01/02/2023020585#game=2023020585">https://www.nhl.com/gamecenter/lak-vs-tor/2024/01/02/2023020585</a>
    /// </summary>
    [JsonProperty("gameCenterLink")]
    public required string GameCenterLink { get; set; }

    /// <summary>
    /// The NHL venue for a specific game for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("venue")]
    public required Venue Venue { get; set; }

    /// <summary>
    /// The NHL start time in UTC for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 2024-01-03T00:00:00Z
    /// </summary>
    [JsonProperty("startTimeUTC")]
    public DateTime StartTimeUTC { get; set; }

    /// <summary>
    /// The NHL eastern UTC offset for a specific game for the scoreboard for an NHL team <br/>
    /// Example: -05:00
    /// </summary>
    [JsonProperty("easternUTCOffset")]
    public required string EasternUTCOffset { get; set; }

    /// <summary>
    /// The NHL venue utc offset for a specific game for the scoreboard for an NHL team <br/>
    /// Example: -08:00
    /// </summary>
    [JsonProperty("venueUTCOffset")]
    public required string VenueUTCOffset { get; set; }

    /// <summary>
    /// The collection of NHL TV broadcasts for a specific game for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("tvBroadcasts")]
    public required List<TvBroadcast> TvBroadcasts { get; set; }

    /// <summary>
    /// The NHL game state for a specific game for the scoreboard for an NHL team <br/>
    /// Example: OFF or LIVE or FUT
    /// </summary>
    [JsonProperty("gameState")]
    public required string GameState { get; set; }

    /// <summary>
    /// The NHL game schedule state for a specific game for the scoreboard for an NHL team <br/>
    /// Example: OK
    /// </summary>
    [JsonProperty("gameScheduleState")]
    public required string GameScheduleState { get; set; }

    /// <summary>
    /// The NHL period for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// An NHL link to the game 3 minute recap for a specific game for the scoreboard for an NHL team <br/>
    /// Example: <a href="https://www.nhl.com/video/recap-golden-knights-at-lightning-12-21-23-6343695834112">https://www.nhl.com/video/recap-golden-knights-at-lightning-12-21-23-6343695834112</a>
    /// </summary>
    [JsonProperty("threeMinRecap")]
    public required string ThreeMinRecap { get; set; }

    /// <summary>
    /// The NHL away team for the game scores information
    /// </summary>
    [JsonProperty("awayTeam")]
    public required GameScoreAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL home team for the game scores information
    /// </summary>
    [JsonProperty("homeTeam")]
    public required GameScoreHomeTeam HomeTeam { get; set; }

    /// <summary>
    /// The NHL game score clock information for the game
    /// </summary>
    [JsonProperty("clock")]
    public required Clock Clock { get; set; }

    /// <summary>
    /// Is the NHL game at a neutral site <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("neutralSite")]
    public bool NeutralSite { get; set; }

    /// <summary>
    /// The NHL venue time zone for the game <br/>
    /// Example: US/Eastern
    /// </summary>
    [JsonProperty("venueTimezone")]
    public required string VenueTimezone { get; set; }

    /// <summary>
    /// The NHL game score period information for the game
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The NHL game outcome based on the plays of the game <br/>
    /// </summary>
    [JsonProperty("gameOutcome")]
    public required GameOutcome GameOutcome { get; set; }

    /// <summary>
    /// The goals scored in the NHL game for the game score information
    /// </summary>
    [JsonProperty("goals")]
    public required List<GameScoreGoal> Goals { get; set; }

    /// <summary>
    /// The three minute recap in French for the NHL game <br/>
    /// Example: <a href="https://www.nhl.com/fr/video/resume-toronto-columbus-23-12-23-23-6343803556112">https://www.nhl.com/fr/video/resume-toronto-columbus-23-12-23-23-6343803556112</a>
    /// </summary>
    [JsonProperty("threeMinRecapFr")]
    public required string ThreeMinRecapFr { get; set; }

}

/// <summary>
/// The NHL game outcome based on the plays of the game
/// </summary>
public class GameOutcome
{
    /// <summary>
    /// The last period type for the NHL game outcome <br/>
    /// Example: OT
    /// </summary>
    [JsonProperty("lastPeriodType")]
    public required string LastPeriodType { get; set; }
}

/// <summary>
/// The NHL game score game week information for the games in the specified week
/// </summary>
public class GameScoreGameWeek
{
    /// <summary>
    /// The date of the NHL game week <br/>
    /// Example: 2024-01-02
    /// </summary>
    [JsonProperty("date")]
    public required string Date { get; set; }

    /// <summary>
    /// The day of the week abbreviation for the NHL game week <br/>
    /// Example: MON
    /// </summary>
    [JsonProperty("dayAbbrev")]
    public required string DayAbbrev { get; set; }

    /// <summary>
    /// The number of games in the NHL game week <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("numberOfGames")]
    public int NumberOfGames { get; set; }
}

/// <summary>
/// The NHL game score goal information for the game
/// </summary>
public class GameScoreGoal
{
    /// <summary>
    /// The period for the NHL game score goal information <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The period descriptor for the NHL game score goal information
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The period time for the NHL game score goal information <br/>
    /// Example: 15:38
    /// </summary>
    [JsonProperty("timeInPeriod")]
    public required string TimeInPeriod { get; set; }

    /// <summary>
    /// The NHL player identifier for the NHL game score goal information <br/>
    /// Example: 8480145
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL player name for the NHL game score goal information <br/>
    /// Example: N. Pionk
    /// </summary>
    [JsonProperty("name")]
    public required Name Name { get; set; }

    /// <summary>
    /// The mugshot for the NHL player for the NHL game score goal information <br/>
    /// Example: https://assets.nhle.com/mugs/nhl/20232024/WPG/8480145.png
    /// </summary>
    [JsonProperty("mugshot")]
    public required string Mugshot { get; set; }

    /// <summary>
    /// The NHL team abbreviation for the NHL game score goal information <br/>
    /// Example: WPG
    /// </summary>
    [JsonProperty("teamAbbrev")]
    public required string TeamAbbrev { get; set; }

    /// <summary>
    /// The number of goals to date for the NHL player for the NHL game score goal information <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("goalsToDate")]
    public int GoalsToDate { get; set; }

    /// <summary>
    /// Is the goal an away goal for the NHL game score goal information <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("awayScore")]
    public int AwayScore { get; set; }

    /// <summary>
    /// Is the goal a home goal for the NHL game score goal information <br/>
    /// Example: true
    /// </summary>
    [JsonProperty("homeScore")]
    public int HomeScore { get; set; }

    /// <summary>
    /// The strength of the team for the goal for the NHL game <br/>
    /// Example: EV or PP
    /// </summary>
    [JsonProperty("strength")]
    public required string Strength { get; set; }

    /// <summary>
    /// The highlight clip for the NHL game score goal <br/>
    /// Example: 6343633516112
    /// </summary>
    [JsonProperty("highlightClip")]
    public long HighlightClip { get; set; }

    /// <summary>
    /// The highlight clip for the NHL game score goal in French <br/>
    /// Example: 6343634981112
    /// </summary>
    [JsonProperty("highlightClipFr")]
    public long HighlightClipFr { get; set; }
}

/// <summary>
/// The NHL home team for the game scores information
/// </summary>
public class GameScoreHomeTeam
{
    /// <summary>
    /// The NHL team identifier for the home team <br/>
    /// Example: 17 - Detroit Red Wings
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The name of the NHL team for the home team
    /// Example: Red Wings
    /// </summary>
    [JsonProperty("name")]
    public required Name Name { get; set; }

    /// <summary>
    /// The abbreviation of the NHL team for the home team <br/>
    /// Example: DET
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The score of the NHL team for the home team <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The number of shots on goal for the NHL team for the home team <br/>
    /// Example: 30
    /// </summary>
    [JsonProperty("sog")]
    public int ShotsOnGoal { get; set; }

    /// <summary>
    /// The logo of the NHL team for the home team <br/>
    /// Example: https://assets.nhle.com/logos/nhl/svg/WPG_light.svg
    /// </summary>
    [JsonProperty("logo")]
    public required string Logo { get; set; }
}

/// <summary>
/// The NHL odds partner information for the game for sports betting
/// </summary>
public class OddsPartner
{
    /// <summary>
    /// The NHL odds partner identifier for the game for sports betting <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("partnerId")]
    public int PartnerId { get; set; }

    /// <summary>
    /// The country of the NHL odds partner for the game for sports betting <br/>
    /// Example: US or SE or CA
    /// </summary>
    [JsonProperty("country")]
    public required string Country { get; set; }

    /// <summary>
    /// The name of the NHL odds partner for the game for sports betting <br/>
    /// Example: DraftKings
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// An image url for the NHL odds partner for the game for sports betting <br/>
    /// Example: <a href="https://assets.nhle.com/betting_partner/unibet.svg">https://assets.nhle.com/betting_partner/unibet.svg</a>
    /// </summary>
    [JsonProperty("imageUrl")]
    public required string ImageUrl { get; set; }

    /// <summary>
    /// The site url for the NHL odds partner for the game for sports betting <br/>
    /// Example: <a href="https://www.unibet.se/betting/sports/filter/ice_hockey/nhl/all/matches">https://www.unibet.se/betting/sports/filter/ice_hockey/nhl/all/matches</a>
    /// </summary>
    [JsonProperty("siteUrl")]
    public required string SiteUrl { get; set; }

    /// <summary>
    /// The background color for the NHL odds partner for the game for sports betting <br/>
    /// Example: #14805E
    /// </summary>
    [JsonProperty("bgColor")]
    public required string BgColor { get; set; }

    /// <summary>
    /// The text color for the NHL odds partner for the game for sports betting <br/>
    /// Example: #FFFFFF
    /// </summary>
    [JsonProperty("textColor")]
    public required string TextColor { get; set; }

    /// <summary>
    /// The accent color for the NHL odds partner for the game for sports betting <br/>
    /// Example: #FFFFFF
    /// </summary>
    [JsonProperty("accentColor")]
    public required string AccentColor { get; set; }
}

/// <summary>
/// The NHL game score information for the games selected for the specified date
/// </summary>
public class GameScore
{
    /// <summary>
    /// The previous date for the NHL game score information <br/>
    /// Example: 2024-01-01
    /// </summary>
    [JsonProperty("prevDate")]
    public required string PrevDate { get; set; }

    /// <summary>
    /// The current date for the NHL game score information <br/>
    /// Example: 2024-01-02
    /// </summary>
    [JsonProperty("currentDate")]
    public required string CurrentDate { get; set; }

    /// <summary>
    /// The next date for the NHL game score information <br/>
    /// Example: 2024-01-03
    /// </summary>
    [JsonProperty("nextDate")]
    public required string NextDate { get; set; }

    /// <summary>
    /// The game week information for the NHL game score information, including number of games
    /// </summary>
    [JsonProperty("gameWeek")]
    public required List<GameScoreGameWeek> GameWeek { get; set; }

    /// <summary>
    /// The NHL odds partners for the game for sports betting
    /// </summary>
    [JsonProperty("oddsPartners")]
    public required List<OddsPartner> OddsPartners { get; set; }

    /// <summary>
    /// The NHL game score information for the games selected for the specified date, including goals, period, time remaining, etc.
    /// </summary>
    [JsonProperty("games")]
    public required List<GameScoreGame> Games { get; set; }
}
