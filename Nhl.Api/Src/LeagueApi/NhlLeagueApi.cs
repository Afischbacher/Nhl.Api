using System.Globalization;
using Nhl.Api.Common.Exceptions;
using Nhl.Api.Services;

namespace Nhl.Api;
/// <summary>
/// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
/// </summary>
public class NhlLeagueApi : INhlLeagueApi
{
    private static readonly NhlStaticAssetsApiHttpClient _nhlStaticAssetsApiHttpClient = new();
    private static readonly NhlTeamService _nhlTeamService = new();
    private static readonly NhlApiWebHttpClient _nhlWebApiHttpClient = new();

    /// <summary>
    /// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
    /// </summary>
    public NhlLeagueApi()
    {

    }

    /// <summary>
    /// Returns the NHL team schedule for a specific date using the <see cref="DateOnly"/>
    /// </summary>
    /// <param name="date">A <see cref="DateOnly"/> for the specific date for the NHL schedule</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A result of the current NHL schedule by the specified date</returns>
    public async Task<LeagueSchedule> GetLeagueGameWeekScheduleByDateAsync(DateOnly date, CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/{date:yyyy-MM-dd}", cancellationToken);

    /// <summary>
    /// Returns the true or false if the NHL regular season is active or inactive
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a result of true or false if the NHL regular season is active</returns>
    public async Task<bool> IsRegularSeasonActiveAsync(CancellationToken cancellationToken = default)
    {
        var leagueSchedule = await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/now", cancellationToken);

        if (leagueSchedule == null)
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(leagueSchedule.RegularSeasonStartDate) || string.IsNullOrWhiteSpace(leagueSchedule.RegularSeasonEndDate))
        {
            return false;
        }

        return DateTime.Now >= DateTime.Parse(leagueSchedule.RegularSeasonStartDate, CultureInfo.InvariantCulture) && DateTime.Now <= DateTime.Parse(leagueSchedule.RegularSeasonEndDate, CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Returns the true or false if the NHL playoff season is active 
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a result of true or false if the NHL playoff season is active</returns>
    public async Task<bool> IsPlayoffSeasonActiveAsync(CancellationToken cancellationToken = default)
    {
        var leagueSchedule = await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/now", cancellationToken);

        if (leagueSchedule == null)
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(leagueSchedule.PlayoffEndDate))
        {
            return false;
        }

        return DateTime.Now >= DateTime.Parse(leagueSchedule.RegularSeasonEndDate, CultureInfo.InvariantCulture) &&
            DateTime.Now <= DateTime.Parse(leagueSchedule.PlayoffEndDate, CultureInfo.InvariantCulture);
    }

    /// <summary>
    /// Returns the true or false if the NHL playoff pre season is active or inactive
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns a result of true or false if the NHL pre-season is active</returns>
    public async Task<bool> IsPreSeasonActiveAsync(CancellationToken cancellationToken = default)
    {
        var leagueSchedule = await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/now", cancellationToken);

        if (leagueSchedule == null)
        {
            return false;
        }

        if (string.IsNullOrWhiteSpace(leagueSchedule.PreSeasonStartDate) || string.IsNullOrWhiteSpace(leagueSchedule.RegularSeasonStartDate))
        {
            return false;
        }

        return DateTime.Now >= DateTime.Parse(leagueSchedule.PreSeasonStartDate, CultureInfo.InvariantCulture) && DateTime.Now <= DateTime.Parse(leagueSchedule.RegularSeasonStartDate, CultureInfo.InvariantCulture);
    }


    /// <summary>
    /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
    /// </summary>
    /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
    /// <param name="seasonYear">The eight digit number format for the season, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
    public async Task<TeamSchedule> GetTeamScheduleBySeasonAsync(string teamAbbreviation, string seasonYear, CancellationToken cancellationToken = default)
    {
        var parsedTeamAbbreviation = _nhlTeamService.GetTeamCodeIdentifierByTeamAbbreviation(teamAbbreviation);
        if (string.IsNullOrWhiteSpace(parsedTeamAbbreviation))
        {
            throw new InvalidTeamAbbreviationException($"The team abbreviation {teamAbbreviation} is not valid");
        }

        if (seasonYear?.Length != 8)
        {
            throw new ArgumentException("The season year must be in the eight digit format, Example: 20232024");
        }

        return await _nhlWebApiHttpClient.GetAsync<TeamSchedule>($"/club-schedule-season/{teamAbbreviation}/{seasonYear}", cancellationToken);
    }


    /// <summary>
    /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
    /// </summary>
    /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
    /// <param name="date">The date in which the request schedule for the team and for the week is request for</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
    public async Task<TeamWeekSchedule> GetTeamWeekScheduleByDateAsync(string teamAbbreviation, DateOnly date, CancellationToken cancellationToken = default)
    {
        var parsedTeamAbbreviation = _nhlTeamService.GetTeamCodeIdentifierByTeamAbbreviation(teamAbbreviation);
        if (string.IsNullOrWhiteSpace(parsedTeamAbbreviation))
        {
            throw new InvalidTeamAbbreviationException($"The team abbreviation {teamAbbreviation} is not valid");
        }

        return await _nhlWebApiHttpClient.GetAsync<TeamWeekSchedule>($"/club-schedule/{teamAbbreviation}/week/{date:yyyy-MM-dd}", cancellationToken);
    }

    /// <summary>
    /// Returns an the NHL team logo based a dark or light preference using the NHL team enumeration
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
    public async Task<TeamLogo> GetTeamLogoAsync(TeamEnum team, TeamLogoType teamLogoType = TeamLogoType.Light, CancellationToken cancellationToken = default)
    {
        var endpoint = $"logos/nhl/svg/{_nhlTeamService.GetTeamCodeIdentifierByTeamId((int)team)}_{_nhlTeamService.GetTeamLogoColorIdentifier(teamLogoType)}.svg";
        var imageContent = await _nhlStaticAssetsApiHttpClient.GetByteArrayAsync(endpoint, cancellationToken);

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
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
    public async Task<TeamLogo> GetTeamLogoAsync(int teamId, TeamLogoType teamLogoType = TeamLogoType.Light, CancellationToken cancellationToken = default)
    {
        var endpoint = $"logos/nhl/svg/{_nhlTeamService.GetTeamCodeIdentifierByTeamId(teamId)}_{_nhlTeamService.GetTeamLogoColorIdentifier(teamLogoType)}.svg";
        var imageContent = await _nhlStaticAssetsApiHttpClient.GetByteArrayAsync(endpoint, cancellationToken);

        return new TeamLogo
        {
            ImageAsBase64String = $"data:image/svg+xml;base64,{Convert.ToBase64String(imageContent)}",
            ImageAsByteArray = imageContent,
            Uri = $"{_nhlStaticAssetsApiHttpClient.Client}/{endpoint}"
        };
    }

    /// <summary>
    /// Returns the NHL league standings for the current NHL season by the specified date
    /// </summary>
    /// <param name="date">The date requested for the NHL season standing</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Return the NHL league standings for the specified date with specific team information</returns>
    public async Task<LeagueStanding> GetLeagueStandingsByDateAsync(DateOnly date, CancellationToken cancellationToken) => await _nhlWebApiHttpClient.GetAsync<LeagueStanding>($"/standings/{date:yyyy-MM-dd}", cancellationToken);

    /// <summary>
    /// Returns the hexadecimal code for an NHL team's colors
    /// </summary>
    /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>An NHL team color scheme using hexadecimal codes</returns>
    public async Task<TeamColors> GetTeamColorsAsync(TeamEnum team, CancellationToken cancellationToken = default)
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
            TeamEnum.UtahHockeyClub => new TeamColors
            {
                PrimaryColor = "#69B3E7",
                SecondaryColor = "#010101",
                TertiaryColor = "#FFFFFF"
            },
            _ => null,
        };

        return await Task.FromResult(teamColors!);
    }

