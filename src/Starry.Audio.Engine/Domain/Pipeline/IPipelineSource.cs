using System.Collections.Generic;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineSource : IPipelineElement {}

    public interface IPipelineSource<TService> : IPipelineElement<TService>, IPipelineSource where TService : IService
    {
        IList<IPipelineOutputConnector> Outputs { get; }
    }
}