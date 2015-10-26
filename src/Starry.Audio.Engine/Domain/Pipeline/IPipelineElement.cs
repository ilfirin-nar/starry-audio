using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineElement {}

    public interface IPipelineElement<TService> : IPipelineElement where TService : IService {}
}