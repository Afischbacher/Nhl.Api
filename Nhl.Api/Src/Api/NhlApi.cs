using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Game;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Schedule;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Team;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Threading.Tasks;
using GameType = Nhl.Api.Enumerations.Game.GameType;

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
        /// Returns any active or inactive NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Jack Adams" or "Wayne Gretzky" or "Mats Sundin" </param>
        /// <param name="limit">A parameter to limit the number of search results returned when searching for a player</param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        public async Task<List<PlayerSearchResult>> SearchAllPlayersAsync(string query, int limit = 25)
        {
            return await _nhlPlayerApi.SearchAllPlayersAsync(query);
        }

        /// <summary>
        /// Returns only active NHL players based on the search query provided
        /// </summary>
        /// <param name="query">A search term to find NHL players, Example: "Owen Power" or "Carter Hart" or "Nathan MacKinnon" </param>
        /// <param name="limit">A parameter to limit the number of search results returned when searching for a player</param>
        /// <returns>A collection of all NHL players based on the search query provided</returns>
        public async Task<List<PlayerSearchResult>> SearchAllActivePlayersAsync(string query, int limit = 25)
        {
            return await _nhlPlayerApi.SearchAllActivePlayersAsync(query);
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
        /// Returns the NHL team schedule for a specific date using the DateTimeOffset
        /// <param name="dateTimeOffset">A <see cref="DateTimeOffset"/> for the specific date for the NHL schedule</param>
        /// <returns>A result of the current NHL schedule by the specified date</returns>
        /// </summary>
        public async Task<LeagueSchedule> GetLeagueGameWeekScheduleByDateTimeAsync(DateTimeOffset dateTimeOffset)
        {
            return await _nhlLeagueApi.GetLeagueGameWeekScheduleByDateTimeAsync(dateTimeOffset);
        }

        /// <summary>
        /// Returns the true or false if the NHL playoff pre season is active or inactive
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL pre-season is active</returns>
        public async Task<bool> IsPreSeasonActiveAsync()
        {
            return await _nhlLeagueApi.IsPlayoffSeasonActiveAsync();
        }

        /// <summary>
        /// Returns the true or false if the NHL regular season is active or inactive
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL regular season is active</returns>
        public async Task<bool> IsRegularSeasonActiveAsync()
        {
            return await _nhlLeagueApi.IsRegularSeasonActiveAsync();
        }

        /// <summary>
        /// Returns the true or false if the NHL playoff season is active or inactive
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL playoff season is active</returns>
        public async Task<bool> IsPlayoffSeasonActiveAsync()
        {
            return await _nhlLeagueApi.IsPlayoffSeasonActiveAsync();
        }

        /// <summary>
        /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
        /// </summary>
        /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
        /// <param name="seasonYear">The eight digit number format for the season, Example: 20232024</param>
        /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
        public async Task<TeamSchedule> GetTeamScheduleBySeasonAsync(string teamAbbreviation, SeasonYear seasonYear)
        {
            return await _nhlLeagueApi.GetTeamScheduleBySeasonAsync(teamAbbreviation, seasonYear);
        }

        /// <summary>
        /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
        /// </summary>
        /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
        /// <param name="dateTimeOffset">The date in which the request schedule for the team and for the week is request for</param>
        /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
        public async Task<TeamWeekSchedule> GetTeamWeekScheduleByDateTimeOffsetAsync(string teamAbbreviation, DateTimeOffset dateTimeOffset)
        {
            return await _nhlLeagueApi.GetTeamWeekScheduleByDateTimeOffsetAsync(teamAbbreviation, dateTimeOffset);
        }

        /// <summary>
        /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Connor McDavid, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
        /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
        /// <returns>The collection of player season game logs with each game played including statistics, all available seasons player, shifts and in game statistics </returns>
        public async Task<PlayerSeasonGameLog> GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum player, string seasonYear, GameType gameType)
        {
            return await _nhlPlayerApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(player, seasonYear, gameType);
        }

        /// <summary>
        /// The player season game log for an NHL player for a specific season and game type including stats such as goals, assists, points, plus/minus and more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8478402 - Connor McDavid</param>
        /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
        /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
        /// <returns>The collection of player season game logs with each game played including statistics, all available seasons player, shifts and in game statistics </returns>
        public async Task<PlayerSeasonGameLog> GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(int playerId, string seasonYear, GameType gameType)
        {
            return await _nhlPlayerApi.GetPlayerSeasonGameLogsBySeasonAndGameTypeAsync(playerId, seasonYear, gameType);
        }

        /// <summary>
        /// The goalie season game log for an NHL goalie for a specific season and game type including stats such as saves, goals against, save percentage and more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8478402 - Joseph Woll, see <see cref="PlayerEnum"/> for more information on NHL goalies </param>
        /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
        /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
        /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
        public async Task<GoalieSeasonGameLog> GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(PlayerEnum player, string seasonYear, GameType gameType)
        {
            return await _nhlPlayerApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(player, seasonYear, gameType);
        }

        /// <summary>
        /// The goalie season game log for an NHL goalie for a specific season and game type including stats such as saves, goals against, save percentage and more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8479361 - Joseph Woll</param>
        /// <param name="seasonYear">The season year parameter for determining the season for the season, <see cref="SeasonYear"/> for all available seasons</param>
        /// <param name="gameType">The game type parameter for determining the game type for the type of player season logs</param>
        /// <returns>The collection of player season game logs with each game played including statistics, all available season and more</returns>
        public async Task<GoalieSeasonGameLog> GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(int playerId, string seasonYear, GameType gameType)
        {
            return await _nhlPlayerApi.GetGoalieSeasonGameLogsBySeasonAndGameTypeAsync(playerId, seasonYear, gameType);
        }

        /// <summary>
        /// Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more
        /// </summary>
        /// <param name="playerId">An NHL player id, Example: 8480313 - Logan Thompson</param>
        /// <returns>Returns the NHL player's profile information </returns>
        public async Task<GoalieProfile> GetGoalieInformationAsync(int playerId)
        {
            return await _nhlPlayerApi.GetGoalieInformationAsync(playerId);
        }

        /// <summary>
        /// Returns the NHL goalie's profile information including their birth date, birth city, height, weight, position and much more
        /// </summary>
        /// <param name="player">An NHL player id, Example: 8480313 - Logan Thompson, see <see cref="PlayerEnum"/> for more information on NHL players</param>
        /// <returns>Returns the NHL player's profile information</returns>
        public async Task<GoalieProfile> GetGoalieInformationAsync(PlayerEnum player)
        {
            return await _nhlPlayerApi.GetGoalieInformationAsync((int)player);
        }

        /// <summary>
        /// Releases and disposes all unused or garbage collected resources for the Nhl.Api
        /// </summary>
        public void Dispose() => _nhlPlayerApi?.Dispose();

        /// <summary>
        /// Releases and disposes all unused or garbage collected resources for the Nhl.Api asynchronously
        /// </summary>
        /// <returns>The await-able result of the asynchronous operation</returns>
        public async ValueTask DisposeAsync() => await Task.Run(() => _nhlPlayerApi?.Dispose());

    }
}
