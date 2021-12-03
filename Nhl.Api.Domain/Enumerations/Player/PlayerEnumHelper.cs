using Nhl.Api.Common.Extensions;
using Nhl.Api.Models.Player;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Nhl.Api.Models.Enumerations.Player
{
    /// <summary>
    /// A helper class for generating the <see cref="PlayerEnum"/> values
    /// </summary>
    public static class PlayerEnumHelper
    {

        /// <summary>
        /// A helper method that returns every single NHL player known
        /// </summary>
        /// <returns>A comprehensive list of NHL players</returns>
        public static async Task<List<Models.Player.Player>> GetAllPlayersAsync()
        {
            var nhlStatsApiHttpClient = new Api.Common.Http.NhlStatsApiHttpClient();
            var playerTasks = new List<Task<Models.Player.Player>>();
            var semaphore = new SemaphoreSlim(initialCount: 1);

            for (var playerId = 8440000; playerId < 8490000; playerId++)
            {
                await semaphore.WaitAsync();

                playerTasks.Add(
                    Task.Run(async () =>
                    {
                        try
                        {
                            return (await nhlStatsApiHttpClient.GetAsync<LeaguePlayers>($"/people/{playerId}"))
                            .Players
                            .SingleOrDefault();
                        }
                        finally
                        {
                            semaphore.Release();
                        }
                    }));
            }

            return (await Task.WhenAll(playerTasks)).Where(player => player != null)
                .DistinctBy(player => player.Id)
                .ToList();

        }
    }
}
