using System;

namespace Nhl.Api.Common.Exceptions
{
	/// <summary>
	/// An exception for when a request is made to the NHL API and the player/goalie position is invalid 
	/// </summary>
	public class InvalidPlayerPositionException : Exception
	{
		public InvalidPlayerPositionException(string message) : base(message)
		{

		}
	}
}
