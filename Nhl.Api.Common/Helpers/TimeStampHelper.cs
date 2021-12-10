using System;

namespace Nhl.Api.Common.Helpers
{
    /// <summary>
    /// A helper class to parse the meta data time stamp in NHL API responses
    /// </summary>
    public class TimeStampHelper
    {
        /// <summary>
        /// Parses a meta data time stamp from the NHL API
        /// </summary>
        /// <param name="timeStamp">The timestamp, Example: 20211105_201423</param>
        /// <returns>A parsed DateTimeOffset time stamp in UTC</returns>
        public static DateTimeOffset? ParseTimeStampToDateTimeOffset(string timeStamp)
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
            if(datetime.Length != 2)
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
    }
}
