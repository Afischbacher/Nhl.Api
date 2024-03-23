namespace Nhl.Api.Models.Player;
using Nhl.Api.Common.Extensions;
using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text;

/// <summary>
/// The expression filter for the NHL API for goalie statistics, this class is used to build the expression filter for the NHL API for goalie statistics <br/>
/// Here is an example of how to use the PlayerFilterExpressionBuilder to build an expression filter for the NHL API for goalie statistics <br/>
/// <br/>
/// <code>
///  expressionFilter
///         .AddFilter(GoalieStatisticsFilter.SavePercentage)
///         .GreaterThanOrEqualTo(0.900)
///         .And()
///         .AddFilter(GoalieStatisticsFilter.Goals)
///         .GreaterThan(1)
///         .And()
///         .AddFilter(GoalieStatisticsFilter.Assists)
///         .GreaterThan(1)
///         .And()
///         .AddFilter(GoalieStatisticsFilter.SkaterFullName)
///         .Contains("Connor")
///         .Build();
/// 
/// </code>
/// </summary>
public class GoalieFilterExpressionBuilder
{
    private readonly StringBuilder _filterExpression = new("factCayenneExp=");

    /// <summary>
    /// Adds a filter to the expression filter to filter by any of the returned properties
    /// </summary>
    /// <param name="goalieStatisticsFilter">The filter to add to the expression</param>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder AddFilter(GoalieStatisticsFilter goalieStatisticsFilter)
    {
        _filterExpression.Append($"{goalieStatisticsFilter.GetEnumMemberValue()}");
        return this;
    }

    /// <summary>
    /// Adds a 'contains' filter to the expression filter
    /// </summary>
    /// <param name="value">The value to search for</param>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder Contains(object value)
    {
        _filterExpression.Append($" like '%{value}%'");
        return this;
    }

    /// <summary>
    /// Adds a 'not contains' filter to the expression filter
    /// </summary>
    /// <param name="value">The value to exclude</param>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder NotContains(object value)
    {
        _filterExpression.Append($" not like '%{value}%'");
        return this;
    }

    /// <summary>
    /// Adds an 'AND' logical operator to the expression filter
    /// </summary>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder And()
    {
        _filterExpression.Append(" and ");
        return this;
    }

    /// <summary>
    /// Adds an 'OR' logical operator to the expression filter
    /// </summary>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder Or()
    {
        _filterExpression.Append(" or ");
        return this;
    }

    /// <summary>
    /// Adds a start group '(' to the expression filter
    /// </summary>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder StartGroup()
    {
        _filterExpression.Append("(");
        return this;
    }

    /// <summary>
    /// Adds an end group ')' to the expression filter
    /// </summary>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder EndGroup()
    {
        _filterExpression.Append(")");
        return this;
    }

    /// <summary>
    /// Adds an 'equal to' filter to the expression filter.
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression.</returns>
    public GoalieFilterExpressionBuilder EqualTo(object value)
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
    /// Adds a 'not equal to' filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder NotEqualTo(object value)
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
    /// Adds a 'greater than' filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against.</param>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder GreaterThan(object value)
    {
        if (value is string)
        {
            _filterExpression.Append($" > '{value}' ");
        }
        else
        {
            _filterExpression.Append($" > {value} ");
        }

        return this;
    }

    /// <summary>
    /// Adds a 'greater than or equal to' filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against</param>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder GreaterThanOrEqualTo(object value)
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
    /// Adds a 'less than' filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against</param>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder LessThan(object value)
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
    /// Adds a 'less than or equal to' filter to the expression filter
    /// </summary>
    /// <param name="value">The value to compare against</param>
    /// <returns>The builder to continue building the expression</returns>
    public GoalieFilterExpressionBuilder LessThanOrEqualTo(object value)
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
    public ExpressionGoalieFilter Build() => new ExpressionGoalieFilter(_filterExpression.ToString());

    /// <summary>
    /// An empty expression filter for the NHL goalie statistics
    /// </summary>
    public static ExpressionGoalieFilter Empty => new(string.Empty);
}


/// <summary>
/// A class that represents the expression filter for the NHL API for goalie statistics <br/>
/// See <see cref="GoalieFilterExpressionBuilder"/> for an example of how to use the expression filter for NHL goalie to filter results
/// </summary>
public class ExpressionGoalieFilter
{
    private readonly string _filterExpression;

