using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineUnit : IPipelineElement {}

    public interface IPipelineUnit<TService> : IPipelineUnit where TService : IService {}
}