using Starry.Audio.Core.Domain.Signals.SignalTypes;

namespace Starry.Audio.Core.Domain.Signals
{
    public interface ISignal
    {
        FillBufferMethod FillBufferMethod { get; }

        ISignalType SignalType { get; }
    }
}