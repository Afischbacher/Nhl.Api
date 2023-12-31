using Nhl.Api.Common.Extensions;
using Nhl.Api.Common.Services;
using Nhl.Api.Enumerations.Player;
using Nhl.Api.Models.Player;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nhl.Api.Models.Enumerations.Player
{
    /// <summary>
    /// A helper class for generating the <see cref="PlayerEnum"/> values
    /// </summary>
    public static class PlayerEnumHelper
    {
        /// <summary>
        /// Retrieves all NHL players to have player in the NHL
        /// </summary>
        /// <returns>A dictionary of players names and their identifiers for every NHL player to ever play</returns>
        public static Dictionary<int, string> GetAllPlayers()
        {
            //@TODO: Need to implement this using the NHL API
            return new Dictionary<int, string>();
        }
    }
}
