using System;

namespace Nhl.Api.Common.Extensions;

/// <summary>
/// A simple library for String extensions for the Nhl.Api
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Converts a string to a camel case formatted string
    /// </summary>
    /// <param name="value">The string value needed to be converted to camel case</param>
    /// <returns>A camel cased string, Example: aCamelCasedString</returns>
    public static string ToCamelCase(this string value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            throw new ArgumentNullException(nameof(value));
        }

        return char.ToLowerInvariant(value[0]) + value.Substring(1);
    }
}
