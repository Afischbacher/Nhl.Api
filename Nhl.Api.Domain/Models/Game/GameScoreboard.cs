using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game;
/// <summary>
/// The NHL away team for the game scoreboard for an NHL team
/// </summary>
public class GameScoreboardAwayTeam
{
    /// <summary>
    /// The NHL team identifier for a specific team for the scoreboard <br/>
    /// Example: 10 - Toronto Maples Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL team name for a specific team for the scoreboard <br/>
    /// Example: Toronto Maples Leafs
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL team abbreviation for a specific team for the scoreboard <br/>
    /// Example: TOR
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// The NHL team score for a specific team for the scoreboard <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The NHL team logo for a specific team for the scoreboard <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/COL_light.svg">https://assets.nhle.com/logos/nhl/svg/COL_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }
}

/// <summary>
/// The NHL game scoreboard game information
/// </summary>
public class GameScoreboardGame
{

    /// <summary>
    /// The NHL game identifier for a specific game for the scoreboard <br/>
    /// Example: 2023020585
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL game season for a specific game for the scoreboard <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The NHL game type for a specific game for the scoreboard <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }

    /// <summary>
    /// The NHL game date for a specific game for the scoreboard <br/>
    /// Example: 2024-01-02
    /// </summary>
    [JsonProperty("gameDate")]
    public string GameDate { get; set; }

    /// <summary>
    /// The NHL game center link for a specific game for the scoreboard <br/>
    /// Example: <a href="https://www.nhl.com/gamecenter/lak-vs-tor/2024/01/02/2023020585#game=2023020585">https://www.nhl.com/gamecenter/lak-vs-tor/2024/01/02/2023020585</a>
    /// </summary>
    [JsonProperty("gameCenterLink")]
    public string GameCenterLink { get; set; }

    /// <summary>
    /// The NHL venue for a specific game for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("venue")]
    public Venue Venue { get; set; }

    /// <summary>
    /// The NHL start time in UTC for a specific game for the scoreboard  <br/>
    /// Example: 2024-01-03T00:00:00Z
    /// </summary>
    [JsonProperty("startTimeUTC")]
    public DateTime StartTimeUTC { get; set; }

    /// <summary>
    /// The NHL eastern UTC offset for a specific game for the scoreboard  <br/>
    /// Example: -05:00
    /// </summary>
    [JsonProperty("easternUTCOffset")]
    public string EasternUTCOffset { get; set; }

    /// <summary>
    /// The NHL venue utc offset for a specific game for the scoreboard <br/>
    /// Example: -08:00
    /// </summary>
    [JsonProperty("venueUTCOffset")]
    public string VenueUTCOffset { get; set; }

    /// <summary>
    /// The collection of NHL TV broadcasts for a specific game for the scoreboard
    /// </summary>
    [JsonProperty("tvBroadcasts")]
    public List<TvBroadcast> TvBroadcasts { get; set; }

    /// <summary>
    /// The NHL game state for a specific game for the scoreboard <br/>
    /// Example: OFF or LIVE or FUT
    /// </summary>
    [JsonProperty("gameState")]
    public string GameState { get; set; }

    /// <summary>
    /// The NHL game schedule state for a specific game for the scoreboard <br/>
    /// Example: OK
    /// </summary>
    [JsonProperty("gameScheduleState")]
    public string GameScheduleState { get; set; }

    /// <summary>
    /// The NHL away team information for a specific game for the scoreboard 
    /// </summary>
    [JsonProperty("awayTeam")]
    public GameScoreboardAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL home team information for a specific game for the scoreboard 
    /// </summary>
    [JsonProperty("homeTeam")]
    public GameScoreboardHomeTeam HomeTeam { get; set; }

    /// <summary>
    /// The NHL link for the tickets for a specific game for the scoreboard <br/>
    /// Example: <a href="https://www.ticketmaster.com/event/09005ED7909A2298">https://www.ticketmaster.com/event/09005ED7909A2298</a>
    /// </summary>
    [JsonProperty("ticketsLink")]
    public string TicketsLink { get; set; }

    /// <summary>
    /// The NHL period for a specific game for the scoreboard <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The NHL game period description for a specific game for the scoreboard
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// An NHL link to the game 3 minute recap for a specific game for the scoreboard <br/>
    /// Example: <a href="https://www.nhl.com/video/recap-golden-knights-at-lightning-12-21-23-6343695834112">https://www.nhl.com/video/recap-golden-knights-at-lightning-12-21-23-6343695834112</a>
    /// </summary>
    [JsonProperty("threeMinRecap")]
    public string ThreeMinRecap { get; set; }
}

/// <summary>
/// The NHL game scoreboard games by date
/// </summary>
public class GameScoreboardGamesByDate
{
    /// <summary>
    /// The NHL date for a specific game for the scoreboard <br/>
    /// Example: 2024-01-02
    /// </summary>
    [JsonProperty("date")]
    public string Date { get; set; }

    /// <summary>
    /// The collection of NHL games for the scoreboard
    /// </summary>
    [JsonProperty("games")]
    public List<GameScoreboardGame> Games { get; set; }
}

/// <summary>
/// The NHL home team for the game scoreboard
/// </summary>
public class GameScoreboardHomeTeam
{
    /// <summary>
    /// The NHL team identifier for a specific team for the scoreboard <br/>
    /// Example: 10 - Toronto Maples Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL team name for a specific team for the scoreboard <br/>
    /// Example: Toronto Maples Leafs
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL team abbreviation for a specific team for the scoreboard <br/>
    /// Example: TOR
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// The NHL team score for a specific team for the scoreboard <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The NHL team logo for a specific team for the scoreboard <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/COL_light.svg">https://assets.nhle.com/logos/nhl/svg/COL_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

}

/// <summary>
/// The NHL game scoreboard
/// </summary>
public class GameScoreboard
{
    /// <summary>
    /// The focused date for the scoreboard <br/>
    /// Example: 2023-12-26
    /// </summary>
    [JsonProperty("focusedDate")]
    public string FocusedDate { get; set; }

    /// <summary>
    /// The focused date count for the scoreboard <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("focusedDateCount")]
    public int FocusedDateCount { get; set; }

    /// <summary>
    /// The NHL game scoreboard games by date
    /// </summary>
    [JsonProperty("gamesByDate")]
    public List<GameScoreboardGamesByDate> GamesByDate { get; set; }
}
