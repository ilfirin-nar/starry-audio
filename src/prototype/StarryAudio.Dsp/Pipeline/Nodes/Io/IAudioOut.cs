namespace StarryAudio.Dsp.Pipeline.Nodes.Io
{
    public interface IAudioOut : IAudioPipelineNode
    {
        void Activate();
        void Deactivate();
    }
}