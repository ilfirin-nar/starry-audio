using NAudio.Wave;

namespace StarryAudio.Loopback.DemoApp
{
    internal class Loopback
    {
        private const int DeviceNumber = 1;
        private const int WeveOutLatency = 50;
        private readonly WaveInEvent _sourceStream;
        private readonly DirectSoundOut _waveOut;
        private readonly WaveInProvider _waveInProvider;

        public Loopback()
        {
            var waveInDeviceCapabilities = WaveIn.GetCapabilities(DeviceNumber);
            _sourceStream = new WaveInEvent
            {
                DeviceNumber = DeviceNumber,
                WaveFormat = new WaveFormat(44100, waveInDeviceCapabilities.Channels)
            };

            _waveInProvider = new WaveInProvider(_sourceStream);
            _waveOut = new DirectSoundOut(WeveOutLatency);
        }

        public ISampleProvider SampleProvider => _waveInProvider.ToSampleProvider();

        public void Start()
        {
            _waveOut.Init(_waveInProvider);
            _sourceStream.StartRecording();
            _waveOut.Play();
        }

        public void StartWith(ISampleProvider sampleProvider)
        {
            _waveOut.Init(sampleProvider);
            _sourceStream.StartRecording();
            _waveOut.Play();
        }
    }
}