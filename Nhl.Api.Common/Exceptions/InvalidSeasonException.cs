using System;

namespace Nhl.Api.Common.Exceptions;
/// <summary>
/// An exception when the season year entered is not a valid NHL season
/// </summary>
/// <remarks>
/// An exception when the season year entered is not a valid NHL season
/// </remarks>
public class InvalidSeasonException(string message) : Exception(message)
{
}
