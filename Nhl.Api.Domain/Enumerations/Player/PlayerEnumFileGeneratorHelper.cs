using Nhl.Api.Common.Http;
using Nhl.Api.Common.Services;
using Nhl.Api.Models.Player;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Nhl.Api.Models.Enumerations.Player;

/// <summary>
/// A helper class for generating the <see cref="PlayerEnum"/> values
/// </summary>
public static class PlayerEnumFileGeneratorHelper
{
    private static readonly INhlApiHttpClient _nhlApiHttpClient = new NhlEApiHttpClient();
    /// <summary>
    /// Retrieves all NHL players to have player in the NHL
    /// </summary>
    /// <returns>A dictionary of players names and their identifiers for every NHL player to ever play</returns>
    public static void GetAllPlayers(string path)
    {
        var startCount = 0;

        var playerSearchResultsTasks = new List<Task<PlayerData>>();
        var players = new Dictionary<int, string>();
        var response = _nhlApiHttpClient.GetAsync<PlayerData>($"/players?start={startCount}").Result;
        var total = response.Total;
        
        while (startCount <= total)
        {
            playerSearchResultsTasks.Add(_nhlApiHttpClient.GetAsync<PlayerData>($"/players?start={startCount}"));
            startCount += 5;
        }

        var playerSearchResultsCollections =  NhlApiAsyncHelper.RunSync(async () => await Task.WhenAll(playerSearchResultsTasks));

        foreach (var playerSearchResults in playerSearchResultsCollections)
        {
            foreach (var playerSearchResult in playerSearchResults.Data)
            {
                players.Add(playerSearchResult.Id, $"{Regex.Replace(playerSearchResult.FullName, @"('|\.|\s|-|_|&|)", string.Empty, RegexOptions.CultureInvariant | RegexOptions.Compiled)}{playerSearchResult.Id}");
            }
        }

        using (StreamWriter outputFile = new StreamWriter(Path.Combine(path, "InternalPlayerEnum.cs")))
        {
            outputFile.WriteLine($"/// <summary>");
            outputFile.WriteLine($"/// The NHL player enumeration of all NHL players");
            outputFile.WriteLine($"/// </summary>");
            outputFile.WriteLine("public enum PlayerEnum");
            outputFile.WriteLine("{");
            var lines = players.Select(x => $"    {x.Value} = {x.Key},");
            foreach (string line in lines)
            {
                outputFile.WriteLine($"    /// <summary>");
                outputFile.WriteLine($"    /// {line}");
                outputFile.WriteLine($"    /// </summary>");
                outputFile.WriteLine(line);
            }
            outputFile.WriteLine("}");
        }
    }
}
