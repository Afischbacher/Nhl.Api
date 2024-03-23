namespace Nhl.Api.Common.Exceptions;
using System;

/// <summary>
/// An exception for a failed Nhl.Api HTTP request
/// </summary>
public class NhlApiRequestException : Exception
{
    /// <summary>
    /// An exception for a failed Nhl.Api HTTP request
    /// </summary>
    public NhlApiRequestException(string message) : base(message)
    {

    }
}
