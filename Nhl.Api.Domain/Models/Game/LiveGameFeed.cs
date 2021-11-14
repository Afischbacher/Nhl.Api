using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Team;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api.Models.Game
{
    public delegate void OnLiveGameFeedChangeEventHandler(object sender, LiveGameFeedEventArgs e);

    /// <summary>
    /// The NHL live game feed result, includes various statistics, scores, players, goalies, game updates and more
    /// </summary>
    public class LiveGameFeedResult
    {
        public LiveGameFeedResult()
        {
            Task.Run(async () => await RaiseOnLiveGameFeedChangeEvent());
        }

        /// <summary>
        /// The NHL live game feed result from the provided game pk id
        /// </summary>
        public LiveGameFeed LiveGameFeed { get; set; }

        /// <summary>
        /// An C# event that enables you to listen to changes of the NHL live game feed
        /// </summary>
        public event OnLiveGameFeedChangeEventHandler OnLiveGameFeedChange;

        private async Task RaiseOnLiveGameFeedChangeEvent()
        {
            var nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
            var endpoint = LiveGameFeed?.Link?.Replace("/api/v1", string.Empty) ?? null;
            if (string.IsNullOrWhiteSpace(endpoint))
            {
                return;
            }

            var timestamp = LiveGameFeed?.MetaData?.TimeStamp ?? null;
            var numberOfAttempts = 0;
            var maxNumberOfAttempts = 7500;
            var waitInMsPerRequest = 250;

            while (true)
            {
                await Task.Delay(waitInMsPerRequest);

                var liveGameFeed = await nhlStatsApiHttpClient.GetAsync<LiveGameFeed>(endpoint);
                if (liveGameFeed == null)
                {
                    break;
                }

                // If game is completed, stop sending events or the number of attempts exceeds 30 minutes of attempts
                var isLiveGameFeedCompleted = (liveGameFeed?.GameData?.Status?.AbstractGameState == "Final"
                    || liveGameFeed?.GameData?.Status?.CodedGameState == "7") || (numberOfAttempts >= maxNumberOfAttempts);
                if (isLiveGameFeedCompleted)
                {
                    break;
                }

                // Parse timestamps to long and compare
                var updatedParsedTimeStamp = ParseTimeStamp(liveGameFeed?.MetaData?.TimeStamp);
                var currentParsedTimeStamp = ParseTimeStamp(timestamp);

                // If the game time stamp and the updated are not equal, send event
                if (updatedParsedTimeStamp > currentParsedTimeStamp)
                {
                    timestamp = liveGameFeed?.MetaData?.TimeStamp;
                    OnLiveGameFeedChange?.Invoke(this, e: new LiveGameFeedEventArgs
                    {
                        LiveGameFeed = liveGameFeed
                    });

                    numberOfAttempts = 0;
                }

                numberOfAttempts++;
            }


            long ParseTimeStamp(string timeStamp)
            {
                if (string.IsNullOrWhiteSpace(timeStamp)) return 0;

                return long.Parse(timeStamp.Replace("_", string.Empty));
            }
        }
    }

    public class LiveGameFeedEventArgs : EventArgs
    {
        /// <summary>
        /// The NHL live game feed
        /// </summary>
        public LiveGameFeed LiveGameFeed { get; set; }
    }

    public class LiveGameFeed
    {
        /// <summary>
        /// The NHL live game feed game pk identifier <br/>
        /// Example: 2021020148
        /// </summary>
        [JsonProperty("gamePk")]
        public int GamePk { get; set; }

        /// <summary>
        /// A link to the NHL stats endpoint for the live game feed <br/>
        /// Example: /api/v1/game/2021020148/feed/live
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// The NHL live game feed meta data for the NHL live feed, this includes the last time stamp of the feed
        /// </summary>
        [JsonProperty("metaData")]
        public LiveGameFeedMetaData MetaData { get; set; }

        /// <summary>
        /// The NHL live game feed game data, this includes the team information, game status, players and more
        /// </summary>
        [JsonProperty("gameData")]
        public GameData GameData { get; set; }

        /// <summary>
        /// The NHL live data for the live game feed, this includes each play by play, the line score, box score and more
        /// </summary>
        [JsonProperty("liveData")]
        public LiveData LiveData { get; set; }
    }

    public class LiveGameFeedMetaData
    {
        /// <summary>
        /// The wait time <br/>
        /// Example: 10
        /// </summary>
        [JsonProperty("wait")]
        public int Wait { get; set; }

        /// <summary>
        /// The time stamp of the NHL live game feed <br/>
        /// Example: 20211105_010833
        /// </summary>
        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }
    }

    public class LiveGameFeedGame
    {

        /// <summary>
        /// This is the game pk identifier <br/>
        /// Example: 2021020148
        /// </summary>
        [JsonProperty("pk")]
        public int Pk { get; set; }

        /// <summary>
        /// Returns the current NHL season <br/>
        /// Example: 20212022
        /// </summary>
        [JsonProperty("season")]
        public string Season { get; set; }

        /// <summary>
        /// Returns the type of NHL game <br/>
        /// Example: R
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }

    public class LiveGameFeedDatetime
    {
        /// <summary>
        /// The date and time for the NHL live game feed <br/>
        /// Example: 2021-11-04T23:00:00Z
        /// </summary>
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// The end date and time for the NHL live game feed <br/>
        /// Example: 2021-10-22T22:00:00Z
        /// </summary>
        [JsonProperty("endDateTime")]
        public DateTime EndDateTime { get; set; }
    }

    public class LiveGameFeedStatus
    {
        /// <summary>
        /// Returns the abstract game state of the current NHL live game feed <br/>
        /// Example: Live
        /// </summary>
        [JsonProperty("abstractGameState")]
        public string AbstractGameState { get; set; }

        /// <summary>
        /// Returns the coded game state of the current NHL live game feed <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("codedGameState")]
        public string CodedGameState { get; set; }

        /// <summary>
        /// Returns the detailed game state of the current NHL live game feed <br/>
        /// Example: In Progress
        /// </summary>
        [JsonProperty("detailedState")]
        public string DetailedState { get; set; }

        /// <summary>
        /// Returns the status code of the current NHL live game feed <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("statusCode")]
        public string StatusCode { get; set; }

        /// <summary>
        /// Returns if the start time is to be determined for the current NHL live game feed <br/>
        /// Example: false
        /// </summary>
        [JsonProperty("startTimeTBD")]
        public bool StartTimeTBD { get; set; }
    }

    public class LiveGameFeedAwayTeam : LiveGameFeedTeam
    {

    }

    public class LiveGameFeedHomeTeam : LiveGameFeedTeam
    {

    }

    public abstract class LiveGameFeedTeam
    {
        /// <summary>
        /// Returns the team id of the NHL team <br/>
        /// Example: 10
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Returns the NHL team name <br/>
        /// Example: Tampa Bay Lightning
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the NHL API link to the team profile and endpoint <br/>
        /// Example: /api/v1/teams/17
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Returns information about the NHL team venue
        /// </summary>
        [JsonProperty("venue")]
        public Venue.Venue Venue { get; set; }

        /// <summary>
        /// Returns the abbreviation for the NHL team <br/>
        /// Example: DET
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Returns the tri code for the NHL team <br/>
        /// Example: FLA
        /// </summary>
        [JsonProperty("triCode")]
        public string TriCode { get; set; }

        /// <summary>
        /// Returns the official team name for the NHL team <br/>
        /// Example: Red Wings
        /// </summary>
        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        /// <summary>
        /// Returns the location name of the NHL team <br/>
        /// Example: Buffalo
        /// </summary>
        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// Returns the first year of play for the NHL team <br/>
        /// Example: 1926
        /// </summary>
        [JsonProperty("firstYearOfPlay")]
        public string FirstYearOfPlay { get; set; }

        /// <summary>
        /// Returns the information about the NHL team division
        /// </summary>
        [JsonProperty("division")]
        public Division.Division Division { get; set; }

        /// <summary>
        /// Returns the information about the NHL team conference
        /// </summary>
        [JsonProperty("conference")]
        public Conference.Conference Conference { get; set; }

        /// <summary>
        /// Returns the information about the NHL team franchise
        /// </summary>
        [JsonProperty("franchise")]
        public Franchise.Franchise Franchise { get; set; }

        /// <summary>
        /// Returns the short name for the NHL team <br/>
        /// Example: Boston
        /// </summary>

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Returns the official NHL website for the NHL team <br/>
        /// Example: http://www.mapleleafs.com/
        /// </summary>

        [JsonProperty("officialSiteUrl")]
        public string OfficialSiteUrl { get; set; }

        /// <summary>
        /// Returns the NHL franchise id for the NHL team <br/>
        /// Example: 10
        /// </summary>
        [JsonProperty("franchiseId")]
        public int FranchiseId { get; set; }

        /// <summary>
        /// Returns if the NHL team is active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Returns the number of goals scored by the NHL team <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("goals")]
        public int Goals { get; set; }

        /// <summary>
        /// Returns the number of shots on goal  by the NHL team <br/>
        /// Example: 32
        /// </summary>
        [JsonProperty("shotsOnGoal")]
        public int ShotsOnGoal { get; set; }

        /// <summary>
        /// Returns the side of the rink the NHL team is on  <br/>
        /// Example: left
        /// </summary>
        [JsonProperty("rinkSide")]
        public string RinkSide { get; set; }

        /// <summary>
        /// Return the NHL team scores <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("scores")]
        public int Scores { get; set; }

        /// <summary>
        /// Returns the number of NHL team scoring attempts  <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("attempts")]
        public int Attempts { get; set; }

        /// <summary>
        /// Returns information about the NHL team
        /// </summary>
        [JsonProperty("team")]
        public Team.Team Team { get; set; }

        /// <summary>
        /// Returns true or false if the NHL goalie is pulled from the net
        /// </summary>
        [JsonProperty("goaliePulled")]
        public bool GoaliePulled { get; set; }

        /// <summary>
        /// Returns the number of NHL skaters <br/>
        /// Example: 22
        /// </summary>
        [JsonProperty("numSkaters")]
        public int NumSkaters { get; set; }

        /// <summary>
        /// Returns true or false in the NHL team is on a power play
        /// </summary>
        [JsonProperty("powerPlay")]
        public bool PowerPlay { get; set; }

        /// <summary>
        /// Returns the NHL team statistics including, goals, face off win percentage and more
        /// </summary>
        [JsonProperty("teamStats")]
        public TeamStats TeamStats { get; set; }

        /// <summary>
        /// Returns all of the NHL players and their player profiles
        /// </summary>
        [JsonProperty("players")]
        public Dictionary<string, LiveGameFeedPlayer> Players { get; set; }

        /// <summary>
        /// Returns the NHL player id's for goalies <br/>
        /// Example: [ 8476341, 8479406 ]...
        /// </summary>
        /// 
        [JsonProperty("goalies")]
        public List<int> Goalies { get; set; }

        /// <summary>
        /// Returns the NHL player id's for skaters <br/>
        /// Example: [ 8482245, 8480801, 8480064, 8477482, 8474584, 8482116, 8480208, 8476400 ]...
        /// </summary>
        [JsonProperty("skaters")]
        public List<int> Skaters { get; set; }

        /// <summary>
        /// Returns the NHL player id's on ice <br/>
        /// Example: 8481102
        /// </summary>
        [JsonProperty("onIce")]
        public List<int> OnIce { get; set; }

        /// <summary>
        /// Returns the NHL players on ice, including player id, stamina and shift duration in seconds
        /// </summary>
        [JsonProperty("onIcePlus")]
        public List<OnIcePlus> OnIcePlus { get; set; }

        /// <summary>
        /// Returns the NHL player id's that are scratched <br/>
        /// Example: [ 8474090 ]
        /// </summary>
        [JsonProperty("scratches")]
        public List<int> Scratches { get; set; }

        /// <summary>
        /// Returns the NHL player id's in the penalty box <br/>
        /// Example: [ 8481102 ]
        /// </summary>
        [JsonProperty("penaltyBox")]
        public List<int> PenaltyBox { get; set; }

        /// <summary>
        /// Returns the coaches for the NHL team
        /// </summary>
        [JsonProperty("coaches")]
        public List<Coach> Coaches { get; set; }
    }

    public class LiveGameFeedGameDataTeams
    {
        /// <summary>
        /// The NHL live game feed home team
        /// </summary>
        [JsonProperty("home")]
        public LiveGameFeedGameDataHomeTeam Home { get; set; }

        /// <summary>
        /// The NHL live game feed away team
        /// </summary>
        [JsonProperty("away")]
        public LiveGameFeedGameDataAwayTeam Away { get; set; }
    }

    public abstract class LiveGameFeedGameDataTeam
    {
        /// <summary>
        /// Returns the team id of the NHL team <br/>
        /// Example: 10
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Returns the NHL team name <br/>
        /// Example: Tampa Bay Lightning
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Returns the NHL API link to the team profile and endpoint <br/>
        /// Example: /api/v1/teams/17
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Returns information about the NHL team venue
        /// </summary>
        [JsonProperty("venue")]
        public Venue.Venue Venue { get; set; }

        /// <summary>
        /// Returns the abbreviation for the NHL team <br/>
        /// Example: DET
        /// </summary>
        [JsonProperty("abbreviation")]
        public string Abbreviation { get; set; }

        /// <summary>
        /// Returns the tri code for the NHL team <br/>
        /// Example: FLA
        /// </summary>
        [JsonProperty("triCode")]
        public string TriCode { get; set; }

        /// <summary>
        /// Returns the official team name for the NHL team <br/>
        /// Example: Red Wings
        /// </summary>
        [JsonProperty("teamName")]
        public string TeamName { get; set; }

        /// <summary>
        /// Returns the location name of the NHL team <br/>
        /// Example: Buffalo
        /// </summary>
        [JsonProperty("locationName")]
        public string LocationName { get; set; }

        /// <summary>
        /// Returns the first year of play for the NHL team <br/>
        /// Example: 1926
        /// </summary>
        [JsonProperty("firstYearOfPlay")]
        public string FirstYearOfPlay { get; set; }

        /// <summary>
        /// Returns the information about the NHL team division
        /// </summary>
        [JsonProperty("division")]
        public Division.Division Division { get; set; }

        /// <summary>
        /// Returns the information about the NHL team conference
        /// </summary>
        [JsonProperty("conference")]
        public Conference.Conference Conference { get; set; }

        /// <summary>
        /// Returns the information about the NHL team franchise
        /// </summary>
        [JsonProperty("franchise")]
        public Franchise.Franchise Franchise { get; set; }

        /// <summary>
        /// Returns the short name for the NHL team <br/>
        /// Example: Boston
        /// </summary>

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        /// <summary>
        /// Returns the official NHL website for the NHL team <br/>
        /// Example: http://www.mapleleafs.com/
        /// </summary>

        [JsonProperty("officialSiteUrl")]
        public string OfficialSiteUrl { get; set; }

        /// <summary>
        /// Returns the NHL franchise id for the NHL team <br/>
        /// Example: 10
        /// </summary>
        [JsonProperty("franchiseId")]
        public int FranchiseId { get; set; }

        /// <summary>
        /// Returns if the NHL team / franchise is active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }
    }

    public class LiveGameFeedGameDataHomeTeam : LiveGameFeedGameDataTeam
    {

    }

    public class LiveGameFeedGameDataAwayTeam : LiveGameFeedGameDataTeam
    {

    }

    public class LiveGameFeedTeams
    {
        /// <summary>
        /// The NHL live game feed home team
        /// </summary>
        [JsonProperty("away")]
        public LiveGameFeedAwayTeam Away { get; set; }

        /// <summary>
        /// The NHL live game feed away team
        /// </summary>
        [JsonProperty("home")]
        public LiveGameFeedHomeTeam Home { get; set; }
    }

    public class LiveGameFeedPlayer
    {
        /// <summary>
        /// The identifier of the NHL player <br/>
        /// Example: 8471675 - Sidney Crosby
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Full name of the NHL player <br/>
        /// Example: Alexander Ovechkin
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// A link to the NHL player profile in the NHL API <br/>
        /// Example: /api/v1/people/8479318
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// The first name of the NHL player <br/>
        /// Example: John
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the NHL player <br/>
        /// Example: Carlson
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The number of the NHL player <br/>
        /// Example: 97
        /// </summary>
        [JsonProperty("primaryNumber")]
        public string PrimaryNumber { get; set; }

        /// <summary>
        /// The birth date of the NHL player <br/>
        /// Example: 1985-05-10
        /// </summary>
        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The current age in years of the NHL player <br/>
        /// Example: 26
        /// </summary>
        [JsonProperty("currentAge")]
        public int CurrentAge { get; set; }

        /// <summary>
        /// The birth city of the NHL player <br/>
        /// Example: Regina
        /// </summary>
        [JsonProperty("birthCity")]
        public string BirthCity { get; set; }

        /// <summary>
        /// The birth state or province of the NHL player <br/>
        /// <strong>NOTE: This value is not always present</strong><br/>
        /// Example: SK
        /// </summary>
        [JsonProperty("birthStateProvince")]
        public string BirthStateProvince { get; set; }

        /// <summary>
        /// The birth country of the NHL Player <br/>
        /// Example: USA
        /// </summary>
        [JsonProperty("birthCountry")]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The nationality of the NHL player <br/>
        /// Example: CAN
        /// </summary>
        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// The height in feet and inches of the NHL player <br/>
        /// Example: "6' 2\""
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// The weight in lbs of the NHL player <br/>
        /// Example: 195
        /// </summary>
        [JsonProperty("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Identifies if the NHL player is currently active in the NHL
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Identifies if the player is an alternate captain
        /// </summary>
        [JsonProperty("alternateCaptain")]
        public bool AlternateCaptain { get; set; }

        /// <summary>
        /// Identifies if the player is the captain
        /// </summary>
        [JsonProperty("captain")]
        public bool Captain { get; set; }

        /// <summary>
        /// Identifies if the player is a rookie
        /// </summary>
        [JsonProperty("rookie")]
        public bool Rookie { get; set; }

        /// <summary>
        /// The hand or glove position of the NHL player or goalie <br/>
        /// Example: R
        /// </summary>
        [JsonProperty("shootsCatches")]
        public string ShootsCatches { get; set; }

        /// <summary>
        /// The roster status of the NHL player <br/>
        /// Example: N - No / Y - Yes
        /// </summary>
        [JsonProperty("rosterStatus")]
        public string RosterStatus { get; set; }

        /// <summary>
        /// The current team of the NHL player
        /// </summary>
        [JsonProperty("currentTeam")]
        public CurrentTeam CurrentTeam { get; set; }

        /// <summary>
        /// The primary position information of the NHL player
        /// </summary>
        [JsonProperty("primaryPosition")]
        public PrimaryPosition PrimaryPosition { get; set; }

        /// <summary>
        /// Returns a profile about the NHL player person, including information such as link, shoots/catches etc.
        /// </summary>
        [JsonProperty("person")]
        public LiveGameFeedPerson Person { get; set; }

        /// <summary>
        /// Returns the jersey number of the NHL player <br/>
        /// Example: 86
        /// </summary>
        [JsonProperty("jerseyNumber")]
        public string JerseyNumber { get; set; }

        /// <summary>
        /// Returns the live game statistics for the NHL player
        /// </summary>
        [JsonProperty("stats")]
        public LiveGameFeedStats Stats { get; set; }

        /// <summary>
        /// Determines if the player is an NHL goalie
        /// </summary>
        public bool IsGoalie
        {
            get
            {
                return PrimaryPosition?.Code == PlayerPositionEnum.G.ToString();
            }
        }

        /// <summary>
        /// Returns a head-shot image of the NHL player <br/>
        /// Example: <a href="https://cms.nhl.bamgrid.com/images/headshots/current/168x168/8478402.png">Connor McDavid</a>
        /// </summary>
        public string PlayerHeadshotImageLink
        {
            get
            {
                return GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Large);
            }
        }

        /// <summary>
        /// Returns an image of the NHL player based on the requested size <br/>
        /// Example: <a href="https://cms.nhl.bamgrid.com/images/headshots/current/168x168/8478402.png">Connor McDavid</a>
        /// </summary>
        public string GetPlayerHeadshotImageLink(PlayerHeadshotImageSize playerHeadshotImageSize)
        {
            if (!Id.Equals(default))
            {
                switch (playerHeadshotImageSize)
                {
                    case PlayerHeadshotImageSize.Small:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Id}.png";
                    case PlayerHeadshotImageSize.Medium:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Id}@2x.png";
                    case PlayerHeadshotImageSize.Large:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Id}@3x.png";
                }
            }

            return null;
        }
    }

    public class GameData
    {
        /// <summary>
        /// Includes information about the game such as the game pk identifier and the type of game
        /// </summary>
        [JsonProperty("game")]
        public LiveGameFeedGame Game { get; set; }

        /// <summary>
        /// Returns the live game feed date and time with start and end times
        /// </summary>
        [JsonProperty("datetime")]
        public LiveGameFeedDatetime Datetime { get; set; }

        /// <summary>
        /// Returns the status of the NHL live game feed, including abstract and detailed game states
        /// </summary>
        [JsonProperty("status")]
        public LiveGameFeedStatus Status { get; set; }

        /// <summary>
        /// Returns both of the home and away NHL teams
        /// </summary>
        [JsonProperty("teams")]
        public LiveGameFeedGameDataTeams Teams { get; set; }

        /// <summary>
        /// Returns all of the NHL players associated with the NHL live game feed and their player data
        /// </summary>
        [JsonProperty("players")]
        public Dictionary<string, LiveGameFeedGameDataPlayer> Players { get; set; }

        /// <summary>
        /// Returns information about the NHL venue, including NHL API link and city
        /// </summary>
        [JsonProperty("venue")]
        public Venue.Venue Venue { get; set; }
    }

    public class LiveGameFeedGameDataPlayer
    {

        /// <summary>
        /// The identifier of the NHL player <br/>
        /// Example: 8471675 - Sidney Crosby
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Full name of the NHL player <br/>
        /// Example: Alexander Ovechkin
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// A link to the NHL player profile in the NHL API <br/>
        /// Example: /api/v1/people/8479318
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// The first name of the NHL player <br/>
        /// Example: John
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of the NHL player <br/>
        /// Example: Carlson
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// The number of the NHL player <br/>
        /// Example: 97
        /// </summary>
        [JsonProperty("primaryNumber")]
        public string PrimaryNumber { get; set; }

        /// <summary>
        /// The birth date of the NHL player <br/>
        /// Example: 1985-05-10
        /// </summary>
        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The current age in years of the NHL player <br/>
        /// Example: 26
        /// </summary>
        [JsonProperty("currentAge")]
        public int CurrentAge { get; set; }

        /// <summary>
        /// The birth city of the NHL player <br/>
        /// Example: Regina
        /// </summary>
        [JsonProperty("birthCity")]
        public string BirthCity { get; set; }

        /// <summary>
        /// The birth state or province of the NHL player <br/>
        /// <strong>NOTE:</strong> This value is not always present <br/>
        /// Example: SK
        /// </summary>
        [JsonProperty("birthStateProvince")]
        public string BirthStateProvince { get; set; }

        /// <summary>
        /// The birth country of the NHL Player <br/>
        /// Example: USA
        /// </summary>
        [JsonProperty("birthCountry")]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The nationality of the NHL player <br/>
        /// Example: CAN
        /// </summary>
        [JsonProperty("nationality")]
        public string Nationality { get; set; }

        /// <summary>
        /// The height in feet and inches of the NHL player <br/>
        /// Example: "6' 2\""
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// The weight in lbs of the NHL player <br/>
        /// Example: 195
        /// </summary>
        [JsonProperty("weight")]
        public int Weight { get; set; }

        /// <summary>
        /// Identifies if the NHL player is currently active
        /// </summary>
        [JsonProperty("active")]
        public bool Active { get; set; }

        /// <summary>
        /// Identifies if the player is an alternate captain
        /// </summary>
        [JsonProperty("alternateCaptain")]
        public bool AlternateCaptain { get; set; }

        /// <summary>
        /// Identifies if the player is the captain
        /// </summary>
        [JsonProperty("captain")]
        public bool Captain { get; set; }

        /// <summary>
        /// Identifies if the player is a rookie
        /// </summary>
        [JsonProperty("rookie")]
        public bool Rookie { get; set; }

        /// <summary>
        /// The hand or glove position of the NHL player or goalie <br/>
        /// Example: R
        /// </summary>
        [JsonProperty("shootsCatches")]
        public string ShootsCatches { get; set; }

        /// <summary>
        /// The roster status of the NHL player <br/>
        /// Example: N - No / Y - Yes
        /// </summary>
        [JsonProperty("rosterStatus")]
        public string RosterStatus { get; set; }

        /// <summary>
        /// The current team of the NHL player
        /// </summary>
        [JsonProperty("currentTeam")]
        public CurrentTeam CurrentTeam { get; set; }

        /// <summary>
        /// The primary position information of the NHL player
        /// </summary>
        [JsonProperty("primaryPosition")]
        public PrimaryPosition PrimaryPosition { get; set; }

        /// <summary>
        /// Returns a head-shot image of the NHL player <br/>
        /// Example: <a href="https://cms.nhl.bamgrid.com/images/headshots/current/168x168/8478402.png">Connor McDavid</a>
        /// </summary>
        public string PlayerHeadshotImageLink
        {
            get
            {
                return GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Large);
            }
        }

        /// <summary>
        /// Determines if the player is an NHL goalie
        /// </summary>
        public bool IsGoalie
        {
            get
            {
                return PrimaryPosition?.Code == PlayerPositionEnum.G.ToString();
            }
        }

        /// <summary>
        /// Returns an image of the NHL player based on the requested size <br/>
        /// Example: <a href="https://cms.nhl.bamgrid.com/images/headshots/current/168x168/8478402.png">Connor McDavid</a>
        /// </summary>
        public string GetPlayerHeadshotImageLink(PlayerHeadshotImageSize playerHeadshotImageSize)
        {
            if (!Id.Equals(default))
            {
                switch (playerHeadshotImageSize)
                {
                    case PlayerHeadshotImageSize.Small:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Id}.png";
                    case PlayerHeadshotImageSize.Medium:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Id}@2x.png";
                    case PlayerHeadshotImageSize.Large:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Id}@3x.png";
                }
            }

            return null;
        }
    }

    public class Strength
    {
        /// <summary>
        /// Returns the code for the NHL team strength <br/>
        /// Example: EVEN
        /// </summary>
        [JsonProperty("code")]
        public string Code { get; set; }

        /// <summary>
        /// Returns the name for the code for the NHL team strength <br/>
        /// Example: Even
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Result
    {
        /// <summary>
        /// Returns information about the NHL live game feed event <br/>
        /// Example: Game Scheduled
        /// </summary>
        [JsonProperty("event")]
        public string Event { get; set; }

        /// <summary>
        /// Returns information about the NHL live game feed event code <br/>
        /// Example: CAR1
        /// </summary>
        [JsonProperty("eventCode")]
        public string EventCode { get; set; }

        /// <summary>
        /// Returns information about the NHL live game feed event type id <br/>
        /// Example: GAME_SCHEDULED
        /// </summary>
        [JsonProperty("eventTypeId")]
        public string EventTypeId { get; set; }

        /// <summary>
        /// Returns information about the NHL live game feed description <br/>
        /// Example: William Nylander Wrist Shot saved by Frederik Andersen
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// Returns information about the NHL live game feed secondary description <br/>
        /// Example: Game Wrist Shot
        /// </summary>
        [JsonProperty("secondaryType")]
        public string SecondaryType { get; set; }

        /// <summary>
        /// Returns information about the strength of the NHL play
        /// </summary>
        [JsonProperty("strength")]
        public Strength Strength { get; set; }

        /// <summary>
        /// Returns true or false if the NHL team has the game winning goal
        /// </summary>
        [JsonProperty("gameWinningGoal")]
        public bool? GameWinningGoal { get; set; }

        /// <summary>
        /// Returns true or false if the NHL team has their net empty
        /// </summary>
        [JsonProperty("emptyNet")]
        public bool? EmptyNet { get; set; }

        /// <summary>
        /// Returns the type of penalty severity for the NHL play <br/>
        /// Example: Minor
        /// </summary>
        [JsonProperty("penaltySeverity")]
        public string PenaltySeverity { get; set; }

        /// <summary>
        /// Returns the total number of penalty minutes for the NHL play <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("penaltyMinutes")]
        public int? PenaltyMinutes { get; set; }
    }

    public class Goals
    {
        /// <summary>
        /// Returns the number of goals for the away NHL team <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("away")]
        public int Away { get; set; }

        /// <summary>
        /// Returns the number of goals for the home NHL team <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("home")]
        public int Home { get; set; }
    }

    public class About
    {
        /// <summary>
        /// Returns the event idx code <br/>
        /// Example: 111
        /// </summary>
        [JsonProperty("eventIdx")]
        public int EventIdx { get; set; }

        /// <summary>
        /// Returns the event id <br/>
        /// Example: 451
        /// </summary>
        [JsonProperty("eventId")]
        public int EventId { get; set; }

        /// <summary>
        /// Returns the period number <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("period")]
        public int Period { get; set; }

        /// <summary>
        /// Returns the period type <br/>
        /// Example: REGULAR
        /// </summary>
        [JsonProperty("periodType")]
        public string PeriodType { get; set; }

        /// <summary>
        /// Returns the period number <br/>
        /// Example: 1st
        /// </summary>
        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        /// <summary>
        /// Returns the period time <br/>
        /// Example: 01:31
        /// </summary>
        [JsonProperty("periodTime")]
        public string PeriodTime { get; set; }

        /// <summary>
        /// Returns the period time remaining <br/>
        /// Example: 18:29
        /// </summary>
        [JsonProperty("periodTimeRemaining")]
        public string PeriodTimeRemaining { get; set; }


        /// <summary>
        /// Returns the date and time stamp for the event information <br/>
        /// Example: 2021-10-26T00:05:07Z
        /// </summary>
        [JsonProperty("dateTime")]
        public DateTime DateTime { get; set; }

        /// <summary>
        /// Returns the goals in the NHL game
        /// </summary>
        [JsonProperty("goals")]
        public Goals Goals { get; set; }
    }

    public class Coordinates
    {
        /// <summary>
        /// Returns the x coordinate for the NHL live game feed play <br/>
        /// Example: -41.0
        /// </summary>
        [JsonProperty("x")]
        public double? X { get; set; }

        /// <summary>
        /// Returns the y coordinate for the NHL live game feed play <br/>
        /// Example: 17.0
        /// </summary>
        [JsonProperty("y")]
        public double? Y { get; set; }
    }

    public class AllPlay
    {
        /// <summary>
        /// Returns the NHL live game feed result information, includes event, event code and more play by play information
        /// </summary>
        [JsonProperty("result")]
        public Result Result { get; set; }

        /// <summary>
        /// Returns the NHL live game feed about information, includes event idx, event id, period information and more
        /// </summary>
        [JsonProperty("about")]
        public About About { get; set; }

        /// <summary>
        /// Returns the NHL live game feed coordinates about the NHL play, if they are available 
        /// </summary>
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }

        /// <summary>
        /// Returns a collection of all the NHL players and their information, including player type, name and more
        /// </summary>
        [JsonProperty("players")]
        public List<LiveGameFeedAllPlayPlayer> Players { get; set; }

        /// <summary>
        /// Returns information about the NHL team in the NHL play, includes the NHL API link, team name and more 
        /// </summary>
        [JsonProperty("team")]
        public TeamInformation Team { get; set; }
    }

    public class LiveGameFeedAllPlayPlayer
    {
        /// <summary>
        /// Returns information about the NHL player
        /// </summary>
        [JsonProperty("player")]
        public Person Player { get; set; }

        /// <summary>
        /// Returns the player type for the NHL player <br/>
        /// Example: Winner, Loser, PenaltyOn, DrewBy
        /// </summary>
        [JsonProperty("playerType")]
        public string PlayerType { get; set; }
    }

    public class PlaysByPeriod
    {
        /// <summary>
        /// Returns the starting index for the plays by each period <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("startIndex")]
        public int StartIndex { get; set; }

        /// <summary>
        /// Returns the all of the plays and their indexes for each period <br/>
        /// Example: [0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10...]
        /// </summary>
        [JsonProperty("plays")]
        public List<int> Plays { get; set; }
        /// <summary>
        /// Returns the ending index for each period's play by play information <br/>
        /// Example : 102
        /// </summary>
        [JsonProperty("endIndex")]
        public int EndIndex { get; set; }
    }

    public class CurrentPlay
    {
        /// <summary>
        /// The result for information on the current play within the NHL live game feed
        /// </summary>
        [JsonProperty("result")]
        public Result Result { get; set; }

        /// <summary>
        /// Returns information about the current play
        /// </summary>
        [JsonProperty("about")]
        public About About { get; set; }

        /// <summary>
        /// Returns the coordinates of the current NHL live game feed play if available
        /// </summary>
        [JsonProperty("coordinates")]
        public Coordinates Coordinates { get; set; }
    }

    public class Plays
    {
        /// <summary>
        /// Returns a collection of all the NHL live game feed plays
        /// </summary>
        [JsonProperty("allPlays")]
        public List<AllPlay> AllPlays { get; set; }

        /// <summary>
        /// Returns a collection of all the indexes of all the scoring plays for the NHL live game feed <br/>
        /// Example: [60, 85, 135, 312, 351]
        /// </summary>
        [JsonProperty("scoringPlays")]
        public List<int> ScoringPlays { get; set; }

        /// <summary>
        /// Returns a collection of all the indexes of all the penalty plays for the NHL live game feed <br/>
        /// Example: [ 18, 149, 154 ]
        /// </summary>
        [JsonProperty("penaltyPlays")]
        public List<int> PenaltyPlays { get; set; }

        /// <summary>
        /// Returns a collection of all the indexes of all the penalty plays for the NHL live game feed <br/>
        /// Example: [ 18, 149, 154 ]
        /// </summary>
        [JsonProperty("playsByPeriod")]
        public List<PlaysByPeriod> PlaysByPeriod { get; set; }

        /// <summary>
        /// Returns information about the current play within the NHL live game feed
        /// </summary>
        [JsonProperty("currentPlay")]
        public CurrentPlay CurrentPlay { get; set; }
    }

    public class Period
    {
        /// <summary>
        /// Returns the period type for the period information <br/>
        /// Example: REGULAR
        /// </summary>
        [JsonProperty("periodType")]
        public string PeriodType { get; set; }

        /// <summary>
        /// Returns the start time for the period <br/>
        /// Example: 2021-10-27T23:12:38Z
        /// </summary>
        [JsonProperty("startTime")]
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Returns the end time for the period <br/>
        /// Example: 2021-10-28T00:47:02Z
        /// </summary>
        [JsonProperty("endTime")]
        public DateTime EndTime { get; set; }

        /// <summary>
        /// Returns the number for the current period of play <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("num")]
        public int Num { get; set; }

        /// <summary>
        /// Returns the ordinal number for the current period of play <br/>
        /// Example: 2nd
        /// </summary>
        [JsonProperty("ordinalNum")]
        public string OrdinalNum { get; set; }

        /// <summary>
        /// Returns the NHL home team for the current period of play <br/>
        /// Example: 2nd
        /// </summary>
        [JsonProperty("home")]
        public LiveGameFeedLineScorePeriodHomeTeam Home { get; set; }

        /// <summary>
        /// Returns the NHL away team for the current period of play <br/>
        /// Example: 2nd
        /// </summary>
        [JsonProperty("away")]
        public LiveGameFeedLineScorePeriodAwayTeam Away { get; set; }
    }

    public class ShootoutInfo
    {
        /// <summary>
        /// Returns information about the NHL away team shootout information
        /// </summary>
        [JsonProperty("away")]
        public LiveGameFeedShootoutInfoAwayTeam Away { get; set; }

        /// <summary>
        /// Returns information about the NHL home team shootout information
        /// </summary>
        [JsonProperty("home")]
        public LiveGameFeedShootoutInfoHomeTeam Home { get; set; }
    }

    public class IntermissionInfo
    {
        /// <summary>
        /// Returns information about the time remaining for the intermission <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("intermissionTimeRemaining")]
        public int IntermissionTimeRemaining { get; set; }

        /// <summary>
        /// Returns information about the time elapsed for the intermission <br/>
        /// Example: 21
        /// </summary>
        [JsonProperty("intermissionTimeElapsed")]
        public int IntermissionTimeElapsed { get; set; }

        /// <summary>
        /// Returns true or false if it is currently intermission
        /// </summary>
        [JsonProperty("inIntermission")]
        public bool InIntermission { get; set; }
    }

    public class PowerPlayInfo
    {

        /// <summary>
        /// Returns the number of time in minutes remaining for a power play <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("situationTimeRemaining")]
        public int SituationTimeRemaining { get; set; }

        /// <summary>
        /// Returns the number of situation time elapsed for a power play <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("situationTimeElapsed")]
        public int SituationTimeElapsed { get; set; }

        /// <summary>
        /// Returns true or false if a power play is in situation
        /// </summary>
        [JsonProperty("inSituation")]
        public bool InSituation { get; set; }
    }

    public class Linescore
    {
        /// <summary>
        /// Returns the integer value of the current period <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("currentPeriod")]
        public int CurrentPeriod { get; set; }

        /// <summary>
        /// Returns the ordinal value of the current period <br/>
        /// Example: 3rd
        /// </summary>
        [JsonProperty("currentPeriodOrdinal")]
        public string CurrentPeriodOrdinal { get; set; }

        /// <summary>
        /// Returns the current time remaining of the current period <br/>
        /// Example: 12:32
        /// </summary>
        [JsonProperty("currentPeriodTimeRemaining")]
        public string CurrentPeriodTimeRemaining { get; set; }

        /// <summary>
        /// Returns a collection of periods and the information such as period type, start time, end time and more
        /// </summary>
        [JsonProperty("periods")]
        public List<Period> Periods { get; set; }

        /// <summary>
        /// Returns a information about shootout information for both home and away teams
        /// </summary>
        [JsonProperty("shootoutInfo")]
        public ShootoutInfo ShootoutInfo { get; set; }

        /// <summary>
        /// Returns a information about shootout information for both home and away teams
        /// </summary>
        [JsonProperty("teams")]
        public LiveGameFeedLineScoreTeams Teams { get; set; }

        /// <summary>
        /// Returns information about the power play strength <br/>
        /// Example: Event
        /// </summary>
        [JsonProperty("powerPlayStrength")]
        public string PowerPlayStrength { get; set; }

        /// <summary>
        /// Returns true or false if there is a shootout
        /// </summary>
        [JsonProperty("hasShootout")]
        public bool HasShootout { get; set; }

        /// <summary>
        /// Returns information about the current NHL live game feed intermission such as start time, time elapsed and end time
        /// </summary>
        [JsonProperty("intermissionInfo")]
        public IntermissionInfo IntermissionInfo { get; set; }

        /// <summary>
        /// Returns information about the power play, including time remaining and more
        /// </summary>
        [JsonProperty("powerPlayInfo")]
        public PowerPlayInfo PowerPlayInfo { get; set; }
    }

    public abstract class LiveGameFeedLineScorePeriodTeam
    {
        /// <summary>
        /// Returns the number of goals for an NHL live feed team <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("goals")]
        public int Goals { get; set; }

        /// <summary>
        /// Returns the number of shots on goal for an NHL live feed team <br/>
        /// Example: 32
        /// </summary>
        [JsonProperty("shotsOnGoal")]
        public int ShotsOnGoal { get; set; }

        /// <summary>
        /// Returns the side of the rink for the NHL live game feed team <br/>
        /// Example: left/right
        /// </summary>
        [JsonProperty("rinkSide")]
        public string RinkSide { get; set; }
    }

    public class LiveGameFeedLineScorePeriodHomeTeam : LiveGameFeedLineScorePeriodTeam
    {

    }

    public class LiveGameFeedLineScorePeriodAwayTeam : LiveGameFeedLineScorePeriodTeam
    {

    }

    public class LiveGameFeedLineScorePeriodTeams
    {
        /// <summary>
        /// The NHL live game feed home team
        /// </summary>
        [JsonProperty("home")]
        public LiveGameFeedLineScorePeriodHomeTeam Home { get; set; }

        /// <summary>
        /// The NHL live game feed away team
        /// </summary>
        [JsonProperty("away")]
        public LiveGameFeedLineScorePeriodAwayTeam Away { get; set; }
    }

    public abstract class LiveGameFeedLineScoreTeam
    {
        /// <summary>
        /// The NHL live game feed team information, including name and NHL API link
        /// </summary>
        [JsonProperty("team")]
        public TeamInformation Team { get; set; }

        /// <summary>
        /// Returns the number of goals for an NHL live feed team <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("goals")]
        public int Goals { get; set; }

        /// <summary>
        /// Returns the number of shots on goal for an NHL live feed team <br/>
        /// Example: 32
        /// </summary>
        [JsonProperty("shotsOnGoal")]
        public int ShotsOnGoal { get; set; }

        /// <summary>
        /// Returns true or false if the goalie is pulled
        /// </summary>
        [JsonProperty("goaliePulled")]
        public bool GoaliePulled { get; set; }

        /// <summary>
        /// Returns the number of skaters on in the game for the NHL team <br/>
        /// Example: 23
        /// </summary>
        [JsonProperty("numSkaters")]
        public int NumSkaters { get; set; }

        /// <summary>
        /// Returns true or false if the NHL team is on the power play
        /// </summary>
        [JsonProperty("powerPlay")]
        public bool PowerPlay { get; set; }
    }

    public class LiveGameFeedLineScoreHomeTeam : LiveGameFeedLineScoreTeam
    {

    }

    public class LiveGameFeedLineScoreAwayTeam : LiveGameFeedLineScoreTeam
    {

    }

    public class LiveGameFeedLineScoreTeams
    {
        /// <summary>
        /// The NHL live game feed home team
        /// </summary>
        [JsonProperty("home")]
        public LiveGameFeedLineScoreHomeTeam Home { get; set; }

        /// <summary>
        /// The NHL live game feed away team
        /// </summary>
        [JsonProperty("away")]
        public LiveGameFeedLineScoreAwayTeam Away { get; set; }
    }

    public abstract class LiveGameFeedShootoutInfoTeam
    {
        /// <summary>
        /// The number of goals scored in the shootout for the NHL team
        /// </summary>
        [JsonProperty("scores")]
        public int Scores { get; set; }

        /// <summary>
        /// The number of attempts in the shootout for the NHL team
        /// </summary>
        [JsonProperty("attempts")]
        public int Attempts { get; set; }
    }

    public class LiveGameFeedShootoutInfoHomeTeam : LiveGameFeedShootoutInfoTeam
    {

    }

    public class LiveGameFeedShootoutInfoAwayTeam : LiveGameFeedShootoutInfoTeam
    {

    }

    public class LiveGameFeedShootoutInfoTeams
    {
        /// <summary>
        /// The NHL live game feed home team
        /// </summary>
        [JsonProperty("home")]
        public LiveGameFeedShootoutInfoHomeTeam Home { get; set; }

        /// <summary>
        /// The NHL live game feed away team
        /// </summary>
        [JsonProperty("away")]
        public LiveGameFeedShootoutInfoAwayTeam Away { get; set; }
    }

    public class TeamSkaterStats
    {
        /// <summary>
        /// The number of goals scored by the NHL players on the NHL team <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("goals")]
        public int Goals { get; set; }

        /// <summary>
        /// The number of penalty infraction minutes by the NHL players on the NHL team <br/>
        /// Example: 6
        /// </summary>
        [JsonProperty("pim")]
        public int Pim { get; set; }

        /// <summary>
        /// The number of shots by the NHL players on the NHL team <br/>
        /// Example: 45
        /// </summary>
        [JsonProperty("shots")]
        public int Shots { get; set; }

        /// <summary>
        /// The power play percentage by the NHL players on the NHL team <br/>
        /// Example: 0.0
        /// </summary>
        [JsonProperty("powerPlayPercentage")]
        public string PowerPlayPercentage { get; set; }

        /// <summary>
        /// The power play percentage by the NHL players on the NHL team <br/>
        /// Example: 0.0
        /// </summary>
        [JsonProperty("powerPlayGoals")]
        public double PowerPlayGoals { get; set; }

        /// <summary>
        /// The number of power play opportunities by the NHL players on the NHL team <br/>
        /// Example: 2.0
        /// </summary>
        [JsonProperty("powerPlayOpportunities")]
        public double PowerPlayOpportunities { get; set; }

        /// <summary>
        /// The face off win percentage by the NHL players on the NHL team <br/>
        /// Example: 47.3
        /// </summary>
        [JsonProperty("faceOffWinPercentage")]
        public string FaceOffWinPercentage { get; set; }

        /// <summary>
        /// The number of blocked shots by the NHL players on the NHL team <br/>
        /// Example: 8
        /// </summary>
        [JsonProperty("blocked")]
        public int Blocked { get; set; }

        /// <summary>
        /// The number of take aways by the NHL players on the NHL team <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("takeaways")]
        public int Takeaways { get; set; }

        /// <summary>
        /// The number of give aways by the NHL players on the NHL team <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("giveaways")]
        public int Giveaways { get; set; }

        /// <summary>
        /// The number of hits by the NHL players on the NHL team <br/>
        /// Example: 6
        /// </summary>
        [JsonProperty("hits")]
        public int Hits { get; set; }
    }

    public class TeamStats
    {
        /// <summary>
        /// A collection of the NHL team skater statistics
        /// </summary>
        [JsonProperty("teamSkaterStats")]
        public TeamSkaterStats TeamSkaterStats { get; set; }
    }

    public class LiveGameFeedPerson
    {
        /// <summary>
        /// Returns the NHL player id <br/>
        /// Example: 8480185
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Returns the NHL player's full name <br/>
        /// Example: Mike Smith
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Returns the NHL player's NHL API endpoint <br/>
        /// Example: /api/v1/people/8480185
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

        /// <summary>
        /// Returns the NHL player's shoots or catches preference <br/>
        /// Example: L
        /// </summary>
        [JsonProperty("shootsCatches")]
        public string ShootsCatches { get; set; }

        /// <summary>
        /// Returns the NHL player's roster status <br/>
        /// Example: Y
        /// </summary>
        [JsonProperty("rosterStatus")]
        public string RosterStatus { get; set; }
    }

    public class SkaterStats
    {
        /// <summary>
        /// Returns the total time in minutes of on ice time for an NHL player <br/>
        /// Example: 14:24
        /// </summary>
        [JsonProperty("timeOnIce")]
        public string TimeOnIce { get; set; }

        /// <summary>
        /// Returns the number of assists for an NHL player <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// Returns the number of goals for an NHL player <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("goals")]
        public int Goals { get; set; }

        /// <summary>
        /// Returns the number of shots for an NHL player <br/>
        /// Example: 5
        /// </summary>
        [JsonProperty("shots")]
        public int Shots { get; set; }

        /// <summary>
        /// Returns the number of hits for an NHL player <br/>
        /// Example: 9
        /// </summary>
        [JsonProperty("hits")]
        public int Hits { get; set; }

        /// <summary>
        /// Returns the number of power play goals for an NHL player <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("powerPlayGoals")]
        public int PowerPlayGoals { get; set; }

        /// <summary>
        /// Returns the number of power play assists for an NHL player <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("powerPlayAssists")]
        public int PowerPlayAssists { get; set; }

        /// <summary>
        /// Returns the number of penalty minutes for an NHL player <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("penaltyMinutes")]
        public int PenaltyMinutes { get; set; }

        /// <summary>
        /// Returns the number of face off wins for an NHL player <br/>
        /// Example: 6
        /// </summary>
        [JsonProperty("faceOffWins")]
        public int FaceOffWins { get; set; }

        /// <summary>
        /// Returns the number of face offs taken for an NHL player <br/>
        /// Example: 12
        /// </summary>
        [JsonProperty("faceoffTaken")]
        public int FaceoffTaken { get; set; }

        /// <summary>
        /// Returns the number of takeaways by an NHL player <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("takeaways")]
        public int Takeaways { get; set; }

        /// <summary>
        /// Returns the number of giveaways by an NHL player <br/>
        /// Example: 3
        /// </summary>
        [JsonProperty("giveaways")]
        public int Giveaways { get; set; }

        /// <summary>
        /// Returns the number of short handed goals by an NHL player <br/>
        /// Example: 4
        /// </summary>
        [JsonProperty("shortHandedGoals")]
        public int ShortHandedGoals { get; set; }

        /// <summary>
        /// Returns the number of short handed assists by an NHL player <br/>
        /// Example: 0
        /// </summary>
        [JsonProperty("shortHandedAssists")]
        public int ShortHandedAssists { get; set; }

        /// <summary>
        /// Returns the number of shots blocked by an NHL player <br/>
        /// Example: 7
        /// </summary>
        [JsonProperty("blocked")]
        public int Blocked { get; set; }

        /// <summary>
        /// Returns the plus/minus for an NHL player <br/>
        /// Example: -2
        /// </summary>
        [JsonProperty("plusMinus")]
        public int PlusMinus { get; set; }

        /// <summary>
        /// Returns the even time on ice for an NHL player <br/>
        /// Example: 13:59
        /// </summary>
        [JsonProperty("evenTimeOnIce")]
        public string EvenTimeOnIce { get; set; }

        /// <summary>
        /// Returns the power play time on ice for an NHL player <br/>
        /// Example: 0:30
        /// </summary>
        [JsonProperty("powerPlayTimeOnIce")]
        public string PowerPlayTimeOnIce { get; set; }

        /// <summary>
        /// Returns the shorthanded time on ice for an NHL player <br/>
        /// Example: 1:30
        /// </summary>
        [JsonProperty("shortHandedTimeOnIce")]
        public string ShortHandedTimeOnIce { get; set; }

        /// <summary>
        /// Returns the face off percentage for an NHL player <br/>
        /// Example: 29.63
        /// </summary>
        [JsonProperty("faceOffPct")]
        public double FaceOffPct { get; set; }
    }

    public class LiveGameFeedStats
    {
        /// <summary>
        /// Returns information about the skater statistics
        /// </summary>
        [JsonProperty("skaterStats")]
        public SkaterStats SkaterStats { get; set; }

        /// <summary>
        /// Returns information about the goalie statistics
        /// </summary>
        [JsonProperty("goalieStats")]
        public GoalieStats GoalieStats { get; set; }
    }

    public class GoalieStats
    {
        /// <summary>
        /// Returns the number of minutes of ice time for the NHL goalie <br/>
        /// Example: 59:54
        /// </summary>
        [JsonProperty("timeOnIce")]
        public string TimeOnIce { get; set; }

        /// <summary>
        /// Returns the number of assists for an NHL goalie <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("assists")]
        public int Assists { get; set; }

        /// <summary>
        /// Returns the number of goals for an NHL goalie <br/>
        /// Example: 1
        /// </summary>
        [JsonProperty("goals")]
        public int Goals { get; set; }

        /// <summary>
        /// Returns the number of penalty infraction minutes for an NHL goalie <br/>
        /// Example: 0
        /// </summary>
        [JsonProperty("pim")]
        public int Pim { get; set; }

        /// <summary>
        /// Returns the number of shots for an NHL goalie <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("shots")]
        public int Shots { get; set; }

        /// <summary>
        /// Returns the number of saves for an NHL goalie <br/>
        /// Example: 29
        /// </summary>
        [JsonProperty("saves")]
        public int Saves { get; set; }

        /// <summary>
        /// Returns the number of power play saves for an NHL goalie <br/>
        /// Example: 8
        /// </summary>
        [JsonProperty("powerPlaySaves")]
        public int PowerPlaySaves { get; set; }

        /// <summary>
        /// Returns the number of short handed saves for an NHL goalie <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("shortHandedSaves")]
        public int ShortHandedSaves { get; set; }

        /// <summary>
        /// Returns the number of even strength saves for an NHL goalie <br/>
        /// Example: 15
        /// </summary>
        [JsonProperty("evenSaves")]
        public int EvenSaves { get; set; }

        /// <summary>
        /// Returns the number of short handed shots against for an NHL goalie <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("shortHandedShotsAgainst")]
        public int ShortHandedShotsAgainst { get; set; }

        /// <summary>
        /// Returns the number of even handed shots against for an NHL goalie <br/>
        /// Example: 14
        /// </summary>
        [JsonProperty("evenShotsAgainst")]
        public int EvenShotsAgainst { get; set; }

        /// <summary>
        /// Returns the number of power play shots against for an NHL goalie <br/>
        /// Example: 11
        /// </summary>
        [JsonProperty("powerPlayShotsAgainst")]
        public int PowerPlayShotsAgainst { get; set; }

        /// <summary>
        /// Returns the decision of a win or loss for the NHL goalie <br/>
        /// Example: W
        /// </summary>
        [JsonProperty("decision")]
        public string Decision { get; set; }

        /// <summary>
        /// Returns the save percentage for the NHL goalie <br/>
        /// Example: 92.5925925925926
        /// </summary>
        [JsonProperty("savePercentage")]
        public double SavePercentage { get; set; }

        /// <summary>
        /// Returns the power play save percentage for the NHL goalie <br/>
        /// Example: 100.0
        /// </summary>
        [JsonProperty("powerPlaySavePercentage")]
        public double PowerPlaySavePercentage { get; set; }

        /// <summary>
        /// Returns the even strength save percentage for the NHL goalie <br/>
        /// Example: 100.0
        /// </summary>
        [JsonProperty("evenStrengthSavePercentage")]
        public double EvenStrengthSavePercentage { get; set; }

        /// <summary>
        /// Returns the short handed save percentage for the NHL goalie <br/>
        /// Example: 88.23529411764706
        /// </summary>
        [JsonProperty("shortHandedSavePercentage")]
        public double ShortHandedSavePercentage { get; set; }
    }

    public class OnIcePlus
    {
        /// <summary>
        /// Returns the NHL player id <br/>
        /// Example: 8470638
        /// </summary>
        [JsonProperty("playerId")]
        public int PlayerId { get; set; }

        /// <summary>
        /// Returns the NHL player shift duration in seconds <br/>
        /// Example: 102
        /// </summary>
        [JsonProperty("shiftDuration")]
        public int ShiftDuration { get; set; }

        /// <summary>
        /// Returns the NHL player stamina as a value out of 100 <br/>
        /// Example: 33
        /// </summary>
        [JsonProperty("stamina")]
        public int Stamina { get; set; }
    }

    public class Coach
    {
        /// <summary>
        /// Returns the NHL coach information, including name, id etc.
        /// </summary>
        [JsonProperty("person")]
        public LiveGameFeedPerson Person { get; set; }

        /// <summary>
        /// Returns the NHL coach position, including abbreviation and full position name
        /// </summary>
        [JsonProperty("position")]
        public PrimaryPosition Position { get; set; }
    }

    public class Official
    {
        /// <summary>
        /// Returns an identifier for the NHL official <br/>
        /// Example: 2459
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Returns the full name of the NHL official <br/>
        /// Example: Justin StPierre
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Returns an NHL API link for the NHL official <br/>
        /// Example: /api/v1/people/2459
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class GameOfficial
    {
        /// <summary>
        /// Returns the profile of an NHL official
        /// </summary>
        [JsonProperty("official")]
        public Official Official { get; set; }

        /// <summary>
        /// Returns the profile type of NHL official <br/>
        /// Example: Linesman/Referee
        /// </summary>
        [JsonProperty("officialType")]
        public string OfficialType { get; set; }
    }

    public class LiveGameFeedBoxscoreTeams
    {
        /// <summary>
        /// Returns the NHL live game feed box score home team
        /// </summary>
        [JsonProperty("home")]
        public LiveGameFeedBoxscoreHomeTeam Home { get; set; }

        /// <summary>
        /// Returns the NHL live game feed box score away team
        /// </summary>
        [JsonProperty("away")]
        public LiveGameFeedBoxscoreAwayTeam Away { get; set; }
    }

    public abstract class LiveGameFeedBoxscoreTeam 
    {
        /// <summary>
        /// Returns the team information for the NHL live game feed box score team
        /// </summary>
        [JsonProperty("team")]
        public TeamInformation TeamInformation { get; set; }

        /// <summary>
        /// Returns the team statistics for the NHL live game feed box score team
        /// </summary>
        [JsonProperty("teamStats")]
        public new TeamStats TeamStats { get; set; }

        /// <summary>
        /// Returns the a key value collection of all the NHL live game feed player box score profiles
        /// </summary>
        [JsonProperty("players")]
        public Dictionary<string, LiveGameFeedBoxscorePlayer> Player { get; set; }

        /// <summary>
        /// Returns the NHL player id's for goalies <br/>
        /// Example: [ 8476341, 8479406 ]...
        /// </summary>
        /// 
        [JsonProperty("goalies")]
        public List<int> Goalies { get; set; }

        /// <summary>
        /// Returns the NHL player id's for skaters <br/>
        /// Example: [ 8482245, 8480801, 8480064, 8477482, 8474584, 8482116, 8480208, 8476400 ]...
        /// </summary>
        [JsonProperty("skaters")]
        public List<int> Skaters { get; set; }

        /// <summary>
        /// Returns the NHL player id's on ice <br/>
        /// Example: 8481102
        /// </summary>
        [JsonProperty("onIce")]
        public List<int> OnIce { get; set; }

        /// <summary>
        /// Returns the NHL players on ice, including player id, stamina and shift duration in seconds
        /// </summary>
        [JsonProperty("onIcePlus")]
        public List<OnIcePlus> OnIcePlus { get; set; }

        /// <summary>
        /// Returns the NHL player id's that are scratched <br/>
        /// Example: [ 8474090 ]
        /// </summary>
        [JsonProperty("scratches")]
        public List<int> Scratches { get; set; }

        /// <summary>
        /// Returns the NHL player id's in the penalty box <br/>
        /// Example: [ 8481102 ]
        /// </summary>
        [JsonProperty("penaltyBox")]
        public List<int> PenaltyBox { get; set; }

        /// <summary>
        /// Returns the coaches for the NHL team
        /// </summary>
        [JsonProperty("coaches")]
        public List<Coach> Coaches { get; set; }
    }

    public class LiveGameFeedBoxscoreHomeTeam : LiveGameFeedBoxscoreTeam
    {

    }

    public class LiveGameFeedBoxscoreAwayTeam : LiveGameFeedBoxscoreTeam
    {

    }

    public class LiveGameFeedBoxscorePlayer
    {
        /// <summary>
        /// Returns the NHL player person profile, including id, name and position information
        /// </summary>
        [JsonProperty("person")]
        public LiveGameFeedPerson Person { get; set; }

        /// <summary>
        /// Returns the jersey number for the NHL player <br/>
        /// Example: 16
        /// </summary>
        [JsonProperty("jerseyNumber")]
        public string JerseyNumber { get; set; }

        /// <summary>
        /// Returns the position information for the NHL player
        /// </summary>
        [JsonProperty("position")]
        public PrimaryPosition Position { get; set; }

        /// <summary>
        /// Returns the NHL player live game statistics
        /// </summary>
        [JsonProperty("stats")]
        public LiveGameFeedStats Stats { get; set; }
    }

    public class Boxscore
    {
        /// <summary>
        /// Returns the NHL live game feed box score teams
        /// </summary>
        [JsonProperty("teams")]
        public LiveGameFeedBoxscoreTeams Teams { get; set; }

        /// <summary>
        /// Returns the NHL live game feed officials
        /// </summary>
        [JsonProperty("officials")]
        public List<GameOfficial> Officials { get; set; }
    }

    public abstract class Decision
    {
        /// <summary>
        /// Returns the NHL player id <br/>
        /// Example: 8470638
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Returns the NHL player full name <br/>
        /// Example: Patrice Bergeron
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Returns the NHL player's NHL API link <br/>
        /// Example: /api/v1/people/8470638
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public abstract class Star
    {
        /// <summary>
        /// Returns the NHL player id <br/>
        /// Example: 8476899
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Returns the NHL player full name <br/>
        /// Example: Matt Murray
        /// </summary>
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        /// <summary>
        /// Returns the NHL player's NHL API link <br/>
        /// Example: /api/v1/people/8476899
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }
    }

    public class Winner : Decision
    {

    }

    public class Loser : Decision
    {
    }

    public class FirstStar : Star
    {

    }

    public class SecondStar : Star
    {

    }

    public class ThirdStar : Star
    {

    }

    public class Decisions
    {
        /// <summary>
        /// Returns the winner for a decision of an NHL live game feed
        /// </summary>
        [JsonProperty("winner")]
        public Winner Winner { get; set; }

        /// <summary>
        /// Returns the loser for a decision of an NHL live game feed
        /// </summary>
        [JsonProperty("loser")]
        public Loser Loser { get; set; }

        /// <summary>
        /// Returns the first star for an NHL live game feed
        /// </summary>
        [JsonProperty("firstStar")]
        public FirstStar FirstStar { get; set; }

        /// <summary>
        /// Returns the second star for an NHL live game feed
        /// </summary>
        [JsonProperty("secondStar")]
        public SecondStar SecondStar { get; set; }

        /// <summary>
        /// Returns the third star for an NHL live game feed
        /// </summary>
        [JsonProperty("thirdStar")]
        public ThirdStar ThirdStar { get; set; }
    }

    public class LiveData
    {
        /// <summary>
        /// Returns all of the NHL live game feed plays
        /// </summary>
        [JsonProperty("plays")]
        public Plays Plays { get; set; }

        /// <summary>
        /// Returns the line score of the NHL live game feed
        /// </summary>
        [JsonProperty("linescore")]
        public Linescore Linescore { get; set; }

        /// <summary>
        /// Returns the box score of the NHL live game feed
        /// </summary>
        [JsonProperty("boxscore")]
        public Boxscore Boxscore { get; set; }

        /// <summary>
        /// Returns the decisions of the NHL live game feed
        /// </summary>
        [JsonProperty("decisions")]
        public Decisions Decisions { get; set; }
    }
}
