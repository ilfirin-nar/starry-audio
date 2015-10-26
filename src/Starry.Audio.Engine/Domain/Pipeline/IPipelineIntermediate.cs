using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineIntermediate<TService> : IPipelineElement<TService> where TService : IService
    {
        IList<IPipelineInputConnector> Inputs { get; }

        IList<IPipelineOutputConnector> Outputs { get; }
    }
}