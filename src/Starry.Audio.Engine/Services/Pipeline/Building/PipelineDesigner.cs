using System.Linq;
using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Audio.Engine.Domain.Pipeline.Building;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    internal class PipelineDesigner : IPipelineDesigner
    {
        private readonly IPipelineElementsBinder binder;

        public PipelineDesigner(IPipelineElementsBinder binder)
        {
            this.binder = binder;
        }

        public IPipelineDesign BeginWith(IPipelineSource sourceElement)
        {
            return new PipelineDesign(sourceElement);
        }

        public IPipelineDesign Append(IPipelineDesign pipelineDesign, IPipelineIntermediate intermediateElement)
        {
            var binding = binder.Bind(pipelineDesign.Bindings.Any()
                ? pipelineDesign.Bindings.Last().Target
                : pipelineDesign.Source, intermediateElement);
            pipelineDesign.Bindings.Add(binding);
            return pipelineDesign;
        }

        public IPipelineDesign Append(IPipelineDesign pipelineDesign, IPipelineSink sinkElement)
        {
            return pipelineDesign;
        }
    }
}