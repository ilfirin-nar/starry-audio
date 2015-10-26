using Starry.Audio.Core.Domain.Signals.SignalTypes;

namespace Starry.Audio.Core.Services.SignalGenerators.Strategies
{
    internal class SawGenerationStrategy : ISignalGenerationStrategy<SawSignalType>
    {
        public int FillBuffer(byte[] buffer, int offset, int sampleCount)
        {
            throw new System.NotImplementedException();
        }
    }
}