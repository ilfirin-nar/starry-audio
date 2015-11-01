using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineUnit : IPipelineElement
    {
        IPipelineUnitState State { get; }
    }

    public interface IPipelineUnit<TService> : IPipelineUnit where TService : IService {}
}