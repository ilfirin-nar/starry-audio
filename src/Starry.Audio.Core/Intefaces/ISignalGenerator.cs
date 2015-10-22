using Starry.Audio.Core.Enums;

namespace Starry.Audio.Core.Intefaces
{
    public interface ISignalGenerator
    {
        SignalType SignalType { get; set; }

        ISignal Generate();
    }
}