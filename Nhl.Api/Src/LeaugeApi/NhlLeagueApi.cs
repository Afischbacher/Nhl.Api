using Nhl.Api.Common.Http;
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
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// NHL League API
    /// </summary>
    public class NhlLeagueApi : INhlLeagueApi
    {

        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
        private static readonly INhlApiHttpClient _nhlSuggestionApiHttpClient = new NhlSuggestionApiHttpClient();
        private static readonly INhlApiHttpClient _nhlStaticAssetsApiHttpClient = new NhlStaticAssetsApiHttpClient();

        /// <summary>
        /// Returns all NHL franchises, including information such as team name, location and more
        /// </summary>
        /// <returns>A collection of all NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetFranchisesAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LegaueFranchises>("/franchises")).Franchises;
        }

        /// <summary>
        /// Returns all active NHL franchises
        /// </summary>
        /// <returns>A collection of all active NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetActiveFranchisesAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LegaueFranchises>("/franchises"))
                .Franchises
                .Where(franchise => !franchise.LastSeasonId.HasValue)
                .ToList();
        }

        /// <summary>
        /// Returns all of the NHL conferences
        /// </summary>
        /// <param name="conferenceId">The NHL conference id, Example: Eastern Conference is the number 6</param>
        /// <returns>An NHL conference, see <see cref="Conference"/> for more information</returns>
        public async Task<Conference> GetConferenceByIdAsync(int conferenceId)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueConferences>($"/conferences/{conferenceId}"))
                .Conferences
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns the NHL conference by the conference enumeration <br/>
        /// Example: <see cref="ConferenceEnum.Eastern"/>
        /// </summary>
        /// <param name="conference">The NHL conference id, Example: 6 - Eastern Conference, see <see cref="ConferenceEnum"/> for more information on NHL conferences</param>
        /// <returns>An NHL conference, see <see cref="Conference"/> for more information</returns>
        public async Task<Conference> GetConferenceByIdAsync(ConferenceEnum conference)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueConferences>($"/conferences/{((int)conference)}"))
            .Conferences
            .SingleOrDefault();
        }

        /// <summary>
        /// Returns all of the NHL conferences
        /// </summary>
        /// <returns>A collection of all the NHL conferences, see <see cref="Conference"/> for more information</returns>
        public async Task<List<Conference>> GetConferencesAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueConferences>($"/conferences")).Conferences;
        }

        /// <summary>
        /// Return the current and most recent NHL season
        /// </summary>
        /// <returns>The most recent NHL season</returns>
        public async Task<Season> GetCurrentSeasonAsync()
        {
            return (await GetSeasonsAsync()).OrderBy(x => x.SeasonId).Last();
        }

        /// <summary>
        /// Returns an NHL division by the division enumeration <br/>
        /// Example: <see cref="DivisionEnum.Atlantic"/>
        /// </summary>
        /// <param name="division">The NHL division id, Example: 17 - Atlantic division, see <see cref="DivisionEnum"/> for more information on NHL divisions </param>
        /// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
        public async Task<Division> GetDivisionByIdAsync(DivisionEnum division)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueDivisions>($"/divisions/{((int)division)}"))
                .Divisions
                .FirstOrDefault();
        }

        /// <summary>
        /// Returns an NHL division by the division id
        /// </summary>
        /// <param name="divisionId">The NHL division id, Example: Atlantic division is the number 17</param>
        /// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
        public async Task<Division> GetDivisionByIdAsync(int divisionId)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueDivisions>($"/divisions/{divisionId}"))
                .Divisions
                .FirstOrDefault();
        }

        /// <summary>
        /// Returns all of the NHL divisions
        /// </summary>
        /// <returns>A collection of all the NHL divisions, see <see cref="Division"/> for more information</returns>
        public async Task<List<Division>> GetDivisionsAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueDivisions>($"/divisions")).Divisions;
        }

        /// <summary>
        /// Returns the NHL league draft based on a specific year based on the 4 character draft year, see <see cref="DraftYear"/> for more information. <br/>
        /// <strong>Note:</strong> Some responses provide very large JSON payloads
        /// </summary>
        /// <param name="year">The specified year of the NHL draft, see <see cref="DraftYear"/> for all NHL draft years</param>
        /// <returns>The NHL league draft, which includes draft rounds, player information and more, see <see cref="LeagueDraft"/> for more information</returns>
        public async Task<LeagueDraft> GetDraftByYear(string year)
        {
            if (string.IsNullOrEmpty(year))
            {
                throw new ArgumentNullException(nameof(year));
            }

            if (year.Length > 4)
            {
                throw new ArgumentException($"{nameof(year)} is not a valid draft year format");
            }

            return await _nhlStatsApiHttpClient.GetAsync<LeagueDraft>($"/draft/{year}");
        }

        /// <summary>
        /// Return's all the event types within the NHL
        /// </summary>
        /// <returns>A collection of event types within the NHL, see <see cref="EventType"/> for more information</returns>
        public async Task<List<EventType>> GetEventTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<EventType>>("/eventTypes");
        }

        /// <summary>
        /// Returns an NHL franchise by the franchise id
        /// </summary>
        /// <param name="franchiseId">The NHL franchise id, Example: Montréal Canadiens - 1 </param>
        /// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
        public async Task<Franchise> GetFranchiseByIdAsync(int franchiseId)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LegaueFranchises>($"/franchises/{franchiseId}"))
                .Franchises
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns all inactive NHL franchises
        /// </summary>
        /// <returns>A collection of all inactive NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetInactiveFranchisesAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LegaueFranchises>("/franchises"))
                .Franchises
                .Where(franchise => franchise.LastSeasonId.HasValue)
                .ToList();
        }

        /// <summary>
        /// Returns all inactive NHL teams
        /// </summary>
        /// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetInactiveTeamsAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueTeam>($"/teams"))
                .Teams
                .Where(team => !team.Active)
                .ToList();
        }

        /// <summary>
        /// Returns an NHL award by id <br/>
        /// </summary>
        /// <param name="awardId">The identifier for the NHL award, Example: Ted Lindsay Award - 13</param>
        /// <returns>An NHL award, see <see cref="Award"/> for more information</returns>
        public async Task<Award> GetLeagueAwardByIdAsync(int awardId)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueAwards>($"/awards/{awardId}"))
                .Awards
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns all of the NHL awards, including the description, history, and images
        /// </summary>
        /// <returns>A collection of all the NHL awards, see <see cref="Award"/> for more information</returns>
        public async Task<List<Award>> GetLeagueAwardsAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueAwards>("/awards")).Awards;
        }

        /// <summary>
        /// Returns the standings of every team in the NHL for the provided date, if the date is null it will provide the current NHL league standings
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings</param>
        /// <returns>A collection of all the league standings </returns>
        public async Task<List<Records>> GetLeagueStandingsAsync(DateTime? date)
        {
            var httpRequestUri = date.HasValue ? $"/standings?date={date.Value:yyyy-MM-dd}" : "/standings";
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueStandings>(httpRequestUri)).Records;
        }

        /// <summary>
        /// Returns the standings of every team in the NHL for the current date
        /// </summary>
        /// <returns>A collection of all the league standings </returns>
        public async Task<List<Records>> GetLeagueStandingsAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueStandings>("/standings")).Records;
        }

        /// <summary>
        /// Returns the standings of every team in the NHL by conference for the current date
        /// </summary>
        /// <returns>A collection of all the league standings by conference</returns>
        public async Task<List<Records>> GetLeagueStandingsByConferenceAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueStandings>("/standings/byConference")).Records;
        }

        /// <summary>
        /// Returns the standings of every team in the NHL by conference for the current date, if the date is null it will provide the current NHL league standings by conference
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings by conference</param>
        /// <returns>A collection of all the league standings by conference for the selected date</returns>
        public async Task<List<Records>> GetLeagueStandingsByConferenceAsync(DateTime? date)
        {
            var httpRequestUri = date.HasValue ? $"/standings/byConference?date={date.Value:yyyy-MM-dd}" : "/standings/byConference";
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueStandings>(httpRequestUri)).Records;
        }

        /// <summary>
        /// Returns the standings of every team by division in the NHL for the current date
        /// </summary>
        /// <returns>A collection of all the league standings by division</returns>
        public async Task<List<Records>> GetLeagueStandingsByDivisionAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueStandings>("/standings/byDivision")).Records;
        }

        /// <summary>
        /// Returns all of the NHL league standing types, this includes playoff and pre-season standings
        /// </summary>
        /// <returns>A collection of all the NHL standing types, see <see cref="LeagueStandingType"/> for more information</returns>
        public async Task<List<LeagueStandingType>> GetLeagueStandingTypesAsync()
        {
            return await _nhlStatsApiHttpClient.GetAsync<List<LeagueStandingType>>($"/standingsTypes");
        }

        /// <summary>
        /// Returns an NHL venue by the venue enumeration <br/>
        ///  Example: <see cref="VenueEnum.EnterpriseCenter"/>
        /// </summary>
        /// <param name="venue">The specified NHL venue, see <see cref="VenueEnum"/> for more information on NHL venues </param>
        /// <returns>An NHL venue, see <see cref="LeagueVenue"/> for more information</returns>
        public async Task<LeagueVenue> GetLeagueVenueByIdAsync(VenueEnum venue)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueVenues>($"/venues/{((int)venue)}"))
            .Venues
            .SingleOrDefault();
        }

        /// <summary>
        /// Returns an NHL venue by the venue id <br/>
        ///  Example: 5058 - Canada Life Centre
        /// </summary>
        /// <param name="venueId">The specified id of an NHL venue, </param>
        /// <returns>An NHL venue, see <see cref="LeagueVenue"/> for more information</returns>
        public async Task<LeagueVenue> GetLeagueVenueByIdAsync(int venueId)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueVenues>($"/venues/{venueId}"))
                .Venues
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns all of the NHL venue's, including arenas and stadiums <br/>
        /// <strong>NOTE:</strong> This is not a comprehensive list of all NHL stadiums and arenas
        /// </summary>
        /// <returns>A collection of NHL stadiums and arenas, see <see cref="LeagueVenue"/> for more information</returns>
        public async Task<List<LeagueVenue>> GetLeagueVenuesAsync()
        {
            var venueTasks = Enum.GetValues(typeof(VenueEnum)).Cast<int>().Select(venueId => GetLeagueVenueByIdAsync(venueId));

            return (await Task.WhenAll(venueTasks)).ToList();
        }


        /// <summary>
        /// Returns the NHL season information based on the provided season years
        /// </summary>
        /// <param name="seasonYear">See <see cref="SeasonYear"/> for all valid season year arguments</param>
        /// <returns>An NHL season based on the provided season year, Example: '20172018'</returns>
        public async Task<Season> GetSeasonByYearAsync(string seasonYear)
        {
            if (string.IsNullOrEmpty(seasonYear))
            {
                throw new ArgumentNullException(nameof(seasonYear));
            }

            if (seasonYear.Length > 8)
            {
                throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
            }

            return (await _nhlStatsApiHttpClient.GetAsync<LeagueSeasons>($"/seasons/{seasonYear}"))
                .Seasons
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns an NHL team by the team id
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: Toronto Maple Leafs - 10</param>
        /// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        public async Task<Team> GetTeamByIdAsync(int teamId)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueTeam>($"/teams/{teamId}"))
                .Teams
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns an NHL team by the team enumeration <br/>
        /// Example: <see cref="TeamEnum.SeattleKraken"/>
        /// </summary>
        /// <param name="team">The NHL team id, Example: 10 - Toronto Maple Leafs, see <see cref="TeamEnum"/> for more information on NHL teams</param>
        /// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information on teams</returns>
        public async Task<Team> GetTeamByIdAsync(TeamEnum team)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueTeam>($"/teams/{((int)team)}"))
            .Teams
            .SingleOrDefault();
        }

        /// <summary>
        /// Returns an the NHL team logo based a dark or light preference using the NHL team enumeration
        /// </summary>
        /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
        /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
        /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
        public async Task<TeamLogo> GetTeamLogoAsync(TeamEnum team, TeamLogoType teamLogoType = TeamLogoType.Light)
        {
            var endpoint = $"images/logos/teams-current-primary-{teamLogoType.ToString().ToLower()}/{(int)team}.svg";
            var imageContent = await _nhlStaticAssetsApiHttpClient.GetByteArrayAsync(endpoint);

            return new TeamLogo
            {
                ImageAsBase64String = $"data:image/png;base64,{Convert.ToBase64String(imageContent)}",
                ImageAsByteArray = imageContent,
                Uri = $"{_nhlStaticAssetsApiHttpClient.Client}{endpoint}"
            };
        }

        /// <summary>
        /// Returns an the NHL team logo based a dark or light preference using the NHL team id
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
        /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
        public async Task<TeamLogo> GetTeamLogoAsync(int teamId, TeamLogoType teamLogoType = TeamLogoType.Light)
        {
            var endpoint = $"images/logos/teams-current-primary-{teamLogoType.ToString().ToLower()}/{teamId}.svg";
            var imageContent = await _nhlStaticAssetsApiHttpClient.GetByteArrayAsync(endpoint);

            return new TeamLogo
            {
                ImageAsBase64String = $"data:image/png;base64,{Convert.ToBase64String(imageContent)}",
                ImageAsByteArray = imageContent,
                Uri = $"{_nhlStaticAssetsApiHttpClient.Client}{endpoint}"
            };
        }

        /// <summary>
        /// Returns all active and inactive NHL teams
        /// </summary>
        /// <returns>A collection of all NHL teams, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetTeamsAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueTeam>($"/teams")).Teams;
        }

        /// <summary>
        /// Returns all active NHL teams
        /// </summary>
        /// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetActiveTeamsAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueTeam>($"/teams"))
                .Teams
                .Where(team => team.Active)
                .ToList();
        }

        /// <summary>
        /// Returns a collection of NHL team by the team id's
        /// </summary>
        /// <param name="teamIds">A collection of NHL team id's, Example: 10 - Toronto Maple Leafs</param>
        /// <returns>A collection of NHL team's with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetTeamsByIdsAsync(IEnumerable<int> teamIds)
        {
            var teamValues = teamIds.Aggregate(string.Empty, (currentTeam, nextTeam) => $"{currentTeam},{nextTeam}").TrimStart(',');
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueTeam>($"/teams?teamId={teamValues}")).Teams;
        }

        /// <summary>
        /// Determines whether the NHL regular season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL regular season is active (true) or inactive (false)</returns>
        public async Task<bool> IsRegularSeasonActiveAsync()
        {
            var currentSeason = (await GetSeasonsAsync()).OrderBy(x => x.SeasonId).Last();

            return DateTime.UtcNow.Date > currentSeason.RegularSeasonStartDate && DateTime.UtcNow.Date < currentSeason.RegularSeasonEndDate;
        }

        /// <summary>
        /// Determines whether the NHL playoff season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL playoff season is active (true) or inactive (false)</returns>
        public async Task<bool> IsPlayoffsActiveAsync()
        {
            var currentSeason = (await GetSeasonsAsync()).OrderBy(x => x.SeasonId).Last();

            return DateTime.UtcNow.Date > currentSeason.RegularSeasonEndDate && DateTime.UtcNow.Date < currentSeason.SeasonEndDate;
        }

        /// <summary>
        /// Determines whether the NHL season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL season is active (true) or inactive (false)</returns>
        public async Task<bool> IsSeasonActiveAsync()
        {
            var currentSeason = (await GetSeasonsAsync()).OrderBy(x => x.SeasonId).Last();

            return DateTime.UtcNow.Date > currentSeason.RegularSeasonEndDate && DateTime.UtcNow.Date < currentSeason.SeasonEndDate;
        }

        /// <summary>
        /// Returns all of the NHL seasons since the inception of the league in 1917-1918
        /// </summary>
        /// <returns>A collection of seasons since the inception of the NHL</returns>
        public async Task<List<Season>> GetSeasonsAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueSeasons>("/seasons")).Seasons;
        }


        /// <summary>
        /// Returns an NHL franchise by the franchise id <br/>
        /// Example: <see cref="FranchiseEnum.LosAngelesKings"/>
        /// </summary>
        /// <param name="franchise">The NHL team id, Example: 10 - Toronto Maple Leafs, see <see cref="FranchiseEnum"/> for more information on NHL franchises</param>
        /// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
        public async Task<Franchise> GetFranchiseByIdAsync(FranchiseEnum franchise)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LegaueFranchises>($"/franchises/{(int)franchise}"))
            .Franchises
            .SingleOrDefault();
        }

        /// <summary>
        /// Returns a collection of NHL team's by the team enumeration values
        /// </summary>
        /// <param name="teams">A collection of NHL team id's, Example: 10 - Toronto Maple Leafs, see <see cref="TeamEnum"/> for more information on NHL teams</param>
        /// <returns>A collection of NHL team's with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetTeamsByIdsAsync(IEnumerable<TeamEnum> teams)
        {
            var teamValues = teams.Aggregate(string.Empty, (currentTeam, nextTeam) => $"{currentTeam},{(int)nextTeam}").TrimStart(',');
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueTeam>($"/teams?teamId={teamValues}")).Teams;
        }

        /// <summary>
        /// Returns the standings of every team by division in the NHL by date, if the date is null it will provide the current NHL league standings by division
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings by division</param>
        /// <returns>A collection of all the league standings by division for the selected date</returns>
        public async Task<List<Records>> GetLeagueStandingsByDivisionAsync(DateTime? date)
        {
            var httpRequestUri = date.HasValue ? $"/standings/byDivision?date={date.Value:yyyy-MM-dd}" : "/standings/byDivision";
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueStandings>(httpRequestUri)).Records;
        }

        /// <summary>
        /// Returns an NHL award by the award id <br/>
        /// Example: <see cref="AwardEnum.StanleyCup"/>
        /// </summary>
        /// <param name="leagueAward">The NHL league award identifier, see <see cref="AwardEnum"/> for more information on NHL awards </param>
        /// <returns>An NHL award, see <see cref="Award"/> for more information</returns>
        public async Task<Award> GetLeagueAwardByIdAsync(AwardEnum leagueAward)
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueAwards>($"/awards/{((int)leagueAward)}"))
            .Awards
            .SingleOrDefault();
        }
    }
}
