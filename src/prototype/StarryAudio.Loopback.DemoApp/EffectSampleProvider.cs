using NAudio.Wave;

namespace StarryAudio.Loopback.DemoApp
{
    public class EffectSampleProvider : ISampleProvider
    {
        private readonly IEffect _effect;
        private readonly ISampleProvider _sourceProvider;

        public EffectSampleProvider(ISampleProvider sourceProvider, IEffect effect)
        {
            _sourceProvider = sourceProvider;
            WaveFormat = sourceProvider.WaveFormat;
            _effect = effect;
        }

        public int Read(float[] buffer, int offset, int count)
        {
            var samplesRead = _sourceProvider.Read(buffer, offset, count);
            for (var i = offset; i < count; i++)
            {
                buffer[i] = _effect.ApplyEffect(buffer[i]);
            }

            return samplesRead;
        }

        public WaveFormat WaveFormat { get; }
    }
}