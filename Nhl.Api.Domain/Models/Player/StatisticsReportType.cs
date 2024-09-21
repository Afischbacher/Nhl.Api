using System.ComponentModel;
using System.Runtime.Serialization;

namespace Nhl.Api.Models.Player;

/// <summary>
/// A statistics filter for the retreival of player and goalie statistics in the NHL using Cayenne expressions
/// </summary>
public enum StatisticsReportType
{
    /// <summary>
    /// Summary
    /// </summary>
    [Description("summary")]
    [EnumMember(Value = "summary")]
    Summary,
    /// <summary>
    /// Time on Ice
    /// </summary>
    [Description("timeonice")]
    [EnumMember(Value = "timeonice")]
    TimeOnIce,
    /// <summary>
    /// Real Time
    /// </summary>
    [Description("realtime")]
    [EnumMember(Value = "realtime")]
    Realtime

}
