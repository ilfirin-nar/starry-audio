using StarryAudio.Dsp.SampleProcessing.Settings;
using StarryAudio.Dsp.Utils;

namespace StarryAudio.Dsp.SampleProcessing.Processors
{
    public class ReverbSampleProcessor : ISampleProcessor
    {
        private const int DelaySamples = 882; // 0.02

        private readonly DelaySampleProcessor _delaySampleProcessor;

        public ReverbSampleProcessor(ReverbProcessorSettings settings)
        {
            _delaySampleProcessor = new DelaySampleProcessor(
                new DelayProcessorSettings(DelaySamples, settings.TailSize)
            );
        }

        public float ProcessSample(float sample)
        {
            return Sample.Normalize(sample + _delaySampleProcessor.ProcessSample(sample));
        }
    }
}