using Nhl.Api.Common.Extensions;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

namespace Nhl.Api.Models.Player;
/// <summary>
/// The expression filter for the NHL API for player statistics, this class is used to build the expression filter for the NHL API for player statistics <br/>
/// Here is an example of how to use the PlayerFilterExpressionBuilder to build an expression filter for the NHL API for player statistics <br/>
/// <br/>
/// <code>
///  expressionFilter
///         .AddFilter(PlayerStatisticsFilter.GamesPlayed)
///         .GreaterThanOrEqualTo(25)
///         .And()
///         .AddFilter(PlayerStatisticsFilter.Goals)
///         .GreaterThan(5)
///         .And()
///         .AddFilter(PlayerStatisticsFilter.Assists)
///         .GreaterThan(10)
///         .And()
///         .AddFilter(PlayerStatisticsFilter.SkaterFullName)
///         .Contains("Ale")
///         .Build();
/// 
/// </code>
/// </summary>
public class PlayerFilterExpressionBuilder

{
    private readonly StringBuilder _filterExpression = new("factCayenneExp=");

    /// <summary>
    /// Adds a filter to the expression filter to filter by any of the returned properties
    /// </summary>
    /// <param name="playerStatisticsFilter">The player statistics filter</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder AddFilter(PlayerStatisticsFilter playerStatisticsFilter)
    {
        _filterExpression.Append($"{playerStatisticsFilter.GetEnumMemberValue()}");
        return this;
    }

    /// <summary>
    /// Adds a filter to the expression filter to filter by any of the returned properties
    /// </summary>
    /// <param name="playerRealtimeStatisticsFilter">The player statistics filter</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder AddFilter(PlayerRealtimeStatisticsFilter playerRealtimeStatisticsFilter)
    {
        _filterExpression.Append($"{playerRealtimeStatisticsFilter.GetEnumMemberValue()}");
        return this;
    }

    /// <summary>
    /// Adds a filter to the expression filter to filter by any of the returned properties
    /// </summary>
    /// <param name="playerTimeOnIceStatisticsFilter">The player statistics filter</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder AddFilter(PlayerTimeOnIceStatisticsFilter playerTimeOnIceStatisticsFilter)
    {
        _filterExpression.Append($"{playerTimeOnIceStatisticsFilter.GetEnumMemberValue()}");
        return this;
    }

    /// <summary>
    /// Adds a <code>'contains'</code> filter to the expression filter
    /// </summary>
    /// <param name="value">The value to search for</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder Contains(object value)
    {
        _filterExpression.Append($" like '%{value}%'");
        return this;
    }

    /// <summary>
    /// Adds a <code>'not contains'</code> filter to the expression filter
    /// </summary>
    /// <param name="value">The value to exclude</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder NotContains(object value)
    {
        _filterExpression.Append($" not like '%{value}%'");
        return this;
    }

    /// <summary>
    /// Adds an <code>'AND'</code> logical operator to the expression filter
    /// </summary>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder And()
    {
        _filterExpression.Append(" and ");
        return this;
    }

    /// <summary>
    /// Adds an <code>'OR'</code> logical operator to the expression filter
    /// </summary>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder Or()
    {
        _filterExpression.Append(" or ");
        return this;
    }

    /// <summary>
    /// Adds a start group <code>'('</code> to the expression filter
    /// </summary>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder StartGroup()
    {
        _filterExpression.Append("(");
        return this;
    }

    /// <summary>
    /// Adds an end group <code>')'</code> to the expression filter
    /// </summary>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder EndGroup()
    {
        _filterExpression.Append(")");
        return this;
    }

    /// <summary>
    /// Adds an <code>'equal to'</code> filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder EqualTo(object value)
    {
        if (value is string)
        {
            _filterExpression.Append($" = '{value}' ");
        }
        else
        {
            _filterExpression.Append($" = {value} ");
        }

        return this;
    }

    /// <summary>
    /// Adds a <code>'not equal to'</code> filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder NotEqualTo(object value)
    {
        if (value is string)
        {
            _filterExpression.Append($" != '{value}' ");
        }
        else
        {
            _filterExpression.Append($" != {value} ");
        }

        return this;
    }

    /// <summary>
    /// Adds a <code>'greater than'</code> filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder GreaterThan(object value)
    {
        _filterExpression.Append($" > {value} ");
        return this;
    }

