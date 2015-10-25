using Starry.Audio.Core.Domain.Signals.SignalTypes;

namespace Starry.Audio.Core.Domain.Signals
{
    public interface ISignal
    {
        SignalCallback FillBufferCallback { get; }

        ISignalType SignalType { get; }
    }
}