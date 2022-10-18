using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Player;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nhl.Api.Services
{
    /// <summary>
    /// The NHL statistics service for providing NHL statistics data
    /// </summary>
    public interface INhlStatisticsService
    {
        /// <summary>
        /// Returns the ordered results of the NHL goalie statistics based on a specified count and direction of descent
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="validGoalieStatistics">A collection of NHL goalie statistic results</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <param name="count">The argument for the number of values to return </param>
        /// <returns>Returns the collection of goalie statistic results </returns>
        List<GoalieStatisticResult> GetOrderedGoalieStatisticResults(GoalieStatisticEnum goalieStatisticEnum, IEnumerable<GoalieStatisticResult> validGoalieStatistics, bool isDescending, int count);

        /// <summary>
        /// Returns the first result of the NHL player statistic based on the direction of descent
        /// </summary>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <param name="validPlayerStatistics">A collection of NHL player statistics results</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <param name="count">The argument for the number of values to return </param>
        /// <returns>Returns the collection of player statistic results </returns>
        List<PlayerStatisticResult> GetOrderedPlayerStatisticResults(PlayerStatisticEnum playerStatisticEnum, IEnumerable<PlayerStatisticResult> validPlayerStatistics, bool isDescending, int count);

        /// <summary>
        /// Returns the first result of the NHL goalie statistic based on the direction of descent
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="validGoalieStatistics">A collection of NHL goalie statistic results</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns the a goalie statistic result </returns>
        GoalieStatisticResult GetOrderedGoalieStatisticResult(GoalieStatisticEnum goalieStatisticEnum, IEnumerable<GoalieStatisticResult> validGoalieStatistics, bool isDescending);

        /// <summary>
        /// Returns the first result of the NHL player statistic based on the direction of descent
        /// </summary>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <param name="validPlayerStatistics">A collection of NHL player statistics results</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns the a player statistic result </returns>
        PlayerStatisticResult GetOrderedPlayerStatisticResult(PlayerStatisticEnum playerStatisticEnum, IEnumerable<PlayerStatisticResult> validPlayerStatistics, bool isDescending);
    }

    /// <summary>
    /// The NHL statistics service for providing NHL statistics data
    /// </summary>
    public class NhlStatisticsService : INhlStatisticsService
    {

        /// <summary>
        /// Returns the first result of the NHL goalie statistic based on the direction of descent
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="validGoalieStatistics">A collection of NHL goalie statistic results</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns the a goalie statistic result </returns>
        public GoalieStatisticResult GetOrderedGoalieStatisticResult(GoalieStatisticEnum goalieStatisticEnum, IEnumerable<GoalieStatisticResult> validGoalieStatistics, bool isDescending)
        {
            return GetOrderedGoalieStatisticResults(goalieStatisticEnum, validGoalieStatistics, isDescending, count: 1).FirstOrDefault();
        }

        /// <summary>
        /// Returns the first result of the NHL player statistic based on the direction of descent
        /// </summary>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <param name="validPlayerStatistics">A collection of NHL player statistics results</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns> Returns the a player statistic result </returns>
        public PlayerStatisticResult GetOrderedPlayerStatisticResult(PlayerStatisticEnum playerStatisticEnum, IEnumerable<PlayerStatisticResult> validPlayerStatistics, bool isDescending)
        {
            return GetOrderedPlayerStatisticResults(playerStatisticEnum, validPlayerStatistics, isDescending, count: 1).FirstOrDefault();
        }

        /// <summary>
        /// Returns the ordered results of the NHL goalie statistics based on a specified count and direction of descent
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="validGoalieStatistics">A collection of NHL goalie statistic results</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <param name="count">The argument for the number of values to return </param>
        /// <returns> Returns the collection of goalie statistic results </returns>
        public List<GoalieStatisticResult> GetOrderedGoalieStatisticResults(GoalieStatisticEnum goalieStatisticEnum, IEnumerable<GoalieStatisticResult> validGoalieStatistics, bool isDescending, int count)
        {
            switch (goalieStatisticEnum)
            {
                case GoalieStatisticEnum.SavePercentage:

                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.SavePercentage, isDescending)
                       .Take(count)
                       .ToList();

                case GoalieStatisticEnum.Shutouts:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Shutouts, isDescending)
                       .Take(count)
                       .ToList();

                case GoalieStatisticEnum.Ties:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Ties, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.Wins:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Wins, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.OvertimeWins:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Ot, isDescending)
                       .Take(count)
                       .ToList();

                case GoalieStatisticEnum.Losses:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Losses, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.Saves:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.Saves, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.PowerPlaySaves:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.PowerPlaySaves, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.PowerPlayShots:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.PowerPlayShots, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.EvenShots:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.EvenShots, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.ShortHandedShots:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.ShortHandedShots, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.EvenSaves:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.EvenSaves, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.ShortHandedSaves:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.ShortHandedSaves, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.GoalAgainstAverage:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.GoalAgainstAverage, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.GoalsAgainst:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.GoalsAgainst, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.EvenStrengthSavePercentage:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.EvenStrengthSavePercentage, isDescending)
                        .Take(count)
                        .ToList();

                case GoalieStatisticEnum.ShortHandedSavePercentage:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.ShortHandedSavePercentage, isDescending)
                       .Take(count)
                       .ToList();

                case GoalieStatisticEnum.PowerPlaySavePercentage:
                    return GetOrderEnumerableByKeySelector(validGoalieStatistics, goalieStatisticResult => goalieStatisticResult.GoalieStatisticsData.PowerPlaySavePercentage, isDescending)
                        .Take(count)
                        .ToList();
                default:
                    return null;
            }
        }

        /// <summary>
        /// Returns the first result of the NHL player statistic based on the direction of descent
        /// </summary>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <param name="validPlayerStatistics">A collection of NHL player statistics results</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <param name="count">The number of players to return</param>
        /// <returns> Returns the a player statistic result </returns>
        public List<PlayerStatisticResult> GetOrderedPlayerStatisticResults(PlayerStatisticEnum playerStatisticEnum, IEnumerable<PlayerStatisticResult> validPlayerStatistics, bool isDescending, int count)
        {

            switch (playerStatisticEnum)
            {
                case PlayerStatisticEnum.Goals:

                    return GetTopPlayersByStatistic
                    (
                        validPlayerStatistics,
                        x => x.PlayerStatisticsData.Goals,
                        x => x.PlayerStatisticsData.Shots,
                        nameof(PlayerStatisticEnum.Goals),
                        typeof(int),
                        count
                    );

                case PlayerStatisticEnum.Assists:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Assists, isDescending)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Points:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Points, isDescending)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Shots:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Shots, isDescending)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.ShotsBlocked:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Blocked, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.ShotPercentage:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.ShotPct, isDescending)
                      .Take(count)
                      .ToList();

                case PlayerStatisticEnum.Hits:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Hits, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.FaceOffPercentage:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.FaceOffPct, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.PenaltyMinutes:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Pim, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PlusMinus:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.PlusMinus, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PowerPlayGoals:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.PowerPlayGoals, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.PowerPlayPoints:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.PowerPlayPoints, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.OverTimeGoals:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.OverTimeGoals, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.Shifts:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.Shifts, isDescending)
                        .Take(count)
                        .ToList();

                case PlayerStatisticEnum.ShortHandedGoals:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.ShortHandedGoals, isDescending)
                       .Take(count)
                       .ToList();

                case PlayerStatisticEnum.ShortHandedPoints:
                    return GetOrderEnumerableByKeySelector(validPlayerStatistics, playerStatisticResult => playerStatisticResult.PlayerStatisticsData.ShortHandedPoints, isDescending)
                        .Take(count)
                        .ToList();

                default:
                    return null;

            }

            List<PlayerStatisticResult> GetTopPlayersByStatistic<T1, T2>
            (
                IEnumerable<PlayerStatisticResult> playerStatisticResults,
                Func<PlayerStatisticResult, T1> orderedStatisticType,
                Func<PlayerStatisticResult, T2> secondOrderedStatisticType,
                string firstStatisticTypePropertyName,
                System.Type firstStatisticPropertyType,
                int numberOfPlayers
            )
            {
                if (numberOfPlayers <= 0)
                {
                    return new List<PlayerStatisticResult>();
                }

                if (numberOfPlayers == 1)
                {
                    var sortedByProperty = isDescending
                        ? playerStatisticResults.OrderByDescending(orderedStatisticType)
                        : playerStatisticResults.OrderBy(orderedStatisticType);

                    var firstPlayer = sortedByProperty.First();
                    var secondPlayer = sortedByProperty.Skip(1).First();

                    var firstPlayerFirstProperty = firstPlayer.PlayerStatisticsData.GetType()
                        .GetProperties()
                        .Single(x => x.Name == firstStatisticTypePropertyName)
                        .GetValue(firstPlayer.PlayerStatisticsData, null);

                    var secondPlayerFirstProperty = secondPlayer.PlayerStatisticsData.GetType()
                        .GetProperties()
                        .Single(x => x.Name == firstStatisticTypePropertyName)
                        .GetValue(secondPlayer.PlayerStatisticsData, null);

                    if (firstPlayerFirstProperty.Equals(secondPlayerFirstProperty))
                    {
                        return isDescending
                          ?
                             new[] { firstPlayer, secondPlayer }
                             .OrderByDescending(secondOrderedStatisticType)
                             .Take(numberOfPlayers)
                             .ToList()

                         : new[] { firstPlayer, secondPlayer }
                             .OrderBy(secondOrderedStatisticType)
                             .Take(numberOfPlayers)
                             .ToList();
                    }
                    else
                    {
                        return new List<PlayerStatisticResult> { firstPlayer };
                    }
                }
                else
                {
                    return isDescending
                         ? validPlayerStatistics.OrderByDescending(orderedStatisticType).Take(numberOfPlayers).ToList()
                         : validPlayerStatistics.OrderBy(orderedStatisticType).Take(numberOfPlayers).ToList();
                }
            }
        }

        private IOrderedEnumerable<T> GetOrderEnumerableByKeySelector<T>(IEnumerable<T> collection, Func<T, object> keySelector, bool isDescending, bool isThenBy = false)
        {
            return isDescending
               ? collection.OrderByDescending(keySelector)
               : collection.OrderBy(keySelector);
        }
    }
}