    /// <summary>
    /// Adds a <code>'greater than or equal to'</code> filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder GreaterThanOrEqualTo(object value)
    {
        if (value is string)
        {
            _filterExpression.Append($" >= '{value}' ");
        }
        else
        {
            _filterExpression.Append($" >= {value} ");
        }

        return this;
    }

    /// <summary>
    /// Adds a <code>'less than'</code> filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder LessThan(object value)
    {
        if (value is string)
        {
            _filterExpression.Append($" < '{value}' ");

        }
        else
        {
            _filterExpression.Append($" < {value} ");
        }

        return this;
    }

    /// <summary>
    /// Adds a <code>'less than or equal to'</code> filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against</param>
    /// <returns>The builder to continue building the expression</returns>
    public PlayerFilterExpressionBuilder LessThanOrEqualTo(object value)
    {
        if (value is string)
        {
            _filterExpression.Append($" <= '{value}' ");
        }
        else
        {
            _filterExpression.Append($" <= {value} ");
        }

        return this;
    }

    /// <summary>
    /// Converts the expression filter to a string
    /// </summary>
    /// <returns>The expression filter as a string</returns>
    public override string ToString() => _filterExpression.ToString();

    /// <summary>
    /// Builds the expression filter for the NHL player statistics
    /// </summary>
    /// <returns>The built expression filter.</returns>
    public ExpressionPlayerFilter Build() => new ExpressionPlayerFilter(_filterExpression.ToString());

    /// <summary>
    /// An empty expression filter for the NHL player statistics
    /// </summary>
    public static ExpressionPlayerFilter Empty => new(string.Empty);
}


/// <summary>
/// A class that represents the expression filter for the NHL API for player statistics <br/>
/// See <see cref="PlayerFilterExpressionBuilder"/> for an example of how to use the expression filter for NHL players to filter results
/// </summary>
public class ExpressionPlayerFilter
{
    private readonly string _filterExpression;

    /// <summary>
    /// A class that represents the expression filter for the NHL player statistics
    /// </summary>
    public ExpressionPlayerFilter(string filterExpression)
    {
        _filterExpression = filterExpression;
    }

    /// <summary>
    /// The ToString method for the expression filter to return the raw expression for filtering <br/>
    /// See <see cref="PlayerFilterExpressionBuilder"/> for an example of how to use the expression filter
    /// </summary>
    /// <returns>The raw expression for filtering</returns>
    public override string ToString() => _filterExpression.ToString();

    /// <summary>
    /// Determines if the expression is valid based on the length of the expression
    /// </summary>
    public bool IsValidExpression => _filterExpression.Length > 15;

    /// <summary>
    /// An empty expression filter for the NHL player statistics
    /// </summary>
    public static ExpressionPlayerFilter Empty => new(string.Empty);

}

/// <summary>
/// The enumeration for the NHL player statistics information for the NHL API for player statistics
/// </summary>
public enum PlayerStatisticsFilter
{
    /// <summary>
    /// Assists
    /// </summary>
    [Description("assists")]
    [EnumMember(Value = "assists")]
    Assists,

    /// <summary>
    /// Even goals
    /// </summary>
    [Description("evGoals")]
    [EnumMember(Value = "evGoals")]
    EvenGoals,

    /// <summary>
    /// Even points
    /// </summary>
    [Description("evPoints")]
    [EnumMember(Value = "evPoints")]
    EvenPoints,

    /// <summary>
    /// Faceoff win percentage
    /// </summary>
    [Description("faceoffWinPct")]
    [EnumMember(Value = "faceoffWinPct")]
    FaceoffWinPercentage,

    /// <summary>
    /// Game-winning goals
    /// </summary>
    [Description("gameWinningGoals")]
    [EnumMember(Value = "gameWinningGoals")]
    GameWinningGoals,

    /// <summary>
    /// Games played
    /// </summary>
    [Description("gamesPlayed")]
    [EnumMember(Value = "gamesPlayed")]
    GamesPlayed,

    /// <summary>
    /// Goals
    /// </summary>
    [Description("goals")]
    [EnumMember(Value = "goals")]
    Goals,

    /// <summary>
    /// Last name
    /// </summary>
    [Description("lastName")]
    [EnumMember(Value = "lastName")]
    LastName,

