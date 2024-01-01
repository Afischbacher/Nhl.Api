using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Nhl.Api.Enumerations.Statistic
{
    /// <summary>
    /// The GameCenter player statistics type for the NHL GameCenter play by play events
    /// </summary>
    public enum PlayerGameCenterStatistic
    {
        /// <summary>
        /// The faceoff event in the GameCenter play by play
        /// </summary>
        [EnumMember(Value = "faceoff")]
        FaceOff,

        /// <summary>
        /// The hit event in the GameCenter play by play
        /// </summary>
        [EnumMember(Value ="hit")]
        Hit,

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
        /// The penalty event in the GameCenter play by play
        /// </summary>
        [EnumMember(Value = "penalty")]
        Penalty,

        /// <summary>
        /// The takeaway event in the GameCenter play by play
        /// </summary> 
        [EnumMember(Value = "takeaway")]
        Takeaway

    }
}
