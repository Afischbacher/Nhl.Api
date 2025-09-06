using Nhl.Api.Common.Attributes;

namespace Nhl.Api.Models.Enumerations.Team;

/// <summary>
/// An enumeration for all active NHL teams
/// </summary>
public enum TeamEnum
{
    /// <summary>
    /// New Jersey Devils
    /// </summary>
    [TeamActive(true)]
    NewJerseyDevils = 1,
    /// <summary>
    /// New York Islanders
    /// </summary>
    [TeamActive(true)]
    NewYorkIslanders = 2,
    /// <summary>
    /// New York Rangers
    /// </summary>
    [TeamActive(true)]
    NewYorkRangers = 3,
    /// <summary>
    /// Philadelphia Flyers
    /// </summary>
    [TeamActive(true)]
    PhiladelphiaFlyers = 4,
    /// <summary>
    /// Pittsburgh Penguins
    /// </summary>
    [TeamActive(true)]
    PittsburghPenguins = 5,
    /// <summary>
    /// Boston Bruins
    /// </summary>
    [TeamActive(true)]
    BostonBruins = 6,
    /// <summary>
    /// Buffalo Sabres
    /// </summary>
    [TeamActive(true)]
    BuffaloSabres = 7,
    /// <summary>
    /// Montreal Canadiens
    /// </summary>
    [TeamActive(true)]
    MontrealCanadiens = 8,
    /// <summary>
    /// Ottawa Senators
    /// </summary>
    [TeamActive(true)]
    OttawaSenators = 9,
    /// <summary>
    /// Toronto Maple Leafs
    /// </summary>
    [TeamActive(true)]
    TorontoMapleLeafs = 10,
    /// <summary>
    /// Carolina Hurricanes
    /// </summary>
    [TeamActive(true)]
    CarolinaHurricanes = 12,
    /// <summary>
    /// Florida Panthers
    /// </summary>
    [TeamActive(true)]
    FloridaPanthers = 13,
    /// <summary>
    /// Tampa Bay Lightning
    /// </summary>
    [TeamActive(true)]
    TampaBayLightning = 14,
    /// <summary>
    /// Washington Capitals
    /// </summary>
    [TeamActive(true)]
    WashingtonCapitals = 15,
    /// <summary>
    /// Chicago Blackhawks
    /// </summary>
    [TeamActive(true)]
    ChicagoBlackhawks = 16,
    /// <summary>
    /// Detroit Red Wings
    /// </summary>
    [TeamActive(true)]
    DetroitRedWings = 17,
    /// <summary>
    /// Nashville Predators
    /// </summary>
    [TeamActive(true)]
    NashvillePredators = 18,
    /// <summary>
    /// St.Louis Blues
    /// </summary>
    [TeamActive(true)]
    StLouisBlues = 19,
    /// <summary>
    /// Calgary Flames
    /// </summary>
    [TeamActive(true)]
    CalgaryFlames = 20,
    /// <summary>
    /// Colorado Avalanche
    /// </summary>
    [TeamActive(true)]
    ColoradoAvalanche = 21,
    /// <summary>
    /// Edmonton Oilers
    /// </summary>
    [TeamActive(true)]
    EdmontonOilers = 22,
    /// <summary>
    /// Vancouver Canucks
    /// </summary>
    [TeamActive(true)]
    VancouverCanucks = 23,
    /// <summary>
    /// Anaheim Ducks
    /// </summary>
    [TeamActive(true)]
    AnaheimDucks = 24,
    /// <summary>
    /// Dallas Stars
    /// </summary>
    [TeamActive(true)]
    DallasStars = 25,
    /// <summary>
    /// Los Angeles Kings
    /// </summary>
    [TeamActive(true)]
    LosAngelesKings = 26,
    /// <summary>
    /// San Jose Sharks
    /// </summary>
    [TeamActive(true)]
    SanJoseSharks = 28,
    /// <summary>
    /// Columbus Blue Jackets
    /// </summary>
    [TeamActive(true)]
    ColumbusBlueJackets = 29,
    /// <summary>
    /// Minnesota Wild
    /// </summary>
    [TeamActive(true)]
    MinnesotaWild = 30,
    /// <summary>
    /// Winnipeg Jets
    /// </summary>
    [TeamActive(true)]
    WinnipegJets = 52,
    /// <summary>
    /// Arizona Coyotes
    /// </summary>
    [TeamActive(false)]
    ArizonaCoyotes = 53,
    /// <summary>
    /// Vegas Golden Knights
    /// </summary>
    [TeamActive(true)]
    VegasGoldenKnights = 54,
    /// <summary>
    /// Seattle Kraken
    /// </summary>
    [TeamActive(true)]
    SeattleKraken = 55,
    /// <summary>
    /// Utah Mammoth
    /// </summary>
    [TeamActive(true)]
    UtahMammoth = 59
}
