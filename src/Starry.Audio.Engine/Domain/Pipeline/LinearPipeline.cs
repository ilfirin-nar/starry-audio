using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    internal class LinearPipeline : ILinearPipeline
    {
        public LinearPipeline()
        {
            Units = new HashSet<IPipelineUnit>();
        }

        public ISet<IPipelineUnit> Units { get; }
    }
}