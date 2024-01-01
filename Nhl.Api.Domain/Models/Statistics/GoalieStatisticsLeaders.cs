using Newtonsoft.Json;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics
{

    /// <summary>
    /// The base class model for NHL goalie statistic leaders
    /// </summary>
    public class BaseGoalieStatisticLeader : BasePlayerStatisticLeader
    {

    }

    /// <summary>
    /// The NHL goalie's statistic leaders for the goals against average statistic type for the NHL season
    /// </summary>
    public class GoalsAgainstAverage : BaseGoalieStatisticLeader
    {
        /// <summary>
        /// The NHL goalie's goals against average <br/>
        /// Example: 2.34324
        /// </summary>
        [JsonProperty("value")]
        public decimal Value { get; set; }
    }

    /// <summary>
    /// The NHL goalie's statistic leaders for the all the categories for an NHL season and game type
    /// </summary>
    public class GoalieStatisticLeaders
    {
        /// <summary>
        /// The NHL goalie's statistic leader for the number of wins in for an NHL season and game type
        /// </summary>
        [JsonProperty("wins")]
        public List<Wins> Wins { get; set; } = new();

        /// <summary>
        /// The NHL goalie's statistic leader for the number of shutouts in for an NHL season and game type
        /// </summary>
        [JsonProperty("shutouts")]
        public List<Shutouts> Shutouts { get; set; } = new();

        /// <summary>
        /// The NHL goalie's statistic leader for the save percentage in for an NHL season and game type
        /// </summary>
        [JsonProperty("savePctg")]
        public List<SavePercentage> SavePercentages { get; set; } = new();

        /// <summary>
        /// The NHL goalie's statistic leader for the goals against average in for an NHL season and game type
        /// </summary>
        [JsonProperty("goalsAgainstAverage")]
        public List<GoalsAgainstAverage> GoalsAgainstAverage { get; set; } = new();
    }

    /// <summary>
    /// The NHL goalie's statistic leaders for the save percentage statistic type for the NHL season
    /// </summary>
    public class SavePercentage : BaseGoalieStatisticLeader
    {
        /// <summary>
        /// The NHL goalie's save percentage <br/>
        /// Example: 0.923134
        /// </summary>
        [JsonProperty("value")]
        public decimal Value { get; set; }
    }

    /// <summary>
    /// The NHL goalie's statistic leaders for the shutouts statistic type for the NHL season
    /// </summary>
    public class Shutouts : BaseGoalieStatisticLeader
    {
        /// <summary>
        /// The number of shutouts for the NHL goalie <br/>
        /// Example: 5
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The NHL goalie's statistic leaders for the wins statistic type for the NHL season
    /// </summary>
    public class Wins : BaseGoalieStatisticLeader
    {
        /// <summary>
        /// The number of wins for the NHL goalie <br/>
        /// Example: 32
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }
}