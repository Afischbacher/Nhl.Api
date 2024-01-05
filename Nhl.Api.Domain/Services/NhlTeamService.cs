using Nhl.Api.Models.Enumerations.Team;
using Nhl.Api.Models.Team;
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
    string GetTeamLogoColorIdentfier(TeamLogoType teamLogoType);

    /// <summary>
    /// Returns the NHL team code identifier by the team id
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <returns>The 3 letter code for the NHL team, Example: TOR - Toronto Maple Leafs</returns>
    string GetTeamCodeIdentfierByTeamId(int teamId);

    /// <summary>
    /// Returns the NHL team code identifier by the team abbreviation
    /// </summary>
    /// <param name="teamAbbreviation">The NHL team abbreviation, specifying which the NHL team, Example: TOR - Toronto Maple Leafs </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    string GetTeamCodeIdentfierByTeamAbbreviation(string teamAbbreviation);

    /// <summary>
    /// Returns the NHL team code identifier by the team enumeration
    /// </summary>
    /// <param name="teamEnum">The NHL team enumeration, specifying which the NHL team, Example: Toronto Maple Leafs - 10 </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    string GetTeamCodeIdentfierByTeamEnumeration(TeamEnum teamEnum);

    /// <summary>
    /// Returns the NHL team code identifier by the team enumerations
    /// </summary>
    /// <param name="teamEnums">The NHL team enumeration, specifying which the NHL team, Example: Toronto Maple Leafs - 10 </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    List<string> GetTeamCodeIdentfierByTeamEnumerations(List<TeamEnum> teamEnums);
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
    public string GetTeamLogoColorIdentfier(TeamLogoType teamLogoType)
    {
        switch (teamLogoType)
        {
            case TeamLogoType.Dark:
                return "dark";
            case TeamLogoType.Light:
                return "light";
            default:
                return null;
        }
    }

    /// <summary>
    /// Returns the NHL team code identifier by the team id
    /// </summary>
    /// <param name="teamId">The NHL team identifier, specifying which the NHL team, Example: 55 - Seattle Kraken </param>
    /// <returns>The 3 letter code for the NHL team, Example: TOR - Toronto Maple Leafs</returns>
    public string GetTeamCodeIdentfierByTeamId(int teamId)
    {
        switch (teamId)
        {
            case (int)TeamEnum.AnaheimDucks:
                return TeamCodes.MightyDucksofAnaheimAnaheimDucks;
            case (int)TeamEnum.ArizonaCoyotes:
                return TeamCodes.ArizonaCoyotes;
            case (int)TeamEnum.BostonBruins:
                return TeamCodes.BostonBruins;
            case (int)TeamEnum.BuffaloSabres:
                return TeamCodes.BuffaloSabres;
            case (int)TeamEnum.CalgaryFlames:
                return TeamCodes.CalgaryFlames;
            case (int)TeamEnum.CarolinaHurricanes:
                return TeamCodes.CarolinaHurricanes;
            case (int)TeamEnum.ChicagoBlackhawks:
                return TeamCodes.ChicagoBlackHawks;
            case (int)TeamEnum.ColoradoAvalanche:
                return TeamCodes.ColoradoAvalanche;
            case (int)TeamEnum.ColumbusBlueJackets:
                return TeamCodes.ColumbusBlueJackets;
            case (int)TeamEnum.DallasStars:
                return TeamCodes.DallasStars;
            case (int)TeamEnum.DetroitRedWings:
                return TeamCodes.DetroitRedWings;
            case (int)TeamEnum.EdmontonOilers:
                return TeamCodes.EdmontonOilers;
            case (int)TeamEnum.FloridaPanthers:
                return TeamCodes.FloridaPanthers;
            case (int)TeamEnum.LosAngelesKings:
                return TeamCodes.LosAngelesKings;
            case (int)TeamEnum.MinnesotaWild:
                return TeamCodes.MinnesotaWild;
            case (int)TeamEnum.MontrealCanadiens:
                return TeamCodes.MontrealCanadiens;
            case (int)TeamEnum.NashvillePredators:
                return TeamCodes.NashvillePredators;
            case (int)TeamEnum.NewJerseyDevils:
                return TeamCodes.NewJerseyDevils;
            case (int)TeamEnum.NewYorkIslanders:
                return TeamCodes.NewYorkIslanders;
            case (int)TeamEnum.NewYorkRangers:
                return TeamCodes.NewYorkRangers;
            case (int)TeamEnum.OttawaSenators:
                return TeamCodes.OttawaSenators;
            case (int)TeamEnum.PhiladelphiaFlyers:
                return TeamCodes.PhiladelphiaFlyers;
            case (int)TeamEnum.PittsburghPenguins:
                return TeamCodes.PittsburghPenguins;
            case (int)TeamEnum.SanJoseSharks:
                return TeamCodes.SanJoseSharks;
            case (int)TeamEnum.SeattleKraken:
                return TeamCodes.SeattleKraken;
            case (int)TeamEnum.StLouisBlues:
                return TeamCodes.StLouisBlues;
            case (int)TeamEnum.TampaBayLightning:
                return TeamCodes.TampaBayLightning;
            case (int)TeamEnum.TorontoMapleLeafs:
                return TeamCodes.TorontoMapleLeafs;
            case (int)TeamEnum.VancouverCanucks:
                return TeamCodes.VancouverCanucks;
            case (int)TeamEnum.VegasGoldenKnights:
                return TeamCodes.VegasGoldenKnights;
            case (int)TeamEnum.WashingtonCapitals:
                return TeamCodes.WashingtonCapitals;
            case (int)TeamEnum.WinnipegJets:
                return TeamCodes.WinnipegJets;
            default:
                return null;
        }
    }

    /// <summary>
    /// Returns the NHL team code identifier by the team abbreviation
    /// </summary>
    /// <param name="teamAbbreviation">The NHL team abbreviation, specifying which the NHL team, Example: TOR - Toronto Maple Leafs </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public string GetTeamCodeIdentfierByTeamAbbreviation(string teamAbbreviation)
    {
        switch (teamAbbreviation)
        {
            case TeamCodes.MightyDucksofAnaheimAnaheimDucks:
                return TeamCodes.MightyDucksofAnaheimAnaheimDucks;
            case TeamCodes.ArizonaCoyotes:
                return TeamCodes.ArizonaCoyotes;
            case TeamCodes.AtlantaFlames:
                return TeamCodes.AtlantaFlames;
            case TeamCodes.AtlantaThrashers:
                return TeamCodes.AtlantaThrashers;
            case TeamCodes.BostonBruins:
                return TeamCodes.BostonBruins;
            case TeamCodes.BuffaloSabres:
                return TeamCodes.BuffaloSabres;
            case TeamCodes.CalgaryFlames:
                return TeamCodes.CalgaryFlames;
            case TeamCodes.CarolinaHurricanes:
                return TeamCodes.CarolinaHurricanes;
            case TeamCodes.ChicagoBlackHawks:
                return TeamCodes.ChicagoBlackHawks;
            case TeamCodes.ColoradoAvalanche:
                return TeamCodes.ColoradoAvalanche;
            case TeamCodes.ColumbusBlueJackets:
                return TeamCodes.ColumbusBlueJackets;
            case TeamCodes.DallasStars:
                return TeamCodes.DallasStars;
            case TeamCodes.DetroitRedWings:
                return TeamCodes.DetroitRedWings;
            case TeamCodes.EdmontonOilers:
                return TeamCodes.EdmontonOilers;
            case TeamCodes.FloridaPanthers:
                return TeamCodes.FloridaPanthers;
            case TeamCodes.LosAngelesKings:
                return TeamCodes.LosAngelesKings;
            case TeamCodes.MinnesotaWild:
                return TeamCodes.MinnesotaWild;
            case TeamCodes.MontrealCanadiens:
                return TeamCodes.MontrealCanadiens;
            case TeamCodes.NashvillePredators:
                return TeamCodes.NashvillePredators;
            case TeamCodes.NewJerseyDevils:
                return TeamCodes.NewJerseyDevils;
            case TeamCodes.NewYorkIslanders:
                return TeamCodes.NewYorkIslanders;
            case TeamCodes.NewYorkRangers:
                return TeamCodes.NewYorkRangers;
            case TeamCodes.OttawaSenators:
                return TeamCodes.OttawaSenators;
            case TeamCodes.PhiladelphiaFlyers:
                return TeamCodes.PhiladelphiaFlyers;
            case TeamCodes.PittsburghPenguins:
                return TeamCodes.PittsburghPenguins;
            case TeamCodes.SanJoseSharks:
                return TeamCodes.SanJoseSharks;
            case TeamCodes.SeattleKraken:
                return TeamCodes.SeattleKraken;
            case TeamCodes.StLouisBlues:
                return TeamCodes.StLouisBlues;
            case TeamCodes.TampaBayLightning:
                return TeamCodes.TampaBayLightning;
            case TeamCodes.TorontoMapleLeafs:
                return TeamCodes.TorontoMapleLeafs;
            case TeamCodes.VancouverCanucks:
                return TeamCodes.VancouverCanucks;
            case TeamCodes.VegasGoldenKnights:
                return TeamCodes.VegasGoldenKnights;
            case TeamCodes.WashingtonCapitals:
                return TeamCodes.WashingtonCapitals;
            case TeamCodes.WinnipegJets:
                return TeamCodes.WinnipegJets;
            default:
                return null;
        }
    }


    /// <summary>
    /// Returns the NHL team code identifier by the team enumeration
    /// </summary>
    /// <param name="teamEnum">The NHL team enumeration, specifying which the NHL team, Example: Toronto Maple Leafs - 10 </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public string GetTeamCodeIdentfierByTeamEnumeration(TeamEnum teamEnum)
    {
        switch (teamEnum)
        {
            case TeamEnum.NewJerseyDevils:
                return TeamCodes.NewJerseyDevils;
            case TeamEnum.NewYorkIslanders:
                return TeamCodes.NewYorkIslanders;
            case TeamEnum.NewYorkRangers:
                return TeamCodes.NewYorkRangers;
            case TeamEnum.PhiladelphiaFlyers:
                return TeamCodes.PhiladelphiaFlyers;
            case TeamEnum.PittsburghPenguins:
                return TeamCodes.PittsburghPenguins;
            case TeamEnum.BostonBruins:
                return TeamCodes.BostonBruins;
            case TeamEnum.BuffaloSabres:
                return TeamCodes.BuffaloSabres;
            case TeamEnum.MontrealCanadiens:
                return TeamCodes.MontrealCanadiens;
            case TeamEnum.OttawaSenators:
                return TeamCodes.OttawaSenators;
            case TeamEnum.TorontoMapleLeafs:
                return TeamCodes.TorontoMapleLeafs;
            case TeamEnum.CarolinaHurricanes:
                return TeamCodes.CarolinaHurricanes;
            case TeamEnum.FloridaPanthers:
                return TeamCodes.FloridaPanthers;
            case TeamEnum.TampaBayLightning:
                return TeamCodes.TampaBayLightning;
            case TeamEnum.WashingtonCapitals:
                return TeamCodes.WashingtonCapitals;
            case TeamEnum.ChicagoBlackhawks:
                return TeamCodes.ChicagoBlackHawks;
            case TeamEnum.DetroitRedWings:
                return TeamCodes.DetroitRedWings;
            case TeamEnum.NashvillePredators:
                return TeamCodes.NashvillePredators;
            case TeamEnum.StLouisBlues:
                return TeamCodes.StLouisBlues;
            case TeamEnum.CalgaryFlames:
                return TeamCodes.CalgaryFlames;
            case TeamEnum.ColoradoAvalanche:
                return TeamCodes.ColoradoAvalanche;
            case TeamEnum.EdmontonOilers:
                return TeamCodes.EdmontonOilers;
            case TeamEnum.VancouverCanucks:
                return TeamCodes.VancouverCanucks;
            case TeamEnum.AnaheimDucks:
                return TeamCodes.MightyDucksofAnaheimAnaheimDucks;
            case TeamEnum.DallasStars:
                return TeamCodes.DallasStars;
            case TeamEnum.LosAngelesKings:
                return TeamCodes.LosAngelesKings;
            case TeamEnum.SanJoseSharks:
                return TeamCodes.SanJoseSharks;
            case TeamEnum.ColumbusBlueJackets:
                return TeamCodes.ColumbusBlueJackets;
            case TeamEnum.MinnesotaWild:
                return TeamCodes.MinnesotaWild;
            case TeamEnum.WinnipegJets:
                return TeamCodes.WinnipegJets;
            case TeamEnum.ArizonaCoyotes:
                return TeamCodes.ArizonaCoyotes;
            case TeamEnum.VegasGoldenKnights:
                return TeamCodes.VegasGoldenKnights;
            case TeamEnum.SeattleKraken:
                return TeamCodes.SeattleKraken;
            default:
                return null;
        }
    }

    /// <summary>
    /// Returns the NHL team code identifier by the team enumerations
    /// </summary>
    /// <param name="teamEnums">The NHL team enumeration, specifying which the NHL team, Example: Toronto Maple Leafs - 10 </param>
    /// <returns>The NHL team code for the NHL team, Example: TOR</returns>
    public List<string> GetTeamCodeIdentfierByTeamEnumerations(List<TeamEnum> teamEnums)
    {
        var teamCodes = new HashSet<string>();
        foreach (var team in teamEnums)
        {
            teamCodes.Add(GetTeamCodeIdentfierByTeamEnumeration(team));
        }

        return teamCodes.ToList();
    }
}
