using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineSource<TService> : IPipelineElement<TService> where TService : IService
    {
        IList<IPipelineOutputConnector> Outputs { get; }
    }
}