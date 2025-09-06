using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Game;

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
    Task<GameCenterPlayByPlay> AddEstimatedDateTimeOfPlayForEachPlay(GameCenterPlayByPlay gameCenterPlayByPlay);
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
    public async Task<GameCenterPlayByPlay> AddEstimatedDateTimeOfPlayForEachPlay(GameCenterPlayByPlay gameCenterPlayByPlay)
    {
        string? scoreReport = null;

        var gameId = gameCenterPlayByPlay.Id.ToString(CultureInfo.InvariantCulture)[4..];

        try
        {
            scoreReport = await this._nhlScoresHtmlReportsApiHttpClient.GetStringAsync($"/{gameCenterPlayByPlay.Season}/PL{gameId}.HTM", default);
        }
        catch
        {
            return gameCenterPlayByPlay;
        }

        var timePeriodMatches = Regex.Matches(scoreReport, @"(?<=<td class="" \+ bborder"">)Period(.*?)(?=</td>)", RegexOptions.Compiled | RegexOptions.CultureInvariant, TimeSpan.FromSeconds(5)).ToList();

        if (string.IsNullOrWhiteSpace(scoreReport) || timePeriodMatches.Count == 0)
        {
            try
            {
                // Parse game start time and adjust for venue UTC offset
                var gameStart = DateTimeOffset.Parse($"{gameCenterPlayByPlay.StartTimeUTC}", CultureInfo.InvariantCulture);
                var timeSpanOffset = TimeSpan.Parse(gameCenterPlayByPlay.VenueUTCOffset, CultureInfo.InvariantCulture);

                gameStart = gameStart.AddHours(timeSpanOffset.TotalHours); // Adjust with venue UTC offset

                // Add average delay in start time (assuming game starts on average 8.5 minutes after scheduled time)
                gameStart = gameStart.AddMinutes(8.5);

                // Constants based on estimated NHL standards
                var averagePeriodDuration = TimeSpan.FromMinutes(42.5);        // Average period duration including stoppages
                var intermissionDuration = TimeSpan.FromMinutes(20);           // Intermission duration
                var overtimeIntermissionDuration = TimeSpan.FromMinutes(2.5);    // Short break before OT
                var maxRegularPeriods = 3;                                     // Number of regular periods

                foreach (var play in gameCenterPlayByPlay.Plays)
                {
                    var period = play.Period;
                    var timeElapsed = TimeSpan.Zero;
                    var timeInPeriod = TimeSpan.ParseExact(play.TimeInPeriod, @"mm\:ss", CultureInfo.InvariantCulture);

                    if (period <= maxRegularPeriods)
                    {
                        // Regular periods
                        var completedPeriods = period - 1;

                        // Total time from completed periods and intermissions
                        timeElapsed += completedPeriods * (averagePeriodDuration + intermissionDuration);

                        // Time elapsed within the current period
                        timeElapsed += timeInPeriod;
                    }
                    else
                    {
                        // Overtime periods
                        // Time from regular periods and intermissions
                        timeElapsed += maxRegularPeriods * (averagePeriodDuration + intermissionDuration);

                        // Add short break before overtime
                        timeElapsed += overtimeIntermissionDuration;

                        // Time within overtime period
                        timeElapsed += timeInPeriod;
                    }

                    // Calculate the estimated DateTime of the play
                    var estimatedDateTime = gameStart.Add(timeElapsed);

                    // Assign estimated date time to play
                    play.EstimatedDateTimeOfPlay = estimatedDateTime;
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

                for (var i = 0; i < timePeriodMatches.Count; i++)
                {
                    var match = timePeriodMatches[i].Value;
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
                    if (startTime == default || endTime == default)
                    {
                        continue;
                    }

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
    /// Calculates a multiplier for time estimation based on period duration and number of events.
    /// The multiplier is used to adjust the distribution of plays within a period.
    /// </summary>
    /// <param name="startTime">The start time of the period</param>
    /// <param name="endTime">The end time of the period</param>
    /// <param name="events">The number of events in the period</param>
    /// <returns>A multiplier value for time distribution calculations</returns>
    private static double CalculateMultiplier(DateTime startTime, DateTime endTime, int events)
    {
        // Constants for the multiplier formula
        var DURATION_COEFFICIENT = 41.0;
        var EVENTS_COEFFICIENT = 2.0;
        var CONSTANT_TERM = 381.0;
        var NORMALIZER = 3000.0;

        // Calculate duration in minutes
        var duration = (endTime - startTime).TotalMinutes;

        return ((DURATION_COEFFICIENT * duration) + (EVENTS_COEFFICIENT * events) - CONSTANT_TERM) / NORMALIZER;
    }
}
