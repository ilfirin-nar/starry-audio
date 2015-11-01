using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    internal class LinearPipeline : ILinearPipeline
    {
        public LinearPipeline(IEnumerable<IPipelineUnit> units)
        {
            Units = new HashSet<IPipelineUnit>(units);
        }

        public ISet<IPipelineUnit> Units { get; }
    }
}