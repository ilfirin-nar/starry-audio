using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline.Building
{
    internal class PipelineDesign : IPipelineDesign
    {
        public PipelineDesign(IPipelineSource sourceElement)
        {
            Source = sourceElement;
            Bindings = new List<IPipelineElementsBinding>();
        }

        public IPipelineSource Source { get; }

        public IList<IPipelineElementsBinding> Bindings { get; }
    }
}