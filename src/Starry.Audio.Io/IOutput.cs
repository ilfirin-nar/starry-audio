using Starry.Audio.Core.ModuleInterface.Interfaces;

namespace Starry.Audio.Io
{
    public interface IOutput
    {
        void Initialize();
        void Play(ISignal signal);
        void Pause();
        void Stop();
    }
}