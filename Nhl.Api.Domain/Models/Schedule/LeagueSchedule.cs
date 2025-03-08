using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Nhl.Api.Models.Schedule;
/// <summary>
/// The NHL away team information for the NHL game schedule
/// </summary>
public class AwayTeam
{
    /// <summary>
    /// The NHL team identifier <br/>
    /// Example: 55 - Seattle Kraken
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL team place name for the away team <br/>
    /// Example: Seattle
    /// </summary>
    [JsonProperty("placeName")]
    public required PlaceName PlaceName { get; set; }

    /// <summary>
    /// The NHL team abbreviation for the away team <br/>
    /// Example: SEA
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The link to the NHL team light logo for the away team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/BUF_19992000-20052006_light.svg">https://assets.nhle.com/logos/nhl/svg/BUF_19992000-20052006_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public required string LightLogo { get; set; }

    /// <summary>
    /// The link to the NHL team dark logo for the away team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/BUF_19992000-20052006_dark.svg">https://assets.nhle.com/logos/nhl/svg/BUF_19992000-20052006_dark.svg</a>
    /// </summary>
    [JsonProperty("darkLogo")]
    public required string DarkLogo { get; set; }

    /// <summary>
    /// Indicates if the away team is a split squad <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("awaySplitSquad")]
    public bool AwaySplitSquad { get; set; }

    /// <summary>
    /// Returns the associated NHL team airline link <br/>
    /// Example: https://www.united.com/ual/en/us/
    /// </summary>
    [JsonProperty("airlinelink")]
    public required string Airlinelink { get; set; }

    /// <summary>
    /// Returns the associated NHL team airline description <br/>
    /// Example: Fly United
    /// </summary>
    [JsonProperty("airlineDesc")]
    public required string AirlineDescription { get; set; }

    /// <summary>
    /// The score for the NHL away team <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The link to the NHL team radio broadcast for the away team <br/>
    /// Example: https://d2igy0yla8zi0u.cloudfront.net/CBJ/20232024/CBJ-radio.m3u8
    /// </summary>
    [JsonProperty("radioLink")]
    public required string RadioLink { get; set; }

    /// <summary>
    /// The odds for the NHL away team
    /// </summary>
    [JsonProperty("odds")]
    public List<Odd> Odds { get; set; } = [];
}

/// <summary>
/// The first initial of the NHL player's first name
/// </summary>
public class FirstInitial
{
    /// <summary>
    /// The NHL player's first initial <br/>
    /// Example: J. for Joseph
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}

/// <summary>
/// An NHL game for a specific date for the NHL league schedule
/// </summary>
public class Game
{
    /// <summary>
    /// The NHL game identifier <br/>
    /// Example: 2023020268
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL game season <br/>
    /// Example: 20232024
    /// </summary>
    [JsonProperty("season")]
    public int Season { get; set; }

    /// <summary>
    /// The NHL game type <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("gameType")]
    public int GameType { get; set; }

    /// <summary>
    /// The NHL game venue
    /// </summary>
    [JsonProperty("venue")]
    public required Venue Venue { get; set; }

    /// <summary>
    /// This indicates if the NHL game is a neutral site game <br/>
    /// Example: A neutral site game is a game played at a location other than the home arena of one of the NHL teams playing
    /// </summary>
    [JsonProperty("neutralSite")]
    public bool NeutralSite { get; set; }

    /// <summary>
    /// The NHL game start time in UTC <br/>
    /// Example 2021-10-12T23:00:00Z
    /// </summary>
    [JsonProperty("startTimeUTC")]
    public DateTime StartTimeUTC { get; set; }

    /// <summary>
    /// The NHL eastern time zone offset for the NHL game <br/>
    /// Example: -05:00
    /// </summary>
    [JsonProperty("easternUTCOffset")]
    public required string EasternUTCOffset { get; set; }

    /// <summary>
    /// The Venue UTC offset for the NHL game <br/>
    /// Example: +01:00
    /// </summary>  
    [JsonProperty("venueUTCOffset")]
    public required string VenueUTCOffset { get; set; }

    /// <summary>
    /// The NHL game venue time zone <br/>
    /// Example: Europe/Stockholm
    /// </summary>
    [JsonProperty("venueTimezone")]
    public required string VenueTimezone { get; set; }

    /// <summary>
    /// The NHL game state <br/>
    /// Example: OFF
    /// </summary>
    [JsonProperty("gameState")]
    public required string GameState { get; set; }

