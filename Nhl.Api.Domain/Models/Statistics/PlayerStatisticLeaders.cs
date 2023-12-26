using Newtonsoft.Json;
using Nhl.Api.Models.Player;
using System;
using System.Collections.Generic;

namespace Nhl.Api.Models.Statistics
{
    /// <summary>
    /// The NHL player's statistic leaders for a specific player statistic type for the NHL season
    /// </summary>
    [Serializable]
    public class PlayerStatisticLeaders
    {
        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for short handed goals
        /// </summary>
        [JsonProperty("goalsSh")]
        public List<ShorthandedGoals> GoalsSh { get; set; } = new List<ShorthandedGoals>();

        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for plus/minus
        /// </summary>
        [JsonProperty("plusMinus")]
        public List<PlusMinus> PlusMinus { get; set; } = new List<PlusMinus>();

        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for assists
        /// </summary>
        [JsonProperty("assists")]
        public List<Assists> Assists { get; set; } = new List<Assists>();

        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for power play goals
        /// </summary>
        [JsonProperty("goalsPp")]
        public List<PowerPlayGoals> GoalsPp { get; set; } = new List<PowerPlayGoals>();

        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for face off percentage leaders
        /// </summary>
        [JsonProperty("faceoffLeaders")]
        public List<FaceoffLeaders> FaceoffLeaders { get; set; } = new List<FaceoffLeaders>();

        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for penalty minutes
        /// </summary>
        [JsonProperty("penaltyMins")]
        public List<PenaltyMinutes> PenaltyMins { get; set; } = new List<PenaltyMinutes>();

        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for goals
        /// </summary>
        [JsonProperty("goals")]
        public List<Goals> Goals { get; set; } = new List<Goals>();

        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for points
        /// </summary>
        [JsonProperty("points")]
        public List<Points> Points { get; set; } = new List<Points>();

        /// <summary>
        /// The NHL player's statistic leaders for a specific player statistic type for the NHL season for total time on ice
        /// </summary>
        [JsonProperty("toi")]
        public List<TotalTimeOnIce> Toi { get; set; } = new List<TotalTimeOnIce>();
    }

    /// <summary>
    /// The base class model for the NHL statistic leaders
    /// </summary>
    public class BaseStatisticLeader
    {
        /// <summary>
        /// The NHL player identifier <br/>
        /// Example: 8478402
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// The NHL player's first name <br/>
        /// Example: Sidney
        /// </summary>
        [JsonProperty("firstName")]
        public FirstName FirstName { get; set; }

        /// <summary>
        /// The name of the NHL player's last name <br/>
        /// Example: Crosby
        /// </summary>
        [JsonProperty("lastName")]
        public LastName LastName { get; set; }

        /// <summary>
        /// The NHL player's sweater number <br/>
        /// Example: 87
        /// </summary>
        [JsonProperty("sweaterNumber")]
        public int SweaterNumber { get; set; }

        /// <summary>
        /// The URL to the NHL player's headshot <br/>
        /// Example: https://assets.nhle.com/mugs/nhl/20232024/VAN/8478444.png
        /// </summary>
        [JsonProperty("headshot")]
        public string Headshot { get; set; }

        /// <summary>
        /// The NHL team abbreviation for the team the player plays for <br/>
        /// Example: VAN
        /// </summary>
        [JsonProperty("teamAbbrev")]
        public string TeamAbbrev { get; set; }

        /// <summary>
        /// The NHL team name for the team the player plays for <br/>
        /// Example: Maple Leafs
        /// </summary>
        [JsonProperty("teamName")]
        public TeamName TeamName { get; set; }

        /// <summary>
        /// The NHL team logo for the team the player plays for <br/>
        /// Example: https://assets.nhle.com/logos/nhl/svg/TOR_light.svg
        /// </summary>
        [JsonProperty("teamLogo")]
        public string TeamLogo { get; set; }

        /// <summary>
        /// The NHL player's position <br/>
        /// Example: Center
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }
    }


    /// <summary>
    /// The base class model for the NHL player statistic leaders
    /// </summary>
    public class BasePlayerStatisticLeader : BaseStatisticLeader
    {

    }

    /// <summary>
    /// The NHL player's goals statistic leader for the NHL season
    /// </summary>
    public class Goals : BasePlayerStatisticLeader
    {

        /// <summary>
        /// The number of goals scored by the NHL player <br/>
        /// Example: 35
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The NHL player's power play goals statistic leader for the NHL season
    /// </summary>
    public class PowerPlayGoals : BasePlayerStatisticLeader
    {
        /// <summary>
        /// The number of power play goals scored by the NHL player  <br/>
        /// Example: 10
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The NHL player's short handed goals statistic leader for the NHL season
    /// </summary>
    public class ShorthandedGoals : BasePlayerStatisticLeader
    {

        /// <summary>
        /// The number of short handed goals scored by the NHL player  <br/>
        /// Example: 2
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The NHL player's penalty minutes statistic leader for the NHL season
    /// </summary>
    public class PenaltyMinutes : BasePlayerStatisticLeader
    {
        /// <summary>
        /// The number of penalty minutes by the NHL player  <br/>
        /// Example: 69
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The NHL player's plus/minus statistic leader for the NHL season
    /// </summary>
    public class PlusMinus : BasePlayerStatisticLeader
    {
        /// <summary>
        /// The plus/minus statistic for the NHL player  <br/>
        /// Example: 26
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The NHL player's points statistic leader for the NHL season
    /// Example: 100
    /// </summary>
    public class Points : BasePlayerStatisticLeader
    {
        /// <summary>
        /// The number of points scored by the NHL player  <br/>
        /// Example: 100
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The NHL player's assists statistic leader for the NHL season
    /// </summary>
    public class Assists : BasePlayerStatisticLeader
    {
        /// <summary>
        /// The number of assists by the NHL player  <br/>
        /// Example: 65
        /// </summary>
        [JsonProperty("value")]
        public int Value { get; set; }
    }

    /// <summary>
    /// The NHL player's face off percentage statistic leader for the NHL season
    /// </summary>
    public class FaceoffLeaders : BasePlayerStatisticLeader
    {
        /// <summary>
        /// The face off percentage for the NHL player <br/>
        /// Example: 0.647059
        /// </summary>
        [JsonProperty("value")]
        public decimal Value { get; set; }
    }

    /// <summary>
    /// The NHL player's total time on ice statistic leader for the NHL season
    /// </summary>
    public class TotalTimeOnIce : BasePlayerStatisticLeader
    {
        /// <summary>
        /// The NHL player's total time on ice <br/>
        /// Example: 1550.6667
        /// </summary>
        [JsonProperty("value")]
        public decimal Value { get; set; }
    }
}
