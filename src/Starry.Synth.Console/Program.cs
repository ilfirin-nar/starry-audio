using System;

namespace Starry.Synth.Console
{
    static class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

//var sineWaveProvider = new SineWaveProvider32();
//sineWaveProvider.SetWaveFormat(16000, 1); // 16kHz mono
//            sineWaveProvider.Frequency = 200;
//            sineWaveProvider.Amplitude = 0.25f;
//            var waveOut = new WaveOut
//            {
//                DesiredLatency = 100
//            };
//waveOut.Init(sineWaveProvider);
//            waveOut.Play();
//            try
//            {
//                while (true)
//                {
//                    var keyInfo = System.Console.ReadKey();
//                    switch (keyInfo.Key) {
//                        case ConsoleKey.UpArrow:
//                            sineWaveProvider.Frequency += 100;
//                            break;
//                        case ConsoleKey.DownArrow:
//                            sineWaveProvider.Frequency -= 100;
//                            break;
//                    }
//                }
//            }
//            catch (Exception)
//            {
//                System.Console.WriteLine("Bad frequency!");
//                System.Console.ReadKey();
//            }
//            finally
//            {
//                waveOut.Stop();
//                waveOut.Dispose();
//            }