    /// <summary>
    /// Overtime goals
    /// </summary>
    [Description("otGoals")]
    [EnumMember(Value = "otGoals")]
    OvertimeGoals,

    /// <summary>
    /// Penalty minutes
    /// </summary>
    [Description("penaltyMinutes")]
    [EnumMember(Value = "penaltyMinutes")]
    PenaltyMinutes,

    /// <summary>
    /// Player ID
    /// </summary>
    [Description("playerId")]
    [EnumMember(Value = "playerId")]
    PlayerId,

    /// <summary>
    /// Plus-minus
    /// </summary>
    [Description("plusMinus")]
    [EnumMember(Value = "plusMinus")]
    PlusMinus,

    /// <summary>
    /// Points
    /// </summary>
    [Description("points")]
    [EnumMember(Value = "points")]
    Points,

    /// <summary>
    /// Points per game
    /// </summary>
    [Description("pointsPerGame")]
    [EnumMember(Value = "pointsPerGame")]
    PointsPerGame,

    /// <summary>
    /// Position code
    /// </summary>
    [Description("positionCode")]
    [EnumMember(Value = "positionCode")]
    PositionCode,

    /// <summary>
    /// Power play goals
    /// </summary>
    [Description("ppGoals")]
    [EnumMember(Value = "ppGoals")]
    PowerPlayGoals,

    /// <summary>
    /// Power play points
    /// </summary>
    [Description("ppPoints")]
    [EnumMember(Value = "ppPoints")]
    PowerPlayPoints,

    /// <summary>
    /// Season ID
    /// </summary>
    [Description("seasonId")]
    [EnumMember(Value = "seasonId")]
    SeasonIdentifier,

    /// <summary>
    /// Short-handed goals
    /// </summary>
    [Description("shGoals")]
    [EnumMember(Value = "shGoals")]
    ShortHandedGoals,

    /// <summary>
    /// Short-handed points
    /// </summary>
    [Description("shPoints")]
    [EnumMember(Value = "shPoints")]
    ShortHandedPoints,

    /// <summary>
    /// Shooting percentage
    /// </summary>
    [Description("shootingPct")]
    [EnumMember(Value = "shootingPct")]
    ShootingPercentage,

    /// <summary>
    /// Shoots/Catches
    /// </summary>
    [Description("shootsCatches")]
    [EnumMember(Value = "shootsCatches")]
    ShootsCatches,

    /// <summary>
    /// Shots
    /// </summary>
    [Description("shots")]
    [EnumMember(Value = "shots")]
    Shots,

    /// <summary>
    /// Skater full name
    /// </summary>
    [Description("skaterFullName")]
    [EnumMember(Value = "skaterFullName")]
    SkaterFullName,

    /// <summary>
    /// Team abbreviations
    /// </summary>
    [Description("teamAbbrevs")]
    [EnumMember(Value = "teamAbbrevs")]
    TeamAbbreviation,

    /// <summary>
    /// Time on ice per game
    /// </summary>
    [Description("timeOnIcePerGame")]
    [EnumMember(Value = "timeOnIcePerGame")]
    TimeOnIcePerGame,

    /// <summary>
    /// Weight
    /// </summary>
    [Description("weight")]
    [EnumMember(Value = "weight")]
    Weight
}

/// <summary>
/// The enumeration for the NHL player statistics information for the NHL API for realtime player statistics
/// </summary>
public enum PlayerRealtimeStatisticsFilter
{
    /// <summary>
    /// Blocked shots
    /// </summary>
    [Description("blockedShots")]
    [EnumMember(Value = "blockedShots")]
    BlockedShots,

    /// <summary>
    /// Blocked shots per 60 minutes
    /// </summary>
    [Description("blockedShotsPer60")]
    [EnumMember(Value = "blockedShotsPer60")]
    BlockedShotsPer60,

    /// <summary>
    /// Empty net assists
    /// </summary>
    [Description("emptyNetAssists")]
    [EnumMember(Value = "emptyNetAssists")]
    EmptyNetAssists,

    /// <summary>
    /// Empty net goals
    /// </summary>
    [Description("emptyNetGoals")]
    [EnumMember(Value = "emptyNetGoals")]
    EmptyNetGoals,

    /// <summary>
    /// Empty net points
    /// </summary>
    [Description("emptyNetPoints")]
    [EnumMember(Value = "emptyNetPoints")]
    EmptyNetPoints,

