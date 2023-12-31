namespace Nhl.Api.Enumerations.Game
{
    /// <summary>
    /// The NHL game type for searching statistics, players, teams and more
    /// </summary>
    public enum GameType
    {
        /// <summary>
        /// The NHL game type is a regular season game, see <see cref="GameType"/> for more information
        /// </summary>
        RegularSeason = 2,

        /// <summary>
        /// The NHL game type is a playoff game, see <see cref="GameType"/> for more information
        /// </summary>
        Playoffs = 3
    }
}
