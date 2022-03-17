using System;
using Newtonsoft.Json;
using Nhl.Api.Common.Helpers;
using Nhl.Api.Models.Team;

namespace Nhl.Api.Models.Player
{
    /// <summary>
    /// NHL Player Search Result
    /// </summary>
    public class PlayerSearchResult
    {
        /// <summary>
        /// The NHL player id <br/>
        /// Example: 8447400
        /// </summary>
        [JsonProperty("playerId")]
        public int PlayerId { get; set; }

        /// <summary>
        /// First name of NHL player <br/>
        /// Example: Wayne
        /// </summary>
        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        /// Last name of NHL player <br/>
        /// Example: Gretzky
        /// </summary>
        [JsonProperty("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Height of the NHL player in feet and inches <br/>
        /// Example: 6\u0027 0\"
        /// </summary>
        [JsonProperty("height")]
        public string Height { get; set; }

        /// <summary>
        /// Weight of the NHL player in pounds <br/>
        /// Example: 185
        /// </summary>
        [JsonProperty("weight")]
        public string Weight { get; set; }

        /// <summary>
        /// City of birth for the NHL player <br/>
        /// Example: Brantford
        /// </summary>
        [JsonProperty("birthCity")]
        public string BirthCity { get; set; }

        /// <summary>
        /// Province or state of birth for the NHL player <br/>
        /// Example: ON
        /// </summary>
        [JsonProperty("birthProvinceState")]
        public string BirthProvinceState { get; set; }

        /// <summary>
        /// Country of birth for the NHL player <br/>
        /// Example: CAN
        /// </summary>
        [JsonProperty("birthCountry")]
        public string BirthCountry { get; set; }

        /// <summary>
        /// The full name of the birth country of the NHL Player <br/>
        /// Example: Canada
        /// </summary>
        [JsonProperty("fullBirthCountry")]
        public string FullBirthCountry
        {
            get
            {
                return CountryCodeHelper.ConvertThreeDigitCountryCodeToFullCountryName(BirthCountry);
            }
        }

        /// <summary>
        /// Is the player currently active in the NHL
        /// </summary>
        [JsonProperty("isActive")]
        public bool IsActive { get; set; }

        /// <summary>
        /// Date of birth for the NHL player <br/>
        /// Example: 1961-01-26
        /// </summary>
        [JsonProperty("birthDate")]
        public DateTime BirthDate { get; set; }

        /// <summary>
        /// The 3 letter code for the NHL team the NHL player played with <br/>
        /// See <see cref="TeamCodes"/> for more information on 3 letter codes<br/>
        /// Example: NYR
        /// </summary>
        [JsonProperty("lastTeamOfPlay")]
        public string LastTeamOfPlay { get; set; }

        /// <summary>
        /// The position for the NHL player <br/>
        /// Example: C
        /// </summary>
        [JsonProperty("position")]
        public string Position { get; set; }

        /// <summary>
        /// The jersey number for the NHL player <br/>
        /// Example: C
        /// </summary>
        [JsonProperty("playerNumber")]
        public int PlayerNumber { get; set; }

    }
}
