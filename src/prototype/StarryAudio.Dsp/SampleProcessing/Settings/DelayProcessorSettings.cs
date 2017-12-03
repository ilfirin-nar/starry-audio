namespace StarryAudio.Dsp.SampleProcessing.Settings
{
    public class DelayProcessorSettings : ISampleProcessorSettings
    {
        private const int DefaultEchoLength = 10_000;
        private const float DefatultEchoFactor = 0.75f;

        public DelayProcessorSettings(
            int echoLength = DefaultEchoLength,
            float echoFactor = DefatultEchoFactor)
        {
            EchoLength = echoLength;
            EchoFactor = echoFactor;
        }

        public int EchoLength { get; }

        public float EchoFactor { get; }
    }
}