    /// <summary>
    /// First goals
    /// </summary>
    [Description("firstGoals")]
    [EnumMember(Value = "firstGoals")]
    FirstGoals,

    /// <summary>
    /// Games played
    /// </summary>
    [Description("gamesPlayed")]
    [EnumMember(Value = "gamesPlayed")]
    GamesPlayed,

    /// <summary>
    /// Giveaways
    /// </summary>
    [Description("giveaways")]
    [EnumMember(Value = "giveaways")]
    Giveaways,

    /// <summary>
    /// Giveaways per 60 minutes
    /// </summary>
    [Description("giveawaysPer60")]
    [EnumMember(Value = "giveawaysPer60")]
    GiveawaysPer60,

    /// <summary>
    /// Hits
    /// </summary>
    [Description("hits")]
    [EnumMember(Value = "hits")]
    Hits,

    /// <summary>
    /// Hits per 60 minutes
    /// </summary>
    [Description("hitsPer60")]
    [EnumMember(Value = "hitsPer60")]
    HitsPer60,

    /// <summary>
    /// Last name
    /// </summary>
    [Description("lastName")]
    [EnumMember(Value = "lastName")]
    LastName,

    /// <summary>
    /// Missed shot crossbar
    /// </summary>
    [Description("missedShotCrossbar")]
    [EnumMember(Value = "missedShotCrossbar")]
    MissedShotCrossbar,

    /// <summary>
    /// Missed shot goalpost
    /// </summary>
    [Description("missedShotGoalpost")]
    [EnumMember(Value = "missedShotGoalpost")]
    MissedShotGoalpost,

    /// <summary>
    /// Missed shot over net
    /// </summary>
    [Description("missedShotOverNet")]
    [EnumMember(Value = "missedShotOverNet")]
    MissedShotOverNet,

    /// <summary>
    /// Missed shot short
    /// </summary>
    [Description("missedShotShort")]
    [EnumMember(Value = "missedShotShort")]
    MissedShotShort,

    /// <summary>
    /// Missed shot wide of net
    /// </summary>
    [Description("missedShotWideOfNet")]
    [EnumMember(Value = "missedShotWideOfNet")]
    MissedShotWideOfNet,

    /// <summary>
    /// Missed shots
    /// </summary>
    [Description("missedShots")]
    [EnumMember(Value = "missedShots")]
    MissedShots,

    /// <summary>
    /// Overtime goals
    /// </summary>
    [Description("otGoals")]
    [EnumMember(Value = "otGoals")]
    OvertimeGoals,

    /// <summary>
    /// Player ID
    /// </summary>
    [Description("playerId")]
    [EnumMember(Value = "playerId")]
    PlayerId,

    /// <summary>
    /// Position code
    /// </summary>
    [Description("positionCode")]
    [EnumMember(Value = "positionCode")]
    PositionCode,

    /// <summary>
    /// Season ID
    /// </summary>
    [Description("seasonId")]
    [EnumMember(Value = "seasonId")]
    SeasonId,

    /// <summary>
    /// Shoots/Catches
    /// </summary>
    [Description("shootsCatches")]
    [EnumMember(Value = "shootsCatches")]
    ShootsCatches,

    /// <summary>
    /// Shot attempts blocked
    /// </summary>
    [Description("shotAttemptsBlocked")]
    [EnumMember(Value = "shotAttemptsBlocked")]
    ShotAttemptsBlocked,

    /// <summary>
    /// Skater full name
    /// </summary>
    [Description("skaterFullName")]
    [EnumMember(Value = "skaterFullName")]
    SkaterFullName,

    /// <summary>
    /// Takeaways
    /// </summary>
    [Description("takeaways")]
    [EnumMember(Value = "takeaways")]
    Takeaways,

    /// <summary>
    /// Takeaways per 60 minutes
    /// </summary>
    [Description("takeawaysPer60")]
    [EnumMember(Value = "takeawaysPer60")]
    TakeawaysPer60,

    /// <summary>
    /// Team abbreviations
    /// </summary>
    [Description("teamAbbrevs")]
    [EnumMember(Value = "teamAbbrevs")]
    TeamAbbreviation,

    /// <summary>
    /// Time on ice per game
    /// </summary>
    [Description("timeOnIcePerGame")]
    [EnumMember(Value = "timeOnIcePerGame")]
    TimeOnIcePerGame

}

