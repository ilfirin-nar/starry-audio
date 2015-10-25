using System;
using NAudio.Wave;

namespace Starry.Audio.Core.Services.NaudioSpecific.WaveProviders
{
    public class SineWaveProvider32 : WaveProvider32
    {
        int sample;

        public SineWaveProvider32()
        {
            Frequency = 1000;
            Amplitude = 0.25f;
        }

        public float Frequency { get; set; }

        private float Amplitude { get; set; }

        public override int Read(float[] buffer, int offset, int sampleCount)
        {
            var sampleRate = WaveFormat.SampleRate;
            for (var n = 0; n < sampleCount; n++)
            {
                buffer[n + offset] = (float)(Amplitude * Math.Sin((2 * Math.PI * sample * Frequency) / sampleRate));
                sample++;
                if (sample >= sampleRate) sample = 0;
            }
            return sampleCount;
        }
    }
}