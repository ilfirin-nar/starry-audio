using Starry.Audio.Core.Services.SignalGenerators;
using Starry.Audio.Engine.Domain.Pipeline.Elements.Connectors.Output;

namespace Starry.Audio.Engine.Domain.Pipeline.Elements.Units.Sources
{
    internal class SignalGeneratorSource : ISignalGeneratorSource
    {
        private readonly ISignalGenerator signalGenerator;

        public SignalGeneratorSource(
            ISignalGenerator signalGenerator,
            IStandartOutputConnector connector)
        {
            this.signalGenerator = signalGenerator;
            OutputConnector = connector;
        }

        public IStandartOutputConnector OutputConnector { get; }
    }
}