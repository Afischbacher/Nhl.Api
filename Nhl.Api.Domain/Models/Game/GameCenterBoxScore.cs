using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Nhl.Api.Models.Game;

/// <summary>
/// The NHL game center box score for the away team
/// </summary>
public class GameCenterBoxScoreAwayTeam
{
    /// <summary>
    /// The NHL team identifier for the away team <br/>
    /// Example: 10 - Toronto Maple Leafs
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL away team name <br/>
    /// Example: Wild
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL away team abbreviation <br/>
    /// Example: MIN
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// The NHL away team score <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The NHL away team shots on goal <br/>
    /// Example: 30
    /// </summary>
    [JsonProperty("sog")]
    public int Sog { get; set; }

    /// <summary>
    /// The NHL away team faceoff winning percentage <br/>
    /// Example: 72.7
    /// </summary>
    [JsonProperty("faceoffWinningPctg")]
    public double FaceoffWinningPctg { get; set; }

    /// <summary>
    /// The NHL away team power play conversion ratio <br/>
    /// Example: 2/5
    /// </summary>
    [JsonProperty("powerPlayConversion")]
    public string PowerPlayConversion { get; set; }

    /// <summary>
    /// The NHL away team penalty minutes <br/>
    /// Example: 8
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The NHL away team hits <br/>
    /// Example: 20
    /// </summary>
    [JsonProperty("hits")]
    public int Hits { get; set; }

    /// <summary>
    /// The NHL away team blocks <br/>
    /// Example: 10
    /// </summary>
    [JsonProperty("blocks")]
    public int Blocks { get; set; }

    /// <summary>
    /// The NHL away team logo <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/MIN_light.svg">https://assets.nhle.com/logos/nhl/svg/MIN_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// The NHL away team forwards
    /// </summary>
    [JsonProperty("forwards")]
    public List<GameCenterBoxScoreForward> Forwards { get; set; }

    /// <summary>
    /// The NHL away team defense
    /// </summary>
    [JsonProperty("defense")]
    public List<GameCenterBoxScoreDefense> Defense { get; set; }

    /// <summary>
    /// The NHL away team goalies
    /// </summary>
    [JsonProperty("goalies")]
    public List<GameCenterBoxScoreGoalie> Goalies { get; set; }

    /// <summary>
    /// The NHL away team head coach
    /// </summary>
    [JsonProperty("headCoach")]
    public HeadCoach HeadCoach { get; set; }

    /// <summary>
    /// The NHL away team scratches
    /// </summary>
    [JsonProperty("scratches")]
    public List<Scratch> Scratches { get; set; }
}

/// <summary>
/// The NHL game center box score information for the game
/// </summary>
public class Boxscore
{
    /// <summary>
    /// The NHL game center box score line score
    /// </summary>
    [JsonProperty("linescore")]
    public Linescore Linescore { get; set; }

    /// <summary>
    /// The NHL game center box score game shots by period
    /// </summary>
    [JsonProperty("shotsByPeriod")]
    public List<ShotsByPeriod> ShotsByPeriod { get; set; }

    /// <summary>
    /// The NHL game center box score game game reports
    /// </summary>
    [JsonProperty("gameReports")]
    public GameReports GameReports { get; set; }

    /// <summary>
    /// The NHL game center box score game information
    /// </summary>
    [JsonProperty("gameInfo")]
    public GameInfo GameInfo { get; set; }

    /// <summary>
    /// The NHL game center box score team game statistics
    /// </summary>
    [JsonProperty("teamGameStats")]
    public List<TeamGameStatistics> TeamGameStatistics { get; set; }

    /// <summary>
    /// The NHL season series information for the 2 teams
    /// </summary>
    [JsonProperty("seasonSeries")]
    public List<SeasonSeries> SeasonSeries { get; set; }

    /// <summary>
    /// The NHL game season series wins between both teams
    /// </summary>
    [JsonProperty("seasonSeriesWins")]
    public SeasonSeriesWins SeasonSeriesWins { get; set; }
}

