using Starry.Audio.Core.Domain.Signals.SignalTypes;
using Starry.External.Interfaces.Audio.WaveGenerators;

namespace Starry.Audio.Core.Services.SignalGenerators.Strategies
{
    internal class SinGenerationStrategy : ISignalGenerationStrategy<SinSignalType>
    {
        private readonly ISinWave32Generator waveGenerator;

        public SinGenerationStrategy(ISinWave32Generator waveGenerator)
        {
            this.waveGenerator = waveGenerator;
        }

        public int FillBuffer(byte[] buffer, int offset, int sampleCount)
        {
            return waveGenerator.Read(buffer, offset, sampleCount);
        }
    }
}