    /// <summary>
    /// The NHL game schedule state <br/>
    /// Example: OK
    /// </summary>
    [JsonProperty("gameScheduleState")]
    public required string GameScheduleState { get; set; }

    /// <summary>
    /// The collection of NHL broadcasts for the NHL game
    /// </summary>
    [JsonProperty("tvBroadcasts")]
    public required List<TvBroadcast> TvBroadcasts { get; set; }

    /// <summary>
    /// The NHL away team information for the NHL game
    /// </summary>
    [JsonProperty("awayTeam")]
    public required AwayTeam AwayTeam { get; set; }


    /// <summary>
    /// The NHL home team information for the NHL game
    /// </summary>
    [JsonProperty("homeTeam")]
    public required HomeTeam HomeTeam { get; set; }

    /// <summary>
    /// The NHL game period descriptor
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public required PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The NHL game outcome
    /// </summary>
    [JsonProperty("gameOutcome")]
    public required GameOutcome GameOutcome { get; set; }

    /// <summary>
    /// The NHL game winning goalie
    /// </summary>
    [JsonProperty("winningGoalie")]
    public required WinningGoalie WinningGoalie { get; set; }

    /// <summary>
    /// The NHL game winning goal scorer
    /// </summary>
    [JsonProperty("winningGoalScorer")]
    public required WinningGoalScorer WinningGoalScorer { get; set; }

    /// <summary>
    /// The NHL special event information for the NHL game
    /// </summary>
    [JsonProperty("specialEvent")]
    public required SpecialEvent SpecialEvent { get; set; }

    /// <summary>
    /// The NHL special event logo for the NHL game <br/>
    /// Example: <a href="https://assets.nhle.com/special_event_season/20232024/2023020267.svg">https://assets.nhle.com/special_event_season/20232024/2023020267.svg</a>
    /// </summary>
    [JsonProperty("specialEventLogo")]
    public required string SpecialEventLogo { get; set; }

    /// <summary>
    /// A NHL link for the 3 minute recap for the NHL game <br/>
    /// Example: https://www.nhl.com/video/recap-maple-leafs-at-wild-11-19-23-6341442719112
    /// </summary>
    [JsonProperty("threeMinRecap")]
    public required string ThreeMinRecap { get; set; }

    /// <summary>
    /// A NHL link for the game recap for the NHL game <br/>
    /// Example: https://www.nhl.com/gamecenter/min-vs-tor/2023/11/19/2023020267
    /// </summary>
    [JsonProperty("gameCenterLink")]
    public required string GameCenterLink { get; set; }

    /// <summary>
    /// A NHL link for purchasing tickets for the NHL game <br/>
    /// </summary>
    [JsonProperty("ticketsLink")]
    public required string TicketsLink { get; set; }
}

/// <summary>
/// The NHL game outcome for the NHL game
/// </summary>
public class GameOutcome
{
    /// <summary>
    /// Returns the NHL game outcome type based on the last NHL period <br/>
    /// Example: OT
    /// </summary>
    [JsonProperty("lastPeriodType")]
    public required string LastPeriodType { get; set; }
}

/// <summary>
/// The NHL league schedule for a specific week
/// </summary>
public class GameWeek
{
    /// <summary>
    /// The NHL game week date <br/>
    /// </summary>
    [JsonProperty("date")]
    public required string Date { get; set; }

    /// <summary>
    /// The NHL game week day abbreviation <br/>
    /// Example: SUN
    /// </summary>
    [JsonProperty("dayAbbrev")]
    public required string DayAbbrev { get; set; }

    /// <summary>
    /// The number of NHL games for the NHL date <br/>
    /// Example: 5
    /// </summary>
    [JsonProperty("numberOfGames")]
    public int NumberOfGames { get; set; }

    /// <summary>
    /// A collection of all the NHL games for the NHL date
    /// </summary>
    [JsonProperty("games")]
    public List<Game> Games { get; set; } = [];
}

/// <summary>
/// The NHL home team information for the NHL game schedule
/// </summary>
public class HomeTeam
{
    /// <summary>
    /// The NHL team identifier <br/>
    /// Example: 55 - Seattle Kraken
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL team place name for the away team <br/>
    /// Example: Seattle
    /// </summary>
    [JsonProperty("placeName")]
    public required PlaceName PlaceName { get; set; }

    /// <summary>
    /// The NHL team abbreviation for the away team <br/>
    /// Example: SEA
    /// </summary>
    [JsonProperty("abbrev")]
    public required string Abbrev { get; set; }

