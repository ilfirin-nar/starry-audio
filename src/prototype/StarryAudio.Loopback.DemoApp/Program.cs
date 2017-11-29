using System.Threading;
using NAudio.Wave;

namespace StarryAudio.Loopback.DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loopback = new Loopback();            
            var delay1 = new EffectSampleProvider(loopback.SampleProvider, new Delay(Delay.DefaultEchoLength + 30000));
            var delay2 = new EffectSampleProvider(delay1, new Delay());
            loopback.StartWith(delay2);

            while (true)
            {
                Thread.Sleep(500);
            }
        }
    }
}
