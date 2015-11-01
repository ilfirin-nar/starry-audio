using System.Collections.Generic;
using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    public interface ILinearPipelineBuilder : IService
    {
        ILinearPipeline Build(IPipelineSource soruceUnit, IList<IPipelineIntermediate> intermediatesUnit, IPipelineSink sinkUnit);
    }
}