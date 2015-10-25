using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Io.Domain.Outputs
{
    public interface IAudioOutput : IService
    {
        void Initialize();
    }
}