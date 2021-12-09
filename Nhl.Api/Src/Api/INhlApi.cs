#region System
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
#endregion

#region Nhl.Api
using Nhl.Api.Models.Award;
using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Enumerations.Award;
using Nhl.Api.Models.Enumerations.Conference;
using Nhl.Api.Models.Enumerations.Division;
using Nhl.Api.Models.Enumerations.Franchise;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Prospect;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Enumerations.Venue;
using Nhl.Api.Models.Event;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standing;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;
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
