using System;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial Nhl.Api providing various NHL information about players, games, teams, conferences, divisions, statistics and more
    /// </summary>
    public interface INhlApi : INhlLeagueApi, INhlGameApi, INhlPlayerApi, INhlStatisticsApi, IDisposable
    {

    }
}
