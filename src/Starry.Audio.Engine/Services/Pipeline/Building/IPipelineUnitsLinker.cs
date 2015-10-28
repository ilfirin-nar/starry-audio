using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    public interface IPipelineUnitsLinker : IService
    {
        void Link(IPipelineConnectableFrom<IPipelineOutputConnector> source, IPipelineConnectableTo<IPipelineInputConnector> target);
    }
}