/// <summary>
/// The enumeration for the NHL player statistics information for the NHL API for player statistics for time on ice
/// </summary>
public enum PlayerTimeOnIceStatisticsFilter
{
    /// <summary>
    /// Even time on ice
    /// </summary>
    [Description("evTimeOnIce")]
    [EnumMember(Value = "evTimeOnIce")]
    EvenTimeOnIce,

    /// <summary>
    /// Even time on ice per game
    /// </summary>
    [Description("evTimeOnIcePerGame")]
    [EnumMember(Value = "evTimeOnIcePerGame")]
    EvenTimeOnIcePerGame,

    /// <summary>
    /// Games played
    /// </summary>
    [Description("gamesPlayed")]
    [EnumMember(Value = "gamesPlayed")]
    GamesPlayed,

    /// <summary>
    /// Last name
    /// </summary>
    [Description("lastName")]
    [EnumMember(Value = "lastName")]
    LastName,

    /// <summary>
    /// Overtime time on ice
    /// </summary>
    [Description("otTimeOnIce")]
    [EnumMember(Value = "otTimeOnIce")]
    OvertimeTimeOnIce,

    /// <summary>
    /// Overtime time on ice per overtime game
    /// </summary>
    [Description("otTimeOnIcePerOtGame")]
    [EnumMember(Value = "otTimeOnIcePerOtGame")]
    OvertimeTimeOnIcePerOvertimeGame,

    /// <summary>
    /// Player ID
    /// </summary>
    [Description("playerId")]
    [EnumMember(Value = "playerId")]
    PlayerId,

    /// <summary>
    /// Position code
    /// </summary>
    [Description("positionCode")]
    [EnumMember(Value = "positionCode")]
    PositionCode,

    /// <summary>
    /// Power play time on ice
    /// </summary>
    [Description("ppTimeOnIce")]
    [EnumMember(Value = "ppTimeOnIce")]
    PowerPlayTimeOnIce,

    /// <summary>
    /// Power play time on ice per game
    /// </summary>
    [Description("ppTimeOnIcePerGame")]
    [EnumMember(Value = "ppTimeOnIcePerGame")]
    PowerPlayTimeOnIcePerGame,

    /// <summary>
    /// Season ID
    /// </summary>
    [Description("seasonId")]
    [EnumMember(Value = "seasonId")]
    SeasonId,

    /// <summary>
    /// Short-handed time on ice
    /// </summary>
    [Description("shTimeOnIce")]
    [EnumMember(Value = "shTimeOnIce")]
    ShortHandedTimeOnIce,

    /// <summary>
    /// Short-handed time on ice per game
    /// </summary>
    [Description("shTimeOnIcePerGame")]
    [EnumMember(Value = "shTimeOnIcePerGame")]
    ShortHandedTimeOnIcePerGame,

    /// <summary>
    /// Shifts
    /// </summary>
    [Description("shifts")]
    [EnumMember(Value = "shifts")]
    Shifts,

    /// <summary>
    /// Shifts per game
    /// </summary>
    [Description("shiftsPerGame")]
    [EnumMember(Value = "shiftsPerGame")]
    ShiftsPerGame,

    /// <summary>
    /// Shoots/Catches
    /// </summary>
    [Description("shootsCatches")]
    [EnumMember(Value = "shootsCatches")]
    ShootsCatches,

    /// <summary>
    /// Skater full name
    /// </summary>
    [Description("skaterFullName")]
    [EnumMember(Value = "skaterFullName")]
    SkaterFullName,

    /// <summary>
    /// Team abbreviations
    /// </summary>
    [Description("teamAbbrevs")]
    [EnumMember(Value = "teamAbbrevs")]
    TeamAbbreviation,

    /// <summary>
    /// Time on ice
    /// </summary>
    [Description("timeOnIce")]
    [EnumMember(Value = "timeOnIce")]
    TimeOnIce,

    /// <summary>
    /// Time on ice per game
    /// </summary>
    [Description("timeOnIcePerGame")]
    [EnumMember(Value = "timeOnIcePerGame")]
    TimeOnIcePerGame,

    /// <summary>
    /// Time on ice per shift
    /// </summary>
    [Description("timeOnIcePerShift")]
    [EnumMember(Value = "timeOnIcePerShift")]
    TimeOnIcePerShift
}
