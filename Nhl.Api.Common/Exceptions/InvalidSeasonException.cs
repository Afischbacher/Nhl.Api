using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Common.Exceptions
{
    /// <summary>
    /// An exception when the season year entered is not a valid NHL season
    /// </summary>
    public class InvalidSeasonException : Exception
    {
        public InvalidSeasonException(string message) : base(message)
        {

        }
    }
}
