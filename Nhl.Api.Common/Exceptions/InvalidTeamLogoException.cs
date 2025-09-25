using System;

namespace Nhl.Api.Common.Exceptions;
/// <summary>
/// An exception when the season year and team identfier entered is not a valid NHL logo
/// </summary>
/// <remarks>
/// An exception when the season year and team identfier entered is not a valid NHL logo
/// </remarks>
public class InvalidTeamLogoSeasonException(string message) : Exception(message)
{
}
