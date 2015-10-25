using Starry.Audio.Core.ModuleInterface.Interfaces;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Core.Services.Configuration
{
    public interface IAudioConfigurator : IService
    {
        void SetConfiguation(IAudioConfiguration configuration);
    }
}