/// <summary>
/// The NHL game center box score team game statistics
/// </summary>
public class TeamGameStatistics
{
    /// <summary>
    /// The category for the team game statistics <br/>
    /// Example: sog - Shots on Goal
    /// </summary>
    [JsonProperty("category")]
    public string Category { get; set; }

    /// <summary>
    /// The NHL away team game statistics value <br/>
    /// Example: 30
    /// </summary>
    [JsonProperty("awayValue")]
    public object AwayValue { get; set; }

    /// <summary>
    /// The NHL home team game statistics value <br/>
    /// Example: 26
    /// </summary>
    [JsonProperty("homeValue")]
    public object HomeValue { get; set; }
}


/// <summary>
/// The NHL game center box score game defense player information
/// </summary>
public class GameCenterBoxScoreDefense
{
    /// <summary>
    /// The NHL player identifier for the defense player <br/>
    /// Example: 8474716 - Jared Spurgeon
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL defense player sweater number <br/>
    /// Example: 46
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int SweaterNumber { get; set; }

    /// <summary>
    /// The NHL defense player name <br/>
    /// Example: J. Spurgeon
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL defense player position <br/>
    /// Example: D
    /// </summary>
    [JsonProperty("position")]
    public string Position { get; set; }

    /// <summary>
    /// The NHL defense player goals <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The NHL defense player assists <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The NHL defense player points <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The NHL defense player plus minus <br/>
    /// Example: -1
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The NHL defense player penalty minutes <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The NHL defense player hits <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("hits")]
    public int Hits { get; set; }

    /// <summary>
    /// The NHL defense player blocked shots <br/>
    /// Example: 3
    /// </summary>
    [JsonProperty("blockedShots")]
    public int BlockedShots { get; set; }

    /// <summary>
    /// The NHL defense player power play goals <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public int PowerPlayGoals { get; set; }

    /// <summary>
    /// The NHL defense player power play points <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("powerPlayPoints")]
    public int PowerPlayPoints { get; set; }

    /// <summary>
    /// The NHL defense player shorthanded goals <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("shorthandedGoals")]
    public int ShorthandedGoals { get; set; }

    /// <summary>
    /// The NHL defense player shorthanded points <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("shPoints")]
    public int ShPoints { get; set; }

    /// <summary>
    /// The NHL defense player shots <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The NHL defense player faceoffs <br/>
    /// Example: 0/0
    /// </summary>
    [JsonProperty("faceoffs")]
    public string Faceoffs { get; set; }

    /// <summary>
    /// The NHL defense player faceoff winning percentage <br/>
    /// Example: 70.59
    /// </summary>
    [JsonProperty("faceoffWinningPctg")]
    public double FaceoffWinningPctg { get; set; }

    /// <summary>
    /// The NHL defense player time on ice <br/>
    /// Example: 14:34
    /// </summary>
    [JsonProperty("toi")]
    public string Toi { get; set; }

    /// <summary>
    /// The NHL defense player power play time on ice <br/>
    /// Example: 02:12
    /// </summary>
    [JsonProperty("powerPlayToi")]
    public string PowerPlayToi { get; set; }

    /// <summary>
    /// The NHL defense player shorthanded time on ice <br/>
    /// Example: 01:02
    /// </summary>
    [JsonProperty("shorthandedToi")]
    public string ShorthandedToi { get; set; }
}

/// <summary>
/// The NHL forward player information for the game
/// </summary>
public class GameCenterBoxScoreForward
{
    /// <summary>
    /// The NHL player identifier for the forward player <br/>
    /// Example: 8471214 - Alexander Ovechkin
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL forward player sweater number <br/>
    /// Example: 8
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int SweaterNumber { get; set; }

    /// <summary>
    /// The NHL forward player name <br/>
    /// Example: A. Ovechkin
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL forward player position <br/>
    /// Example: LW
    /// </summary>
    [JsonProperty("position")]
    public string Position { get; set; }

