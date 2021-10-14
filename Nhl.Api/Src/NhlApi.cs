using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Nhl.Api.Models.Award;
using Nhl.Api.Models.Conference;
using Nhl.Api.Models.Division;
using Nhl.Api.Models.Draft;
using Nhl.Api.Models.Event;
using Nhl.Api.Models.Franchise;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standing;
using Nhl.Api.Models.Statistics;
using Nhl.Api.Models.Team;
using Nhl.Api.Models.Venue;
using Nhl.Api.Common.Http;
using Nhl.Api.Domain.Models.League;
using Nhl.Api.Domain.Models.Team;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Domain.Enumerations.Franchise;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Enumerations.Division;
using Nhl.Api.Models.Enumerations.Conference;
using Nhl.Api.Models.Enumerations.Award;
using Nhl.Api.Domain.Enumerations.Venue;
using Nhl.Api.Domain.Enumerations.Player;
using Nhl.Api.Domain.Models.Player;
using Nhl.Api.Common.Extensions;
using Nhl.Api.Common.Exceptions;

namespace Nhl.Api
{
	/// <summary>
	/// The Unofficial NHL API providing various NHL information about players, teams, conferences, divisions, statistics and more
	/// </summary>
	public class NhlApi : INhlApi
	{


		/// <summary>
		/// Returns all NHL franchises, including information such as team name, location and more
		/// </summary>
		/// <returns>A collection of all NHL franchises, see <see cref="Franchise"/> for more information</returns>
		public async Task<List<Franchise>> GetFranchisesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>("/franchises")).Franchises;
		}

		/// <summary>
		/// Returns all active NHL franchises
		/// </summary>
		/// <returns>A collection of all active NHL franchises, see <see cref="Franchise"/> for more information</returns>
		public async Task<List<Franchise>> GetActiveFranchisesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>("/franchises"))
				.Franchises
				.Where(franchise => !franchise.LastSeasonId.HasValue)
				.ToList();
		}

		/// <summary>
		/// Returns all inactive NHL franchises
		/// </summary>
		/// <returns>A collection of all inactive NHL franchises, see <see cref="Franchise"/> for more information</returns>
		public async Task<List<Franchise>> GetInactiveFranchisesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>("/franchises"))
				.Franchises
				.Where(franchise => franchise.LastSeasonId.HasValue)
				.ToList();
		}

		/// <summary>
		/// Returns an NHL franchise by the franchise id
		/// </summary>
		/// <param name="franchiseId">The NHL franchise id, example: Montréal Canadiens - 1 </param>
		/// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
		public async Task<Franchise> GetFranchiseByIdAsync(int franchiseId)
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>($"/franchises/{franchiseId}"))
				.Franchises
				.SingleOrDefault();
		}


		/// <summary>
		/// Returns an NHL franchise by the franchise id <br/>
		/// Example: <see cref="FranchiseEnum.LosAngelesKings"/>
		/// </summary>
		/// <param name="franchise">The NHL team id, Example: 10 - Toronto Maple Leafs, see <see cref="FranchiseEnum"/> for more information on NHL franchises</param>
		/// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
		public async Task<Franchise> GetFranchiseByIdAsync(FranchiseEnum franchise)
		{
			return (await NhlApiHttpClient.GetAsync<LegaueFranchises>($"/franchises/{((int)franchise)}"))
			.Franchises
			.SingleOrDefault();
		}


		/// <summary>
		/// Returns an NHL team by the team id
		/// </summary>
		/// <param name="teamId">The NHL team id, example: Toronto Maple Leafs - 10</param>
		/// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
		public async Task<Team> GetTeamByIdAsync(int teamId)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams/{teamId}"))
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
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams/{((int)team)}"))
			.Teams
			.SingleOrDefault();
		}

		/// <summary>
		/// Returns all active and inactive NHL teams
		/// </summary>
		/// <returns>A collection of all NHL teams, see <see cref="Team"/> for more information</returns>
		public async Task<List<Team>> GetTeamsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams")).Teams;
		}

		/// <summary>
		/// Returns all active NHL teams
		/// </summary>
		/// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
		public async Task<List<Team>> GetActiveTeamsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams"))
				.Teams
				.Where(team => team.Active)
				.ToList();
		}

		/// <summary>
		/// Returns all inactive NHL teams
		/// </summary>
		/// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
		public async Task<List<Team>> GetInactiveTeamsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueTeam>($"/teams"))
				.Teams
				.Where(team => !team.Active)
				.ToList();
		}

		/// <summary>
		/// Returns all of the NHL divisions
		/// </summary>
		/// <returns>A collection of all the NHL divisions, see <see cref="Division"/> for more information</returns>
		public async Task<List<Division>> GetDivisionsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueDivisions>($"/divisions")).Divisions;
		}

		/// <summary>
		/// Returns an NHL division by the division id
		/// </summary>
		/// <param name="divisionId">The NHL division id, example: Atlantic division is the number 17</param>
		/// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
		public async Task<Division> GetDivisionByIdAsync(int divisionId)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueDivisions>($"/divisions/{divisionId}"))
				.Divisions
				.FirstOrDefault();
		}

		/// <summary>
		/// Returns an NHL division by the division enumeration <br/>
		/// Example: <see cref="DivisionEnum.Atlantic"/>
		/// </summary>
		/// <param name="division">The NHL division id, Example: 17 - Atlantic division, see <see cref="DivisionEnum"/> for more information on NHL divisions </param>
		/// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
		public async Task<Division> GetDivisionByIdAsync(DivisionEnum division)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueDivisions>($"/divisions/{((int)division)}"))
				.Divisions
				.FirstOrDefault();
		}

		/// <summary>
		/// Returns all of the NHL conferences
		/// </summary>
		/// <returns>A collection of all the NHL conferences, see <see cref="Conference"/> for more information</returns>
		public async Task<List<Conference>> GetConferencesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueConferences>($"/conferences")).Conferences;
		}

		/// <summary>
		/// Returns all of the NHL conferences
		/// </summary>
		/// <param name="conferenceId">The NHL conference id, example: Eastern Conference is the number 6</param>
		/// <returns>An NHL conference, see <see cref="Conference"/> for more information</returns>
		public async Task<Conference> GetConferenceByIdAsync(int conferenceId)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueConferences>($"/conferences/{conferenceId}"))
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
			return (await NhlApiHttpClient.GetAsync<LeagueConferences>($"/conferences/{((int)conference)}"))
			.Conferences
			.SingleOrDefault();
		}

		/// <summary>
		/// Returns an NHL player by their player id, includes information such as age, weight, position and more
		/// </summary>
		/// <param name="playerId">An NHL player id, example: 8478402 is Connor McDavid </param>
		/// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
		public async Task<Player> GetPlayerByIdAsync(int playerId)
		{
			return (await NhlApiHttpClient.GetAsync<LeaguePlayers>($"/people/{playerId}"))
				.Players
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns an NHL player by their player id, includes information such as age, weight, position and more
		/// </summary>
		/// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
		/// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
		public async Task<Player> GetPlayerByIdAsync(PlayerEnum player)
		{
			return (await NhlApiHttpClient.GetAsync<LeaguePlayers>($"/people/{((int)player)}"))
				.Players
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns all of the active NHL players
		/// </summary>
		/// <returns>A collection of all NHL players</returns>
		public async Task<List<TeamRosterMember>> GetLeagueTeamRosterMembersAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueRosters>($"/teams?expand=team.roster"))
				.Teams
				.SelectMany(team => team.Roster.Roster)
				.ToList();
		}

		/// <summary>
		/// Returns all of the active NHL players based on the search query provided
		/// </summary>
		/// <param name="query">An search term to find NHL players, Example: "Auston Matthews" or "Carey Pr.." or "John C" </param>
		/// <returns>A collection of all NHL players based on the search query provided</returns>
		public async Task<List<TeamRosterMember>> SearchLeagueTeamRosterMembersAsync(string query)
		{
			if (string.IsNullOrWhiteSpace(query))
			{
				return new List<TeamRosterMember>();
			}

			return (await NhlApiHttpClient.GetAsync<LeagueRosters>($"/teams?expand=team.roster"))
				.Teams
				.SelectMany(team => team.Roster.Roster)
				.Where(rosterMember => rosterMember.Person.FullName.ToLowerInvariant().Contains(query.ToLowerInvariant()))
				.ToList();
		}

		/// <summary>
		/// Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
		/// </summary>
		/// <param name="playerId">The identifier for the NHL player</param>
		/// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
		/// <returns>A collection of all the in-depth NHL player statistics by type</returns>
		public async Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(int playerId, string seasonYear)
		{
			if (string.IsNullOrEmpty(seasonYear))
			{
				throw new ArgumentNullException(nameof(seasonYear));
			}

			if (seasonYear.Length > 8)
			{
				throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
			}

			var nhlPlayer = await GetPlayerByIdAsync(playerId);
			var isPlayerPositionGoalie = nhlPlayer?.PrimaryPosition?.Abbreviation == PlayerPositionEnum.G.ToString();
			if (isPlayerPositionGoalie)
			{
				throw new InvalidPlayerPositionException($"The NHL player {nhlPlayer?.FullName ?? "N/A"} - {nhlPlayer?.Id ?? 0} has a position of {nhlPlayer?.PrimaryPosition?.Abbreviation ?? "N/A"} and can not his have statistics retrieved");
			}

			return await NhlApiHttpClient.GetAsync<PlayerSeasonStatistics>($"/people/{playerId}/stats?stats={nameof(PlayerStatisticsTypeEnum.StatsSingleSeason).ToCamelCase()}&season={seasonYear}");
		}

		/// <summary>
		/// Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
		/// </summary>
		/// <param name="player">The identifier for the NHL player</param>
		/// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
		/// <returns>A collection of all the in-depth NHL player statistics by type</returns>
		public async Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(PlayerEnum player, string seasonYear)
		{
			if (string.IsNullOrEmpty(seasonYear))
			{
				throw new ArgumentNullException(nameof(seasonYear));
			}

			if (seasonYear.Length > 8)
			{
				throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
			}

			var nhlPlayer = await GetPlayerByIdAsync((int)player);
			var isPlayerPositionGoalie = nhlPlayer?.PrimaryPosition?.Abbreviation == PlayerPositionEnum.G.ToString();
			if (isPlayerPositionGoalie)
			{
				throw new InvalidPlayerPositionException($"The NHL player {nhlPlayer?.FullName ?? "N/A"} - {nhlPlayer?.Id ?? 0} has a position of {nhlPlayer?.PrimaryPosition?.Abbreviation ?? "N/A"} and can not have his statistics retrieved");
			}

			return await NhlApiHttpClient.GetAsync<PlayerSeasonStatistics>($"/people/{((int)player)}/stats?stats={nameof(PlayerStatisticsTypeEnum.StatsSingleSeason).ToCamelCase()}&season={seasonYear}");
		}

		/// <summary>
		/// Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
		/// </summary>
		/// <param name="playerId">The identifier for the NHL goalie</param>
		/// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
		/// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
		public Task<dynamic> GetGoalieStatisticsBySeasonAsync(int playerId, string seasonYear)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
		/// </summary>
		/// <param name="player">The identifier for the NHL goalie</param>
		/// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
		/// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
		public Task<dynamic> GetGoalieStatisticsBySeasonAsync(PlayerEnum player, string seasonYear)
		{
			throw new NotImplementedException();
		}

		/// <summary>
		/// Returns all of the NHL game types within a season and within special events
		/// </summary>
		/// <returns>A collection of NHL and other sporting event game types, see <see cref="GameType"/> for more information </returns>
		public async Task<List<GameType>> GetGameTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<GameType>>($"/gameTypes");
		}

		/// <summary>
		/// Returns all of the valid NHL game statuses of an NHL game
		/// </summary>
		/// <returns>A collection of NHL game statues, see <see cref="GameStatus"/> for more information</returns>
		public async Task<List<GameStatus>> GetGameStatusesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<GameStatus>>($"/gameStatus");
		}

		/// <summary>
		/// Returns a collection of all the play types within the duration of an NHL game
		/// </summary>
		/// <returns>A collection of distinct play types, see <see cref="PlayType"/> for more information</returns>
		public async Task<List<PlayType>> GetPlayTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<PlayType>>($"/playTypes");
		}

		/// <summary>
		/// Returns a collection of all the different types of tournaments in the hockey
		/// </summary>
		/// <returns>A collection of tournament types, see <see cref="TournamentType"/> for more information</returns>
		public async Task<List<TournamentType>> GetTournamentTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<TournamentType>>($"/tournamentTypes");
		}

		/// <summary>
		/// Returns a collection of all the different types of playoff tournaments in the NHL 
		/// </summary>
		/// <returns>A collection of tournament types, see <see cref="PlayoffTournamentType"/> for more information</returns>
		public async Task<PlayoffTournamentType> GetPlayoffTournamentTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<PlayoffTournamentType>($"/tournaments/playoffs");
		}

		/// <summary>
		/// Return's the NHL game schedule based on the provided <see cref="DateTime"/>. If the date is null, it will provide today's current NHL game schedule 
		/// </summary>
		/// <param name="date">The requested date for the NHL game schedule</param>
		/// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
		public async Task<GameSchedule> GetGameScheduleByDateAsync(DateTime? date)
		{
			var httpRequestUri = date.HasValue ? $"/schedule?date={date.Value:yyyy-MM-dd}" : "/schedule";
			return await NhlApiHttpClient.GetAsync<GameSchedule>(httpRequestUri);
		}

		/// <summary>
		/// Return's the NHL game schedule based on the provided year, month and day
		/// </summary>
		/// <param name="year">The requested year for the NHL game schedule</param>
		/// <param name="month">The requested month for the NHL game schedule</param>
		/// <param name="day">The requested day for the NHL game schedule</param>
		/// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
		public async Task<GameSchedule> GetGameScheduleByDateAsync(int year, int month, int day)
		{
			return await NhlApiHttpClient.GetAsync<GameSchedule>($"/schedule?date={year}-{month}-{day}");
		}

		/// <summary>
		/// Returns all of the NHL seasons since the inception of the league in 1917-1918
		/// </summary>
		/// <returns>A collection of seasons since the inception of the NHL</returns>
		public async Task<List<Season>> GetSeasonsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueSeasons>("/seasons")).Seasons;
		}

		/// <summary>
		/// Returns the NHL season information based on the provided season years
		/// </summary>
		/// <param name="seasonYear">See <see cref="SeasonYear"/> for all valid season year arguments</param>
		/// <returns>An NHL season based on the provided season year, example: '20172018'</returns>
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

			return (await NhlApiHttpClient.GetAsync<LeagueSeasons>($"/seasons/{seasonYear}"))
				.Seasons
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns all of the NHL league standing types, this includes playoff and preseason standings
		/// </summary>
		/// <returns>A collection of all the NHL standing types, see <see cref="LeagueStandingType"/> for more information</returns>
		public async Task<List<LeagueStandingType>> GetLeagueStandingTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<LeagueStandingType>>($"/standingsTypes");
		}

		/// <summary>
		/// Returns the standings of every team in the NHL for the provided date, if the date is null it will provide the current NHL league standings
		/// </summary>
		/// <param name="date">The NHL league standings date for the request NHL standings</param>
		/// <returns>A collection of all the league standings </returns>
		public async Task<List<Records>> GetLeagueStandingsAsync(DateTime? date)
		{
			var httpRequestUri = date.HasValue ? $"/standings?date={date.Value:yyyy-MM-dd}" : "/standings";
			return (await NhlApiHttpClient.GetAsync<LeagueStandings>(httpRequestUri)).Records;
		}

		/// <summary>
		/// Returns all distinct types of NHL statistics types
		/// </summary>
		/// <returns>A collection of all the various NHL statistics types, see <see cref="StatisticTypes"/> for more information</returns>
		public async Task<List<StatisticTypes>> GetStatisticTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<StatisticTypes>>("/statTypes");
		}

		/// <summary>
		/// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
		/// </summary>
		/// <param name="teamId">The NHL team id, example: Toronto Maple Leafs - 10</param>
		/// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, example: 20202021</param>
		/// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
		public async Task<TeamStatistics> GetTeamStatisticsByIdAsync(int teamId, string seasonYear)
		{
			if (seasonYear?.Length > 8)
			{
				throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
			}

			var httpRequestUri = string.IsNullOrWhiteSpace(seasonYear) ? $"/teams/{teamId}/stats" : $"/teams/{teamId}/stats?season={seasonYear}";
			return await NhlApiHttpClient.GetAsync<TeamStatistics>(httpRequestUri);
		}

		/// <summary>
		/// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
		/// </summary>
		/// <param name="team">The NHL team id, example: <see cref="TeamEnum.AnaheimDucks"/></param>
		/// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, example: 20202021</param>
		/// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
		public async Task<TeamStatistics> GetTeamStatisticsByIdAsync(TeamEnum team, string seasonYear)
		{
			if (seasonYear?.Length > 8)
			{
				throw new ArgumentException($"{nameof(seasonYear)} is not a valid season year format");
			}

			var httpRequestUri = string.IsNullOrWhiteSpace(seasonYear) ? $"/teams/{((int)team)}/stats" : $"/teams/{((int)team)}/stats?season={seasonYear}";
			return await NhlApiHttpClient.GetAsync<TeamStatistics>(httpRequestUri);
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

			return await NhlApiHttpClient.GetAsync<LeagueDraft>($"/draft/{year}");
		}

		/// <summary>
		/// Returns all the NHL league prospects <br/>
		/// <strong>Note:</strong> The NHL prospects response provides a very large JSON payload
		/// </summary>
		/// <returns>A collection of all the NHL prospects, see <see cref="ProspectProfile"/> for more information </returns>
		public async Task<List<ProspectProfile>> GetLeagueProspectsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueProspects>("/draft/prospects")).ProspectProfiles;
		}

		/// <summary>
		/// Returns an NHL prospect profile by their prospect id
		/// </summary>
		/// <param name="prospectId">The NHL prospect id, Example: 86515 - Francesco Pinelli</param>
		/// <returns>An NHL prospect, see <see cref="ProspectProfile"/> for more information </returns>
		public async Task<ProspectProfile> GetLeagueProspectByIdAsync(int prospectId)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueProspects>($"/draft/prospects/{prospectId}"))
				.ProspectProfiles
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns all of the NHL awards, including the description, history, and images
		/// </summary>
		/// <returns>A collection of all the NHL awards, see <see cref="Award"/> for more information</returns>
		public async Task<List<Award>> GetLeagueAwardsAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueAwards>("/awards")).Awards;
		}

		/// <summary>
		/// Returns an NHL award by id <br/>
		/// </summary>
		/// <param name="awardId">The identifier for the NHL award, Example: Ted Lindsay Award - 13</param>
		/// <returns>An NHL award, see <see cref="Award"/> for more information</returns>
		public async Task<Award> GetLeagueAwardByIdAsync(int awardId)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueAwards>($"/awards/{awardId}"))
				.Awards
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns an NHL award by the award id <br/>
		/// Example: <see cref="AwardEnum.StanleyCup"/>
		/// </summary>
		/// <param name="leagueAward">The NHL league award identifier, see <see cref="AwardEnum"/> for more information on NHL awards </param>
		/// <returns>An NHL award, see <see cref="Award"/> for more information</returns>
		public async Task<Award> GetLeagueAwardByIdAsync(AwardEnum leagueAward)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueAwards>($"/awards/{((int)leagueAward)}"))
			.Awards
			.SingleOrDefault();
		}

		/// <summary>
		/// Returns all of the NHL venue's, including arenas and stadiums <br/>
		/// <strong>NOTE:</strong> This is not a comprehensive list of all NHL stadiums and arenas
		/// </summary>
		/// <returns>A collection of NHL stadiums and arenas, see <see cref="LeagueVenue"/> for more information</returns>
		public async Task<List<LeagueVenue>> GetLeagueVenuesAsync()
		{
			return (await NhlApiHttpClient.GetAsync<LeagueVenues>("/venues")).Venues;
		}


		/// <summary>
		/// Returns an NHL venue by the venue id <br/>
		///  Example: 5058 - Canada Life Centre
		/// </summary>
		/// <param name="venueId">The specified id of an NHL venue, </param>
		/// <returns>An NHL venue, see <see cref="LeagueVenue"/> for more information</returns>
		public async Task<LeagueVenue> GetLeagueVenueByIdAsync(int venueId)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueVenues>($"/venues/{venueId}"))
				.Venues
				.SingleOrDefault();
		}

		/// <summary>
		/// Returns an NHL venue by the venue enumeration <br/>
		///  Example: <see cref="VenueEnum.EnterpriseCenter"/>
		/// </summary>
		/// <param name="venue">The specified NHL venue, see <see cref="VenueEnum"/> for more information on NHL venues </param>
		/// <returns>An NHL venue, see <see cref="LeagueVenue"/> for more information</returns>
		public async Task<LeagueVenue> GetLeagueVenueByIdAsync(VenueEnum venue)
		{
			return (await NhlApiHttpClient.GetAsync<LeagueVenues>($"/venues/{((int)venue)}"))
			.Venues
			.SingleOrDefault();
		}

		/// <summary>
		/// Return's all the event types within the NHL
		/// </summary>
		/// <returns>A collection of event types within the NHL, see <see cref="EventType"/> for more information</returns>
		public async Task<List<EventType>> GetEventTypesAsync()
		{
			return await NhlApiHttpClient.GetAsync<List<EventType>>("/eventTypes");
		}
	}
}