    /// <summary>
    /// The link to the NHL team light logo for the away team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/BUF_19992000-20052006_light.svg">https://assets.nhle.com/logos/nhl/svg/BUF_19992000-20052006_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public required string LightLogo { get; set; }

    /// <summary>
    /// The link to the NHL team dark logo for the away team <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/BUF_19992000-20052006_dark.svg">https://assets.nhle.com/logos/nhl/svg/BUF_19992000-20052006_dark.svg</a>
    /// </summary>
    [JsonProperty("darkLogo")]
    public required string DarkLogo { get; set; }

    /// <summary>
    /// Indicates if the away team is a split squad <br/>
    /// Example: false
    /// </summary>
    [JsonProperty("awaySplitSquad")]
    public bool AwaySplitSquad { get; set; }

    /// <summary>
    /// The score for the NHL away team <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The link to the NHL team radio broadcast for the away team <br/>
    /// Example: https://d2igy0yla8zi0u.cloudfront.net/CBJ/20232024/CBJ-radio.m3u8
    /// </summary>
    [JsonProperty("radioLink")]
    public required string RadioLink { get; set; }

    /// <summary>
    /// The odds for the NHL away team
    /// </summary>
    [JsonProperty("odds")]
    public List<Odd> Odds { get; set; } = [];
}

/// <summary>
/// The last name of the NHL player
/// </summary>
public class LastName
{
    /// <summary>
    /// The default NHL player last name <br/>
    /// Example: Smith
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}

/// <summary>
/// The NHL game odds for the NHL game
/// </summary>
public class Odd
{
    /// <summary>
    /// The provider id for the NHL game odd provider <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("providerId")]
    public int ProviderId { get; set; }

    /// <summary>
    /// The value for the NHL game odd provider <br/>
    /// Example : 2.3000
    /// </summary>
    [JsonProperty("value")]
    public decimal Value { get; set; }
}

/// <summary>
/// The NHL game odds partner for the NHL game
/// </summary>
public class OddsPartner
{
    /// <summary>
    /// The NHL game odds partner id <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("partnerId")]
    public int PartnerId { get; set; }

    /// <summary>
    /// The country of the NHL game odds partner <br/>
    /// Example: "CA"
    /// </summary>
    [JsonProperty("country")]
    public required string Country { get; set; }

    /// <summary>
    /// The NHL game odds partner name <br/>
    /// Example: Bet365
    /// </summary>
    [JsonProperty("name")]
    public required string Name { get; set; }

    /// <summary>
    /// The NHL game odds partner logo <br/>
    /// Example: https://assets.nhle.com/betting_partner/bet365.svg
    /// </summary>
    [JsonProperty("imageUrl")]
    public required string ImageUrl { get; set; }

    /// <summary>
    /// The NHL game odds partner site url <br/>
    /// Example: https://www.on.bet365.ca/olp/nhl
    /// </summary>
    [JsonProperty("siteUrl")]
    public required string SiteUrl { get; set; }

    /// <summary>
    /// The background color for the NHL game odds partner <br/>
    /// Example: #086D51
    /// </summary>
    [JsonProperty("bgColor")]
    public required string BgColor { get; set; }

    /// <summary>
    /// The text color for the NHL game odds partner <br/>
    /// Example: #FFFFFF
    /// </summary>
    [JsonProperty("textColor")]
    public required string TextColor { get; set; }

    /// <summary>
    /// The accent color for the NHL game odds partner <br/>
    /// Example: #FDDE14
    /// </summary>
    [JsonProperty("accentColor")]
    public required string AccentColor { get; set; }
}

/// <summary>
/// The NHL game period descriptor for the NHL game
/// </summary>
public class PeriodDescriptor
{
    /// <summary>
    /// Returns the NHL game period number <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("number")]
    public int Number { get; set; }

    /// <summary>
    /// The NHL game period type <br/>
    /// Example: OT
    /// </summary>
    [JsonProperty("periodType")]
    public required string PeriodType { get; set; }
}

/// <summary>
/// The NHL team place name for the an NHL team
/// </summary>
public class PlaceName
{
    /// <summary>
    /// The NHL team default place name for the team <br/>
    /// Example: Philadelphia
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }

    /// <summary>
    /// The NHL team place name for the team in French <br/>
    /// Example: Philadelphie
    /// </summary>
    [JsonProperty("fr")]
    public required string Fr { get; set; }
}

