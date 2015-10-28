using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline.Elements.Connectors.Output
{
    internal class StandartOutputConnector : IStandartOutputConnector
    {
        public StandartOutputConnector()
        {
            Links = new HashSet<IPipelineInputConnector>();
        }

        public ISet<IPipelineInputConnector> Links { get; }
    }
}