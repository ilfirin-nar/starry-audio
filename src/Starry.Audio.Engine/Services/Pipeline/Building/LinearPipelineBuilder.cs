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

        public ILinearPipeline Build(IPipelineSource soruceUnit, IList<IPipelineIntermediate> intermediatesUnit, IPipelineSink sinkUnit)
        {
            var unitsList = GetNewLinearPipeline(soruceUnit, intermediatesUnit, sinkUnit);
            linker.Link(unitsList);
            return new LinearPipeline(unitsList);
        }

        private static IList<IPipelineUnit> GetNewLinearPipeline(IPipelineUnit soruceUnit, IEnumerable<IPipelineIntermediate> intermediatesUnit, IPipelineUnit sinkUnit)
        {
            var result = new List<IPipelineUnit> { soruceUnit };
            result.AddRange(intermediatesUnit);
            result.Add(sinkUnit);
            return result;
        }
    }
}