    /// <summary>
    /// The NHL forward player goals <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("goals")]
    public int Goals { get; set; }

    /// <summary>
    /// The NHL forward player assists <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("assists")]
    public int Assists { get; set; }

    /// <summary>
    /// The NHL forward player points <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("points")]
    public int Points { get; set; }

    /// <summary>
    /// The NHL forward player plus minus <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("plusMinus")]
    public int PlusMinus { get; set; }

    /// <summary>
    /// The NHL forward player penalty minutes <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The NHL forward player hits <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("hits")]
    public int Hits { get; set; }

    /// <summary>
    /// The NHL forward player blocked shots <br/>
    /// Example: 0 
    /// </summary>
    [JsonProperty("blockedShots")]
    public int BlockedShots { get; set; }

    /// <summary>
    /// The NHL forward player power play goals <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("powerPlayGoals")]
    public int PowerPlayGoals { get; set; }

    /// <summary>
    /// The NHL forward player power play points <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("powerPlayPoints")]
    public int PowerPlayPoints { get; set; }

    /// <summary>
    /// The NHL forward player shorthanded goals <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("shorthandedGoals")]
    public int ShorthandedGoals { get; set; }

    /// <summary>
    /// The NHL forward player shorthanded points <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("shPoints")]
    public int ShPoints { get; set; }

    /// <summary>
    /// The NHL forward player shots <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("shots")]
    public int Shots { get; set; }

    /// <summary>
    /// The NHL forward player faceoffs <br/>
    /// Example: 2/5
    /// </summary>
    [JsonProperty("faceoffs")]
    public string Faceoffs { get; set; }

    /// <summary>
    /// The NHL forward player faceoff winning percentage <br/>
    /// Example: 45.32
    /// </summary>
    [JsonProperty("faceoffWinningPctg")]
    public double FaceoffWinningPctg { get; set; }

    /// <summary>
    /// The NHL forward player time on ice <br/>
    /// Example: 18:34
    /// </summary>
    [JsonProperty("toi")]
    public string Toi { get; set; }

    /// <summary>
    /// The NHL forward player power play time on ice <br/>
    /// Example: 02:12
    /// </summary>
    [JsonProperty("powerPlayToi")]
    public string PowerPlayToi { get; set; }

    /// <summary>
    /// The NHL forward player shorthanded time on ice <br/>
    /// Example: 01:02
    /// </summary>
    [JsonProperty("shorthandedToi")]
    public string ShorthandedToi { get; set; }
}

/// <summary>
/// The NHL game center box score game information
/// </summary>
public class GameCenterBoxScoreGameInfo
{
    /// <summary>
    /// The NHL game referee information
    /// </summary>
    [JsonProperty("referees")]
    public List<Referee> Referees { get; set; }

    /// <summary>
    /// The NHL game linesmen information
    /// </summary>
    [JsonProperty("linesmen")]
    public List<Linesman> Linesmen { get; set; }

    /// <summary>
    /// The NHL away team information
    /// </summary>
    [JsonProperty("awayTeam")]
    public GameCenterBoxScoreAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL home team information
    /// </summary>
    [JsonProperty("homeTeam")]
    public GameCenterBoxScoreHomeTeam HomeTeam { get; set; }
}

/// <summary>
/// The NHL game center box score game report links
/// </summary>
public class GameReports
{
    /// <summary>
    /// The NHL game center box score game summary link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/GS020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/GS020206.HTM</a>
    /// </summary>
    [JsonProperty("gameSummary")]
    public string GameSummary { get; set; }

    /// <summary>
    /// The NHL game center box score event summary link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/ES020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/ES020206.HTM</a>
    /// </summary>
    [JsonProperty("eventSummary")]
    public string EventSummary { get; set; }

    /// <summary>
    /// The NHL game center box score play by play link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/PL020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/PL020206.HTM</a>
    /// </summary>
    [JsonProperty("playByPlay")]
    public string PlayByPlay { get; set; }

