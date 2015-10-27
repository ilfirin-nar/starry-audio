using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineOutputConnector : IPipelineConnector
    {
        ISet<IPipelineInputConnector> Links { get; }
    }
}