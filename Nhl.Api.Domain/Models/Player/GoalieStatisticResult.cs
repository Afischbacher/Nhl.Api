using Nhl.Api.Models.Player;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Goalie Statistic Result
    /// </summary>
    public class GoalieStatisticResult
    {
        /// <summary>
        /// Returns NHL goalie information including identifier, name, date of birth and more
        /// </summary>
        public Player Player { get; set; }

        /// <summary>
        /// Returns statistics about a specific NHL goalie including saves, goals against average, power play saves, wins, losses
        /// </summary>
        public GoalieStatisticsData GoalieStatisticsData { get; set; }
    }
}
