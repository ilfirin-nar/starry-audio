using NAudio.Wave;

namespace StarryAudio.Loopback.DemoApp
{
    internal class Loopback
    {
        private const int DefaultDeviceNumber = 1;
        private const int DefaultWaveOutLatency = 50;
        private readonly WaveInEvent _sourceStream;
        private readonly DirectSoundOut _waveOut;
        private readonly WaveInProvider _waveInProvider;

        public Loopback(int deviceNumber = DefaultDeviceNumber)
        {
            var waveInDeviceCapabilities = WaveIn.GetCapabilities(deviceNumber);
            _sourceStream = new WaveInEvent
            {
                DeviceNumber = deviceNumber,
                WaveFormat = new WaveFormat(44100, waveInDeviceCapabilities.Channels)
            };

            _waveInProvider = new WaveInProvider(_sourceStream);
            _waveOut = new DirectSoundOut(DefaultWaveOutLatency);
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