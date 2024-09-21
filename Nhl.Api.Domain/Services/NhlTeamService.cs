using Nhl.Api.Common.Extensions;
using Nhl.Api.Common.Helpers;
using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Team;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Nhl.Api.Services;
/// <summary>
/// An interface to define the NHL team service to retrieve NHL team information
/// </summary>
public interface INhlTeamService
{
    /// <summary>
    /// Returns the NHL team logo color identifier by the team logo type enumeration
    /// </summary>
    /// <param name="teamLogoType">The NHL team logo type, specifying which the NHL team logo, Example: Dark </param>
    /// <returns>The NHL team logo color identifier, Example: dark</returns>
    public string? GetTeamLogoColorIdentifier(TeamLogoType teamLogoType);

    /// <summary>
    /// Returns the NHL team code identifier by the team id
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <returns>The 3 letter code for the NHL team, Example: TOR - Toronto Maple Leafs</returns>
    public string? GetTeamCodeIdentifierByTeamId(int teamId);

    /// <summary>
    /// Returns the NHL team code identifier by the team abbreviation
    /// </summary>
    /// <param name="teamAbbreviation">The NHL team abbreviation, specifying which the NHL team, Example: TOR - Toronto Maple Leafs </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public string? GetTeamCodeIdentifierByTeamAbbreviation(string teamAbbreviation);

    /// <summary>
    /// Returns the NHL team code identifier by the team enumeration
    /// </summary>
    /// <param name="teamEnum">The NHL team enumeration, specifying which the NHL team, Example: Toronto Maple Leafs - 10 </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public string? GetTeamCodeIdentifierByTeamEnumeration(TeamEnum teamEnum);

    /// <summary>
    /// Returns the NHL team code identifier by the team enumerations
    /// </summary>
    /// <param name="teamEnums">The NHL team enumeration, specifying which the NHL team, Example: Toronto Maple Leafs - 10 </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public List<string> GetTeamCodeIdentifierByTeamEnumerations(List<TeamEnum> teamEnums);

    /// <summary>
    /// Returns the NHL team code identifier based on the full NHL team name 
    /// </summary>
    /// <param name="teamName">The NHL team name, Example: Vancouver Canucks</param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public string? GetTeamCodeIdentifierByTeamName(string teamName);

}

/// <summary>
/// An implementation of the NHL team service to retrieve NHL team information 
/// </summary>
public class NhlTeamService : INhlTeamService
{

    /// <summary>
    /// Returns the NHL team logo color identifier by the team logo type enumeration
    /// </summary>
    /// <param name="teamLogoType">The NHL team logo type, specifying which the NHL team logo, Example: Dark </param>
    /// <returns>The NHL team logo color identifier, Example: dark</returns>
    public string? GetTeamLogoColorIdentifier(TeamLogoType teamLogoType) => teamLogoType switch
    {
        TeamLogoType.Dark => "dark",
        TeamLogoType.Light => "light",
        _ => null,
    };

    /// <summary>
    /// Returns the NHL team code identifier by the team id
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <returns>The 3 letter code for the NHL team, Example: TOR - Toronto Maple Leafs</returns>
    public string? GetTeamCodeIdentifierByTeamId(int teamId) => teamId switch
    {
        (int)TeamEnum.AnaheimDucks => TeamCodes.MightyDucksofAnaheimAnaheimDucks,
        (int)TeamEnum.ArizonaCoyotes => TeamCodes.ArizonaCoyotes,
        (int)TeamEnum.BostonBruins => TeamCodes.BostonBruins,
        (int)TeamEnum.BuffaloSabres => TeamCodes.BuffaloSabres,
        (int)TeamEnum.CalgaryFlames => TeamCodes.CalgaryFlames,
        (int)TeamEnum.CarolinaHurricanes => TeamCodes.CarolinaHurricanes,
        (int)TeamEnum.ChicagoBlackhawks => TeamCodes.ChicagoBlackHawks,
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
        (int)TeamEnum.UtahHockeyClub => TeamCodes.UtahHockeyClub,
        _ => null,
    };

