using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Services.Engines
{
    public interface IAudioEngine : IService
    {
        void Run(IPipeline pipeline);
    }
}