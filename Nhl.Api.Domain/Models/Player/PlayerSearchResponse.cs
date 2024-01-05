using System;
using System.Collections.Generic;

namespace Nhl.Api.Models.Player;

/// <summary>
/// NHL Player Search Response
/// </summary>
[Obsolete("This class is obsolete use the PlayerSearchResult class instead")]
public class PlayerSearchResponse
{
    /// <summary>
    /// A collection of suggestions for NHL player search
    /// </summary>
    [Obsolete("This property is obsolete use the PlayerSearchResult class instead")]
    public List<string> Suggestions { get; set; }
}
