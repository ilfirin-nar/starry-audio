using Starry.Audio.Core.Domain.Signals.SignalTypes;
using Starry.Audio.Core.Services.SignalGenerators.Strategies;
using Starry.Infrastructure.ServiceProviders;

namespace Starry.Audio.Core.Services.SignalGenerators.SignalGenerationStrategiesProviders
{
    public interface ISignalGenerationStrategyProvider : IStrategyProvider
    {
        ISignalGenerationStrategy Provide(ISignalType signalType);
    }
}