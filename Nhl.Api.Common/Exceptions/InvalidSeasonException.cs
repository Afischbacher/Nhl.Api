namespace Nhl.Api.Common.Exceptions;
using System;

/// <summary>
/// An exception when the season year entered is not a valid NHL season
/// </summary>
public class InvalidSeasonException : Exception
{
    /// <summary>
    /// An exception when the season year entered is not a valid NHL season
    /// </summary>
    public InvalidSeasonException(string message) : base(message)
    {

    }
}
