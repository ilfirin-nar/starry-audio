using Starry.Audio.Core.Domain.Signals;
using Starry.Audio.Core.ModuleInterface.Interfaces;
using Starry.Audio.Core.Services.SignalGenerators.SignalGenerationStrategiesProviders;

namespace Starry.Audio.Core.Services.SignalGenerators
{
    public class SignalGenerator : ISignalGenerator
    {
        private readonly ISignalGenerationStrategyProvider strategyProvider;

        public SignalGenerator(ISignalGenerationStrategyProvider strategyProvider)
        {
            this.strategyProvider = strategyProvider;
        }

        public ISignal Generate(ISignalType signalType)
        {
            var strategy = strategyProvider.Provide(signalType);
            return new Signal((buffer, offset, sampleCount) => strategy.FillBuffer(buffer, offset, sampleCount), signalType);
        }
    }
}