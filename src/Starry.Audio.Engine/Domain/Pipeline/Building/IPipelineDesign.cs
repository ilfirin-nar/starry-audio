using System.Collections.Generic;

namespace Starry.Audio.Engine.Domain.Pipeline.Building
{
    public interface IPipelineDesign
    {
        IPipelineSource Source { get; }

        IList<IPipelineElementsBinding> Bindings { get; }
    }
}