using StarryAudio.Loopback.DemoApp.Utils;

namespace StarryAudio.Loopback.DemoApp
{
    public class ChorusEffect : IEffect
    {
        // samples = seconds * 44100
        private const int MinDelaySamples = 882; // 0.02
        private const int MaxDelaySamples = 1323; // 0.03
        private const int LfoVelocity = 200;

        private readonly DelayEffect _delayEffect;
        private bool _incrementing;
        private int _counter;

        public ChorusEffect()
        {
            _delayEffect = new DelayEffect(MinDelaySamples);
            _incrementing = true;
    }

        public float ApplyEffect(float sample)
        {
            if (_delayEffect.EchoLength <= MinDelaySamples)
            {
                _incrementing = true;
            }
            if (_delayEffect.EchoLength >= MaxDelaySamples)
            {
                _incrementing = false;
            }

            if (_counter == LfoVelocity)
            {
                if (_incrementing)
                {
                    _delayEffect.EchoLength++;
                }
                else
                {
                    _delayEffect.EchoLength--;
                }
                _counter = 0;
            }
            _counter++;
            return Sample.Normalize(sample + _delayEffect.ApplyEffect(sample));
        }
    }
}