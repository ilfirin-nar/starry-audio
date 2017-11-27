using System.Threading;
using NAudio.Wave;

namespace StarryAudio.Loopback.DemoApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var loopback = new Loopback();
            loopback.Start();

            while (true)
            {
                Thread.Sleep(500);
            }
        }
    }
}
