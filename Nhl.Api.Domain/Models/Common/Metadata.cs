using Newtonsoft.Json;
using Nhl.Api.Common.Helpers;
using System;

namespace Nhl.Api.Models.Common
{
    /// <summary>
    /// MetaData
    /// </summary>
    public class MetaData
    {
        /// <summary>
        /// The time-stamp of the current time for the NHL game schedule
        /// </summary>
        [JsonProperty("timeStamp")]
        public string TimeStamp { get; set; }

        /// <summary>
        /// Time Stamp As DateTimeOffset
        /// </summary>
        public DateTimeOffset? TimeStampAsDateTimeOffset
        {
            get
            {
                return TimeStampHelper.ParseTimeStampToDateTimeOffset(TimeStamp);
            }
        }
    }
}
