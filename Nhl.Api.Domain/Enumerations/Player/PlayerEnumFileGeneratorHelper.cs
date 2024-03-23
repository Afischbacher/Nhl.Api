namespace Nhl.Api.Models.Enumerations.Player;
using Nhl.Api.Common.Http;
using Nhl.Api.Models.Player;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

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
    public static async Task UpdatePlayerEnumToFile(string path)
    {
        var startCount = 0;

        var playerSearchResultsTasks = new List<Task<PlayerData>>();
        var players = new Dictionary<int, string>();
        var response = await _nhlApiHttpClient.GetAsync<PlayerData>($"/players?start={startCount}");
        var total = response.Total;

        while (startCount <= total)
        {
            playerSearchResultsTasks.Add(_nhlApiHttpClient.GetAsync<PlayerData>($"/players?start={startCount}"));
            startCount += 5;
        }

        var playerSearchResultsCollections = await Task.WhenAll(playerSearchResultsTasks);

        foreach (var playerSearchResults in playerSearchResultsCollections)
        {
            foreach (var playerSearchResult in playerSearchResults.Data)
            {
                if (!players.ContainsKey(playerSearchResult.Id))
                {
                    players.Add(playerSearchResult.Id, $"{Regex.Replace(ReplaceNonAsciiWithAscii(playerSearchResult.FullName), @"('|\.|\s|-|_|&|)", string.Empty, RegexOptions.CultureInvariant | RegexOptions.Compiled)}{playerSearchResult.Id}");
                }
            }
        }

        using StreamWriter outputFile = new(Path.Combine(path, "InternalPlayerEnum.cs"));
        outputFile.WriteLine($"namespace Nhl.Api.Models.Enumerations.Player;");
        outputFile.WriteLine($"/// <summary>");
        outputFile.WriteLine($"/// The NHL player enumeration of all NHL players");
        outputFile.WriteLine($"/// </summary>");
        outputFile.WriteLine("public enum PlayerEnum");
        outputFile.WriteLine("{");
        var lines = players.Select(x => new { PlayerName = x.Value, EnumValue = $"    {x.Value} = {x.Key}," });
        foreach (var line in lines)
        {
            outputFile.WriteLine($"    /// <summary>");
            outputFile.WriteLine($"    /// {line.PlayerName}");
            outputFile.WriteLine($"    /// </summary>");
            outputFile.WriteLine(line.EnumValue);
        }
        outputFile.WriteLine("}");

    }

    /// <summary>
    /// Replaces non-ASCII characters with their ASCII equivalents
    /// </summary>
    /// <param name="input">The string value for conversion</param>
    /// <returns>The ASCII equivalent of the non-ASCII string</returns>
    public static string ReplaceNonAsciiWithAscii(string input)
    {
        // Define a regular expression pattern for non-ASCII characters
        string pattern = @"[^\x00-\x7F]";

        // Replace non-ASCII characters with their ASCII equivalents
        string output = Regex.Replace(input, pattern, (match) =>
        {
            char c = match.Value[0];
            return c switch
            {
                'À' or 'Á' or 'Â' or 'Ã' or 'Ä' => "A",
                'Å' => "A",
                'Æ' => "AE",
                'Ç' or 'Ć' => "C",
                'È' or 'É' or 'Ê' or 'Ë' => "E",
                'Ì' or 'Í' or 'Î' or 'Ï' => "I",
                'Ð' or 'Đ' => "D",
                'Ñ' => "N",
                'Ò' or 'Ó' or 'Ô' or 'Õ' or 'Ö' => "O",
                'Ø' => "O",
                'Ù' or 'Ú' or 'Û' or 'Ü' => "U",
                'Š' => "S",
                'Ý' or 'Ÿ' => "Y",
                'Ž' => "Z",
                'à' or 'á' or 'â' or 'ã' or 'ä' => "a",
                'å' => "a",
                'æ' => "ae",
                'ç' or 'ć' => "c",
                'đ' => "d",
                'è' or 'é' or 'ê' or 'ë' => "e",
                'ì' or 'í' or 'î' or 'ï' => "i",
                'ð' => "d",
                'ñ' => "n",
                'ò' or 'ó' or 'ô' or 'õ' or 'ö' => "o",
                'ø' => "o",
                'ù' or 'ú' or 'û' or 'ü' => "u",
                'š' => "s",
                'ý' or 'ÿ' => "y",
                'ž' => "z",
                _ => c.ToString(),
            };
        });

        return output;
    }
}
