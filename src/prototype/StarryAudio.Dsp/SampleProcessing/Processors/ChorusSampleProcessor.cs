using StarryAudio.Dsp.SampleProcessing.Settings;
using StarryAudio.Dsp.Utils;

namespace StarryAudio.Dsp.SampleProcessing.Processors
{
    public class ChorusSampleProcessor : ISampleProcessor
    {
        // samples = seconds * 44100
        private const int MinDelaySamples = 882; // 0.02
        private const int MaxDelaySamples = 1323; // 0.03
        private const int LfoVelocity = 200;

        private readonly DelaySampleProcessor _delaySampleProcessor;
        private bool _incrementing;
        private int _counter;

        public ChorusSampleProcessor()
        {
            _delaySampleProcessor = new DelaySampleProcessor(new DelayProcessorSettings(MinDelaySamples));
            _incrementing = true;
    }

        public float ProcessSample(float sample)
        {
            if (_delaySampleProcessor.EchoLength <= MinDelaySamples)
            {
                _incrementing = true;
            }
            if (_delaySampleProcessor.EchoLength >= MaxDelaySamples)
            {
                _incrementing = false;
            }

            if (_counter == LfoVelocity)
            {
                if (_incrementing)
                {
                    _delaySampleProcessor.EchoLength++;
                }
                else
                {
                    _delaySampleProcessor.EchoLength--;
                }
                _counter = 0;
            }
            _counter++;
            return Sample.Normalize(sample + _delaySampleProcessor.ProcessSample(sample));
        }
    }
}