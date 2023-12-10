using Nhl.Api.Common.Exceptions;
using Nhl.Api.Common.Extensions;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;
using Nhl.Api.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
    /// </summary>
    public class NhlStatisticsApi : INhlStatisticsApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
        private static readonly INhlPlayerApi _nhlPlayerApi = new NhlPlayerApi();
        private static readonly INhlStatisticsService _nhlStatisticsService = new NhlStatisticsService();

        /// <summary>
        /// The official unofficial NHL Statistics API providing various NHL information about in-depth player statistics, team statistics and more
        /// </summary>
        public NhlStatisticsApi()
        {

        }

    }
}
