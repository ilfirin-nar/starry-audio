using NAudio.Wave;

namespace StarryAudio.Loopback.DemoApp
{
    public class EffectSampleProvider : ISampleProvider
    {
        private readonly Delay _effect;
        private readonly ISampleProvider _sourceProvider;

        public EffectSampleProvider(ISampleProvider sourceProvider)
        {
            _sourceProvider = sourceProvider;
            WaveFormat = sourceProvider.WaveFormat;
            _effect = new Delay();
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