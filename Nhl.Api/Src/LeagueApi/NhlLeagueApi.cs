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
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
    /// </summary>
    public class NhlLeagueApi : INhlLeagueApi
    {
        private static readonly INhlApiHttpClient _nhlStatsApiHttpClient = new NhlStatsApiHttpClient();
        private static readonly INhlApiHttpClient _nhlStaticAssetsApiHttpClient = new NhlStaticAssetsApiHttpClient();

        /// <summary>
        /// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
        /// </summary>
        public NhlLeagueApi()
        {

        }

        /// <summary>
        /// Returns all NHL franchises, including information such as team name, location and more
        /// </summary>
        /// <returns>A collection of all NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetFranchisesAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueFranchises>("/franchises")).Franchises;
        }

        /// <summary>
        /// Returns all active NHL franchises
        /// </summary>
        /// <returns>A collection of all active NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetActiveFranchisesAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueFranchises>("/franchises"))
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
        public async Task<LeagueDraft> GetDraftByYearAsync(string year)
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
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueFranchises>($"/franchises/{franchiseId}"))
                .Franchises
                .SingleOrDefault();
        }

        /// <summary>
        /// Returns all inactive NHL franchises
        /// </summary>
        /// <returns>A collection of all inactive NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetInactiveFranchisesAsync()
        {
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueFranchises>("/franchises"))
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
            var endpoint = $"logos/nhl/svg/{GetTeamCodeIdentfier((int)team)}_{GetTeamLogoColorIdentfier(teamLogoType)}.svg";
            var imageContent = await _nhlStaticAssetsApiHttpClient.GetByteArrayAsync(endpoint);

            return new TeamLogo
            {
                ImageAsBase64String = $"data:image/svg+xml;base64,{Convert.ToBase64String(imageContent)}",
                ImageAsByteArray = imageContent,
                Uri = $"{_nhlStaticAssetsApiHttpClient.Client}/{endpoint}"
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
            var endpoint = $"logos/nhl/svg/{GetTeamCodeIdentfier(teamId)}_{GetTeamLogoColorIdentfier(teamLogoType)}.svg";
            var imageContent = await _nhlStaticAssetsApiHttpClient.GetByteArrayAsync(endpoint);

            return new TeamLogo
            {
                ImageAsBase64String = $"data:image/svg+xml;base64,{Convert.ToBase64String(imageContent)}",
                ImageAsByteArray = imageContent,
                Uri = $"{_nhlStaticAssetsApiHttpClient.Client}/{endpoint}"
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
            return (await _nhlStatsApiHttpClient.GetAsync<LeagueFranchises>($"/franchises/{(int)franchise}"))
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

        /// <summary>
        /// Returns the hexadecimal code for an NHL team's colors
        /// </summary>
        /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
        /// <returns>An NHL team color scheme using hexadecimal codes</returns>
        public async Task<TeamColors> GetTeamColorsAsync(TeamEnum team)
        {
            var teamColors = team switch
            {
                TeamEnum.NewJerseyDevils => new TeamColors
                {
                    PrimaryColor = "#CE1126",
                    SecondaryColor = "#000000",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.NewYorkIslanders => new TeamColors
                {
                    PrimaryColor = "#00539B",
                    SecondaryColor = "#F47D30",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.NewYorkRangers => new TeamColors
                {
                    PrimaryColor = "#0038A8",
                    SecondaryColor = "#CE1126",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.PhiladelphiaFlyers => new TeamColors
                {
                    PrimaryColor = "#F74902",
                    SecondaryColor = "#000000",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.PittsburghPenguins => new TeamColors
                {
                    PrimaryColor = "#F74902",
                    SecondaryColor = "#000000",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.BostonBruins => new TeamColors
                {
                    PrimaryColor = "#FFB81C",
                    SecondaryColor = "#000000",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.BuffaloSabres => new TeamColors
                {
                    PrimaryColor = "#002654",
                    SecondaryColor = "#FCB514",
                    TertiaryColor = "#ADAFAA",
                    QuaternaryColor = "#C8102E"
                },
                TeamEnum.MontrealCanadiens => new TeamColors
                {
                    PrimaryColor = "#AF1E2D",
                    SecondaryColor = "#192168",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.OttawaSenators => new TeamColors
                {
                    PrimaryColor = "#C52032",
                    SecondaryColor = "#C2912C",
                    TertiaryColor = "#000000",
                    QuaternaryColor = "#FFFFFF"
                },
                TeamEnum.TorontoMapleLeafs => new TeamColors
                {
                    PrimaryColor = "#00205B",
                    SecondaryColor = "#FFFFFF"
                },
                TeamEnum.CarolinaHurricanes => new TeamColors
                {
                    PrimaryColor = "#CC0000",
                    SecondaryColor = "#000000",
                    TertiaryColor = "#A2AAAD",
                    QuaternaryColor = "#76232F"
                },
                TeamEnum.FloridaPanthers => new TeamColors
                {
                    PrimaryColor = "#041E42",
                    SecondaryColor = "#C8102E",
                    TertiaryColor = "#B9975B"
                },
                TeamEnum.TampaBayLightning => new TeamColors
                {
                    PrimaryColor = "#002868",
                    SecondaryColor = "#FFFFFF"
                },
                TeamEnum.WashingtonCapitals => new TeamColors
                {
                    PrimaryColor = "#041E42",
                    SecondaryColor = "#C8102E",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.ChicagoBlackhawks => new TeamColors
                {
                    PrimaryColor = "#CF0A2C",
                    SecondaryColor = "#FF671B",
                    TertiaryColor = "#00833E",
                    QuaternaryColor = "#FFD100",
                    QuinaryColor = "#D18A00",
                    SenaryColor = "#001970",
                    SeptenaryColor = "#000000"
                },
                TeamEnum.DetroitRedWings => new TeamColors
                {
                    PrimaryColor = "#CE1126",
                    SecondaryColor = "#FFFFFF"
                },
                TeamEnum.NashvillePredators => new TeamColors
                {
                    PrimaryColor = "#FFB81C",
                    SecondaryColor = "#041E42",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.StLouisBlues => new TeamColors
                {
                    PrimaryColor = "#002F87",
                    SecondaryColor = "#FCB514",
                    TertiaryColor = "#041E42",
                    QuaternaryColor = "#FFFFFF"
                },
                TeamEnum.CalgaryFlames => new TeamColors
                {
                    PrimaryColor = "#C8102E",
                    SecondaryColor = "#F1BE48",
                    TertiaryColor = "#111111",
                    QuaternaryColor = "#FFFFFF"
                },
                TeamEnum.ColoradoAvalanche => new TeamColors
                {
                    PrimaryColor = "#6F263D",
                    SecondaryColor = "#236192",
                    TertiaryColor = "#A2AAAD",
                    QuaternaryColor = "#000000"
                },
                TeamEnum.EdmontonOilers => new TeamColors
                {
                    PrimaryColor = "#041E42",
                    SecondaryColor = "#FF4C00",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.VancouverCanucks => new TeamColors
                {
                    PrimaryColor = "#00205B",
                    SecondaryColor = "#00843D",
                    TertiaryColor = "#041C2C",
                    QuaternaryColor = "#99999A"
                },
                TeamEnum.AnaheimDucks => new TeamColors
                {
                    PrimaryColor = "#F47A38",
                    SecondaryColor = "#B9975B",
                    TertiaryColor = "#C1C6C8",
                    QuaternaryColor = "#000000"
                },
                TeamEnum.DallasStars => new TeamColors
                {
                    PrimaryColor = "#006847",
                    SecondaryColor = "#8F8F8C",
                    TertiaryColor = "#111111"
                },
                TeamEnum.LosAngelesKings => new TeamColors
                {
                    PrimaryColor = "#111111",
                    SecondaryColor = "#A2AAAD",
                    TertiaryColor = "#FFFFFF"
                },
                TeamEnum.SanJoseSharks => new TeamColors
                {
                    PrimaryColor = "#006D75",
                    SecondaryColor = "#EA7200",
                    TertiaryColor = "#000000",
                    QuaternaryColor = "#FFFFFF"
                },
                TeamEnum.ColumbusBlueJackets => new TeamColors
                {
                    PrimaryColor = "#002654",
                    SecondaryColor = "#CE1126",
                    TertiaryColor = "#A4A9AD"
                },
                TeamEnum.MinnesotaWild => new TeamColors
                {
                    PrimaryColor = "#A6192E",
                    SecondaryColor = "#154734",
                    TertiaryColor = "#EAAA00",
                    QuaternaryColor = "#DDCBA4"
                },
                TeamEnum.WinnipegJets => new TeamColors
                {
                    PrimaryColor = "#041E42",
                    SecondaryColor = "#004C97",
                    TertiaryColor = "#AC162C",
                    QuaternaryColor = "#7B303E",
                    QuinaryColor = "#55565A",
                    SenaryColor = "#8E9090",
                    SeptenaryColor = "#FFFFFF"
                },
                TeamEnum.ArizonaCoyotes => new TeamColors
                {
                    PrimaryColor = "#8C2633",
                    SecondaryColor = "#E2D6B5",
                    TertiaryColor = "#111111"
                },
                TeamEnum.VegasGoldenKnights => new TeamColors
                {
                    PrimaryColor = "#B4975A",
                    SecondaryColor = "#333F42",
                    TertiaryColor = "#C8102E",
                    QuaternaryColor = "#000000",
                    QuinaryColor = "#FFFFFF"
                },
                TeamEnum.SeattleKraken => new TeamColors
                {
                    PrimaryColor = "#001628",
                    SecondaryColor = "#99D9D9",
                    TertiaryColor = "#355464",
                    QuaternaryColor = "#68A2B9",
                    QuinaryColor = "#E9072B"
                },
                _ => null,
            };

            return await Task.FromResult(teamColors);
        }

        /// <summary>
        /// Returns the hexadecimal code for an NHL team's colors
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <returns>An NHL team color scheme using hexadecimal codes</returns>
        public async Task<TeamColors> GetTeamColorsAsync(int teamId)
        {
            var teamEnum = Enum.Parse<TeamEnum>(teamId.ToString());

            return await GetTeamColorsAsync(teamEnum);
        }


        private static string GetTeamLogoColorIdentfier(TeamLogoType teamLogoType) =>teamLogoType switch
        {
            TeamLogoType.Dark => "dark",
            TeamLogoType.Light => "light",
            _ => null
        };

        private static string GetTeamCodeIdentfier(int team) => team switch
        {
            (int)TeamEnum.AnaheimDucks => TeamCodes.MightyDucksofAnaheimAnaheimDucks,
            (int)TeamEnum.ArizonaCoyotes => TeamCodes.ArizonaCoyotes,
            (int)TeamEnum.BostonBruins => TeamCodes.BostonBruins,
            (int)TeamEnum.BuffaloSabres => TeamCodes.BuffaloSabres,
            (int)TeamEnum.CalgaryFlames => TeamCodes.CalgaryFlames,
            (int)TeamEnum.CarolinaHurricanes => TeamCodes.CarolinaHurricanes,
            (int)TeamEnum.ChicagoBlackhawks => TeamCodes.ChicagoBlackHawksBlackhawks,
            (int)TeamEnum.ColoradoAvalanche => TeamCodes.ColoradoAvalanche,
            (int)TeamEnum.ColumbusBlueJackets => TeamCodes.ColumbusBlueJackets,
            (int)TeamEnum.DallasStars => TeamCodes.DallasStars,
            (int)TeamEnum.DetroitRedWings => TeamCodes.DetroitRedWings,
            (int)TeamEnum.EdmontonOilers => TeamCodes.EdmontonOilers,
            (int)TeamEnum.FloridaPanthers => TeamCodes.FloridaPanthers,
            (int)TeamEnum.LosAngelesKings => TeamCodes.LosAngelesKings,
            (int)TeamEnum.MinnesotaWild => TeamCodes.MinnesotaWild,
            (int)TeamEnum.MontrealCanadiens => TeamCodes.MontrealCanadiens,
            (int)TeamEnum.NashvillePredators => TeamCodes.NashvillePredators,
            (int)TeamEnum.NewJerseyDevils => TeamCodes.NewJerseyDevils,
            (int)TeamEnum.NewYorkIslanders => TeamCodes.NewYorkIslanders,
            (int)TeamEnum.NewYorkRangers => TeamCodes.NewYorkRangers,
            (int)TeamEnum.OttawaSenators => TeamCodes.OttawaSenators,
            (int)TeamEnum.PhiladelphiaFlyers => TeamCodes.PhiladelphiaFlyers,
            (int)TeamEnum.PittsburghPenguins => TeamCodes.PittsburghPenguins,
            (int)TeamEnum.SanJoseSharks => TeamCodes.SanJoseSharks,
            (int)TeamEnum.SeattleKraken => TeamCodes.SeattleKraken,
            (int)TeamEnum.StLouisBlues => TeamCodes.StLouisBlues,
            (int)TeamEnum.TampaBayLightning => TeamCodes.TampaBayLightning,
            (int)TeamEnum.TorontoMapleLeafs => TeamCodes.TorontoMapleLeafs,
            (int)TeamEnum.VancouverCanucks => TeamCodes.VancouverCanucks,
            (int)TeamEnum.VegasGoldenKnights => TeamCodes.VegasGoldenKnights,
            (int)TeamEnum.WashingtonCapitals => TeamCodes.WashingtonCapitals,
            (int)TeamEnum.WinnipegJets => TeamCodes.WinnipegJets,
            _ => null
        };
    }
}
