namespace StarryAudio.Dsp.SampleProcessing.Settings
{
    public class DelayProcessorSettings : ISampleProcessorSettings
    {
        private const int MinEchoLength = 882;
        private const int MaxEchoLength = 100_000;
        private const float MinEchoFactor = 0.3f;
        private const float MaxEchoFactor = 1.0f;
        private const int DefaultEchoLength = 10_000;
        private const float DefatultEchoFactor = 0.75f;
        private int _echoLength;
        private float _echoFactor;

        public DelayProcessorSettings(
            int echoLength = DefaultEchoLength,
            float echoFactor = DefatultEchoFactor)
        {
            EchoLength = echoLength;
            EchoFactor = echoFactor;
        }

        public int EchoLength
        {
            get => _echoLength;
            set
            {
                if (value < MinEchoLength)
                {
                    _echoLength = MinEchoLength;
                }
                else if (value > MaxEchoLength)
                {
                    _echoLength = MaxEchoLength;
                }
                else
                {
                    _echoLength = value;
                }
            }
        }

        public float EchoFactor
        {
            get => _echoFactor;
            set
            {
                if (value < MinEchoFactor)
                {
                    _echoFactor = MinEchoFactor;
                }
                else if (value > MaxEchoFactor)
                {
                    _echoFactor = MaxEchoFactor;
                }
                else
                {
                    _echoFactor = value;
                }
            }
        }
    }
}