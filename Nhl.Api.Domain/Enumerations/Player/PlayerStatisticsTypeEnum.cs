namespace Nhl.Api.Models.Enumerations.Player
{
    /// <summary>
    /// An enumeration of all the NHL player statistics
    /// </summary>
    public enum PlayerStatisticsTypeEnum
    {
        /// <summary>
        /// The statistics for a single NHL season for a player/goalie
        /// </summary>
        StatsSingleSeason,
        /// <summary>
        /// The statistics for a player/goalie who is on pace for a single NHL season
        /// </summary>
        OnPaceRegularSeason,
        /// <summary>
        /// The statistics for a player/goalie for each year by year for every season
        /// </summary>
        YearByYear,
        /// <summary>
        /// The statistics for a player/goalie for home and away games per season
        /// </summary>
        HomeAndAway
    }
}
