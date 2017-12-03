using NAudio.Wave;
using StarryAudio.Dsp.Utils.NaudioExtensions;

namespace StarryAudio.Dsp.Pipeline.Nodes.Io
{
    internal class DeviceAudioOut : IAudioOut
    {
        private readonly IAudioPipelineNode _inputNode;
        private readonly DirectSoundOut _waveOut;

        public DeviceAudioOut(IAudioPipelineNode inputNode, int latencyMs = 50)
        {
            _inputNode = inputNode;
            _waveOut = new DirectSoundOut(latencyMs);
        }

        public AudioDataProvider AudioDataProvider => null;

        public void Activate()
        {
            _waveOut.Init(_inputNode.AudioDataProvider.WaveProvider);
            _waveOut.Play();
        }

        public void Deactivate()
        {
            _waveOut.Stop();
        }
    }
}