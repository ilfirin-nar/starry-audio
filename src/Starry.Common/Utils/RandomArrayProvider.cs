using System;

namespace Starry.Common.Utils
{
    public static class RandomArrayProvider
    {
        public static int[] GetRandomIntegerArray()
        {
            var array = new int[100];
            var random = new Random();
            for (var index = 0; index < array.Length; index++)
            {
                array[index] = random.Next(-100, 100);
            }
            return array;
        }
    }
}