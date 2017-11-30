using System.Threading;

namespace StarryAudio.Loopback.DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loopback = new Loopback();
            //loopback.Start();

            // chorus
            //var chorusSampleProvider = new EffectSampleProvider(loopback.SampleProvider, new ChorusEffect());
            //loopback.StartWith(chorusSampleProvider);

            // double delay
            //var delaySampleProvider = new EffectSampleProvider(loopback.SampleProvider, new DelayEffect(DelayEffect.DefaultEchoLength + 30000));
            //var secondDelaySampleProvider = new EffectSampleProvider(delaySampleProvider, new DelayEffect());
            //loopback.StartWith(secondDelaySampleProvider);

            var sampleProvider = new EffectSampleProvider(loopback.SampleProvider, new ReverbEffect());
            loopback.StartWith(sampleProvider);

            while (true)
            {
                Thread.Sleep(500);
            }
        }
    }
}
