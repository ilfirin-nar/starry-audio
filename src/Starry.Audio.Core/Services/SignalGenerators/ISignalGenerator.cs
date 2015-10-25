using Starry.Audio.Core.Domain.Signals;
using Starry.Audio.Core.Domain.Signals.SignalTypes;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Core.Services.SignalGenerators
{
    public interface ISignalGenerator : IService
    {
        ISignal Generate(ISignalType signalType);
    }
}