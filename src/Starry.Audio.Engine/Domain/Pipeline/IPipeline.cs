using System.Collections.Generic;
using Starry.Audio.Engine.Domain.Pipeline.Building;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipeline
    {
        IPipelineDesign Design { get; }

        IList<IPipelineSource> SourceElements { get; }

        IList<IPipelineIntermediate> IntermediateElements { get; }

        IList<IPipelineSink> SinksElements { get; }

        IList<IPipelineElementsBinding> ElementsBindings { get; }
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