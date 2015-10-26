using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline.Elements
{
    internal class SignalGeneratorSource : ISignalGeneratorSource
    {
        private readonly ISignalGenerator signalGenerator;

        public SignalGeneratorSource(ISignalGenerator signalGenerator)
        {
            this.signalGenerator = signalGenerator;
        }

        public IList<IPipelineOutputConnector> Outputs { get; private set; }
    }
}