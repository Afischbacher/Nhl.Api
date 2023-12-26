using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nhl.Api.Models.Schedule
{

    /// <summary>
    /// The team season schedule period descriptor information for a specified NHL team
    /// </summary>
    public class TeamSeasonSchedule
    {
        /// <summary>
        /// The previous season for the NHL team <br/>
        /// Example: 20222023
        /// </summary>
        [JsonProperty("previousSeason")]
        public int PreviousSeason { get; set; }

        /// <summary>
        /// The current season for the NHL team <br/>
        /// Example: 20232024
        /// </summary>
        [JsonProperty("currentSeason")]
        public int CurrentSeason { get; set; }

        /// <summary>
        /// The club time zone for the NHL team <br/>
        /// Example: US/Eastern
        /// </summary>
        [JsonProperty("clubTimezone")]
        public string ClubTimezone { get; set; }

        /// <summary>
        /// The club UTC offset for the NHL team <br/>
        /// Example: -04:00
        /// </summary>
        [JsonProperty("clubUTCOffset")]
        public string ClubUTCOffset { get; set; }

        /// <summary>
        /// The collection of games for the NHL team
        /// </summary>
        [JsonProperty("games")]
        public List<TeamSeasonScheduleGame> Games { get; set; }
    }

    /// <summary>
    /// The team season schedule away team information for a specified NHL team
    /// </summary>
    public class TeamSeasonScheduleAwayTeam
    {
        /// <summary>
        /// The NHL team identifier for the away NHL team <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The place name for the away NHL team <br/>
        /// Example: Boston
        /// </summary>
        [JsonProperty("placeName")]
        public PlaceName PlaceName { get; set; }

        /// <summary>
        /// The abbreviation for the away NHL team <br/>
        /// Example: BOS
        /// </summary>
        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        /// <summary>
        /// The light logo for the away NHL team <br/>
        /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/TOR_light.svg">https://assets.nhle.com/logos/nhl/svg/TOR_light.svg</a>
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// The dark logo for the away NHL team <br/>
        /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/TOR_dark.svg">https://assets.nhle.com/logos/nhl/svg/TOR_dark.svg</a>
        /// </summary>
        [JsonProperty("darkLogo")]
        public string DarkLogo { get; set; }

        /// <summary>
        /// The away split squad status for the away NHL team <br/>
        /// Example: false
        /// </summary>
        [JsonProperty("awaySplitSquad")]
        public bool AwaySplitSquad { get; set; }

        /// <summary>
        /// The score for the away NHL team <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("score")]
        public int Score { get; set; }

        /// <summary>
        /// The airline link for the away NHL team <br/>
        /// Example: <a href="https://www.united.com/ual/en/us/">https://www.united.com/ual/en/us/</a>
        /// </summary>
        [JsonProperty("airlineLink")]
        public string AirlineLink { get; set; }

        /// <summary>
        /// The airline description for the away NHL team <br/>
        /// Example: Fly United
        /// </summary>
        [JsonProperty("airlineDesc")]
        public string AirlineDesc { get; set; }

        /// <summary>
        /// The hotel link for the away NHL team <br/>
        /// Example: <a href="https://www.ticasino.com/resort/hotel-rooms-and-suites">https://www.ticasino.com/resort/hotel-rooms-and-suites</a>
        /// </summary>
        [JsonProperty("hotelLink")]
        public string HotelLink { get; set; }

        /// <summary>
        /// The hotel description for the away NHL team <br/>
        /// Example: Stay at Treasure Island Resort and Casino
        /// </summary>
        [JsonProperty("hotelDesc")]
        public string HotelDesc { get; set; }


        /// <summary>
        /// The radio link for the away NHL team <br/>
        /// Example: <a href="https://d2igy0yla8zi0u.cloudfront.net/OTT/20232024/OTT-radio.m3u8">https://d2igy0yla8zi0u.cloudfront.net/OTT/20232024/OTT-radio.m3u8</a>
        /// </summary>
        [JsonProperty("radioLink")]
        public string RadioLink { get; set; }
    }

    /// <summary>
    /// The team season schedule game information for a specified NHL game
    /// </summary>
    public class TeamSeasonScheduleGame
    {
        /// <summary>
        /// The NHL game identifier for the NHL game <br/>
        /// Example: 2023010109
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The season for the NHL game <br/>
        /// Example: 20232024
        /// </summary>
        [JsonProperty("season")]
        public int Season { get; set; }

        /// <summary>
        /// The game type for the NHL game <br/>
        /// Example: 2 - Regular Season or 3 - Playoffs
        /// </summary>
        [JsonProperty("gameType")]
        public int GameType { get; set; }

        /// <summary>
        /// The game date for the NHL game <br/>
        /// Example: 2023-10-04
        /// </summary>
        [JsonProperty("gameDate")]
        public string GameDate { get; set; }

        /// <summary>
        /// The venue for the NHL game <br/>
        /// Example: 
        /// <code> 
        /// "venue": {
        ///     "default": "Capital One Arena"
        /// }
        /// </code>
        /// </summary>
        [JsonProperty("venue")]
        public Venue Venue { get; set; }

        /// <summary>
        /// Determines if the NHL game is a neutral site game <br/>
        /// Example: false
        /// </summary>
        [JsonProperty("neutralSite")]
        public bool NeutralSite { get; set; }

        /// <summary>
        /// The start time for the NHL game in UTC <br/>
        /// Example: 2023-10-04T23:00:00Z
        /// </summary>
        [JsonProperty("startTimeUTC")]
        public DateTime StartTimeUTC { get; set; }

        /// <summary>
        /// The eastern UTC offset for the NHL game <br/>
        /// Example: -04:00
        /// </summary>
        [JsonProperty("easternUTCOffset")]
        public string EasternUTCOffset { get; set; }

        /// <summary>
        /// The venue UTC offset for the NHL game <br/>
        /// Example: -04:00
        /// </summary>
        [JsonProperty("venueUTCOffset")]
        public string VenueUTCOffset { get; set; }

        /// <summary>
        /// The venue timezone for the NHL game <br/>
        /// Example: US/Eastern
        /// </summary>
        [JsonProperty("venueTimezone")]
        public string VenueTimezone { get; set; }

        /// <summary>
        /// The game state for the NHL game <br/>
        /// Example: FINAL or LIVE
        /// </summary>
        [JsonProperty("gameState")]
        public string GameState { get; set; }

        /// <summary>
        /// The game schedule state for the NHL game <br/>
        /// Example: OK
        /// </summary>
        [JsonProperty("gameScheduleState")]
        public string GameScheduleState { get; set; }

        /// <summary>
        /// The TV broadcasts for the NHL game
        /// </summary>
        [JsonProperty("tvBroadcasts")]
        public List<TvBroadcast> TvBroadcasts { get; set; }

        /// <summary>
        /// The away team for the NHL game
        /// </summary>
        [JsonProperty("awayTeam")]
        public AwayTeam AwayTeam { get; set; }

        /// <summary>
        /// The home team for the NHL game
        /// </summary>
        [JsonProperty("homeTeam")]
        public HomeTeam HomeTeam { get; set; }

        /// <summary>
        /// The period descriptor for the NHL game
        /// </summary>
        [JsonProperty("periodDescriptor")]
        public PeriodDescriptor PeriodDescriptor { get; set; }

        /// <summary>
        /// The game outcome for the NHL game
        /// </summary>
        [JsonProperty("gameOutcome")]
        public GameOutcome GameOutcome { get; set; }

        /// <summary>
        /// The winning goalie for the NHL game
        /// </summary>
        [JsonProperty("winningGoalie")]
        public WinningGoalie WinningGoalie { get; set; }

        /// <summary>
        /// The winning goal scorer for the NHL game
        /// </summary>
        [JsonProperty("winningGoalScorer")]
        public WinningGoalScorer WinningGoalScorer { get; set; }

        /// <summary>
        /// The game center link for the NHL game <br/>
        /// Example: <a href="https://www.nhl.com/gamecenter/buf-vs-wsh/2023/09/24/2023010006">https://www.nhl.com/gamecenter/buf-vs-wsh/2023/09/24/2023010006</a>
        /// </summary>
        [JsonProperty("gameCenterLink")]
        public string GameCenterLink { get; set; }

        /// <summary>
        /// The special event for the NHL game , if applicable <br/>
        /// Example: 
        /// <code>
        /// "specialEvent": {
        ///        "default": "Kraft Hockeyville Canada"
        /// }
        /// </code>
        /// </summary>
        [JsonProperty("specialEvent")]
        public SpecialEvent SpecialEvent { get; set; }

        /// <summary>
        /// The three minute recap for the NHL game <br/>
        /// Example: <a href="https://www.nhl.com/video/recap-maple-leafs-at-blue-jackets-12-23-23-6343803556112">https://www.nhl.com/video/recap-maple-leafs-at-blue-jackets-12-23-23-6343803556112</a>
        /// </summary>
        [JsonProperty("threeMinRecap")]
        public string ThreeMinRecap { get; set; }

        /// <summary>
        /// The three minute recap in French for the NHL game <br/>
        /// Example: <a href="https://www.nhl.com/fr/video/resume-toronto-columbus-23-12-23-23-6343803556112">https://www.nhl.com/fr/video/resume-toronto-columbus-23-12-23-23-6343803556112</a>
        /// </summary>
        [JsonProperty("threeMinRecapFr")]
        public string ThreeMinRecapFr { get; set; }

        /// <summary>
        /// The special event logo for the NHL game <br/>
        /// Example: <a href="https://assets.nhle.com/special_event_season/20232024/2023020251.svg">https://assets.nhle.com/special_event_season/20232024/2023020251.svg</a>
        /// </summary>
        [JsonProperty("specialEventLogo")]
        public string SpecialEventLogo { get; set; }

        /// <summary>
        /// The tickets link for the NHL game <br/>
        /// Example: <a href="https://www.nhl.com/tickets">https://www.nhl.com/tickets</a>
        /// </summary>
        [JsonProperty("ticketsLink")]
        public string TicketsLink { get; set; }
    }

    /// <summary>
    /// The team season schedule home team information for a specified NHL team
    /// </summary>
    public class TeamSeasonScheduleGameOutcome
    {
        /// <summary>
        /// The game outcome for the NHL game <br/>
        /// Example: REG
        /// </summary>
        [JsonProperty("lastPeriodType")]
        public string LastPeriodType { get; set; }
    }

    /// <summary>
    /// The team season schedule home team information for a specified NHL team
    /// </summary>
    public class TeamSeasonScheduleHomeTeam
    {
        /// <summary>
        /// The NHL team identifier for the home NHL team <br/>
        /// Example: 10 - Toronto Maple Leafs
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The place name for the home NHL team <br/>
        /// Example: Toronto
        /// </summary>
        [JsonProperty("placeName")]
        public PlaceName PlaceName { get; set; }
        
        /// <summary>
        /// The abbreviation for the home NHL team <br/>
        /// Example: TOR
        /// </summary>
        [JsonProperty("abbrev")]
        public string Abbrev { get; set; }

        /// <summary>
        /// The light logo for the home NHL team <br/>
        /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/TOR_light.svg">https://assets.nhle.com/logos/nhl/svg/TOR_light.svg</a>
        /// </summary>
        [JsonProperty("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// The dark logo for the home NHL team <br/>
        /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/TOR_dark.svg">https://assets.nhle.com/logos/nhl/svg/TOR_dark.svg</a>
        /// </summary>
        [JsonProperty("darkLogo")]
        public string DarkLogo { get; set; }

        /// <summary>
        /// The home split squad status for the home NHL team <br/>
        /// Example: true
        /// </summary>
        [JsonProperty("homeSplitSquad")]
        public bool HomeSplitSquad { get; set; }

        /// <summary>
        /// The hotel link for the home NHL team <br/>
        /// Example: <a href="https://www.hilton.com/en/hotels/sjcshhf-hilton-san-jose/">https://www.hilton.com/en/hotels/sjcshhf-hilton-san-jose/</a>
        /// </summary>
        [JsonProperty("hotelLink")]
        public string HotelLink { get; set; }

        /// <summary>
        /// The hotel description for the home NHL team <br/>
        /// Example: Stay with Hilton
        /// </summary>
        [JsonProperty("hotelDesc")]
        public string HotelDesc { get; set; }

        /// <summary>
        /// The score for the home NHL team <br/>
        /// Example: 4
        /// </summary>
        [JsonProperty("score")]
        public int Score { get; set; }

        /// <summary>
        /// The airline link for the home NHL team <br/>
        /// Example: <a href="https://www.united.com/en/us/">https://www.united.com/en/us/</a>
        /// </summary>
        [JsonProperty("airlineLink")]
        public string AirlineLink { get; set; }
        
        /// <summary>
        /// The airline description for the NHL home team <br/>
        /// Example: Fly United
        /// </summary>
        [JsonProperty("airlineDesc")]
        public string AirlineDesc { get; set; }

        /// <summary>
        /// The radio link for the home NHL team <br/>
        /// Example: <a href="https://d2igy0yla8zi0u.cloudfront.net/OTT/20232024/OTT-radio.m3u8">https://d2igy0yla8zi0u.cloudfront.net/OTT/20232024/OTT-radio.m3u8</a>
        /// </summary>
        [JsonProperty("radioLink")]
        public string RadioLink { get; set; }
    }
}
