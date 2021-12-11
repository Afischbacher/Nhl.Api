#region System
using System;
#endregion

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL API providing various NHL information about players, games, teams, conferences, divisions, statistics and more
    /// </summary>
    public interface INhlApi : INhlLeagueApi, INhlGameApi, INhlPlayerApi, INhlStatisticsApi, IDisposable
    {

    }
}
