using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Game;
/// <summary>
/// The NHL away team information for a specific game for the scoreboard for an NHL team
/// </summary>
public class AwayTeam
{
    /// <summary>
    /// The NHL away team identifier for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL away team name for a specific game for the scoreboard for an NHL team <br/>
    /// Example: Toronto Maple Leafs
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL away team abbreviation for a specific game for the scoreboard for an NHL team <br/>
    /// Example: TOR
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// The NHL away team score for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The NHL away team logo for a specific game for the scoreboard for an NHL team <br/>
    /// Example: https://assets.nhle.com/logos/nhl/svg/CAR_light.svg
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// The NHL away team record for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 36-18-9
    /// </summary>
    [JsonProperty("record")]
    public string Record { get; set; }
}

/// <summary>
/// The NHL game for the scoreboard for an NHL team
/// </summary>
public class Game
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
    public string GameDate { get; set; }

    /// <summary>
    /// The NHL game center link for a specific game for the scoreboard for an NHL team <br/>
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
    public string EasternUTCOffset { get; set; }

    /// <summary>
    /// The NHL venue utc offset for a specific game for the scoreboard for an NHL team <br/>
    /// Example: -08:00
    /// </summary>
    [JsonProperty("venueUTCOffset")]
    public string VenueUTCOffset { get; set; }

    /// <summary>
    /// The collection of NHL TV broadcasts for a specific game for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("tvBroadcasts")]
    public List<TvBroadcast> TvBroadcasts { get; set; }

    /// <summary>
    /// The NHL game state for a specific game for the scoreboard for an NHL team <br/>
    /// Example: OFF or LIVE or FUT
    /// </summary>
    [JsonProperty("gameState")]
    public string GameState { get; set; }

    /// <summary>
    /// The NHL game schedule state for a specific game for the scoreboard for an NHL team <br/>
    /// Example: OK
    /// </summary>
    [JsonProperty("gameScheduleState")]
    public string GameScheduleState { get; set; }

    /// <summary>
    /// The NHL away team information for a specific game for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("awayTeam")]
    public AwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL home team information for a specific game for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("homeTeam")]
    public HomeTeam HomeTeam { get; set; }

    /// <summary>
    /// The NHL link for the tickets for a specific game for the scoreboard for an NHL team <br/>
    /// Example: <a href="https://www.ticketmaster.com/event/09005ED7909A2298">https://www.ticketmaster.com/event/09005ED7909A2298</a>
    /// </summary>
    [JsonProperty("ticketsLink")]
    public string TicketsLink { get; set; }

    /// <summary>
    /// The NHL period for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The NHL game period description for a specific game for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// An NHL link to the game 3 minute recap for a specific game for the scoreboard for an NHL team <br/>
    /// Example: <a href="https://www.nhl.com/video/recap-golden-knights-at-lightning-12-21-23-6343695834112">https://www.nhl.com/video/recap-golden-knights-at-lightning-12-21-23-6343695834112</a>
    /// </summary>
    [JsonProperty("threeMinRecap")]
    public string ThreeMinRecap { get; set; }
}

/// <summary>
/// A collection of NHL games for the scoreboard for an NHL team
/// </summary>
public class GamesByDate
{
    /// <summary>
    /// The date for the scoreboard for an NHL team <br/>
    /// Example: 2023-12-30
    /// </summary>
    [JsonProperty("date")]
    public string Date { get; set; }

    /// <summary>
    /// The collection of NHL games for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("games")]
    public List<Game> Games { get; set; }
}

/// <summary>
/// The NHL home team information for a specific game for the scoreboard for an NHL team
/// </summary>
public class HomeTeam
{
    /// <summary>
    /// The NHL team identifier for a specific game for the scoreboard for an NHL home team <br/>
    /// Example: 9 - Ottawa Senators
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL team name for a specific game for the scoreboard for an NHL home team <br/>
    /// Example: Ottawa Senators
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL team abbreviation for a specific game for the scoreboard for an NHL home team <br/>
    /// Example: OTT
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// The NHL team score for a specific game for the scoreboard for an NHL home team <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The NHL team logo for a specific game for the scoreboard for an NHL home team <br/>
    /// Example: https://assets.nhle.com/logos/nhl/svg/CAR_light.svg
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// The NHL record for a specific game for the scoreboard for an NHL home team <br/>
    /// Example: 16-8-6
    /// </summary>
    [JsonProperty("record")]
    public string Record { get; set; }
}