    /// <summary>
    /// Returns the hexadecimal code for an NHL team's colors
    /// </summary>
    /// <param name="teamId">The NHL team identifier - Seattle Kraken: 55</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>An NHL team color scheme using hexadecimal codes</returns>
    public async Task<TeamColors> GetTeamColorsAsync(int teamId, CancellationToken cancellationToken = default)
    {
        var teamEnum = Enum.Parse<TeamEnum>(teamId!.ToString(CultureInfo.InvariantCulture));

        return await this.GetTeamColorsAsync(teamEnum, cancellationToken);
    }

    /// <summary>
    /// Returns the NHL league standings for the all NHL seasons with specific league season information
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league standings information for each season since 1917-1918</returns>
    public async Task<LeagueStandingsSeasonInformation> GetLeagueStandingsSeasonInformationAsync(CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<LeagueStandingsSeasonInformation>($"/standings-season", cancellationToken);

    /// <summary>
    /// Returns the NHL team roster for a specific team by the team identifier and season year
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
    public async Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(int teamId, string seasonYear, CancellationToken cancellationToken = default)
    {
        if (seasonYear?.Length != 8)
        {
            throw new ArgumentException("The season year must be in the eight digit format, Example: 20232024");
        }

        var teamAbbreviation = _nhlTeamService.GetTeamCodeIdentifierByTeamId(teamId);
        return await _nhlWebApiHttpClient.GetAsync<TeamSeasonRoster>($"/roster/{teamAbbreviation}/{seasonYear}", cancellationToken);
    }

    /// <summary>
    /// Returns the NHL team roster for a specific team by the team and season year
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
    /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
    public async Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(TeamEnum team, string seasonYear, CancellationToken cancellationToken = default)
    {
        if (seasonYear?.Length != 8)
        {
            throw new ArgumentException("The season year must be in the eight digit format, Example: 20232024");
        }

        var teamAbbreviation = _nhlTeamService.GetTeamCodeIdentifierByTeamEnumeration(team);
        return await _nhlWebApiHttpClient.GetAsync<TeamSeasonRoster>($"/roster/{teamAbbreviation}/{seasonYear}", cancellationToken);
    }


    /// <summary>
    /// Returns every active season for an NHL team and their participation in the NHL
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name = "cancellationToken" > A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
    public async Task<List<int>> GetAllRosterSeasonsByTeamAsync(int teamId, CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<List<int>>($"/roster-season/{_nhlTeamService.GetTeamCodeIdentifierByTeamId(teamId)}", cancellationToken);

    /// <summary>
    /// Returns every active season for an NHL team and their participation in the NHL
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
    /// <param name = "cancellationToken" > A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
    public async Task<List<int>> GetAllRosterSeasonsByTeamAsync(TeamEnum team, CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<List<int>>($"/roster-season/{_nhlTeamService.GetTeamCodeIdentifierByTeamEnumeration(team)}", cancellationToken);

    /// <summary>
    /// Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies
    /// </summary>
    /// <param name="teamId">The NHL team identifier, Example: 55 - Seattle Kraken</param>
    /// <param name = "cancellationToken" > A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies</returns>
    public async Task<TeamProspects> GetTeamProspectsByTeamAsync(int teamId, CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<TeamProspects>($"/prospects/{_nhlTeamService.GetTeamCodeIdentifierByTeamId(teamId)}", cancellationToken);

    /// <summary>
    /// Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies
    /// </summary>
    /// <param name="team">The NHL team identifier, see <see cref="TeamEnum"/> for more information, Example: 10 - Toronto Maple Leafs </param>
    /// <param name = "cancellationToken" > A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all the NHL prospects for the specified NHL team including forwards, defense men and goalies</returns>
    public async Task<TeamProspects> GetTeamProspectsByTeamAsync(TeamEnum team, CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<TeamProspects>($"/prospects/{_nhlTeamService.GetTeamCodeIdentifierByTeamEnumeration(team)}", cancellationToken);

    /// <summary>
    /// Returns the NHL league schedule for the specified date
    /// </summary>
    /// <param name="date">The date requested for the NHL league schedule, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league schedule for the specified date</returns>
    public async Task<LeagueSchedule> GetLeagueWeekScheduleByDateAsync(DateOnly date, CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/{date:yyyy-MM-dd}", cancellationToken);

    /// <summary>
    /// Returns the NHL league calendar schedule for the specified date and all applicable teams
    /// </summary>
    /// <param name="date">The date requested for the NHL league schedule, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL league calendar schedule for the specified date and all applicable teams</returns>
    public async Task<LeagueScheduleCalendar> GetLeagueScheduleCalendarByDateAsync(DateOnly date, CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<LeagueScheduleCalendar>($"/schedule-calendar/{date:yyyy-MM-dd}", cancellationToken);

    /// <summary>
    /// Returns the collection of countries and where you can watch NHL games with links and more
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the collection of countries and where you can watch NHL games with links and more</returns>
    public async Task<List<GameWatchSource>> GetSourcesToWatchGamesAsync(CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<List<GameWatchSource>>($"/where-to-watch", cancellationToken);

    /// <summary>
    /// Returns the NHL TV broadcasts for the specified date with information about the broadcasts
    /// </summary>
    /// <param name="date">The date requested for the NHL TV broadcasts, Example: 2024-02-10</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the NHL TV broadcasts for the specified date with information about the broadcasts</returns>
    public async Task<TvScheduleBroadcast> GetTvScheduleBroadcastByDateAsync(DateOnly date, CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<TvScheduleBroadcast>($"/network/tv-schedule/{date:yyyy-MM-dd}", cancellationToken);

    /// <summary>
    /// Returns all the NHL seasons for the NHL league
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns all the NHL seasons for the NHL league</returns>
    public async Task<List<int>> GetAllSeasonsAsync(CancellationToken cancellationToken = default) => await _nhlWebApiHttpClient.GetAsync<List<int>>($"/season", cancellationToken);

    /// <summary>
    /// Returns the meta data information about the NHL league including players, teams and season states
    /// </summary>
    /// <param name="playerIds">A collection of NHL player identifiers, Example: [8478402,8478403] </param>
    /// <param name="teamIds">A collection of NHL team identifiers, Example: [EDM, TOR]</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the meta data information about the NHL league including players, teams and season states</returns>
    public async Task<LeagueMetadataInformation> GetLeagueMetadataInformationAsync(List<int> playerIds, List<string> teamIds, CancellationToken cancellationToken = default)
    {
        var sb = new StringBuilder("/meta");
        if (playerIds?.Count > 0)
        {
            _ = sb.Append(CultureInfo.InvariantCulture, $"?players={string.Join(",", playerIds)}");
        }

        if (teamIds?.Count > 0)
        {
            if (playerIds?.Count > 0)
            {
                _ = sb.Append(CultureInfo.InvariantCulture, $"&teams={string.Join(",", teamIds)}");
            }
            else
            {
                _ = sb.Append(CultureInfo.InvariantCulture, $"?teams={string.Join(",", teamIds)}");
            }
        }

        return await _nhlWebApiHttpClient.GetAsync<LeagueMetadataInformation>(sb.ToString(), cancellationToken);
    }

    /// <summary>
    /// Returns the meta data information about the NHL league including players, teams and season states
    /// </summary>
    /// <param name="players">A collection of NHL player identifiers, Example: [8478402,8478403] </param>
    /// <param name="teams">A collection of NHL team identifiers, Example: [EDM, TOR]</param>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns the meta data information about the NHL league including players, teams and season states</returns>
    public async Task<LeagueMetadataInformation> GetLeagueMetadataInformationAsync(List<PlayerEnum> players, List<TeamEnum> teams, CancellationToken cancellationToken = default)
    {
        var sb = new StringBuilder("/meta");
        if (players?.Count > 0)
        {
            _ = sb.Append(CultureInfo.InvariantCulture, $"?players={string.Join(",", players.Select(player => (int)player).ToArray())}");
        }

        if (teams?.Count > 0)
        {
            var teamAbbreviations = _nhlTeamService.GetTeamCodeIdentifierByTeamEnumerations(teams);
            if (players?.Count > 0)
            {
                _ = sb.Append(CultureInfo.InvariantCulture, $"&teams={string.Join(",", teamAbbreviations)}");
            }
            else
            {
                _ = sb.Append(CultureInfo.InvariantCulture, $"?teams={string.Join(",", teamAbbreviations)}");
            }
        }

        return await _nhlWebApiHttpClient.GetAsync<LeagueMetadataInformation>(sb.ToString(), cancellationToken);
    }

    /// <summary>
    /// Determines if the NHL league is active or inactive based on the current date and time
    /// </summary>
    /// <param name="cancellationToken"> A cancellation token that can be used by other objects or threads to receive notice of cancellation</param>
    /// <returns>Returns true or false based on the current time and date</returns>
    public async Task<bool> IsLeagueActiveAsync(CancellationToken cancellationToken = default) => await this.IsRegularSeasonActiveAsync(cancellationToken) || await this.IsPlayoffSeasonActiveAsync(cancellationToken) || await this.IsPreSeasonActiveAsync(cancellationToken);
}
