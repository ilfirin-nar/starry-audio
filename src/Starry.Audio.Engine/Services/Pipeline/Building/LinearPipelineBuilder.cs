using System.Collections.Generic;
using Starry.Audio.Engine.Domain.Pipeline;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    internal class LinearPipelineBuilder : ILinearPipelineBuilder
    {
        private readonly IPipelineUnitsLinker linker;

        public LinearPipelineBuilder(IPipelineUnitsLinker linker)
        {
            this.linker = linker;
        }

        public ILinearPipeline Build(IPipelineSource soruceUnits, IList<IPipelineIntermediate> intermediatesUnits, IPipelineSink sinkUnits)
        {
            var result = new LinearPipeline();
            foreach (var unit in intermediatesUnits)
            {
                linker.Link(unit, unit[]);
            }
            return result;
        }
    }
}