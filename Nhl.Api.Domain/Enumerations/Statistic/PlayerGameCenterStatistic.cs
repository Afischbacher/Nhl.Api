using System.Runtime.Serialization;

namespace Nhl.Api.Enumerations.Statistic;
/// <summary>
/// The GameCenter player statistics type for the NHL GameCenter play by play events
/// </summary>
public enum PlayerGameCenterStatistic
{
    /// <summary>
    /// The faceoff won event in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "faceoff")]
    FaceOffWon,

    /// <summary>
    /// The faceoff lost event in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "faceoff")]
    FaceOffLost,

    /// <summary>
    /// The body check hit event for a player giving a body check in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "hit")]
    HitGiven,

    /// <summary>
    /// The body check hit event for a player receiving a body check in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "hit")]
    HitReceived,

    /// <summary>
    /// The shot on goal event in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "shot-on-goal")]
    ShotOnGoal,

    /// <summary>
    /// The missed shot event in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "missed-shot")]
    MissedShot,

    /// <summary>
    /// The blocked shot event in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "blocked-shot")]
    BlockedShot,

    /// <summary>
    /// The giveaway event in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "giveaway")]
    Giveaway,

    /// <summary>
    /// The drawn penalty event in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "penalty")]
    DrawnPenalty,

    /// <summary>
    /// The committed penalty event in the GameCenter play by play
    /// </summary>
    [EnumMember(Value = "penalty")]
    CommittedPenalty,

    /// <summary>
    /// The takeaway event in the GameCenter play by play
    /// </summary> 
    [EnumMember(Value = "takeaway")]
    Takeaway

}
