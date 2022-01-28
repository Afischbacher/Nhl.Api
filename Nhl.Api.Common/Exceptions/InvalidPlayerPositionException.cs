using System;

namespace Nhl.Api.Common.Exceptions
{
    /// <summary>
    /// An exception for when a request is made to the Nhl.Api and the player/goalie position is invalid 
    /// </summary>
    public class InvalidPlayerPositionException : Exception
    {
        /// <summary>
        /// An exception for when a request is made to the Nhl.Api and the player/goalie position is invalid 
        /// </summary>
        public InvalidPlayerPositionException(string message) : base(message)
        {

        }
    }
}
