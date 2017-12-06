using System.Collections.Generic;
using StarryAudio.Dsp.SampleProcessing.Settings;
using StarryAudio.Dsp.Utils;

namespace StarryAudio.Dsp.SampleProcessing.Processors
{
    public class DelaySampleProcessor : ISampleProcessor
    {
        private readonly Queue<float> _samplesQueue;
        private readonly DelayProcessorSettings _settings;

        public DelaySampleProcessor(DelayProcessorSettings settings)
        { 
            _samplesQueue = new Queue<float>();

            for (var j = 0; j < settings.EchoLength; j++)
            {
                _samplesQueue.Enqueue(0f);
            }

            _settings = settings;
        }

        public float ProcessSample(float sample)
        {
            ActualizeQueueSize(_settings.EchoLength);

            var result = Sample.Normalize(sample + _settings.EchoFactor * _samplesQueue.Dequeue());
            _samplesQueue.Enqueue(result);
            return result;
        }

        private void ActualizeQueueSize(int echoLength)
        {
            var oldLength = _samplesQueue.Count;
            if (oldLength < echoLength)
            {
                var arr = _samplesQueue.ToArray();
                for (var i = 0; i < echoLength - oldLength; i++)
                {
                    _samplesQueue.Enqueue(arr[arr.Length - i - 1]);
                }
            }
            else
            {
                for (var i = 0; i < oldLength - echoLength; i++)
                {
                    _samplesQueue.Dequeue();
                }
            }
        }
    }
}