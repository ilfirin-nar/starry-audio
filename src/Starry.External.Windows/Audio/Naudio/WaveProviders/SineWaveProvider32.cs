using System;
using NAudio.Wave;
using Starry.External.Interfaces.Audio.WaveGenerators;

namespace Starry.External.Windows.Audio.Naudio.WaveProviders
{
    public class SineSinWave32Generator32 : WaveProvider32, ISinWave32Generator
    {
        int sample;

        public SineSinWave32Generator32()
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