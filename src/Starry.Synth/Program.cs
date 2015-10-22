using System;
using NAudio.Wave;

namespace StarrySynth
{
    static class Program
    {
        static void Main(string[] args)
        {
            var sineWaveProvider = new SineWaveProvider32();
            sineWaveProvider.SetWaveFormat(16000, 1); // 16kHz mono
            sineWaveProvider.Frequency = 200;
            sineWaveProvider.Amplitude = 0.25f;
            var waveOut = new WaveOut
            {
                DesiredLatency = 100
            };
            waveOut.Init(sineWaveProvider);
            waveOut.Play();
            try
            {
                while (true)
                {
                    var keyInfo = Console.ReadKey();
                    switch (keyInfo.Key) {
                        case ConsoleKey.UpArrow:
                            sineWaveProvider.Frequency += 100;
                            break;
                        case ConsoleKey.DownArrow:
                            sineWaveProvider.Frequency -= 100;
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Bad frequency!");
                Console.ReadKey();
            }
            finally
            {
                waveOut.Stop();
                waveOut.Dispose();
            }
        }
    }
}
