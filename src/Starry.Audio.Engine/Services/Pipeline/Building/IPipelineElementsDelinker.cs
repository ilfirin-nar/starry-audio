using Starry.Audio.Engine.Domain.Pipeline.Building;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    public interface IPipelineElementsDelinker
    {
        void Delink(IPipelineElementsBinding binding);
    }
}