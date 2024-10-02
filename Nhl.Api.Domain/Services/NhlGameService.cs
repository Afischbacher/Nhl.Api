using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;
using System;
using System.Threading.Tasks;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Game;
using System.Linq;
using Nhl.Api.Models.Schedule;

namespace Nhl.Api.Services;

/// <summary>
/// The NHL game service, enabling data enrichment and functionality to the Nhl.Api
/// </summary>
public interface INhlGameService
{
    /// <summary>
    /// A method to add the time of play for each play in the game center play by play
    /// </summary>
    /// <param name="gameCenterPlayByPlay"> A game center play by play object</param>
    /// <returns>All of the game center play by play information with the time of play for each play</returns>
    Task<GameCenterPlayByPlay> AddDateTimeOfPlayForEachPlay(GameCenterPlayByPlay gameCenterPlayByPlay);
}

/// <summary>
/// The NHL game service, enabling data enrichment and functionality to the Nhl.Api
/// </summary>
public class NhlGameService : INhlGameService
{
    private readonly NhlScoresHtmlReportsApiHttpClient _nhlScoresHtmlReportsApiHttpClient = new();

    /// <summary>
    /// A method to add the estimated time of play for each play in the game center play by play
    /// </summary>
    /// <param name="gameCenterPlayByPlay"> A game center play by play object</param>
    /// <returns>All of the game center play by play information with the time of play for each play</returns>
    public async Task<GameCenterPlayByPlay> AddDateTimeOfPlayForEachPlay(GameCenterPlayByPlay gameCenterPlayByPlay)
    {
        var gameId = gameCenterPlayByPlay.Id.ToString(CultureInfo.InvariantCulture)[4..];
        var scoreReport = await this._nhlScoresHtmlReportsApiHttpClient.GetStringAsync($"/{gameCenterPlayByPlay.Season}/PL{gameId}.HTM", default);

        var regex = Regex.Matches(scoreReport, @"(?<=<td class="" \+ bborder"">)Period(.*?)(?=</td>)", RegexOptions.Compiled, TimeSpan.FromSeconds(5)).ToList();

        if (string.IsNullOrWhiteSpace(scoreReport) || regex.Count == 0)
        {
            try
            {
                var gameStart = DateTimeOffset.Parse($"{gameCenterPlayByPlay.StartTimeUTC}", CultureInfo.InvariantCulture);
                var timeSpanOffset = TimeSpan.Parse(gameCenterPlayByPlay.VenueUTCOffset, CultureInfo.InvariantCulture);

                // Set offset
                gameStart = gameStart.AddHours(timeSpanOffset.TotalHours);

                // Set average delay in start time
                gameStart = gameStart.Add(TimeSpan.FromMinutes(8.5));

                var averageTimeDelayInIntermission = TimeSpan.FromMinutes(18);

                // Average time of a period including stoppage
                var timeOfPeriod = TimeSpan.FromMinutes(35);

                foreach (var play in gameCenterPlayByPlay.Plays)
                {
                    var period = play.Period;
                    var timeElapsed = TimeSpan.Zero;

                    if (period > 1)
                    {
                        var regularPeriodTime = period <= 3 ? ((period - 1) * timeOfPeriod) : TimeSpan.FromMinutes(105);
                        var averageDelayInIntermission = period <= 3 ? ((period - 1) * averageTimeDelayInIntermission) : TimeSpan.FromMinutes(60);
                        timeElapsed += averageDelayInIntermission + regularPeriodTime;
                    }

                    timeElapsed += TimeOnly.Parse($"00:{play.TimeInPeriod}", CultureInfo.InvariantCulture).ToTimeSpan();
                    if (period > 3)
                    {
                        timeElapsed += period * TimeSpan.FromMinutes(10);
                    }

                    timeElapsed += TimeSpan.FromSeconds(5);
                    play.EstimatedDateTimeOfPlay = gameStart.Add(timeElapsed);
                }
            }
            catch
            {
            }
        }
        else
        {
            try
            {
                var startTimeOfEachPeriod = new Dictionary<int, List<DateTime>>
                {
                    { 1, [] },
                    { 2, [] },
                    { 3, [] },
                    { 4, [] },
                    { 5, [] },
                };

                for (var i = 0; i < regex.Count; i++)
                {
                    var match = regex[i].Value;
                    var value = Regex.Match(match, @"([0-9]{1,2}:[0-9]{2})", RegexOptions.Compiled | RegexOptions.IgnoreCase, TimeSpan.FromSeconds(30)).Groups[0].Value;
                    var time = TimeOnly.Parse($"{value} PM", CultureInfo.InvariantCulture);
                    var dateTime = DateTime.Parse($"{gameCenterPlayByPlay.GameDate} {time} {gameCenterPlayByPlay.EasternUTCOffset}", CultureInfo.InvariantCulture);

                    if (i <= 1)
                    {
                        startTimeOfEachPeriod[1].Add(dateTime);
                    }
                    else if (i is >= 2 and <= 3)
                    {
                        startTimeOfEachPeriod[2].Add(dateTime);
                    }
                    else if (i is >= 4 and <= 5)
                    {
                        startTimeOfEachPeriod[3].Add(dateTime);
                    }
                    else if (i is >= 6 and <= 7)
                    {
                        startTimeOfEachPeriod[4].Add(dateTime);
                    }
                    else if (i <= 9)
                    {
                        startTimeOfEachPeriod[5].Add(dateTime);
                    }
                }

                var playsByPeriod = gameCenterPlayByPlay.Plays.GroupBy(x => x.Period).ToDictionary(x => x.Key, x => x.ToList());

                foreach (var playsForPeriod in playsByPeriod)
                {
                    var startTime = startTimeOfEachPeriod[playsForPeriod.Key].FirstOrDefault();
                    var endTime = startTimeOfEachPeriod[playsForPeriod.Key].LastOrDefault();
                    var distanceBetweenPlays = endTime - startTime;
                    var timeBetweenPlays = distanceBetweenPlays / playsForPeriod.Value.Count;

                    var multiplier = CalculateMultiplier(startTime, endTime, playsForPeriod.Value.Count);
                    for (var i = 0; i < playsForPeriod.Value.Count; i++)
                    {
                        var play = playsForPeriod.Value[i];
                        var timeElapsed = TimeOnly.Parse($"00:{playsForPeriod.Value[i].TimeInPeriod}", CultureInfo.InvariantCulture).ToTimeSpan();
                        play.EstimatedDateTimeOfPlay = startTime.Add(timeElapsed + (timeBetweenPlays * (i * multiplier)));
                    }
                }
            }
            catch
            {
            }
        }

        return gameCenterPlayByPlay;
    }

    /// <summary>
    /// A linear 
    /// </summary>
    private double CalculateMultiplier(DateTime startTime, DateTime endTime, int events)
    {
        // Calculate duration in minutes
        var duration = (endTime - startTime).TotalMinutes;

        var multiplier = ((41 * duration) + (2 * events) - 381) / 3000;

        return multiplier;
    }
}
