using System.Collections.Generic;
using StarryAudio.Dsp.SampleProcessing.Settings;
using StarryAudio.Dsp.Utils;

namespace StarryAudio.Dsp.SampleProcessing.Processors
{
    public class DelaySampleProcessor : ISampleProcessor
    {
        private readonly Queue<float> _samplesQueue;
        private int _echoLength;
        private float _echoFactor;

        public DelaySampleProcessor(DelayProcessorSettings settings)
        { 
            _samplesQueue = new Queue<float>();

            for (var j = 0; j < settings.EchoLength; j++)
            {
                _samplesQueue.Enqueue(0f);
            }

            EchoLength = settings.EchoLength;
            EchoFactor = settings.EchoFactor;
        }

        public const int MinEchoLength = 882;
        public const int MaxEchoLength = 100_000;
        public const float MinEchoFactor = 0.3f;
        public const float MaxEchoFactor = 1.0f;

        public int EchoLength
        {
            get => _echoLength;
            set
            {
                var oldLength = _echoLength;
                if (value < MinEchoLength)
                {
                    _echoLength = MinEchoLength;
                } else if (value > MaxEchoLength)
                {
                    _echoLength = MaxEchoLength;
                }
                else
                {
                    _echoLength = value;
                }

                if (oldLength < _echoLength)
                {
                    var arr = _samplesQueue.ToArray();
                    for (var i = 0; i < _echoLength - oldLength; i++)
                    {
                        _samplesQueue.Enqueue(arr[arr.Length - i -1]);
                    }
                }
                else
                {
                    for (var i = 0; i < oldLength - _echoLength; i++)
                    {
                        _samplesQueue.Dequeue();
                    }
                }
            }
        }

        public float EchoFactor
        {
            get => _echoFactor;
            set
            {
                if (value < MinEchoFactor)
                {
                    _echoFactor = MinEchoFactor;
                }
                else if (value > MaxEchoFactor)
                {
                    _echoFactor = MaxEchoFactor;
                }
                else
                {
                    _echoFactor = value;
                }
            }
        }

        public float ProcessSample(float sample)
        {
            var result = Sample.Normalize(sample + EchoFactor * _samplesQueue.Dequeue());
            _samplesQueue.Enqueue(result);
            return result;
        }
    }
}