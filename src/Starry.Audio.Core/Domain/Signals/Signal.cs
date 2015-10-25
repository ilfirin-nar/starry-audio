using Starry.Audio.Core.ModuleInterface.Delegates;
using Starry.Audio.Core.ModuleInterface.Interfaces;

namespace Starry.Audio.Core.Domain.Signals
{
    public class Signal : ISignal
    {
        public Signal(SignalCallback fillBufferCallback, ISignalType signalType)
        {
            FillBufferCallback = fillBufferCallback;
            SignalType = signalType;
        }

        public SignalCallback FillBufferCallback { get; }

        public ISignalType SignalType { get; }
    }
}