    /// <summary>
    /// The NHL game center box score faceoff summary link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/FS020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/FS020206.HTM</a>
    /// </summary>
    [JsonProperty("faceoffSummary")]
    public string FaceoffSummary { get; set; }

    /// <summary>
    /// The NHL game center box score faceoff comparison link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/FC020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/FC020206.HTM</a>
    /// </summary>
    [JsonProperty("faceoffComparison")]
    public string FaceoffComparison { get; set; }

    /// <summary>
    /// The NHL game center box score roster summary link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/RO020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/RO020206.HTM</a>
    /// </summary>
    [JsonProperty("rosters")]
    public string Rosters { get; set; }

    /// <summary>
    /// The NHL game center box score shot summary link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/SS020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/SS020206.HTM</a>
    /// </summary>
    [JsonProperty("shotSummary")]
    public string ShotSummary { get; set; }

    /// <summary>
    /// The NHL game center box score shift chart link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/SC020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/SC020206.HTM</a>
    /// </summary>
    [JsonProperty("shiftChart")]
    public string ShiftChart { get; set; }

    /// <summary>
    /// The NHL game center box score total time on ice away report link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/TV020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/TV020206.HTM</a>
    /// </summary>
    [JsonProperty("toiAway")]
    public string ToiAway { get; set; }

    /// <summary>
    /// The NHL game center box score total time on ice home report link <br/>
    /// Example: <a href="https://www.nhl.com/scores/htmlreports/20232024/TH020206.HTM">https://www.nhl.com/scores/htmlreports/20232024/TH020206.HTM</a>
    /// </summary>
    [JsonProperty("toiHome")]
    public string ToiHome { get; set; }
}


/// <summary>
/// The NHL game center box score goalie information
/// </summary>
public class GameCenterBoxScoreGoalie
{
    /// <summary>
    /// The NHL player identifier for the goalie <br/>
    /// Example: 8477424 - JuuseSaros
    /// </summary>
    [JsonProperty("playerId")]
    public int PlayerId { get; set; }

    /// <summary>
    /// The NHL goalie sweater number <br/>
    /// Example: 74
    /// </summary>
    [JsonProperty("sweaterNumber")]
    public int SweaterNumber { get; set; }

    /// <summary>
    /// The NHL goalie name <br/>
    /// Example: J. Saros
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL goalie position <br/>
    /// Example: G
    /// </summary>
    [JsonProperty("position")]
    public string Position { get; set; }

    /// <summary>
    /// The NHL goalie even strength shots against <br/>
    /// Example: 20/22
    /// </summary>
    [JsonProperty("evenStrengthShotsAgainst")]
    public string EvenStrengthShotsAgainst { get; set; }

    /// <summary>
    /// The NHL goalie power play shots against <br/>
    /// Example: 4/4
    /// </summary>
    [JsonProperty("powerPlayShotsAgainst")]
    public string PowerPlayShotsAgainst { get; set; }

    /// <summary>
    /// The NHL goalie shorthanded shots against <br/>
    /// Example: 0/0
    /// </summary>
    [JsonProperty("shorthandedShotsAgainst")]
    public string ShorthandedShotsAgainst { get; set; }

    /// <summary>
    /// The NHL goalie shots against <br/>
    /// Example: 24/26
    /// </summary>
    [JsonProperty("saveShotsAgainst")]
    public string SaveShotsAgainst { get; set; }

    /// <summary>
    /// The NHL even strength goals against <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("evenStrengthGoalsAgainst")]
    public int EvenStrengthGoalsAgainst { get; set; }

    /// <summary>
    /// The NHL power play goals against <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("powerPlayGoalsAgainst")]
    public int PowerPlayGoalsAgainst { get; set; }

    /// <summary>
    /// The NHL shorthanded goals against <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("shorthandedGoalsAgainst")]
    public int ShorthandedGoalsAgainst { get; set; }

    /// <summary>
    /// The NHL goalie penalty minutes <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The NHL goals against <br/>
    /// Example: 2
    /// </summary>
    [JsonProperty("goalsAgainst")]
    public int GoalsAgainst { get; set; }

