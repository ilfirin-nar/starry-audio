using Starry.Audio.Core.Interfaces;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Core.Services.Configuration
{
    public interface IAudioConfigurationChecker : IService
    {
        void Check(IAudioConfiguration configuration);
    }
}