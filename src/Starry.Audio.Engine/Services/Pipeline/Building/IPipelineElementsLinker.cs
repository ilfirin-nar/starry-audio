using Starry.Audio.Engine.Domain.Pipeline.Building;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    public interface IPipelineElementsLinker : IService
    {
        void Link(IPipelineElementsBinding binding);
    }
}