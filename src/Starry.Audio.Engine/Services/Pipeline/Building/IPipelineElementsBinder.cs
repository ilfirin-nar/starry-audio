using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Audio.Engine.Domain.Pipeline.Building;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    public interface IPipelineElementsBinder : IService
    {
        IPipelineElementsBinding Bind(IPipelineElement source, IPipelineElement target);
    }
}