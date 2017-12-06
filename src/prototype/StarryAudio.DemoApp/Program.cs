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
                .Processor<DelaySampleProcessor>(new DelayProcessorSettings(20_000))
                .Output()
                .Activate();

            while (true)
            {
                Thread.Sleep(500);
            }
        }
    }
}
