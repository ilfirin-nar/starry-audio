using Starry.Audio.Core.Domain.SignalTypes;

namespace Starry.Audio.Core.Services.SignalGenerators.SignalGenerationStrategies
{
    internal class TriangleGenerationStrategy : ISignalGenerationStrategy<TriangleSignalType>
    {
        public int FillBuffer(byte[] buffer, int offset, int sampleCount)
        {
            throw new System.NotImplementedException();
        }
    }
}