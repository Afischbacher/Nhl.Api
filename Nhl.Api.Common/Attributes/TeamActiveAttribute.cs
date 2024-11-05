using System;

namespace Nhl.Api.Common.Attributes;

/// <summary>
/// An enumeration to specifically mark NHL teams active or inactive
/// </summary>
/// <remarks>
/// The constructor
/// </remarks>
/// <param name="isActive">Whether an NHL team is active in the leauge</param>
[AttributeUsage(AttributeTargets.Field, Inherited = false, AllowMultiple = false)]
public class TeamActiveAttribute(bool isActive) : Attribute
{
    /// <summary>
    /// Determines if the NHL team is currently active
    /// </summary>
    public bool IsActive { get; } = isActive;
}
