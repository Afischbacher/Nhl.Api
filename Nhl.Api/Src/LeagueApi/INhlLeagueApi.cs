using Nhl.Api.Models.Schedule;
using Nhl.Api.Models.Award;
using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Enumerations.Award;
using Nhl.Api.Models.Enumerations.Conference;
using Nhl.Api.Models.Enumerations.Division;
using Nhl.Api.Models.Enumerations.Franchise;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Enumerations.Venue;
using Nhl.Api.Models.Event;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standing;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
    /// </summary>
    public interface INhlLeagueApi
    {
        /// <summary>
        /// Returns an the NHL team logo using the NHL team id
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <param name="teamLogoType">A season year for the all the NHL statistics, based on the background of light or dark</param>
        /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the uri endpoint</returns>
        Task<TeamLogo> GetTeamLogoAsync(int teamId, TeamLogoType teamLogoType = TeamLogoType.Light);

        /// <summary>
        /// Returns an the NHL team logo based using the NHL team enumeration
        /// </summary>
        /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
        /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
        /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the uri endpoint</returns>
        Task<TeamLogo> GetTeamLogoAsync(TeamEnum team, TeamLogoType teamLogoType = TeamLogoType.Light);

        /// <summary>
        /// Returns the hexadecimal code for an NHL team's colors
        /// </summary>
        /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
        /// <returns>An NHL team color scheme using hexadecimal codes</returns>
        Task<TeamColors> GetTeamColorsAsync(TeamEnum team);

        /// <summary>
        /// Returns the hexadecimal code for an NHL team's colors
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <returns>An NHL team color scheme using hexadecimal codes</returns>
        Task<TeamColors> GetTeamColorsAsync(int teamId);

        /// <summary>
        /// Returns the NHL team schedule for a specific date using the DateTimeOffset
        /// </summary>
        /// <param name="dateTimeOffset">A <see cref="DateTimeOffset"/> for the specific date for the NHL schedule</param>
        /// <returns>A result of the current NHL schedule by the specified date</returns>
        Task<LeagueSchedule> GetLeagueGameWeekScheduleByDateTimeAsync(DateTimeOffset dateTimeOffset);

        /// <summary>
        /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
        /// </summary>
        /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
        /// <param name="dateTimeOffset">The date in which the request schedule for the team and for the week is request for</param>
        /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
        Task<TeamWeekSchedule> GetTeamWeekScheduleByDateTimeOffsetAsync(string teamAbbreviation, DateTimeOffset dateTimeOffset);

        /// <summary>
        /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
        /// </summary>
        /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
        /// <param name="seasonYear">The eight digit number format for the season, Example: 20232024</param>
        /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
        Task<TeamSchedule> GetTeamScheduleBySeasonAsync(string teamAbbreviation, SeasonYear seasonYear);

        /// <summary>
        /// Returns the true or false if the NHL playoff pre season is active or inactive
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL pre-season is active</returns>
        Task<bool> IsPreSeasonActiveAsync();
        /// <summary>
        /// Returns the true or false if the NHL regular season is active or inactive
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL regular season is active</returns>
        Task<bool> IsRegularSeasonActiveAsync();

        /// <summary>
        /// Returns the true or false if the NHL playoff season is active or inactive
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL playoff season is active</returns>
        Task<bool> IsPlayoffSeasonActiveAsync();

    }
}
