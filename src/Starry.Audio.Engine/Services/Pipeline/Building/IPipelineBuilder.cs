using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    public interface IPipelineBuilder : IService
    {
        IPipeline Build(IPipelineDesigner pipelineDesigner);
    }
}