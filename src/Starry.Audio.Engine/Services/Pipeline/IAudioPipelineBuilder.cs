using System.Collections.Generic;
using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Infrastructure.Interfaces;

namespace Starry.Audio.Engine.Services.Pipeline
{
    public interface IAudioPipelineBuilder : IService
    {
        IPipeline Build(IList<IPipelineElement> elements);
    }
}