    /// <summary>
    /// The NHL goalie total time on ice <br/>
    /// Example: 59:58
    /// </summary>
    [JsonProperty("toi")]
    public string Toi { get; set; }

    /// <summary>
    /// The NHL goalie save percentage <br/>
    /// Example: 0.923
    /// </summary>

    [JsonProperty("savePctg")]
    public string SavePctg { get; set; }
}

/// <summary>
/// The NHL game center box score home team information
/// </summary>
public class GameCenterBoxScoreHomeTeam
{
    /// <summary>
    /// The NHL home team identifier <br/>
    /// Example: 24 - Washington Capitals
    /// </summary>
    [JsonProperty("id")]
    public int Id { get; set; }

    /// <summary>
    /// The NHL home team name <br/>
    /// Example: Capitals
    /// </summary>
    [JsonProperty("name")]
    public Name Name { get; set; }

    /// <summary>
    /// The NHL home team abbreviation <br/>
    /// Example: WSH
    /// </summary>
    [JsonProperty("abbrev")]
    public string Abbrev { get; set; }

    /// <summary>
    /// The NHL home team score <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("score")]
    public int Score { get; set; }

    /// <summary>
    /// The NHL home team shots on goal <br/>
    /// Example: 26
    /// </summary>
    [JsonProperty("sog")]
    public int Sog { get; set; }

    /// <summary>
    /// The NHL home team faceoff winning percentage <br/>
    /// Example: 49.2
    /// </summary>
    [JsonProperty("faceoffWinningPctg")]
    public double FaceoffWinningPctg { get; set; }

    /// <summary>
    /// The NHL home team power play conversion ratio <br/>
    /// Example: 1/4
    /// </summary>
    [JsonProperty("powerPlayConversion")]
    public string PowerPlayConversion { get; set; }

    /// <summary>
    /// The NHL home team penalty minutes <br/>
    /// Example: 4
    /// </summary>
    [JsonProperty("pim")]
    public int Pim { get; set; }

    /// <summary>
    /// The NHL home team hits <br/>
    /// Example: 20
    /// </summary>
    [JsonProperty("hits")]
    public int Hits { get; set; }

    /// <summary>
    /// The NHL home team blocks <br/>
    /// Example: 10
    /// </summary>
    [JsonProperty("blocks")]
    public int Blocks { get; set; }

    /// <summary>
    /// The NHL home team logo <br/>
    /// Example: <a href="https://assets.nhle.com/logos/nhl/svg/WSH_light.svg">https://assets.nhle.com/logos/nhl/svg/WSH_light.svg</a>
    /// </summary>
    [JsonProperty("logo")]
    public string Logo { get; set; }

    /// <summary>
    /// The NHL home team forwards
    /// </summary>
    [JsonProperty("forwards")]
    public List<GameCenterBoxScoreForward> Forwards { get; set; }

    /// <summary>
    /// The NHL home team defense
    /// </summary>
    [JsonProperty("defense")]
    public List<GameCenterBoxScoreDefense> Defense { get; set; }

    /// <summary>
    /// The NHL home team goalies
    /// </summary>
    [JsonProperty("goalies")]
    public List<GameCenterBoxScoreGoalie> Goalies { get; set; }

    /// <summary>
    /// The NHL home team head coach
    /// </summary>
    [JsonProperty("headCoach")]
    public HeadCoach HeadCoach { get; set; }

    /// <summary>
    /// The NHL home team scratches
    /// </summary>
    [JsonProperty("scratches")]
    public List<Scratch> Scratches { get; set; }
}

/// <summary>
/// The NHL game center player by game statistics per team
/// </summary>
public class PlayerByGameStats
{
    /// <summary>
    /// The NHL game center player by game statistics for the away team
    /// </summary>
    [JsonProperty("awayTeam")]
    public GameCenterBoxScoreAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL game center player by game statistics for the home team
    /// </summary>
    [JsonProperty("homeTeam")]
    public GameCenterBoxScoreHomeTeam HomeTeam { get; set; }
}

