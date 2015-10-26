using Starry.Audio.Core.Domain.Signals.SignalTypes;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Core.Services.SignalGenerators.Strategies
{
    public interface ISignalGenerationStrategy : IStrategy
    {
        int FillBuffer(byte[] buffer, int offset, int sampleCount);
    }

    public interface ISignalGenerationStrategy<TSignalType> : ISignalGenerationStrategy
        where TSignalType : ISignalType {}
}