    /// <summary>
    /// Returns the NHL team code identifier by the team abbreviation
    /// </summary>
    /// <param name="teamAbbreviation">The NHL team abbreviation, specifying which the NHL team, Example: TOR - Toronto Maple Leafs </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public string? GetTeamCodeIdentifierByTeamAbbreviation(string teamAbbreviation) => teamAbbreviation switch
    {
        TeamCodes.MightyDucksofAnaheimAnaheimDucks => TeamCodes.MightyDucksofAnaheimAnaheimDucks,
        TeamCodes.ArizonaCoyotes => TeamCodes.ArizonaCoyotes,
        TeamCodes.AtlantaFlames => TeamCodes.AtlantaFlames,
        TeamCodes.AtlantaThrashers => TeamCodes.AtlantaThrashers,
        TeamCodes.BostonBruins => TeamCodes.BostonBruins,
        TeamCodes.BuffaloSabres => TeamCodes.BuffaloSabres,
        TeamCodes.CalgaryFlames => TeamCodes.CalgaryFlames,
        TeamCodes.CarolinaHurricanes => TeamCodes.CarolinaHurricanes,
        TeamCodes.ChicagoBlackHawks => TeamCodes.ChicagoBlackHawks,
        TeamCodes.ColoradoAvalanche => TeamCodes.ColoradoAvalanche,
        TeamCodes.ColumbusBlueJackets => TeamCodes.ColumbusBlueJackets,
        TeamCodes.DallasStars => TeamCodes.DallasStars,
        TeamCodes.DetroitRedWings => TeamCodes.DetroitRedWings,
        TeamCodes.EdmontonOilers => TeamCodes.EdmontonOilers,
        TeamCodes.FloridaPanthers => TeamCodes.FloridaPanthers,
        TeamCodes.LosAngelesKings => TeamCodes.LosAngelesKings,
        TeamCodes.MinnesotaWild => TeamCodes.MinnesotaWild,
        TeamCodes.MontrealCanadiens => TeamCodes.MontrealCanadiens,
        TeamCodes.NashvillePredators => TeamCodes.NashvillePredators,
        TeamCodes.NewJerseyDevils => TeamCodes.NewJerseyDevils,
        TeamCodes.NewYorkIslanders => TeamCodes.NewYorkIslanders,
        TeamCodes.NewYorkRangers => TeamCodes.NewYorkRangers,
        TeamCodes.OttawaSenators => TeamCodes.OttawaSenators,
        TeamCodes.PhiladelphiaFlyers => TeamCodes.PhiladelphiaFlyers,
        TeamCodes.PittsburghPenguins => TeamCodes.PittsburghPenguins,
        TeamCodes.SanJoseSharks => TeamCodes.SanJoseSharks,
        TeamCodes.SeattleKraken => TeamCodes.SeattleKraken,
        TeamCodes.StLouisBlues => TeamCodes.StLouisBlues,
        TeamCodes.TampaBayLightning => TeamCodes.TampaBayLightning,
        TeamCodes.TorontoMapleLeafs => TeamCodes.TorontoMapleLeafs,
        TeamCodes.VancouverCanucks => TeamCodes.VancouverCanucks,
        TeamCodes.VegasGoldenKnights => TeamCodes.VegasGoldenKnights,
        TeamCodes.WashingtonCapitals => TeamCodes.WashingtonCapitals,
        TeamCodes.WinnipegJets => TeamCodes.WinnipegJets,
        TeamCodes.UtahHockeyClub => TeamCodes.UtahHockeyClub,
        _ => null,
    };


    /// <summary>
    /// Returns the NHL team code identifier by the team enumeration
    /// </summary>
    /// <param name="teamEnum">The NHL team enumeration, specifying which the NHL team, Example: Toronto Maple Leafs - 10 </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public string? GetTeamCodeIdentifierByTeamEnumeration(TeamEnum teamEnum) => teamEnum switch
    {
        TeamEnum.NewJerseyDevils => TeamCodes.NewJerseyDevils,
        TeamEnum.NewYorkIslanders => TeamCodes.NewYorkIslanders,
        TeamEnum.NewYorkRangers => TeamCodes.NewYorkRangers,
        TeamEnum.PhiladelphiaFlyers => TeamCodes.PhiladelphiaFlyers,
        TeamEnum.PittsburghPenguins => TeamCodes.PittsburghPenguins,
        TeamEnum.BostonBruins => TeamCodes.BostonBruins,
        TeamEnum.BuffaloSabres => TeamCodes.BuffaloSabres,
        TeamEnum.MontrealCanadiens => TeamCodes.MontrealCanadiens,
        TeamEnum.OttawaSenators => TeamCodes.OttawaSenators,
        TeamEnum.TorontoMapleLeafs => TeamCodes.TorontoMapleLeafs,
        TeamEnum.CarolinaHurricanes => TeamCodes.CarolinaHurricanes,
        TeamEnum.FloridaPanthers => TeamCodes.FloridaPanthers,
        TeamEnum.TampaBayLightning => TeamCodes.TampaBayLightning,
        TeamEnum.WashingtonCapitals => TeamCodes.WashingtonCapitals,
        TeamEnum.ChicagoBlackhawks => TeamCodes.ChicagoBlackHawks,
        TeamEnum.DetroitRedWings => TeamCodes.DetroitRedWings,
        TeamEnum.NashvillePredators => TeamCodes.NashvillePredators,
        TeamEnum.StLouisBlues => TeamCodes.StLouisBlues,
        TeamEnum.CalgaryFlames => TeamCodes.CalgaryFlames,
        TeamEnum.ColoradoAvalanche => TeamCodes.ColoradoAvalanche,
        TeamEnum.EdmontonOilers => TeamCodes.EdmontonOilers,
        TeamEnum.VancouverCanucks => TeamCodes.VancouverCanucks,
        TeamEnum.AnaheimDucks => TeamCodes.MightyDucksofAnaheimAnaheimDucks,
        TeamEnum.DallasStars => TeamCodes.DallasStars,
        TeamEnum.LosAngelesKings => TeamCodes.LosAngelesKings,
        TeamEnum.SanJoseSharks => TeamCodes.SanJoseSharks,
        TeamEnum.ColumbusBlueJackets => TeamCodes.ColumbusBlueJackets,
        TeamEnum.MinnesotaWild => TeamCodes.MinnesotaWild,
        TeamEnum.WinnipegJets => TeamCodes.WinnipegJets,
        TeamEnum.ArizonaCoyotes => TeamCodes.ArizonaCoyotes,
        TeamEnum.VegasGoldenKnights => TeamCodes.VegasGoldenKnights,
        TeamEnum.SeattleKraken => TeamCodes.SeattleKraken,
        TeamEnum.UtahHockeyClub => TeamCodes.UtahHockeyClub,
        _ => null,
    };

