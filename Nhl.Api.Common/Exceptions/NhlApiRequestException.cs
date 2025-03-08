using System;

namespace Nhl.Api.Common.Exceptions;
/// <summary>
/// An exception for a failed Nhl.Api HTTP request
/// </summary>
/// <remarks>
/// An exception for a failed Nhl.Api HTTP request
/// </remarks>
public class NhlApiRequestException(string message) : Exception(message)
{
}
