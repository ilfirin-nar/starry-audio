using NAudio.Wave;

namespace StarryAudio.Loopback.DemoApp
{
    internal class Loopback
    {
        private const int DeviceNumber = 1;
        private readonly WaveInEvent _sourceStream;
        private readonly DirectSoundOut _waveOut;

        public Loopback()
        {
            var waveInDeviceCapabilities = WaveIn.GetCapabilities(DeviceNumber);
            _sourceStream = new WaveInEvent
            {
                DeviceNumber = DeviceNumber,
                WaveFormat = new WaveFormat(44100, waveInDeviceCapabilities.Channels)
            };

            var waveIn = new WaveInProvider(_sourceStream);
            _waveOut = new DirectSoundOut();
            _waveOut.Init(waveIn);
        }

        public void Start()
        {
            _sourceStream.StartRecording();
            _waveOut.Play();
        }
    }
}