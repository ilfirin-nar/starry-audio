using System.Threading;
using StarryAudio.Dsp.Pipeline;
using StarryAudio.Dsp.SampleProcessing.Processors;
using StarryAudio.Dsp.SampleProcessing.Settings;

namespace StarryAudio.DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            new AudioPipeline(1, 50)
                .Processor<DelaySampleProcessor>(new DelayProcessorSettings())
                //.Processor<ReverbSampleProcessor>(new ReverbProcessorSettings())
                .Output()
                .Activate();

            while (true)
            {
                Thread.Sleep(500);
            }
        }

        //public static void Main(string[] args)
        //{
        //    var loopback = new Loopback();
        //    //loopback.Start();

        //    // chorus
        //    //var chorusSampleProvider = new EffectSampleProvider(loopback.SampleProvider, new ChorusEffect());
        //    //loopback.StartWith(chorusSampleProvider);

        //    // double delay
        //    //var delaySampleProvider = new EffectSampleProvider(loopback.SampleProvider, new DelayEffect(DelayEffect.DefaultEchoLength + 30000));
        //    //var secondDelaySampleProvider = new EffectSampleProvider(delaySampleProvider, new DelayEffect());
        //    //loopback.StartWith(secondDelaySampleProvider);

        //    var sampleProvider = new EffectSampleProvider(loopback.SampleProvider, new ReverbEffect());
        //    loopback.StartWith(sampleProvider);

        //    while (true)
        //    {
        //        Thread.Sleep(500);
        //    }
        //}
    }
}