/// <summary>
/// The NHL league schedule for a specific week
/// </summary>
public class LeagueSchedule
{
    /// <summary>
    /// The NHL league schedule next start date <br/>
    /// Example: 2023-10-18
    /// </summary>
    [JsonProperty("nextStartDate")]
    public required string NextStartDate { get; set; }

    /// <summary>
    /// The previous NHL league schedule next start date <br/>
    /// Example: 2023-10-11
    /// </summary>
    [JsonProperty("previousStartDate")]
    public required string PreviousStartDate { get; set; }

    /// <summary>
    /// The collection of NHL game weeks for the NHL league schedule
    /// </summary>
    [JsonProperty("gameWeek")]
    public List<GameWeek> GameWeek { get; set; } = [];

    /// <summary>
    /// The collection of NHL game odds partners for the NHL league schedule
    /// </summary>
    [JsonProperty("oddsPartners")]
    public List<OddsPartner> OddsPartners { get; set; } = [];

    /// <summary>
    /// The NHL league schedule pre season start date <br/>
    /// Example: 2023-09-23
    /// </summary>
    [JsonProperty("preSeasonStartDate")]
    public required string PreSeasonStartDate { get; set; }

    /// <summary>
    /// The NHL league schedule regular season start date <br/>
    /// Example: 2023-10-10
    /// </summary>
    [JsonProperty("regularSeasonStartDate")]
    public required string RegularSeasonStartDate { get; set; }

    /// <summary>
    /// The NHL league schedule regular season end date <br/>
    /// Example: 2024-04-18
    /// </summary>
    [JsonProperty("regularSeasonEndDate")]
    public required string RegularSeasonEndDate { get; set; }

    /// <summary>
    /// The NHL league schedule playoff season end date <br/>
    /// Example: 2024-06-18
    /// </summary>
    [JsonProperty("playoffEndDate")]
    public required string PlayoffEndDate { get; set; }

    /// <summary>
    /// The number of games for the NHL league schedule for the selected date and week <br/>
    /// Example: 32
    /// </summary>
    [JsonProperty("numberOfGames")]
    public int NumberOfGames { get; set; }
}

/// <summary>
/// The NHL game for a special event
/// </summary>
public class SpecialEvent
{
    /// <summary>
    /// The default NHL game special event name <br/>
    /// Example: 2023 NHL Global Series
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}

/// <summary>
/// The NHL game TV broadcast for the NHL game information
/// </summary>
public class TvBroadcast
{
    /// <summary>
    /// The NHL game TV broadcast identifier <br/>
    /// Example: 323
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL game TV broadcast market <br/>
    /// Example: H or A (Home or Away)
    /// </summary>
    [JsonProperty("market")]
    public required string Market { get; set; }

    /// <summary>
    /// The country code for the NHL game TV broadcast <br/>
    /// Example: US
    /// </summary>
    [JsonProperty("countryCode")]
    public required string CountryCode { get; set; }

    /// <summary>
    /// The TV network for the NHL game TV broadcast <br/>
    /// Example: ESPN+ or NBCSP+
    /// </summary>
    [JsonProperty("network")]
    public required string Network { get; set; }
}

/// <summary>
/// The NHL venue for the NHL game
/// </summary>
public class Venue
{
    /// <summary>
    /// The default NHL venue identifier <br/>
    /// Example: Wells Fargo Center
    /// </summary>
    [JsonProperty("default")]
    public required string Default { get; set; }
}

/// <summary>
/// The Winning goalie for the NHL game
/// </summary>
public class WinningGoalie
{
    /// <summary>
    /// The player identifier for the NHL goalie <br/>
    /// Example: 8479361
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The first initial of the NHL goalie's first name
    /// Example: J. for Joseph
    /// </summary>
    [JsonProperty("firstInitial")]
    public required FirstInitial FirstInitial { get; set; }

    /// <summary>
    /// The last name of the NHL goalie <br/>
    /// Example: Smith
    /// </summary>
    [JsonProperty("lastName")]
    public required LastName LastName { get; set; }
}

/// <summary>
/// The NHL game winning goal scorer
/// </summary>
public class WinningGoalScorer
{
    /// <summary>
    /// The player id for the NHL player <br/>
    /// Example: 8478402
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The first initial of the NHL player's first name
    /// Example: C. for Connor
    /// </summary>
    [JsonProperty("firstInitial")]
    public required FirstInitial FirstInitial { get; set; }

    /// <summary>
    /// The last name of the NHL player <br/>
    /// Example: McDavid
    /// </summary>
    [JsonProperty("lastName")]
    public required LastName LastName { get; set; }
}
