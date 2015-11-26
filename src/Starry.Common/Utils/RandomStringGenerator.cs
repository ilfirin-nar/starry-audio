using System;
using System.Linq;

namespace Starry.Common.Utils
{
    public static class RandomStringGenerator
    {
        public static string GetRandomString(uint length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, (int) length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}