using NAudio.Wave;

namespace StarryAudio.Dsp.Utils.NaudioExtensions
{
    public class AudioDataProvider
    {
        public AudioDataProvider(
            ISampleProvider sampleProvider,
            IWaveProvider waveProvider = null)
        {
            SampleProvider = sampleProvider;
            WaveProvider = waveProvider;
        }

        public ISampleProvider SampleProvider { get; }

        public IWaveProvider WaveProvider { get; }
    }
}