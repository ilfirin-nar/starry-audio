using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineSink : IPipelineElement {}

    public interface IPipelineSink<TService> : IPipelineElement<TService>, IPipelineSink where TService : IService
    {
        IPipelineInputConnector Inputs { get; }
    }
}