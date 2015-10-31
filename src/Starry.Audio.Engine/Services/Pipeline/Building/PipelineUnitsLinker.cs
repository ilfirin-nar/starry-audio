using System.Collections.Generic;
using Starry.Audio.Engine.Domain.Pipeline;
using Starry.Audio.Engine.Services.Pipeline.Building.Exceptions;

namespace Starry.Audio.Engine.Services.Pipeline.Building
{
    internal class PipelineUnitsLinker : IPipelineUnitsLinker
    {
        public void Link(IPipelineConnectableFrom<IPipelineOutputConnector> source, IPipelineConnectableTo<IPipelineInputConnector> target)
        {
            if (source == null || source.OutputConnector == null)
            {
                throw new InvalidPipelineConnectableElementStateException(source);
            }
            if (target == null || target.InputConnector == null)
            {
                throw new InvalidPipelineConnectableElementStateException(target);
            }
            source.OutputConnector.Links.Add(target.InputConnector);
        }

        public void Link(IPipelineUnit source, IPipelineUnit target)
        {
            var connectableFrom = source as IPipelineConnectableFrom<IPipelineOutputConnector>;
            var connectableTo = source as IPipelineConnectableTo<IPipelineInputConnector>;
            if (connectableFrom == null)
            {
                throw new InvalidPipelineConnectableElementTypeException(source);
            }
            if (connectableTo == null)
            {
                throw new InvalidPipelineConnectableElementTypeException(target);
            }
            Link(connectableFrom, connectableTo);
        }

        public void Link(IList<IPipelineUnit> units)
        {
            for (var index = 0; index < units.Count - 1; index++)
            {
                Link(units[index], units[index + 1]);
            }
        }
    }
}