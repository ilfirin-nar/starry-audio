using System.Collections.Generic;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineIntermediate : IPipelineElement {}

    public interface IPipelineIntermediate<TService> : IPipelineElement<TService>, IPipelineIntermediate where TService : IService
    {
        IPipelineInputConnector Input { get; }

        IPipelineOutputConnector Output { get; }
    }
}