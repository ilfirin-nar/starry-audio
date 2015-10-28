using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipeline
    {
        ISet<IPipelineSource> SourceElements { get; }

        ISet<IPipelineSink> SinksElements { get; }
    }
}