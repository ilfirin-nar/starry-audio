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
    }
}