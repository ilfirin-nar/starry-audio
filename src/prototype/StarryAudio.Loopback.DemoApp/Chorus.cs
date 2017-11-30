using System;

namespace StarryAudio.Loopback.DemoApp
{
    public class Chorus : IEffect
    {
        // samples = seconds * 44100
        private const int MinDelaySamples = 882; // 0.02
        private const int MaxDelaySamples = 1323; // 0.03
        private const int LfoVelocity = 200;

        private readonly Delay _delay;
        private bool _incrementing;
        private int _counter;

        public Chorus()
        {
            _delay = new Delay(MinDelaySamples);
            _incrementing = true;
    }

        public float ApplyEffect(float sample)
        {
            if (_delay.EchoLength <= MinDelaySamples)
            {
                _incrementing = true;
            }
            if (_delay.EchoLength >= MaxDelaySamples)
            {
                _incrementing = false;
            }

            if (_counter == LfoVelocity)
            {
                if (_incrementing)
                {
                    _delay.EchoLength++;
                }
                else
                {
                    _delay.EchoLength--;
                }
                _counter = 0;
            }
            _counter++;
            return Math.Min(1, Math.Max(-1, sample + _delay.ApplyEffect(sample)));
        }
    }
}