/// <summary>
/// The NHL team name for a specific game for the scoreboard for an NHL team
/// </summary>
public class Name
{
    /// <summary>
    /// The NHL team name in English for a specific game for the scoreboard for an NHL team <br/>
    /// Example: Buffalo Sabres
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }

    /// <summary>
    /// The NHL team name in French for a specific game for the scoreboard for an NHL team <br/>
    /// Example: Sabres de Buffalo
    /// </summary>
    [JsonProperty("fr")]
    public string Fr { get; set; }
}

/// <summary>
/// The NHL period descriptor for a specific game for the scoreboard for an NHL team
/// </summary>
public class PeriodDescriptor
{
    /// <summary>
    /// The NHL game period number for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("number")]
    public int Number { get; set; }

    /// <summary>
    /// The NHL game period type for a specific game for the scoreboard for an NHL team <br/>
    /// Example: REG
    /// </summary>
    [JsonProperty("periodType")]
    public string PeriodType { get; set; }
}

/// <summary>
/// The NHL team scoreboard for an NHL team for a focused date
/// </summary>
public class TeamScoreboard
{
    /// <summary>
    /// The focused date for the scoreboard for an NHL team <br/>
    /// Example: 2023-12-30
    /// </summary>
    [JsonProperty("focusedDate")]
    public string FocusedDate { get; set; }

    /// <summary>
    /// The number of games for the scoreboard for an NHL team for a focused date <br/>
    /// Example: 11
    /// </summary>
    [JsonProperty("focusedDateCount")]
    public int FocusedDateCount { get; set; }

    /// <summary>
    /// The NHL team club time zone for the scoreboard for an NHL team <br/>
    /// Example: America/Vancouver
    /// </summary>
    [JsonProperty("clubTimeZone")]
    public string ClubTimeZone { get; set; }

    /// <summary>
    /// The NHL team club UTC offset for the scoreboard for an NHL team <br/>
    /// Example: -08:00
    /// </summary>
    [JsonProperty("clubUTCOffset")]
    public string ClubUTCOffset { get; set; }

    /// <summary>
    /// The NHL team club schedule link for the scoreboard for an NHL team <br/>
    /// Example: https://www.nhl.com/canucks/schedule
    /// </summary>
    [JsonProperty("clubScheduleLink")]
    public string ClubScheduleLink { get; set; }

    /// <summary>
    /// The collection of NHL team games by date for the scoreboard for an NHL team
    /// </summary>
    [JsonProperty("gamesByDate")]
    public List<GamesByDate> GamesByDate { get; set; }
}

/// <summary>
/// The TV broadcast information for a specific game for the scoreboard for an NHL team
/// </summary>
public class TvBroadcast
{
    /// <summary>
    /// The TV broadcast identifier for a specific game for the scoreboard for an NHL team <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL market for a specific game for the scoreboard for an NHL team <br/>
    /// Example: N or A
    /// </summary>
    [JsonProperty("market")]
    public string Market { get; set; }

    /// <summary>
    /// The country code for a specific game for the scoreboard for an NHL team <br/>
    /// Example: CA or US
    /// </summary>
    [JsonProperty("countryCode")]
    public string CountryCode { get; set; }

    /// <summary>
    /// The TV broadcast network for a specific game for the scoreboard for an NHL team <br/>
    /// Example: CBC
    /// </summary>
    [JsonProperty("network")]
    public string Network { get; set; }
}

/// <summary>
/// The NHL venue information for a specific game for the scoreboard for an NHL team
/// </summary>
public class Venue
{
    /// <summary>
    /// The NHL venue name for a specific game for the scoreboard for an NHL team <br/>
    /// Example: Rogers Arena
    /// </summary>
    [JsonProperty("default")]
    public string Default { get; set; }
}
