using System.Text.RegularExpressions;

namespace Nhl.Api.Common.Extensions;
/// <summary>
/// A helper class for string extensions
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Replaces non-ASCII characters with their ASCII equivalents
    /// </summary>
    /// <param name="input">The string value for conversion</param>
    /// <returns>The ASCII equivalent of the non-ASCII string</returns>
    public static string ReplaceNonAsciiWithAscii(this string input)
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
