using Starry.Audio.Engine.Domain.Pipeline.Building;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipeline
    {
        IPipelineDesign Design { get; }
    }

    internal class AudioPipeline : IPipeline
    {
        public AudioPipeline(IPipelineDesign design)
        {
            Design = design;
        }

        public IPipelineDesign Design { get; }
    }
}