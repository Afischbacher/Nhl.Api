using System.Runtime.Serialization;

namespace Nhl.Api.Enumerations.Statistic;
/// <summary>
/// The types of NHL player statistics
/// </summary>
public enum PlayerStatisticsType
{
    /// <summary>
    /// The NHL player goals
    /// </summary>
    [EnumMember(Value = "goals")]
    Goals,

    /// <summary>
    /// The NHL player assists
    /// </summary>
    [EnumMember(Value = "assists")]
    Assists,

    /// <summary>
    /// The NHL player points
    /// </summary>
    [EnumMember(Value = "points")]
    Points,

    /// <summary>
    /// The NHL player plus/minus
    /// </summary>
    [EnumMember(Value = "plusMinus")]
    PlusMinus,

    /// <summary>
    /// The NHL player power play goals
    /// </summary>
    [EnumMember(Value = "goalsPp")]
    PowerPlayGoals,

    /// <summary>
    /// The NHL player short handed goals
    /// </summary>
    [EnumMember(Value = "goalsSh")]
    ShortHandedGoals,

    /// <summary>
    /// The NHL player penalty minutes
    /// </summary>
    [EnumMember(Value = "penaltyMins")]
    PenaltyMinutes,

    /// <summary>
    /// The NHL player total time on ice
    /// </summary>
    [EnumMember(Value = "toi")]
    TotalTimeOnIce,

    /// <summary>
    /// The NHL player face off percentage
    /// </summary>
    [EnumMember(Value = "faceoffLeaders")]
    FaceOffPercentage,
}
