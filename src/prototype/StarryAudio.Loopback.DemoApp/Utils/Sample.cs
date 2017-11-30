using System;

namespace StarryAudio.Loopback.DemoApp.Utils
{
    internal static class Sample
    {
        public static float Normalize(float sample) => Math.Min(1, Math.Max(-1, sample));
    }
}