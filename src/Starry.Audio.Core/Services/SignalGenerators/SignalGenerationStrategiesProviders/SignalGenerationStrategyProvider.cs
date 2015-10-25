using Starry.Audio.Core.ModuleInterface.Interfaces;
using Starry.Audio.Core.Services.SignalGenerators.SignalGenerationStrategies;

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