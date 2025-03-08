using System;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;

namespace Nhl.Api.Common.Extensions;
/// <summary>
/// An enumerations extension class for the Nhl.Api
/// </summary>
public static class EnumExtensions
{
    /// <summary>
    /// Retrieves the <see cref="EnumMemberAttribute"/> value for a specific enumeration
    /// </summary>
    /// <typeparam name="T">The enumeration type</typeparam>
    /// <param name="value">The value of the enumerations</param>
    /// <returns>The string value of the enumeration based on the attribute <see cref="EnumMemberAttribute"/></returns>
    public static string? GetEnumMemberValue<T>(this T value) where T : Enum => typeof(T)
            .GetTypeInfo()
            .DeclaredMembers
            .SingleOrDefault(x => x.Name == value.ToString())
            ?.GetCustomAttribute<EnumMemberAttribute>(false)
            ?.Value ?? null;
}
