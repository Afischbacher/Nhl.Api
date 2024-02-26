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
    /// Adds a filter to the expression filter to filter by any of the returned properties.
    /// </summary>
    /// <param name="playerStatisticsFilter">The player statistics filter.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder AddFilter(PlayerStatisticsFilter playerStatisticsFilter)
    {
        _filterExpression.Append($"{playerStatisticsFilter.GetEnumMemberValue()}");
        return this;
    }

    /// <summary>
    /// Adds a 'contains' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to search for.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder Contains(object value)
    {
        _filterExpression.Append($" like '%{value}%'");
        return this;
    }

    /// <summary>
    /// Adds a 'not contains' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to exclude.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder NotContains(object value)
    {
        _filterExpression.Append($" not like '%{value}%'");
        return this;
    }

    /// <summary>
    /// Adds an 'AND' logical operator to the expression filter.
    /// </summary>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder And()
    {
        _filterExpression.Append(" and ");
        return this;
    }

    /// <summary>
    /// Adds an 'OR' logical operator to the expression filter.
    /// </summary>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder Or()
    {
        _filterExpression.Append(" or ");
        return this;
    }

    /// <summary>
    /// Adds a start group '(' to the expression filter.
    /// </summary>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder StartGroup()
    {
        _filterExpression.Append("(");
        return this;
    }

    /// <summary>
    /// Adds an end group ')' to the expression filter.
    /// </summary>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder EndGroup()
    {
        _filterExpression.Append(")");
        return this;
    }

    /// <summary>
    /// Adds an 'equal to' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder EqualTo(object value)
    {
        _filterExpression.Append($" = '{value}' ");
        return this;
    }

    /// <summary>
    /// Adds a 'not equal to' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder NotEqualTo(object value)
    {
        _filterExpression.Append($" != '{value}' ");
        return this;
    }

    /// <summary>
    /// Adds a 'greater than' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder GreaterThan(object value)
    {
        _filterExpression.Append($" > {value} ");
        return this;
    }

    /// <summary>
    /// Adds a 'greater than or equal to' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder GreaterThanOrEqualTo(object value)
    {
        _filterExpression.Append($" >= {value}");
        return this;
    }

    /// <summary>
    /// Adds a 'less than' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder LessThan(object value)
    {
        _filterExpression.Append($" < {value} ");
        return this;
    }

    /// <summary>
    /// Adds a 'less than or equal to' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public PlayerFilterExpressionBuilder LessThanOrEqualTo(object value)
    {
        _filterExpression.Append($" <= {value} ");
        return this;
    }

    /// <summary>
    /// Converts the expression filter to a string.
    /// </summary>
    /// <returns>The expression filter as a string.</returns>
    public override string ToString()
    {
        return _filterExpression.ToString();
    }

    /// <summary>
    /// Builds the expression filter for the NHL API for player statistics.
    /// </summary>
    /// <returns>The built expression filter.</returns>
    public ExpressionPlayerFilter Build()
    {
        return new ExpressionPlayerFilter(_filterExpression.ToString());
    }
}


/// <summary>
/// A class that represents the expression filter for the NHL API for player statistics <br/>
/// See <see cref="PlayerFilterExpressionBuilder"/> for an example of how to use the expression filter for NHL players to filter results
/// </summary>
public class ExpressionPlayerFilter
{
    private readonly string _filterExpression;

    /// <summary>
    /// A class that represents the expression filter for the NHL API for player statistics
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
    public override string ToString()
    {
        return _filterExpression.ToString();
    }
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