    /// <summary>
    /// Returns the NHL team code identifier by the team enumerations
    /// </summary>
    /// <param name="teamEnums">The NHL team enumeration, specifying which the NHL team, Example: Toronto Maple Leafs - 10 </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public List<string> GetTeamCodeIdentifierByTeamEnumerations(List<TeamEnum> teamEnums)
    {
        var teamCodes = new HashSet<string>();
        foreach (var team in teamEnums)
        {
            teamCodes.Add(GetTeamCodeIdentifierByTeamEnumeration(team));
        }

        return teamCodes.ToList();
    }


    /// <summary>
    /// Returns the NHL team code identifier based on the full NHL team name 
    /// </summary>
    /// <param name="teamName">The NHL team name, Example: Vancouver Canucks</param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public string GetTeamCodeIdentifierByTeamName(string teamName) => teamName.ReplaceNonAsciiWithAscii() switch
    {
        TeamNames.AnaheimDucks => TeamCodes.MightyDucksofAnaheimAnaheimDucks,
        TeamNames.ArizonaCoyotes => TeamCodes.ArizonaCoyotes,
        TeamNames.BostonBruins => TeamCodes.BostonBruins,
        TeamNames.BuffaloSabres => TeamCodes.BuffaloSabres,
        TeamNames.CalgaryFlames => TeamCodes.CalgaryFlames,
        TeamNames.CarolinaHurricanes => TeamCodes.CarolinaHurricanes,
        TeamNames.ChicagoBlackhawks => TeamCodes.ChicagoBlackHawks,
        TeamNames.ColoradoAvalanche => TeamCodes.ColoradoAvalanche,
        TeamNames.ColumbusBlueJackets => TeamCodes.ColumbusBlueJackets,
        TeamNames.DallasStars => TeamCodes.DallasStars,
        TeamNames.DetroitRedWings => TeamCodes.DetroitRedWings,
        TeamNames.EdmontonOilers => TeamCodes.EdmontonOilers,
        TeamNames.FloridaPanthers => TeamCodes.FloridaPanthers,
        TeamNames.LosAngelesKings => TeamCodes.LosAngelesKings,
        TeamNames.MinnesotaWild => TeamCodes.MinnesotaWild,
        TeamNames.MontrealCanadiens => TeamCodes.MontrealCanadiens,
        TeamNames.NashvillePredators => TeamCodes.NashvillePredators,
        TeamNames.NewJerseyDevils => TeamCodes.NewJerseyDevils,
        TeamNames.NewYorkIslanders => TeamCodes.NewYorkIslanders,
        TeamNames.NewYorkRangers => TeamCodes.NewYorkRangers,
        TeamNames.OttawaSenators => TeamCodes.OttawaSenators,
        TeamNames.PhiladelphiaFlyers => TeamCodes.PhiladelphiaFlyers,
        TeamNames.PittsburghPenguins => TeamCodes.PittsburghPenguins,
        TeamNames.SanJoseSharks => TeamCodes.SanJoseSharks,
        TeamNames.SeattleKraken => TeamCodes.SeattleKraken,
        TeamNames.StLouisBlues => TeamCodes.StLouisBlues,
        TeamNames.TampaBayLightning => TeamCodes.TampaBayLightning,
        TeamNames.TorontoMapleLeafs => TeamCodes.TorontoMapleLeafs,
        TeamNames.VancouverCanucks => TeamCodes.VancouverCanucks,
        TeamNames.VegasGoldenKnights => TeamCodes.VegasGoldenKnights,
        TeamNames.WashingtonCapitals => TeamCodes.WashingtonCapitals,
        TeamNames.WinnipegJets => TeamCodes.WinnipegJets,
        TeamNames.UtahHockeyClub => TeamCodes.UtahHockeyClub,
        _ => throw new ArgumentException($"Unknown NHL team: {teamName}", nameof(teamName)),
    };
}
