using System;

namespace Nhl.Api.Common.Helpers;

/// <summary>
/// A helper class to parse the meta data time stamp in Nhl.Api responses
/// </summary>
public class TimeStampHelper
{
    /// <summary>
    /// Parses a meta data time stamp from the Nhl.Api
    /// </summary>
    /// <param name="timeStamp">The time stamp, Example: 20211105_201423</param>
    /// <returns>A parsed DateTimeOffset time stamp in UTC</returns>
    public static DateTimeOffset? ParseTimeStampToDateTimeOffset(string timeStamp)
    {
        try
        {
            if (string.IsNullOrWhiteSpace(timeStamp))
            {
                return null;
            }

            if (timeStamp.Length != 15)
            {
                return null;
            }

            var datetime = timeStamp.Split('_');
            if (datetime.Length != 2)
            {
                return null;
            }

            var year = datetime[0].Substring(0, 4);
            var month = datetime[0].Substring(4, 2);
            var day = datetime[0].Substring(6, 2);

            var hour = datetime[1].Substring(0, 2);
            var minute = datetime[1].Substring(2, 2);
            var second = datetime[1].Substring(4, 2);

            return DateTimeOffset.Parse($"{year}-{month}-{day}T{hour}:{minute}:{second}") as DateTimeOffset? ?? null;
        }
        catch
        {
            return null;
        }
    }

    /// <summary>
    /// Parses a <see cref="DateTimeOffset"/> to a meta data timestamp for the Nhl.Api
    /// </summary>
    /// <param name="dateTimeOffset">The timestamp, Example: <see cref="DateTimeOffset.Now"/> </param>
    /// <returns>A parsed game meta data timestamp in UTC, Exampe: 20231105_201423</returns>
    public static string ParseDateTimeOffsetFromTimeStamp(DateTimeOffset dateTimeOffset)
    {
        var year = dateTimeOffset.Year;
        var day = dateTimeOffset.Day < 10 ? $"0{dateTimeOffset.Day}" : dateTimeOffset.Day.ToString();
        var month = dateTimeOffset.Month < 10 ? $"0{dateTimeOffset.Month}" : dateTimeOffset.Month.ToString();

        var hour = dateTimeOffset.Hour < 10 ? $"0{dateTimeOffset.Hour}" : dateTimeOffset.Hour.ToString();
        var minute = dateTimeOffset.Minute < 10 ? $"0{dateTimeOffset.Minute}" : dateTimeOffset.Minute.ToString();
        var second = dateTimeOffset.Second < 10 ? $"0{dateTimeOffset.Second}" : dateTimeOffset.Second.ToString();

        return $"{year}{month}{day}_{hour}{minute}{second}";

    }
}
