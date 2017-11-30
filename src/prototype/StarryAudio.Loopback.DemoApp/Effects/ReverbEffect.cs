using StarryAudio.Loopback.DemoApp.Utils;

namespace StarryAudio.Loopback.DemoApp
{
    public class ReverbEffect : IEffect
    {
        private const int DelaySamples = 882; // 0.02

        private readonly DelayEffect _delayEffect;

        public ReverbEffect()
        {
            _delayEffect = new DelayEffect(DelaySamples, 0.8f);
        }

        public float ApplyEffect(float sample)
        {
            return Sample.Normalize(sample + _delayEffect.ApplyEffect(sample));
        }
    }
}