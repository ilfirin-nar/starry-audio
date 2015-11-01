using System.Collections.Generic;

namespace Starry.Common.Extensions
{
    public static class EnumerableExtensions
    {
        public static ISet<T> ToHashSet<T>(this IEnumerable<T> collection)
        {
            return new HashSet<T>(collection);
        }

        public static ISet<T> ToSortedSet<T>(this IEnumerable<T> collection)
        {
            return new SortedSet<T>(collection);
        }
    }
}