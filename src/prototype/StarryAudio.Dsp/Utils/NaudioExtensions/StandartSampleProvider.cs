using NAudio.Wave;
using StarryAudio.Dsp.SampleProcessing;

namespace StarryAudio.Dsp.Utils.NaudioExtensions
{
    public class StandartSampleProvider : ISampleProvider
    {
        private readonly ISampleProcessor _sampleProcessor;
        private readonly ISampleProvider _sourceProvider;

        public StandartSampleProvider(
            AudioDataProvider audioDataProvider,
            ISampleProcessor sampleProcessor)
        {
            _sourceProvider = audioDataProvider.SampleProvider;
            WaveFormat = _sourceProvider.WaveFormat;
            _sampleProcessor = sampleProcessor;
        }

        public int Read(float[] buffer, int offset, int count)
        {
            var samplesRead = _sourceProvider.Read(buffer, offset, count);
            for (var i = offset; i < count; i++)
            {
                buffer[i] = _sampleProcessor.ProcessSample(buffer[i]);
            }
            return samplesRead;
        }

        public WaveFormat WaveFormat { get; }
    }
}