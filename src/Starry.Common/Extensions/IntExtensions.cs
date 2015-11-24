using System;

namespace Starry.Common.Extensions
{
    public static class IntExtensions
    {
        public static void Times(this int count, Action action)
        {
            for (var index = 0; index < count; index++)
            {
                action();
            }
        }

        public static void Times(this int count, Action<int> action)
        {
            for (var index = 0; index < count; index++)
            {
                action(index);
            }
        }
    }
}