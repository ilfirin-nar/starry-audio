namespace StarryAudio.Dsp.Pipeline.Nodes.Io
{
    public interface IAudioIn : IAudioPipelineNode
    {
        void Activate();
        void Deactivate();
    }
}