using Starry.Audio.Core.Domain.Signals.SignalTypes;

namespace Starry.Audio.Core.Domain.Signals
{
    internal class Signal : ISignal
    {
        public Signal(FillBufferMethod fillBufferMethod, ISignalType signalType)
        {
            FillBufferMethod = fillBufferMethod;
            SignalType = signalType;
        }

        public FillBufferMethod FillBufferMethod { get; }

        public ISignalType SignalType { get; }
    }
}