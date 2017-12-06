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
        private readonly DelayProcessorSettings _innerDelayProcessorSettings;
        private readonly DelaySampleProcessor _delaySampleProcessor;
        private bool _incrementing;
        private int _counter;

        public ChorusSampleProcessor()
        {
            _innerDelayProcessorSettings = new DelayProcessorSettings(MinDelaySamples);
            _delaySampleProcessor = new DelaySampleProcessor(_innerDelayProcessorSettings);
            _incrementing = true;
    }

        public float ProcessSample(float sample)
        {
            var echoLength = _innerDelayProcessorSettings.EchoLength;

            if (echoLength <= MinDelaySamples)
            {
                _incrementing = true;
            }
            if (echoLength >= MaxDelaySamples)
            {
                _incrementing = false;
            }

            if (_counter == LfoVelocity)
            {
                if (_incrementing)
                {
                    _innerDelayProcessorSettings.EchoLength++;
                }
                else
                {
                    _innerDelayProcessorSettings.EchoLength--;
                }
                _counter = 0;
            }
            _counter++;
            return Sample.Normalize(sample + _delaySampleProcessor.ProcessSample(sample));
        }
    }
}