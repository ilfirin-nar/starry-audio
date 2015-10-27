using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineInputConnector : IPipelineConnector
    {
        ISet<IPipelineOutputConnector> Links { get; }
    }
}