using Nhl.Api.Common.Http;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Player;
using Nhl.Api.Models.Schedule;
using Nhl.Api.Models.Season;
using Nhl.Api.Models.Standing;
using Nhl.Api.Models.Team;
using Nhl.Api.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Nhl.Api
{
    /// <summary>
    /// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
    /// </summary>
    public class NhlLeagueApi : INhlLeagueApi
    {
        private static readonly INhlApiHttpClient _nhlStaticAssetsApiHttpClient = new NhlStaticAssetsApiHttpClient();
        private static readonly INhlTeamService _nhlTeamService = new NhlTeamService();
        private static readonly INhlApiHttpClient _nhlWebApiHttpClient = new NhlApiWebHttpClient();

        /// <summary>
        /// The official unofficial NHL League API providing various NHL league information including teams, franchises, standings, awards and more
        /// </summary>
        public NhlLeagueApi()
        {

        }

        /// <summary>
        /// Returns the NHL team schedule for a specific date using the DateTimeOffset
        /// </summary>
        /// <param name="dateTimeOffset">A <see cref="DateTimeOffset"/> for the specific date for the NHL schedule</param>
        /// <returns>A result of the current NHL schedule by the specified date</returns>
        public async Task<LeagueSchedule> GetLeagueGameWeekScheduleByDateTimeAsync(DateTimeOffset dateTimeOffset)
        {
            return (await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/{dateTimeOffset:yyyy-MM-dd}"));
        }

        /// <summary>
        /// Returns the true or false if the NHL regular season is active or inactive
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL regular season is active</returns>
        public async Task<bool> IsRegularSeasonActiveAsync()
        {
            var leagueSchedule = await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/now");

            if (leagueSchedule == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(leagueSchedule.RegularSeasonStartDate) || string.IsNullOrWhiteSpace(leagueSchedule.RegularSeasonEndDate))
            {
                return false;
            }

            return DateTime.Parse(leagueSchedule.RegularSeasonStartDate) >= DateTime.Now && DateTime.Parse(leagueSchedule.RegularSeasonEndDate) <= DateTime.Now;
        }

        /// <summary>
        /// Returns the true or false if the NHL playoff season is active 
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL playoff season is active</returns>
        public async Task<bool> IsPlayoffSeasonActiveAsync()
        {
            var leagueSchedule = await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/now");

            if (leagueSchedule == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(leagueSchedule.PlayoffEndDate))
            {
                return false;
            }

            return DateTime.Parse(leagueSchedule.RegularSeasonEndDate) >= DateTime.Now && DateTime.Parse(leagueSchedule.PlayoffEndDate) <= DateTime.Now;
        }

        /// <summary>
        /// Returns the true or false if the NHL playoff pre season is active or inactive
        /// </summary>
        /// <returns>Returns a result of true or false if the NHL pre-season is active</returns>
        public async Task<bool> IsPreSeasonActiveAsync()
        {
            var leagueSchedule = await _nhlWebApiHttpClient.GetAsync<LeagueSchedule>($"/schedule/now");

            if (leagueSchedule == null)
            {
                return false;
            }

            if (string.IsNullOrWhiteSpace(leagueSchedule.PreSeasonStartDate) || string.IsNullOrWhiteSpace(leagueSchedule.RegularSeasonStartDate))
            {
                return false;
            }

            return DateTime.Parse(leagueSchedule.PreSeasonStartDate) >= DateTime.Now && DateTime.Parse(leagueSchedule.RegularSeasonStartDate) <= DateTime.Now;
        }

        /// <summary>
        /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
        /// </summary>
        /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
        /// <param name="seasonYear">The eight digit number format for the season, Example: 20232024</param>
        /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
        public async Task<TeamSchedule> GetTeamScheduleBySeasonAsync(string teamAbbreviation, SeasonYear seasonYear)
        {
            var parsedTeamAbbreviation = _nhlTeamService.GetTeamCodeIdentfierByTeamAbbreviation(teamAbbreviation);
            if (string.IsNullOrWhiteSpace(parsedTeamAbbreviation))
            {
                throw new Exception($"The team abbreviation {teamAbbreviation} is not valid");
            }

            return await _nhlWebApiHttpClient.GetAsync<TeamSchedule>($"/club-schedule-season/{teamAbbreviation}/{seasonYear}");
        }


        /// <summary>
        /// This returns the NHL team schedule for a specific season and a specific team by the team abbreviation and season
        /// </summary>
        /// <param name="teamAbbreviation">The required team abbreviation for the NHL team, Example: WSH - Washington</param>
        /// <param name="dateTimeOffset">The date in which the request schedule for the team and for the week is request for</param>
        /// <returns>A collection of all games in the requested season for the requested NHL team</returns>
        public async Task<TeamWeekSchedule> GetTeamWeekScheduleByDateTimeOffsetAsync(string teamAbbreviation, DateTimeOffset dateTimeOffset)
        {
            var parsedTeamAbbreviation = _nhlTeamService.GetTeamCodeIdentfierByTeamAbbreviation(teamAbbreviation);
            if (string.IsNullOrWhiteSpace(parsedTeamAbbreviation))
            {
                throw new Exception($"The team abbreviation {teamAbbreviation} is not valid");
            }

            return await _nhlWebApiHttpClient.GetAsync<TeamWeekSchedule>($"/club-schedule-season/{teamAbbreviation}/week/{dateTimeOffset:yyyy-MM-dd}");
        }

        /// <summary>
        /// Returns an the NHL team logo based a dark or light preference using the NHL team enumeration
        /// </summary>
        /// <param name="team">The NHL team identifier, 55 - Seattle Kraken, see <see cref="TeamEnum"/> for more information</param>
        /// <param name="teamLogoType">The NHL team logo image type, based on the background of light or dark</param>
        /// <returns>Returns NHL team logo information including a byte array, base64 encoded string and the Uri endpoint</returns>
        public async Task<TeamLogo> GetTeamLogoAsync(TeamEnum team, TeamLogoType teamLogoType = TeamLogoType.Light)
        {
            var endpoint = $"logos/nhl/svg/{_nhlTeamService.GetTeamCodeIdentfierByTeamId((int)team)}_{_nhlTeamService.GetTeamLogoColorIdentfier(teamLogoType)}.svg";
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
            var endpoint = $"logos/nhl/svg/{_nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId)}_{_nhlTeamService.GetTeamLogoColorIdentfier(teamLogoType)}.svg";
            var imageContent = await _nhlStaticAssetsApiHttpClient.GetByteArrayAsync(endpoint);

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
        /// <param name="dateTimeOffset">The date requested for the NHL season standing</param>
        /// <returns>Return the NHL league standings for the specified date with specific team information</returns>
        public async Task<LeagueStanding> GetLeagueStandingsByDateTimeOffsetAsync(DateTimeOffset dateTimeOffset)
        {
            return await _nhlWebApiHttpClient.GetAsync<LeagueStanding>($"/standings/{dateTimeOffset:yyyy-MM-dd}");
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

        /// <summary>
        /// Returns the NHL league standings for the all NHL seasons with specific league season information
        /// </summary>
        /// <returns>Returns the NHL league standings information for each saeson since 1917-1918</returns>
        public async Task<LeagueStandingsSeasonInformation> GetLeagueStandingsSeasonInformationAsync()
        {
            return await _nhlWebApiHttpClient.GetAsync<LeagueStandingsSeasonInformation>($"/standings-season");
        }

        /// <summary>
        /// Returns the NHL team roster for a specific team by the team identifier and season year
        /// </summary>
        /// <param name="teamId">The NHL team identifider, Example: 55 - Seattle Kraken</param>
        /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
        /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
        public async Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(int teamId, string seasonYear)
        {
            if (string.IsNullOrWhiteSpace(seasonYear))
            {
                throw new ArgumentException("The season year is required");
            }

            if (seasonYear.Length != 8)
            {
                throw new ArgumentException("The season year must be in the eight digit format, Example: 20232024");
            }

            var teamAbbreviation = _nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId);
            return await _nhlWebApiHttpClient.GetAsync<TeamSeasonRoster>($"/roster/{teamAbbreviation}/{seasonYear}");
        }

        /// <summary>
        /// Returns the NHL team roster for a specific team by the team and season year
        /// </summary>
        /// <param name="team">The NHL team identifider, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
        /// <param name="seasonYear">The eight digit number format for the season, see <see cref="SeasonYear"/> for more information, Example: 20232024</param>
        /// <returns>Returns the NHL team roster for a specific team by the team identifier and season year</returns>
        public async Task<TeamSeasonRoster> GetTeamRosterBySeasonYearAsync(TeamEnum team, string seasonYear)
        {
            if (string.IsNullOrWhiteSpace(seasonYear))
            {
                throw new ArgumentException("The season year is required");
            }

            if (seasonYear.Length != 8)
            {
                throw new ArgumentException("The season year must be in the eight digit format, Example: 20232024");
            }

            var teamAbbreviation = _nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team);
            return await _nhlWebApiHttpClient.GetAsync<TeamSeasonRoster>($"/roster/{teamAbbreviation}/{seasonYear}");
        }


        /// <summary>
        /// Returns every active season for an NHL team and their participation in the NHL
        /// </summary>
        /// <param name="teamId">The NHL team identifider, Example: 55 - Seattle Kraken</param>
        /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
        public async Task<List<int>> GetAllRosterSeasonsByTeamAsync(int teamId)
        {
            return await _nhlWebApiHttpClient.GetAsync<List<int>>($"/roster-season/{_nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId)}");
        }

        /// <summary>
        /// Returns every active season for an NHL team and their participation in the NHL
        /// </summary>
        /// <param name="team">The NHL team identifider, see <see cref="TeamEnum"/> for more information, Example: 9 - Ottawa Senators </param>
        /// <returns>Returns every active season for an NHL team and their participation in the NHL</returns>
        public async Task<List<int>> GetAllRosterSeasonsByTeamAsync(TeamEnum team)
        {
            return await _nhlWebApiHttpClient.GetAsync<List<int>>($"/roster-season/{_nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team)}");
        }

        /// <summary>
        /// Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies
        /// </summary>
        /// <param name="teamId">The NHL team identifider, Example: 55 - Seattle Kraken</param>
        /// <returns>Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies</returns>
        public async Task<TeamProspects> GetTeamProspectsByTeamAsync(int teamId)
        {
            return await _nhlWebApiHttpClient.GetAsync<TeamProspects>($"/prospects/{_nhlTeamService.GetTeamCodeIdentfierByTeamId(teamId)}");
        }

        /// <summary>
        /// Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies
        /// </summary>
        /// <param name="team">The NHL team identifider, see <see cref="TeamEnum"/> for more information, Example: 10 - Toronto Maple Leafs </param>
        /// <returns>Returns all the NHL prospects for the specified NHL team including forwards, defensemen and goalies</returns>
        public async Task<TeamProspects> GetTeamProspectsByTeamAsync(TeamEnum team)
        {
            return await _nhlWebApiHttpClient.GetAsync<TeamProspects>($"/prospects/{_nhlTeamService.GetTeamCodeIdentfierByTeamEnumeration(team)}");
        }
    }
}
