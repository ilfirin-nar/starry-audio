using Starry.Audio.Core.ModuleInterface.Interfaces;

namespace Starry.Audio.Core.Services.SignalGenerators
{
    public interface ISignalGenerator
    {
        ISignal Generate(ISignalType signalType);
    }
}