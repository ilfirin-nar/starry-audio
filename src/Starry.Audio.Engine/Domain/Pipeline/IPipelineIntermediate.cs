using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineIntermediate : IPipelineUnit, IPipelineConnectableFrom, IPipelineConnectableTo {}

    public interface IPipelineIntermediate<TService, out TInputConnector, out TOutputConnector>
        : IPipelineIntermediate, IPipelineUnit<TService>, IPipelineConnectableFrom<TOutputConnector>, IPipelineConnectableTo<TInputConnector>
        where TService : IService
        where TInputConnector : IPipelineInputConnector
        where TOutputConnector : IPipelineOutputConnector {}
}