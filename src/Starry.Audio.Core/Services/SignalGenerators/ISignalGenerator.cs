using Starry.Audio.Core.Enums;
using Starry.Audio.Core.Interfaces;

namespace Starry.Audio.Core.Services.SignalGenerators
{
    public interface ISignalGenerator
    {
        SignalType SignalType { get; set; }

        ISignal Generate();
    }
}