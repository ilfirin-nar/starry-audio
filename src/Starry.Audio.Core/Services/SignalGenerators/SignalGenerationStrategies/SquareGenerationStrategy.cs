using Starry.Audio.Core.Domain.SignalTypes;

namespace Starry.Audio.Core.Services.SignalGenerators.SignalGenerationStrategies
{
    internal class SquareGenerationStrategy : ISignalGenerationStrategy<SquareSignalType>
    {
        public int FillBuffer(byte[] buffer, int offset, int sampleCount)
        {
            throw new System.NotImplementedException();
        }
    }
}