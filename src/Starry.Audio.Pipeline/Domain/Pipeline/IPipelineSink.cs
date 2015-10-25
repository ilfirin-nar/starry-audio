using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineSink<TService> : IPipelineElement<TService> where TService : IService
    {
        IList<IPipelineInputConnector> Inputs { get; }
    }
}