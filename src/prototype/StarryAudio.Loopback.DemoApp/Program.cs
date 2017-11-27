using System.Threading;
using NAudio.Wave;

namespace StarryAudio.Loopback.DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loopback = new Loopback();
            var delay = new EffectSampleProvider(loopback.SampleProvider);
            loopback.StartWith(delay);

            while (true)
            {
                Thread.Sleep(500);
            }
        }
    }
}
