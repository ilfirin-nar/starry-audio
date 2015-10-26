using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Audio.Engine.Domain.Pipeline.Building;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    public interface IPipelineDesigner
    {
        IPipelineDesign BeginWith(IPipelineSource sourceElement);

        IPipelineDesign Append(IPipelineIntermediate intermediateElement);

        IPipelineDesign Append(IPipelineSink sinkElement);
    }
}