/// <summary>
/// The NHL game center box score game information
/// </summary>
public class GameCenterBoxScore
{
    /// <summary>
    /// The NHL game identifier <br/>
    /// Example: 2020020206
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
    public string GameDate { get; set; }

    /// <summary>
    /// The information about the NHL game venue
    /// </summary>
    [JsonProperty("venue")]
    public Venue Venue { get; set; }

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
    public string EasternUTCOffset { get; set; }

    /// <summary>
    /// The venue UTC offset for the NHL game <br/>
    /// Example: -5:00
    /// </summary>
    [JsonProperty("venueUTCOffset")]
    public string VenueUTCOffset { get; set; }

    /// <summary>
    /// The NHL game TV broadcast statuses
    /// </summary>
    [JsonProperty("tvBroadcasts")]
    public List<TvBroadcast> TvBroadcasts { get; set; }

    /// <summary>
    /// The NHL game state for the game <br/>
    /// Example: OFF
    /// </summary>
    [JsonProperty("gameState")]
    public string GameState { get; set; }

    /// <summary>
    /// The NHL game schedule state for the game <br/>
    /// Example: OK
    /// </summary>
    [JsonProperty("gameScheduleState")]
    public string GameScheduleState { get; set; }

    /// <summary>
    /// The NHL period number for the game <br/>
    /// Example: 1
    /// </summary>  
    [JsonProperty("period")]
    public int Period { get; set; }

    /// <summary>
    /// The NHL period description for the game
    /// </summary>
    [JsonProperty("periodDescriptor")]
    public PeriodDescriptor PeriodDescriptor { get; set; }

    /// <summary>
    /// The NHL game center box score away team information
    /// </summary>
    [JsonProperty("awayTeam")]
    public GameCenterBoxScoreAwayTeam AwayTeam { get; set; }

    /// <summary>
    /// The NHL game center box score home team information
    /// </summary>
    [JsonProperty("homeTeam")]
    public GameCenterBoxScoreHomeTeam HomeTeam { get; set; }

    /// <summary>
    /// The NHL game center box score clock information
    /// </summary>
    [JsonProperty("clock")]
    public Clock Clock { get; set; }

    /// <summary>
    /// The NHL game center box score game player statistics for the game
    /// </summary>
    [JsonProperty("playerByGameStats")]
    public PlayerByGameStats PlayerByGameStatistics { get; set; }

    /// <summary>
    /// The NHL game center box score information
    /// </summary>
    [JsonProperty("summary")]
    public Boxscore Boxscore { get; set; }

    /// <summary>
    /// The NHL game center box score game outcome information
    /// </summary>
    [JsonProperty("gameOutcome")]
    public GameOutcome GameOutcome { get; set; }

    /// <summary>
    /// The NHL game center box score game video information
    /// </summary>
    [JsonProperty("gameVideo")]
    public GameVideo GameVideo { get; set; }
}

/// <summary>
/// The NHL game center box score line score information
/// </summary>
public class Linescore
{
    /// <summary>
    /// The NHL game center box score break down by period 
    /// </summary>
    [JsonProperty("byPeriod")]
    public List<ByPeriod> ByPeriod { get; set; }

    /// <summary>
    /// The NHL game center box score team totals
    /// </summary>
    [JsonProperty("totals")]
    public Totals Totals { get; set; }
}

/// <summary>
/// The NHL game home versus away season series wins
/// </summary>
public class SeasonSeriesWins
{
    /// <summary>
    /// The number of away team wins for the NHL game <br/>
    /// Example: 0
    /// </summary>
    [JsonProperty("awayTeamWins")]
    public int AwayTeamWins { get; set; }

    /// <summary>
    /// The number of home team wins for the NHL game <br/>
    /// Example: 1
    /// </summary>
    [JsonProperty("homeTeamWins")]
    public int HomeTeamWins { get; set; }
}
