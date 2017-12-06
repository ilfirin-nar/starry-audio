using NAudio.Wave;

namespace StarryAudio.Dsp.Utils.NaudioExtensions
{
    public class AudioDataProvider
    {
        public AudioDataProvider(ISampleProvider sampleProvider)
        {
            SampleProvider = sampleProvider;
        }

        public ISampleProvider SampleProvider { get; }
    }
}