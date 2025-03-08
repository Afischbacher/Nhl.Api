using System;

namespace Nhl.Api.Common.Exceptions;

/// <summary>
/// This exception is thrown when an invalid team abbreviation is used
/// </summary>
public class InvalidTeamAbbreviationException(string message) : Exception
{
    /// <summary>
    /// The exception message
    /// </summary>
    public override string Message => message;
}
