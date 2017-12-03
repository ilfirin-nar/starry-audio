namespace StarryAudio.Dsp.SampleProcessing.Settings
{
    public class ReverbProcessorSettings : ISampleProcessorSettings
    {
        private const float DefaultTailSize = 0.8f;

        public ReverbProcessorSettings(float tailSize = DefaultTailSize)
        {
            TailSize = tailSize;
        }

        public float TailSize { get; }
    }
}