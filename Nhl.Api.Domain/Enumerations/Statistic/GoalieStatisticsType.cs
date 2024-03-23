namespace Nhl.Api.Enumerations.Statistic;
using System.Runtime.Serialization;

/// <summary>
/// The types of NHL goalie statistics
/// </summary>
public enum GoalieStatisticsType
{
    /// <summary>
    /// The NHL goalie wins statistic type
    /// </summary>
    [EnumMember(Value = "wins")]
    Wins,
    /// <summary>
    /// The NHL goalie losses statistic type
    /// </summary>
    [EnumMember(Value = "shutouts")]
    Shutouts,
    /// <summary>
    /// The NHL goalie save percentage statistic type
    /// </summary>
    [EnumMember(Value = "savePctg")]
    SavePercentage,
    /// <summary>
    /// The NHL goalie goals against average statistic type
    /// </summary>
    [EnumMember(Value = "goalsAgainstAverage")]
    GoalsAgainstAverage,
}
