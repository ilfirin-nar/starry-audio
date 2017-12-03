using StarryAudio.Dsp.Utils.NaudioExtensions;

namespace StarryAudio.Dsp.Pipeline.Nodes
{
    public interface IAudioPipelineNode
    {
        AudioDataProvider AudioDataProvider { get; }
    }
}