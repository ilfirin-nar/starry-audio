using NAudio.Wave;
using StarryAudio.Dsp.Utils.NaudioExtensions;

namespace StarryAudio.Dsp.Pipeline.Nodes.Io
{
    public class DeviceAudioIn : IAudioIn
    {
        private const int DefaultDeviceNumber = 0;
        private readonly WaveInEvent _sourceStream;

        public DeviceAudioIn(int deviceNumber = DefaultDeviceNumber)
        {
            var waveInDeviceCapabilities = WaveIn.GetCapabilities(deviceNumber);
            _sourceStream = new WaveInEvent
            {
                DeviceNumber = deviceNumber,
                WaveFormat = new WaveFormat(44100, waveInDeviceCapabilities.Channels)
            };

            var waveInProvider = new WaveInProvider(_sourceStream);
            AudioDataProvider = new AudioDataProvider(waveInProvider.ToSampleProvider());
        }

        public AudioDataProvider AudioDataProvider { get; }

        public void Activate()
        {
            _sourceStream.StartRecording();
        }

        public void Deactivate()
        {
            _sourceStream.StopRecording();
        }
    }
}