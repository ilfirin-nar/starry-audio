using Starry.Audio.Core.ModuleInterface.Delegates;

namespace Starry.Audio.Core.ModuleInterface.Interfaces
{
    public interface ISignal
    {
        SignalCallback FillBufferCallback { get; }

        ISignalType SignalType { get; }
    }
}