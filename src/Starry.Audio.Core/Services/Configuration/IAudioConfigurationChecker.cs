using Starry.Audio.Core.ModuleInterface.Interfaces;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Core.Services.Configuration
{
    public interface IAudioConfigurationChecker : IService
    {
        void Check(IAudioConfiguration configuration);
    }
}