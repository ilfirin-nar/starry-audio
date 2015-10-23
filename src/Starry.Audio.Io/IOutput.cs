using Starry.Audio.Core.Intefaces;

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