using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipeline
    {
        IList<IPipelineElement> Elements { get; }
    }
}