using System;
using System.Collections.Generic;
using System.Text;

namespace Nhl.Api.Common.Extensions
{
    /// <summary>
    ///  A collection of LINQ extensions for the Nhl.Api
    /// </summary>
    public static class LinqExtensions
    {
        /// <summary>
        /// An extension method for finding elements in an array distinctly by a specific key or set of keys
        /// </summary>
        /// <typeparam name="TSource"></typeparam>
        /// <typeparam name="TKey"></typeparam>
        /// <param name="source"></param>
        /// <param name="keySelector"></param>
        /// <returns></returns>
        public static IEnumerable<TSource> DistinctBy<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
        {
            HashSet<TKey> seenKeys = new HashSet<TKey>();
            foreach (TSource element in source)
            {
                if (seenKeys.Add(keySelector(element)))
                {
                    yield return element;
                }
            }
        }
    }
}
