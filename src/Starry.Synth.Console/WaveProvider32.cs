using NAudio.Wave;

namespace Starry.Synth.Console
{
    public abstract class WaveProvider32 : IWaveProvider
    {
        protected WaveProvider32() : this(44100, 1) {}

        private WaveProvider32(int sampleRate, int channels)
        {
            SetWaveFormat(sampleRate, channels);
        }

        public void SetWaveFormat(int sampleRate, int channels)
        {
            WaveFormat = WaveFormat.CreateIeeeFloatWaveFormat(sampleRate, channels);
        }

        public int Read(byte[] buffer, int offset, int count)
        {
            var waveBuffer = new WaveBuffer(buffer);
            const int someDeriver = 4;
            var samplesRequired = count / someDeriver;
            var samplesRead = Read(waveBuffer.FloatBuffer, offset / someDeriver, samplesRequired);
            return samplesRead * someDeriver;
        }

        protected abstract int Read(float[] buffer, int offset, int sampleCount);

        public WaveFormat WaveFormat { get; private set; }
    }
}