    /// <summary>
    /// A class that represents the expression filter for the NHL goalie statistics
    /// </summary>
    public ExpressionGoalieFilter(string filterExpression)
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
    /// An empty expression filter for the NHL goalie statistics
    /// </summary>
    public static ExpressionGoalieFilter Empty => new(string.Empty);

}

/// <summary>
/// A class that represents the NHL goalie statistics filter for searching statistics
/// </summary>
public enum GoalieStatisticsFilter
{
    /// <summary>
    /// The NHL goalie assists 
    /// </summary>
    [Description("assists")]
    [EnumMember(Value = "assists")]
    Assists,

    /// <summary>
    /// The NHL goalie games played
    /// </summary>
    [Description("gamesPlayed")]
    [EnumMember(Value = "gamesPlayed")]
    GamesPlayed,

    /// <summary>
    /// The NHL goalie games started
    /// </summary>
    [Description("gamesStarted")]
    [EnumMember(Value = "gamesStarted")]
    GamesStarted,

    /// <summary>
    /// The NHL goalie full name 
    /// </summary>
    [Description("goalieFullName")]
    [EnumMember(Value = "goalieFullName")]
    GoalieFullName,

    /// <summary>
    /// The NHL goalie goals
    /// </summary>
    [Description("goals")]
    [EnumMember(Value = "goals")]
    Goals,

    /// <summary>
    /// The NHL goalie goals against
    /// </summary>
    [Description("goalsAgainst")]
    [EnumMember(Value = "goalsAgainst")]
    GoalsAgainst,

    /// <summary>
    /// The NHL goalie goals against average 
    /// </summary>
    [Description("goalsAgainst")]
    [EnumMember(Value = "goalsAgainstAverage")]
    GoalsAgainstAverage,

    /// <summary>
    /// The NHL goalie last name
    /// </summary>
    [EnumMember(Value = "lastName")]
    [Description("lastName")]
    LastName,

    /// <summary>
    /// The NHL goalie losses
    /// </summary>
    [Description("losses")]
    [EnumMember(Value = "losses")]
    Losses,

    /// <summary>
    /// The NHL goalie OT losses
    /// </summary>
    [Description("otLosses")]
    [EnumMember(Value = "otLosses")]
    OvertimeLosses,

    /// <summary>
    /// The NHL goalie penalty minutes
    /// </summary>
    [Description("penaltyMinutes")]
    [EnumMember(Value = "penaltyMinutes")]
    PenaltyMinutes,

    /// <summary>
    /// The NHL goalie player identifier
    /// </summary>
    [Description("playerId")]
    [EnumMember(Value = "playerId")]
    PlayerId,

    /// <summary>
    /// The NHL goalie points
    /// </summary>
    [Description("points")]
    [EnumMember(Value = "points")]
    Points,

    /// <summary>
    /// The NHL goalie save percentage
    /// </summary>
    [Description("savePct")]
    [EnumMember(Value = "savePct")]
    SavePercentage,

    /// <summary>
    /// The NHL goalie saves
    /// </summary>
    [Description("saves")]
    [EnumMember(Value = "saves")]
    Saves,

    /// <summary>
    /// The NHL goalie season identifier
    /// </summary>
    [Description("seasonId")]
    [EnumMember(Value = "seasonId")]
    SeasonId,

    /// <summary>
    /// The NHL goalie shoots and catches
    /// </summary>
    [Description("shootsCatches")]
    [EnumMember(Value = "shootsCatches")]
    ShootsCatches,

    /// <summary>
    /// The NHL shots against
    /// </summary>
    [Description("shotsAgainst")]
    [EnumMember(Value = "shotsAgainst")]
    ShotsAgainst,

    /// <summary>
    /// The NHL shutouts
    /// </summary>
    [Description("shutouts")]
    [EnumMember(Value = "shutouts")]
    Shutouts,

    /// <summary>
    /// The NHL goalie team abbreviations
    /// </summary>
    [Description("teamAbbrevs")]
    [EnumMember(Value = "teamAbbrevs")]
    TeamAbbrevs,

    /// <summary>
    /// The NHL goalie ties
    /// </summary>
    [Description("ties")]
    [EnumMember(Value = "ties")]
    Ties,

    /// <summary>
    /// The NHL goalie time on ice
    /// </summary>
    [Description("timeOnIce")]
    [EnumMember(Value = "timeOnIce")]
    TimeOnIce,

    /// <summary>
    /// The NHL goalie wins
    /// </summary>
    [Description("wins")]
    [EnumMember(Value = "wins")]
    Wins
}