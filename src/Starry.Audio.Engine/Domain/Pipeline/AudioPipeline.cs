using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    internal class AudioPipeline : IPipeline
    {
        public ISet<IPipelineSource> SourceElements { get; }

        public ISet<IPipelineSink> SinksElements { get; }
    }
}