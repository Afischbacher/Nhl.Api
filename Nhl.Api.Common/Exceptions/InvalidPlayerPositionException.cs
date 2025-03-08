using System;

namespace Nhl.Api.Common.Exceptions;
/// <summary>
/// An exception for when a request is made to the Nhl.Api and the player/goalie position is invalid 
/// </summary>
/// <remarks>
/// An exception for when a request is made to the Nhl.Api and the player/goalie position is invalid 
/// </remarks>
public class InvalidPlayerPositionException(string message) : Exception(message)
{
}
