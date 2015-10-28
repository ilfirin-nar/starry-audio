using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineSink : IPipelineUnit, IPipelineConnectableTo {}

    public interface IPipelineSink<TService, out TInputConnector> : IPipelineSink, IPipelineUnit<TService>, IPipelineConnectableTo<TInputConnector>
        where TService : IService
        where TInputConnector : IPipelineInputConnector {} 
}