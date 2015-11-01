using System.Collections.Generic;

namespace Starry.Common.Extensions
{
    public static class SetExtensions
    {
        public static ISet<T> AddRange<T>(this ISet<T> set, IEnumerable<T> enumerable)
        {
            foreach (var item in enumerable)
            {
                set.Add(item);
            }
            return set;
        }
    }
}