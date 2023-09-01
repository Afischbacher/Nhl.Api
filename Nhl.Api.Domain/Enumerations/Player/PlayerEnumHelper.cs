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
            var nhlStatsApiHttpClient = new Api.Common.Http.NhlStatsApiHttpClient();
            var players = new ConcurrentBag<Models.Player.Player>();

            var internalPlayerEnumValues = typeof(InternalPlayerEnum)
                .GetEnumValues()
                .Cast<object>();

            var internalPlayerEnumValuesDictionary = internalPlayerEnumValues.ToDictionary(key => (int)key, value => value.ToString());
            var lastEnumValue = (int)internalPlayerEnumValues.OrderBy(c => c).Last();


            Parallel.For(lastEnumValue, 8490000, new ParallelOptions { CancellationToken = default, MaxDegreeOfParallelism = 2 }, (i) =>
            {
                try
                {
                    var player = NhlApiAsyncHelper.RunSync<LeaguePlayers>(() => nhlStatsApiHttpClient.GetAsync<LeaguePlayers>($"/people/{i}"))
                    .Players
                    .SingleOrDefault();

                    players.Add(player);
                }
                finally
                {
                }
            });

            var allPlayers = players.Where(p => p != null).DistinctBy(p => p.Id).ToList();
            foreach (var newPlayer in allPlayers)
            {
                try
                {
                    internalPlayerEnumValuesDictionary.Add(newPlayer.Id, $"{Regex.Replace(newPlayer.FullName, @"('|\.|\s|-|_|&|)", "")}{newPlayer.Id}");
                }
                catch
                {
                }
            }

            return internalPlayerEnumValuesDictionary;
        }
    }
}
