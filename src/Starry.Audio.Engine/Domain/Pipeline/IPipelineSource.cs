using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineSource : IPipelineUnit, IPipelineConnectableFrom {}

    public interface IPipelineSource<TService, out TOutputConnector> : IPipelineSource, IPipelineUnit<TService>, IPipelineConnectableFrom<TOutputConnector>
        where TService : IService
        where TOutputConnector : IPipelineOutputConnector {}
}