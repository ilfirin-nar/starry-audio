using Starry.Audio.Core.Domain.Signals.SignalTypes;
using Starry.Audio.Core.Services.SignalGenerators.Strategies;

namespace Starry.Audio.Core.Services.SignalGenerators.SignalGenerationStrategiesProviders
{
    internal class SignalGenerationStrategyProvider : ISignalGenerationStrategyProvider
    {
        public ISignalGenerationStrategy Provide(ISignalType signalType)
        {
            throw new System.NotImplementedException();
        }
    }
}