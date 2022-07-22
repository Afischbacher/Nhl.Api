using System;
using System.Collections.Generic;
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
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Enumerations.Division;
using Nhl.Api.Models.Enumerations.Conference;
using Nhl.Api.Models.Enumerations.Award;
using Nhl.Api.Models.Enumerations.Venue;
using Nhl.Api.Models.Enumerations.Franchise;
using Nhl.Api.Models.Enumerations.Prospect;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial Nhl.Api providing various NHL information about players, teams, conferences, divisions, statistics and more
    /// </summary>
    public class NhlApi : INhlApi
    {
        private static readonly INhlLeagueApi _nhlLeagueApi = new NhlLeagueApi();
        private static readonly INhlGameApi _nhlGameApi = new NhlGameApi();
        private static readonly INhlPlayerApi _nhlPlayerApi = new NhlPlayerApi();
        private static readonly INhlStatisticsApi _nhlStatisticsApi = new NhlStatisticsApi();

        /// <summary>
        /// The official unofficial Nhl.Api providing various NHL information about players, teams, conferences, divisions, statistics and more
        /// </summary>
        public NhlApi()
        {

        }

        /// <summary>
        /// Returns all NHL franchises, including information such as team name, location and more
        /// </summary>
        /// <returns>A collection of all NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetFranchisesAsync()
        {
            return await _nhlLeagueApi.GetFranchisesAsync();
        }

        /// <summary>
        /// Returns all active NHL franchises
        /// </summary>
        /// <returns>A collection of all active NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetActiveFranchisesAsync()
        {
            return await _nhlLeagueApi.GetActiveFranchisesAsync();
        }

        /// <summary>
        /// Returns all inactive NHL franchises
        /// </summary>
        /// <returns>A collection of all inactive NHL franchises, see <see cref="Franchise"/> for more information</returns>
        public async Task<List<Franchise>> GetInactiveFranchisesAsync()
        {
            return await _nhlLeagueApi.GetInactiveFranchisesAsync();
        }

        /// <summary>
        /// Returns an NHL franchise by the franchise id
        /// </summary>
        /// <param name="franchiseId">The NHL franchise id, Example: Montréal Canadiens - 1 </param>
        /// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
        public async Task<Franchise> GetFranchiseByIdAsync(int franchiseId)
        {
            return await _nhlLeagueApi.GetFranchiseByIdAsync(franchiseId);
        }

        /// <summary>
        /// Returns an NHL franchise by the franchise id <br/>
        /// Example: <see cref="FranchiseEnum.LosAngelesKings"/>
        /// </summary>
        /// <param name="franchise">The NHL team id, Example: 10 - Toronto Maple Leafs, see <see cref="FranchiseEnum"/> for more information on NHL franchises</param>
        /// <returns> An NHL franchise, see <see cref="Franchise"/> for more information</returns>
        public async Task<Franchise> GetFranchiseByIdAsync(FranchiseEnum franchise)
        {
            return await _nhlLeagueApi.GetFranchiseByIdAsync(franchise);
        }

        /// <summary>
        /// Returns an NHL team by the team id
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: Toronto Maple Leafs - 10</param>
        /// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        public async Task<Team> GetTeamByIdAsync(int teamId)
        {
            return await _nhlLeagueApi.GetTeamByIdAsync(teamId);
        }

        /// <summary>
        /// Returns a collection of NHL team by the team id's
        /// </summary>
        /// <param name="teamIds">A collection of NHL team id's, Example: 10 - Toronto Maple Leafs</param>
        /// <returns>A collection of NHL team's with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetTeamsByIdsAsync(IEnumerable<int> teamIds)
        {
            return await _nhlLeagueApi.GetTeamsByIdsAsync(teamIds);
        }

        /// <summary>
        /// Returns an NHL team by the team enumeration <br/>
        /// Example: <see cref="TeamEnum.SeattleKraken"/>
        /// </summary>
        /// <param name="team">The NHL team id, Example: 10 - Toronto Maple Leafs, see <see cref="TeamEnum"/> for more information on NHL teams</param>
        /// <returns>An NHL team with information including name, location, division and more, see <see cref="Team"/> for more information on teams</returns>
        public async Task<Team> GetTeamByIdAsync(TeamEnum team)
        {
            return await _nhlLeagueApi.GetTeamByIdAsync(team);
        }

        /// <summary>
        /// Returns a collection of NHL team's by the team enumeration values
        /// </summary>
        /// <param name="teams">A collection of NHL team id's, Example: 10 - Toronto Maple Leafs, see <see cref="TeamEnum"/> for more information on NHL teams</param>
        /// <returns>A collection of NHL team's with information including name, location, division and more, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetTeamsByIdsAsync(IEnumerable<TeamEnum> teams)
        {
            return await _nhlLeagueApi.GetTeamsByIdsAsync(teams);
        }

        /// <summary>
        /// Returns all active and inactive NHL teams
        /// </summary>
        /// <returns>A collection of all NHL teams, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetTeamsAsync()
        {
            return await _nhlLeagueApi.GetTeamsAsync();
        }

        /// <summary>
        /// Returns all active NHL teams
        /// </summary>
        /// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetActiveTeamsAsync()
        {
            return await _nhlLeagueApi.GetActiveTeamsAsync();
        }

        /// <summary>
        /// Returns all inactive NHL teams
        /// </summary>
        /// <returns>A collection of all active NHL teams, see <see cref="Team"/> for more information</returns>
        public async Task<List<Team>> GetInactiveTeamsAsync()
        {
            return await _nhlLeagueApi.GetInactiveTeamsAsync();
        }

        /// <summary>
        /// Returns an the NHL team logo based a dark or light preference using the NHL team id
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
        /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
        public async Task<TeamLogo> GetTeamLogoAsync(int teamId, TeamLogoType teamLogoType = TeamLogoType.Light)
        {
            return await _nhlLeagueApi.GetTeamLogoAsync(teamId, teamLogoType);
        }


        /// <summary>
        /// Returns an the NHL team logo based a dark or light preference using the NHL team enumeration
        /// </summary>
        /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
        /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
        /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
        public async Task<TeamLogo> GetTeamLogoAsync(TeamEnum team, TeamLogoType teamLogoType = TeamLogoType.Light)
        {
            return await _nhlLeagueApi.GetTeamLogoAsync(team, teamLogoType);
        }

        /// <summary>
        /// Returns the hexadecimal code for an NHL team's colors
        /// </summary>
        /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
        /// <returns>An NHL team color scheme using hexadecimal codes</returns>
        public async Task<TeamColors> GetTeamColorsAsync(TeamEnum team)
        {
            return await _nhlLeagueApi.GetTeamColorsAsync(team);
        }

        /// <summary>
        /// Returns the hexadecimal code for an NHL team's colors
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <returns>An NHL team color scheme using hexadecimal codes</returns>
        public async Task<TeamColors> GetTeamColorsAsync(int teamId)
        {
            return await _nhlLeagueApi.GetTeamColorsAsync(teamId);
        }

        /// <summary>
        /// Returns all of the NHL team statistics for the specific NHL team identifier and season
        /// </summary>
        /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
        /// <param name="seasonYear">A season year for the entire NHL roster, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        public async Task<StatisticsTeam> GetTeamStatisticsBySeasonAsync(int teamId, string seasonYear)
        {
            return await _nhlStatisticsApi.GetTeamStatisticsBySeasonAsync(teamId, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL team statistics for the specific NHL team identifier and season
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/>, see <see cref="TeamEnum"/> for more information</param>
        /// <param name="seasonYear">A season year for the entire NHL roster, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        public async Task<StatisticsTeam> GetTeamStatisticsBySeasonAsync(TeamEnum team, string seasonYear)
        {
            return await _nhlStatisticsApi.GetTeamStatisticsBySeasonAsync(team, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL team's statistics for the specific NHL season
        /// </summary>
        /// <param name="seasonYear">A season year for the all the NHL statistics, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of NHL team statistics for the specified season</returns>
        public async Task<TeamSeasonStatistics> GetAllTeamsStatisticsBySeasonAsync(string seasonYear)
        {
            return await _nhlStatisticsApi.GetAllTeamsStatisticsBySeasonAsync(seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL divisions
        /// </summary>
        /// <returns>A collection of all the NHL divisions, see <see cref="Division"/> for more information</returns>
        public async Task<List<Division>> GetDivisionsAsync()
        {
            return await _nhlLeagueApi.GetDivisionsAsync();
        }

        /// <summary>
        /// Returns an NHL division by the division id
        /// </summary>
        /// <param name="divisionId">The NHL division id, Example: Atlantic division is the number 17</param>
        /// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
        public async Task<Division> GetDivisionByIdAsync(int divisionId)
        {
            return await _nhlLeagueApi.GetDivisionByIdAsync(divisionId);
        }

        /// <summary>
        /// Returns an NHL division by the division enumeration <br/>
        /// Example: <see cref="DivisionEnum.Atlantic"/>
        /// </summary>
        /// <param name="division">The NHL division id, Example: 17 - Atlantic division, see <see cref="DivisionEnum"/> for more information on NHL divisions </param>
        /// <returns>Returns an NHL division, see <see cref="Division"/> for more information</returns>
        public async Task<Division> GetDivisionByIdAsync(DivisionEnum division)
        {
            return await _nhlLeagueApi.GetDivisionByIdAsync(division);
        }

        /// <summary>
        /// Returns all of the NHL conferences
        /// </summary>
        /// <returns>A collection of all the NHL conferences, see <see cref="Conference"/> for more information</returns>
        public async Task<List<Conference>> GetConferencesAsync()
        {
            return await _nhlLeagueApi.GetConferencesAsync();
        }

        /// <summary>
        /// Returns all of the NHL conferences
        /// </summary>
        /// <param name="conferenceId">The NHL conference id, Example: Eastern Conference is the number 6</param>
        /// <returns>An NHL conference, see <see cref="Conference"/> for more information</returns>
        public async Task<Conference> GetConferenceByIdAsync(int conferenceId)
        {
            return await _nhlLeagueApi.GetConferenceByIdAsync(conferenceId);
        }

        /// <summary>
        /// Returns the NHL conference by the conference enumeration <br/>
        /// Example: <see cref="ConferenceEnum.Eastern"/>
        /// </summary>
        /// <param name="conference">The NHL conference id, Example: 6 - Eastern Conference, see <see cref="ConferenceEnum"/> for more information on NHL conferences</param>
        /// <returns>An NHL conference, see <see cref="Conference"/> for more information</returns>
        public async Task<Conference> GetConferenceByIdAsync(ConferenceEnum conference)
        {
            return await _nhlLeagueApi.GetConferenceByIdAsync(conference);
        }

        /// <summary>
        /// Returns an NHL player by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 is Connor McDavid </param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        public async Task<Player> GetPlayerByIdAsync(int playerId)
        {
            return await _nhlPlayerApi.GetPlayerByIdAsync(playerId);
        }

        /// <summary>
        /// Returns an NHL player by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        public async Task<Player> GetPlayerByIdAsync(PlayerEnum player)
        {
            return await _nhlPlayerApi.GetPlayerByIdAsync(player);
        }

        /// <summary>
        /// Returns a collection of NHL players by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="playerIds">A collection of NHL player identifiers, Example: 8478402 - Connor McDavid </param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        public async Task<List<Player>> GetPlayersByIdAsync(IEnumerable<int> playerIds)
        {
            return await _nhlPlayerApi.GetPlayersByIdAsync(playerIds);
        }

        /// <summary>
        /// Returns a collection of NHL players by their player id, includes information such as age, weight, position and more
        /// </summary>
        /// <param name="players">A collection of NHL player identifiers, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <returns>An NHL player profile, see <see cref="Player"/> for more information</returns>
        public async Task<List<Player>> GetPlayersByIdAsync(IEnumerable<PlayerEnum> players)
        {
            return await _nhlPlayerApi.GetPlayersByIdAsync(players);
        }

        /// <summary>
        /// Returns every single NHL player to ever play
        /// </summary>
        /// <returns>Returns every single NHL player since the league inception</returns>
        public async Task<List<Player>> GetAllPlayersAsync()
        {
            return await _nhlPlayerApi.GetAllPlayersAsync();
        }

        /// <summary>
        /// Returns the NHL player's head shot image by the selected size
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <param name="playerHeadshotImageSize">The size of the head shot image, see <see cref="PlayerHeadshotImageSize"/> for more information </param>
        /// <returns>A byte array content of an NHL player head shot image</returns>
        public async Task<byte[]> GetPlayerHeadshotImageAsync(PlayerEnum player, PlayerHeadshotImageSize playerHeadshotImageSize = PlayerHeadshotImageSize.Small)
        {
            return await _nhlPlayerApi.GetPlayerHeadshotImageAsync(player, playerHeadshotImageSize);
        }

        /// <summary>
        /// Returns the NHL player's head shot image by the selected size
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
        /// <param name="playerHeadshotImageSize">The size of the head shot image, see <see cref="PlayerHeadshotImageSize"/> for more information </param>
        /// <returns>A byte array content of an NHL player head shot image</returns>
        public async Task<byte[]> GetPlayerHeadshotImageAsync(int playerId, PlayerHeadshotImageSize playerHeadshotImageSize = PlayerHeadshotImageSize.Small)
        {
            return await _nhlPlayerApi.GetPlayerHeadshotImageAsync(playerId, playerHeadshotImageSize);
        }

        /// <summary>
        /// Returns all of the active NHL players
        /// </summary>
        /// <returns>A collection of all NHL players</returns>
        public async Task<List<TeamRosterMember>> GetLeagueTeamRosterMembersAsync()
        {
            return await _nhlPlayerApi.GetLeagueTeamRosterMembersAsync();
        }

        /// <summary>
        /// Returns all of the active NHL roster members by a season year 
        /// </summary>
        /// <param name="seasonYear">A season year for the entire NHL roster, Example: 19971998, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all NHL players based on the season year provided</returns>
        public async Task<List<TeamRosterMember>> GetLeagueTeamRosterMembersBySeasonYearAsync(string seasonYear)
        {
            return await _nhlPlayerApi.GetLeagueTeamRosterMembersBySeasonYearAsync(seasonYear);
        }

        /// <summary>
        /// Returns all of the active rostered NHL players based on the search query provided
        /// </summary>
        /// <param name="query">An search term to find NHL players, Example: "Auston Matthews" or "Carey Pr.." or "John C" </param>
        /// <returns>A collection of all rostered and active NHL players based on the search query provided</returns>
        public async Task<List<TeamRosterMember>> SearchLeagueTeamRosterMembersAsync(string query)
        {
            return await _nhlPlayerApi.SearchLeagueTeamRosterMembersAsync(query);
        }

        /// <summary>
        /// Returns any active or inactive NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" </param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        public async Task<List<PlayerSearchResult>> SearchAllPlayersAsync(string query)
        {
            return await _nhlPlayerApi.SearchAllPlayersAsync(query);
        }

        /// <summary>
        /// Returns only active NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" </param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        public async Task<List<PlayerSearchResult>> SearchAllActivePlayersAsync(string query)
        {
            return await _nhlPlayerApi.SearchAllActivePlayersAsync(query);

        }

        /// <summary>
        /// Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics by type</returns>
        public async Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(int playerId, string seasonYear)
        {
            return await _nhlStatisticsApi.GetPlayerStatisticsBySeasonAsync(playerId, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL player statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics by type</returns>
        public async Task<PlayerSeasonStatistics> GetPlayerStatisticsBySeasonAsync(PlayerEnum player, string seasonYear)
        {
            return await _nhlStatisticsApi.GetPlayerStatisticsBySeasonAsync(player, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL players statistics for each season, year by year statistics type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL goalie</param>
        /// <returns>A collection of all the in-depth NHL player statistics for each season year by year</returns>
        public async Task<PlayerSeasonStatisticsYearByYear> GetPlayerStatisticsYearByYearAsync(PlayerEnum player)
        {
            return await _nhlStatisticsApi.GetPlayerStatisticsYearByYearAsync(player);
        }

        /// <summary>
        /// Returns all of the NHL players statistics for each season, year by year statistics type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <returns>A collection of all the in-depth NHL player statistics for each season year by year</returns>
        public async Task<PlayerSeasonStatisticsYearByYear> GetPlayerStatisticsYearByYearAsync(int playerId)
        {
            return await _nhlStatisticsApi.GetPlayerStatisticsYearByYearAsync(playerId);
        }

        /// <summary>
        /// Returns all of the NHL players statistics for home and away games for a season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics for home and away games for a season</returns>
        public async Task<PlayerSeasonStatisticsHomeAndAway> GetPlayerStatisticsHomeAndAwayBySeasonAsync(PlayerEnum player, string seasonYear)
        {
            return await _nhlStatisticsApi.GetPlayerStatisticsHomeAndAwayBySeasonAsync(player, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL players statistics for home and away games for a season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL player statistics for home and away games for a season</returns>
        public async Task<PlayerSeasonStatisticsHomeAndAway> GetPlayerStatisticsHomeAndAwayBySeasonAsync(int playerId, string seasonYear)
        {
            return await _nhlStatisticsApi.GetPlayerStatisticsHomeAndAwayBySeasonAsync(playerId, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
        public async Task<GoalieSeasonStatistics> GetGoalieStatisticsBySeasonAsync(int playerId, string seasonYear)
        {
            return await _nhlStatisticsApi.GetGoalieStatisticsBySeasonAsync(playerId, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL goalie statistics for each season, year by year statistics type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL goalie</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics year by year</returns>
        public async Task<GoalieSeasonStatisticsYearByYear> GetGoalieStatisticsYearByYearAsync(PlayerEnum player)
        {
            return await _nhlStatisticsApi.GetGoalieStatisticsYearByYearAsync(player);
        }

        /// <summary>
        /// Returns all of the NHL goalie statistics for each season, year by year statistics type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL goalie</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics year by year</returns>
        public async Task<GoalieSeasonStatisticsYearByYear> GetGoalieStatisticsYearByYearAsync(int playerId)
        {
            return await _nhlStatisticsApi.GetGoalieStatisticsYearByYearAsync(playerId);
        }

        /// <summary>
        /// Returns all of the NHL goalies statistics for home and away games for a season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics for home and away games for a season</returns>
        public async Task<GoalieSeasonStatisticsHomeAndAway> GetGoalieStatisticsHomeAndAwayBySeasonAsync(PlayerEnum player, string seasonYear)
        {
            return await _nhlStatisticsApi.GetGoalieStatisticsHomeAndAwayBySeasonAsync(player, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL goalies statistics for home and away games for a season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="playerId">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics for home and away games for a season</returns>
        public async Task<GoalieSeasonStatisticsHomeAndAway> GetGoalieStatisticsHomeAndAwayBySeasonAsync(int playerId, string seasonYear)
        {
            return await _nhlStatisticsApi.GetGoalieStatisticsHomeAndAwayBySeasonAsync(playerId, seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL goalie statistics for a specific statistic type and NHL season with insightful statistics and NHL game data
        /// </summary>
        /// <param name="player">The identifier for the NHL goalie</param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <returns>A collection of all the in-depth NHL goalie statistics per season</returns>
        public async Task<GoalieSeasonStatistics> GetGoalieStatisticsBySeasonAsync(PlayerEnum player, string seasonYear)
        {
            return await _nhlStatisticsApi.GetGoalieStatisticsBySeasonAsync(player, seasonYear);
        }

        /// <summary>
        /// Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics
        /// </summary>
        /// <param name="player">The identifier for the NHL player</param>
        /// <returns>A collection of all the on pace expected NHL player statistics by type</returns>
        public async Task<PlayerSeasonStatistics> GetOnPaceRegularSeasonPlayerStatisticsAsync(PlayerEnum player)
        {
            return await _nhlStatisticsApi.GetOnPaceRegularSeasonPlayerStatisticsAsync(player);
        }

        /// <summary>
        /// Returns the on pace regular season NHL player statistics for the current NHL season with insightful statistics
        /// </summary>
        /// <param name="playerId">The identifier for the NHL player</param>
        /// <returns>A collection of all the on pace expected NHL player statistics by type</returns>
        public async Task<PlayerSeasonStatistics> GetOnPaceRegularSeasonPlayerStatisticsAsync(int playerId)
        {
            return await _nhlStatisticsApi.GetOnPaceRegularSeasonPlayerStatisticsAsync(playerId);
        }

        /// <summary>
        /// Returns the player with the top NHL player statistic based on the selected season year
        /// </summary>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <param name="numberOfPlayers">The argument for the number of players to retrieve, default value is 10 </param>
        /// <returns>Returns the collection of player profiles with the selected player statistic in the specified NHL season</returns>
        public async Task<List<PlayerStatisticResult>> GetPlayersByStatisticTypeBySeasonAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear, bool isDescending = true, int numberOfPlayers = 10)
        {
            return await _nhlStatisticsApi.GetPlayersByStatisticTypeBySeasonAsync(playerStatisticEnum, seasonYear, isDescending, numberOfPlayers);
        }

        /// <summary>
        /// Returns the goalie with the top NHL goalie statistic based on the selected season year
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <param name="numberOfGoalies">The argument for the number of goalies to retrieve, default value is 10 </param>
        /// <returns>Returns a collection goalie profiles with the selected statistic in the specified NHL season</returns>
        public async Task<List<GoalieStatisticResult>> GetGoaliesByStatisticTypeBySeasonAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear, bool isDescending = true, int numberOfGoalies = 10)
        {
            return await _nhlStatisticsApi.GetGoaliesByStatisticTypeBySeasonAsync(goalieStatisticEnum, seasonYear, isDescending, numberOfGoalies);
        }


        /// <summary>
        /// Returns the player with the top NHL player statistic based on the selected season year
        /// </summary>
        /// <param name="playerStatisticEnum">The argument for the type of NHL player statistic, see <see cref="PlayerStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns the player profile with the selected statistic in the specified NHL season</returns>
        public async Task<PlayerStatisticResult> GetPlayerByStatisticTypeBySeasonAsync(PlayerStatisticEnum playerStatisticEnum, string seasonYear, bool isDescending = true)
        {
            return await _nhlStatisticsApi.GetPlayerByStatisticTypeBySeasonAsync(playerStatisticEnum, seasonYear, isDescending);
        }

        /// <summary>
        /// Returns the goalie with the top NHL goalie statistic based on the selected season year
        /// </summary>
        /// <param name="goalieStatisticEnum">The argument for the type of NHL goalie statistic, see <see cref="GoalieStatisticEnum"/> for more information </param>
        /// <param name="seasonYear">The argument for the NHL season of the play, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="isDescending">The argument to determine whether the order of the results of the statistic should be in a descending or ascending order</param>
        /// <returns>Returns the goalie profile with the selected statistic in the specified NHL season</returns>
        public async Task<GoalieStatisticResult> GetGoalieByStatisticTypeBySeasonAsync(GoalieStatisticEnum goalieStatisticEnum, string seasonYear, bool isDescending = true)
        {
            return await _nhlStatisticsApi.GetGoalieByStatisticTypeBySeasonAsync(goalieStatisticEnum, seasonYear, isDescending);
        }

        /// <summary>
        /// Returns all of the NHL game types within a season and within special events
        /// </summary>
        /// <returns>A collection of NHL and other sporting event game types, see <see cref="GameType"/> for more information </returns>
        public async Task<List<GameType>> GetGameTypesAsync()
        {
            return await _nhlGameApi.GetGameTypesAsync();
        }

        /// <summary>
        /// Returns all of the valid NHL game statuses of an NHL game
        /// </summary>
        /// <returns>A collection of NHL game statues, see <see cref="GameStatus"/> for more information</returns>
        public async Task<List<GameStatus>> GetGameStatusesAsync()
        {
            return await _nhlGameApi.GetGameStatusesAsync();
        }

        /// <summary>
        /// Returns a collection of all the play types within the duration of an NHL game
        /// </summary>
        /// <returns>A collection of distinct play types, see <see cref="PlayType"/> for more information</returns>
        public async Task<List<PlayType>> GetPlayTypesAsync()
        {
            return await _nhlGameApi.GetPlayTypesAsync();
        }

        /// <summary>
        /// Returns a collection of all the different types of tournaments in the hockey
        /// </summary>
        /// <returns>A collection of tournament types, see <see cref="TournamentType"/> for more information</returns>
        public async Task<List<TournamentType>> GetTournamentTypesAsync()
        {
            return await _nhlGameApi.GetTournamentTypesAsync();
        }

        /// <summary>
        /// Returns a collection of all the different types of playoff tournaments in the NHL 
        /// </summary>
        /// <returns>A collection of tournament types, see <see cref="PlayoffTournamentType"/> for more information</returns>
        public async Task<PlayoffTournamentType> GetPlayoffTournamentTypesAsync()
        {
            return await _nhlGameApi.GetPlayoffTournamentTypesAsync();
        }

        /// <summary>
        /// Return's the NHL game schedule based on the provided <see cref="DateTime"/>. If the date is null, it will provide today's current NHL game schedule 
        /// </summary>
        /// <param name="date">The requested date for the NHL game schedule</param>
        /// <param name="gameScheduleConfiguration">A configuration for the NHL game schedule to include various points of additional information</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        public async Task<GameSchedule> GetGameScheduleByDateAsync(DateTime? date, GameScheduleConfiguration gameScheduleConfiguration = null)
        {
            return await _nhlGameApi.GetGameScheduleByDateAsync(date, gameScheduleConfiguration);
        }

        /// <summary>
        /// Return's today's the NHL game schedule and it will provide today's current NHL game schedule 
        /// </summary>
        /// <param name="gameScheduleConfiguration">A configuration for the NHL game schedule to include various points of additional information</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more information</returns>
        public async Task<GameSchedule> GetGameScheduleAsync(GameScheduleConfiguration gameScheduleConfiguration = null)
        {
            return await _nhlGameApi.GetGameScheduleAsync(gameScheduleConfiguration);
        }

        /// <summary>
        /// Return's the NHL game schedule based on the provided year, month and day
        /// </summary>
        /// <param name="year">The requested year for the NHL game schedule</param>
        /// <param name="month">The requested month for the NHL game schedule</param>
        /// <param name="day">The requested day for the NHL game schedule</param>
        /// <param name="gameScheduleConfiguration">A configuration for the NHL game schedule to include various points of additional information</param>
        /// <returns>NHL game schedule, see <see cref="GameSchedule"/> for more infGetGameScheduleByDateAsyncormation</returns>
        public async Task<GameSchedule> GetGameScheduleByDateAsync(int year, int month, int day, GameScheduleConfiguration gameScheduleConfiguration = null)
        {
            return await _nhlGameApi.GetGameScheduleByDateAsync(year, month, day, gameScheduleConfiguration);
        }

        /// <summary>
        /// Return's the NHL game schedule for the specified team based on the provided start date and end date
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/></param>
        /// <param name="startDate">The starting date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 2017-01-01</param>
        /// <param name="endDate">The ending date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 1988-06-01</param>
        /// <param name="gameScheduleConfiguration">A configuration for the NHL game schedule to include various points of additional information</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected start and end dates</returns>
        public async Task<GameSchedule> GetGameScheduleForTeamByDateAsync(TeamEnum team, DateTime startDate, DateTime endDate, GameScheduleConfiguration gameScheduleConfiguration = null)
        {
            return await _nhlGameApi.GetGameScheduleForTeamByDateAsync(team, startDate, endDate, gameScheduleConfiguration);
        }

        /// <summary>
        /// Return's the NHL game schedule for the specified team based on the provided start date and end date
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: 1</param>
        /// <param name="startDate">The starting date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 2017-01-01</param>
        /// <param name="endDate">The ending date for the NHL team game schedule, see <see cref="LeagueSeasonDates"/> for start dates of NHL seasons, Example: 1988-06-01</param>
        /// <param name="gameScheduleConfiguration">A configuration for the NHL game schedule to include various points of additional information</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected start and end dates</returns>
        public async Task<GameSchedule> GetGameScheduleForTeamByDateAsync(int teamId, DateTime startDate, DateTime endDate, GameScheduleConfiguration gameScheduleConfiguration = null)
        {
            return await _nhlGameApi.GetGameScheduleForTeamByDateAsync(teamId, startDate, endDate, gameScheduleConfiguration);
        }

        /// <summary>
        /// Return's the entire collection of NHL game schedules for the specified season
        /// </summary>
        /// <param name="seasonYear">The NHL season year, Example: 19992000, see <see cref="SeasonYear"/> for more information</param>
        /// <param name="includePlayoffGames">Includes the NHL playoff games if set to true, default value is false</param>
        /// <param name="gameScheduleConfiguration">A configuration for the NHL game schedule to include various points of additional information</param>
        /// <returns>Returns all of the NHL team's game schedules based on the selected NHL season</returns>
        public async Task<GameSchedule> GetGameScheduleBySeasonAsync(string seasonYear, bool includePlayoffGames = false, GameScheduleConfiguration gameScheduleConfiguration = null)
        {
            return await _nhlGameApi.GetGameScheduleBySeasonAsync(seasonYear, includePlayoffGames, gameScheduleConfiguration);
        }

        /// <summary>
        /// Returns the live game feed content for an NHL game
        /// </summary>
        /// <param name="gameId">The live game feed id, Example: 2021020087</param>
        /// <param name="liveGameFeedConfiguration">The NHL live game feed configuration settings for NHL live game feed updates</param>
        /// <returns>A detailed collection of information about play by play details, scores, teams, coaches, on ice statistics, real-time updates and more</returns>
        public async Task<LiveGameFeedResult> GetLiveGameFeedByIdAsync(int gameId, LiveGameFeedConfiguration liveGameFeedConfiguration = null)
        {
            return await _nhlGameApi.GetLiveGameFeedByIdAsync(gameId, liveGameFeedConfiguration);
        }

        /// <summary>
        /// Returns all of the individual shifts of each NHL player for a specific NHL game id
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>A collection of all the NHL player game shifts for a specific game, including start and end times, on ice duration and more</returns>
        public async Task<LiveGameFeedPlayerShifts> GetLiveGameFeedPlayerShiftsAsync(int gameId)
        {
            return await _nhlGameApi.GetLiveGameFeedPlayerShiftsAsync(gameId);
        }

        /// <summary>
        /// Returns the line score content for an NHL game
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>Returns information about the current score, strength of the play, time remaining, shots on goal and more</returns>
        public async Task<Linescore> GetLineScoreByIdAsync(int gameId)
        {
            return await _nhlGameApi.GetLineScoreByIdAsync(gameId);
        }

        /// <summary>
        /// Returns the box score content for an NHL game
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>Returns information about the current score, penalties, players, team statistics and more</returns>
        public async Task<Boxscore> GetBoxScoreByIdAsync(int gameId)
        {
            return await _nhlGameApi.GetBoxScoreByIdAsync(gameId);
        }

        /// <summary>
        /// Returns a collection of NHL live game feed content including highlights, media coverage, images, videos and more
        /// </summary>
        /// <param name="gameId">The game id, Example: 2021020087</param>
        /// <returns>A collection of images, video and information from a specific NHL game</returns>
        public async Task<LiveGameFeedContent> GetLiveGameFeedContentByIdAsync(int gameId)
        {
            return await _nhlGameApi.GetLiveGameFeedContentByIdAsync(gameId);
        }

        /// <summary>
        /// Returns all of the NHL seasons since the inception of the league in 1917-1918
        /// </summary>
        /// <returns>A collection of seasons since the inception of the NHL</returns>
        public async Task<List<Season>> GetSeasonsAsync()
        {
            return await _nhlLeagueApi.GetSeasonsAsync();
        }

        /// <summary>
        /// Return the current and most recent NHL season
        /// </summary>
        /// <returns>The most recent NHL season</returns>
        public async Task<Season> GetCurrentSeasonAsync()
        {
            return await _nhlLeagueApi.GetCurrentSeasonAsync();
        }

        /// <summary>
        /// Determines whether the NHL regular season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL regular season is active (true) or inactive (false)</returns>
        public async Task<bool> IsRegularSeasonActiveAsync()
        {
            return await _nhlLeagueApi.IsRegularSeasonActiveAsync();
        }

        /// <summary>
        /// Determines whether the NHL playoff season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL playoff season is active (true) or inactive (false)</returns>
        public async Task<bool> IsPlayoffsActiveAsync()
        {
            return await _nhlLeagueApi.IsPlayoffsActiveAsync();

        }

        /// <summary>
        /// Determines whether the NHL season is currently active or inactive
        /// </summary>
        /// <returns>A result if the current NHL season is active (true) or inactive (false)</returns>
        public async Task<bool> IsSeasonActiveAsync()
        {
            return await _nhlLeagueApi.IsSeasonActiveAsync();
        }

        /// <summary>
        /// Returns the NHL season information based on the provided season years
        /// </summary>
        /// <param name="seasonYear">See <see cref="SeasonYear"/> for all valid season year arguments</param>
        /// <returns>An NHL season based on the provided season year, Example: '20172018'</returns>
        public async Task<Season> GetSeasonByYearAsync(string seasonYear)
        {
            return await _nhlLeagueApi.GetSeasonByYearAsync(seasonYear);
        }

        /// <summary>
        /// Returns all of the NHL league standing types, this includes playoff and pre-season standings
        /// </summary>
        /// <returns>A collection of all the NHL standing types, see <see cref="LeagueStandingType"/> for more information</returns>
        public async Task<List<LeagueStandingType>> GetLeagueStandingTypesAsync()
        {
            return await _nhlLeagueApi.GetLeagueStandingTypesAsync();
        }

        /// <summary>
        /// Returns the standings of every team in the NHL for the provided date, if the date is null it will provide the current NHL league standings
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings</param>
        /// <returns>A collection of all the league standings </returns>
        public async Task<List<Records>> GetLeagueStandingsAsync(DateTime? date)
        {
            return await _nhlLeagueApi.GetLeagueStandingsAsync(date);
        }

        /// <summary>
        /// Returns the standings of every team in the NHL for the current date
        /// </summary>
        /// <returns>A collection of all the league standings </returns>
        public async Task<List<Records>> GetLeagueStandingsAsync()
        {
            return await _nhlLeagueApi.GetLeagueStandingsAsync();
        }

        /// <summary>
        /// Returns the standings of every team in the NHL by conference for the current date
        /// </summary>
        /// <returns>A collection of all the league standings by conference</returns>
        public async Task<List<Records>> GetLeagueStandingsByConferenceAsync()
        {
            return await _nhlLeagueApi.GetLeagueStandingsByConferenceAsync();
        }

        /// <summary>
        /// Returns the standings of every team by division in the NHL for the current date
        /// </summary>
        /// <returns>A collection of all the league standings by division</returns>
        public async Task<List<Records>> GetLeagueStandingsByDivisionAsync()
        {
            return await _nhlLeagueApi.GetLeagueStandingsByDivisionAsync();
        }

        /// <summary>
        /// Returns the standings of every team in the NHL by conference for the current date, if the date is null it will provide the current NHL league standings by conference
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings by conference</param>
        /// <returns>A collection of all the league standings by conference for the selected date</returns>
        public async Task<List<Records>> GetLeagueStandingsByConferenceAsync(DateTime? date)
        {
            return await _nhlLeagueApi.GetLeagueStandingsByConferenceAsync(date);
        }

        /// <summary>
        /// Returns the standings of every team by division in the NHL by date, if the date is null it will provide the current NHL league standings by division
        /// </summary>
        /// <param name="date">The NHL league standings date for the request NHL standings by division</param>
        /// <returns>A collection of all the league standings by division for the selected date</returns>
        public async Task<List<Records>> GetLeagueStandingsByDivisionAsync(DateTime? date)
        {
            return await _nhlLeagueApi.GetLeagueStandingsByDivisionAsync(date);
        }

        /// <summary>
        /// Returns all distinct types of NHL statistics types
        /// </summary>
        /// <returns>A collection of all the various NHL statistics types, see <see cref="StatisticTypes"/> for more information</returns>
        public async Task<List<StatisticTypes>> GetStatisticTypesAsync()
        {
            return await _nhlStatisticsApi.GetStatisticTypesAsync();
        }

        /// <summary>
        /// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
        /// </summary>
        /// <param name="teamId">The NHL team id, Example: Toronto Maple Leafs - 10</param>
        /// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, Example: 20202021</param>
        /// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
        public async Task<TeamStatistics> GetTeamStatisticsByIdAsync(int teamId, string seasonYear)
        {
            return await _nhlStatisticsApi.GetTeamStatisticsByIdAsync(teamId, seasonYear);
        }

        /// <summary>
        /// Returns a specified NHL team's statistics for the specified season, the most recent season statistics will be returned
        /// </summary>
        /// <param name="team">The NHL team id, Example: <see cref="TeamEnum.AnaheimDucks"/></param>
        /// <param name="seasonYear">The NHL season year, see <see cref="SeasonYear"/> for all valid seasons, Example: 20202021</param>
        /// <returns>A collection of all the specified NHL team statistics for the specified season</returns>
        public async Task<TeamStatistics> GetTeamStatisticsByIdAsync(TeamEnum team, string seasonYear)
        {
            return await _nhlStatisticsApi.GetTeamStatisticsByIdAsync(team, seasonYear);
        }

        /// <summary>
        /// Returns the NHL league draft based on a specific year based on the 4 character draft year, see <see cref="DraftYear"/> for more information. <br/>
        /// <strong>Note:</strong> Some responses provide very large JSON payloads
        /// </summary>
        /// <param name="year">The specified year of the NHL draft, see <see cref="DraftYear"/> for all NHL draft years</param>
        /// <returns>The NHL league draft, which includes draft rounds, player information and more, see <see cref="LeagueDraft"/> for more information</returns>
        public async Task<LeagueDraft> GetDraftByYearAsync(string year)
        {
            return await _nhlLeagueApi.GetDraftByYearAsync(year);
        }

        /// <summary>
        /// Returns all the NHL league prospects <br/>
        /// <strong>Note:</strong> The NHL prospects response provides a very large JSON payload
        /// </summary>
        /// <returns>A collection of all the NHL prospects, see <see cref="ProspectProfile"/> for more information </returns>
        public async Task<List<ProspectProfile>> GetLeagueProspectsAsync()
        {
            return await _nhlPlayerApi.GetLeagueProspectsAsync();
        }

        /// <summary>
        /// Returns an NHL prospect profile by their prospect id
        /// </summary>
        /// <param name="prospectId">The NHL prospect id, Example: 86515 - Francesco Pinelli</param>
        /// <returns>An NHL prospect, see <see cref="ProspectProfile"/> for more information </returns>
        public async Task<ProspectProfile> GetLeagueProspectByIdAsync(int prospectId)
        {
            return await _nhlPlayerApi.GetLeagueProspectByIdAsync(prospectId);
        }

        /// <summary>
        /// Returns an NHL prospect profile by their prospect id
        /// </summary>
        /// <param name="prospect">The NHL prospect id, Example: 86515 - Francesco Pinelli, see <see cref="ProspectEnum"/> for more information</param>
        /// <returns>An NHL prospect, see <see cref="ProspectProfile"/> for more information </returns>
        public async Task<ProspectProfile> GetLeagueProspectByIdAsync(ProspectEnum prospect)
        {
            return await _nhlPlayerApi.GetLeagueProspectByIdAsync(prospect);
        }

        /// <summary>
        /// Returns all of the NHL awards, including the description, history, and images
        /// </summary>
        /// <returns>A collection of all the NHL awards, see <see cref="Award"/> for more information</returns>
        public async Task<List<Award>> GetLeagueAwardsAsync()
        {
            return await _nhlLeagueApi.GetLeagueAwardsAsync();
        }

        /// <summary>
        /// Returns an NHL award by id <br/>
        /// </summary>
        /// <param name="awardId">The identifier for the NHL award, Example: Ted Lindsay Award - 13</param>
        /// <returns>An NHL award, see <see cref="Award"/> for more information</returns>
        public async Task<Award> GetLeagueAwardByIdAsync(int awardId)
        {
            return await _nhlLeagueApi.GetLeagueAwardByIdAsync(awardId);
        }

        /// <summary>
        /// Returns an NHL award by the award id <br/>
        /// Example: <see cref="AwardEnum.StanleyCup"/>
        /// </summary>
        /// <param name="leagueAward">The NHL league award identifier, see <see cref="AwardEnum"/> for more information on NHL awards </param>
        /// <returns>An NHL award, see <see cref="Award"/> for more information</returns>
        public async Task<Award> GetLeagueAwardByIdAsync(AwardEnum leagueAward)
        {
            return await _nhlLeagueApi.GetLeagueAwardByIdAsync(leagueAward);
        }

        /// <summary>
        /// Returns all of the NHL venue's, including arenas and stadiums <br/>
        /// <strong>NOTE:</strong> This is not a comprehensive list of all NHL stadiums and arenas
        /// </summary>
        /// <returns>A collection of NHL stadiums and arenas, see <see cref="LeagueVenue"/> for more information</returns>
        public async Task<List<LeagueVenue>> GetLeagueVenuesAsync()
        {
            return await _nhlLeagueApi.GetLeagueVenuesAsync();
        }

        /// <summary>
        /// Returns an NHL venue by the venue id <br/>
        ///  Example: 5058 - Canada Life Centre
        /// </summary>
        /// <param name="venueId">The specified id of an NHL venue, </param>
        /// <returns>An NHL venue, see <see cref="LeagueVenue"/> for more information</returns>
        public async Task<LeagueVenue> GetLeagueVenueByIdAsync(int venueId)
        {
            return await _nhlLeagueApi.GetLeagueVenueByIdAsync(venueId);
        }

        /// <summary>
        /// Returns an NHL venue by the venue enumeration <br/>
        ///  Example: <see cref="VenueEnum.EnterpriseCenter"/>
        /// </summary>
        /// <param name="venue">The specified NHL venue, see <see cref="VenueEnum"/> for more information on NHL venues </param>
        /// <returns>An NHL venue, see <see cref="LeagueVenue"/> for more information</returns>
        public async Task<LeagueVenue> GetLeagueVenueByIdAsync(VenueEnum venue)
        {
            return await _nhlLeagueApi.GetLeagueVenueByIdAsync(venue);
        }

        /// <summary>
        /// Return's all the event types within the NHL
        /// </summary>
        /// <returns>A collection of event types within the NHL, see <see cref="EventType"/> for more information</returns>
        public async Task<List<EventType>> GetEventTypesAsync()
        {
            return await _nhlLeagueApi.GetEventTypesAsync();
        }

        /// <summary>
        /// Releases and disposes all unused or garbage collected resources for the Nhl.Api
        /// </summary>
        public void Dispose()
        {
            _nhlPlayerApi?.Dispose();
        }
    }
}
