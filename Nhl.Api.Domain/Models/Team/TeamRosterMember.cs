using Newtonsoft.Json;
using Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Models.Player;

namespace Nhl.Api.Models.Team
{
    public class TeamRosterMember
    {
        /// <summary>
        /// Information about the team member such as name, NHL API link and player id
        /// </summary>
        [JsonProperty("person")]
        public Person Person { get; set; }

        /// <summary>
        /// The team roster member jersey number <br/>
        /// Example: "97"
        /// </summary>
        [JsonProperty("jerseyNumber")]
        public string JerseyNumber { get; set; }

        /// <summary>
        /// The information about the primary position of the player
        /// </summary>
        [JsonProperty("position")]
        public PrimaryPosition Position { get; set; }

        /// <summary>
        /// Returns a head-shot image of the NHL player <br/>
        /// Example: <a href="https://cms.nhl.bamgrid.com/images/headshots/current/168x168/8478402.png">Connor McDavid</a>
        /// </summary>
        public string PlayerHeadshotImageLink
        {
            get
            {
                return GetPlayerHeadshotImageLink(PlayerHeadshotImageSize.Small);
            }
        }

        /// <summary>
        /// Returns an image of the NHL player based on the requested size <br/>
        /// Example: <a href="https://cms.nhl.bamgrid.com/images/headshots/current/168x168/8478402.png">Connor McDavid</a>
        /// </summary>
        public string GetPlayerHeadshotImageLink(PlayerHeadshotImageSize playerHeadshotImageSize)
        {
            if (Person != null)
            {
                switch (playerHeadshotImageSize)
                {
                    case PlayerHeadshotImageSize.Small:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Person.Id}.png";
                    case PlayerHeadshotImageSize.Medium:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Person.Id}@2x.png";
                    case PlayerHeadshotImageSize.Large:
                        return $"{PlayerConstants.PlayerHeadshotImageLink}{Person.Id}@3x.png";
                }
            }

            return null;
        }
    }
}
