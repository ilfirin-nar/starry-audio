using System;

namespace Starry.Common.Utils
{
    public static class RandomArrayProvider
    {
        public static int[] GetRandomIntegerArray(int count = 100)
        {
            var array = new int[count];
            var random = new Random();
            for (var index = 0; index < array.Length; index++)
            {
                array[index] = random.Next(-count, count);
            }
            return array;
        }

        public static string[] GetRandomStringArray(int count = 100)
        {
            var array = new string[count];
            var random = new Random();
            for (var index = 0; index < array.Length; index++)
            {
                array[index] = RandomStringGenerator.GetRandomString((uint) random.Next(0, count));
            }
            return array;
        }
    }
}