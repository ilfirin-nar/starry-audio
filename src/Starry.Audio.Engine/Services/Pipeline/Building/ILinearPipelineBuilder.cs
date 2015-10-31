using System.Collections.Generic;
using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    public interface ILinearPipelineBuilder : IService
    {
        ILinearPipeline Build(IPipelineSource soruceUnits, IList<IPipelineIntermediate> intermediatesUnits, IPipelineSink sinkUnits);
    }
}