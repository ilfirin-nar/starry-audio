using System;
using System.Collections.Generic;

namespace StarryAudio.Loopback.DemoApp
{
    public class Delay : IEffect
    {
        private readonly Queue<float> _samplesQueue;
        private int _echoLength;
        private float _echoFactor;

        public Delay(int echoLength = DefaultEchoLength, float echoFactor = DefatultEchoFactor)
        {
            _samplesQueue = new Queue<float>();

            for (var j = 0; j < echoLength; j++)
            {
                _samplesQueue.Enqueue(0f);
            }

            EchoLength = echoLength;
            EchoFactor = echoFactor;
        }

        public const int MinEchoLength = 882;
        public const int MaxEchoLength = 100_000;
        public const int DefaultEchoLength = 10_000;
        public const float MinEchoFactor = 0.3f;
        public const float MaxEchoFactor = 1.0f;
        public const float DefatultEchoFactor = 0.75f;

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

        public float ApplyEffect(float sample)
        {
            var result = Math.Min(1, Math.Max(-1, sample + EchoFactor * _samplesQueue.Dequeue()));
            _samplesQueue.Enqueue(result);
            return result;
        }
    }
}