using System.Collections.Generic;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineIntermediate : IPipelineElement {}

    public interface IPipelineIntermediate<TService> : IPipelineElement<TService>, IPipelineIntermediate where TService : IService
    {
        IList<IPipelineInputConnector> Inputs { get; }

        IList<IPipelineOutputConnector> Outputs { get; }
    }
}