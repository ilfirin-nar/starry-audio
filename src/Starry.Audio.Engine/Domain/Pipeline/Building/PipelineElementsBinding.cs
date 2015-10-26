namespace Starry.Audio.Engine.Domain.Pipeline.Building
{
    internal class PipelineElementsBinding : IPipelineElementsBinding
    {
        public PipelineElementsBinding(IPipelineElement source, IPipelineElement target)
        {
            Source = source;
            Target = target;
        }

        public IPipelineElement Source { get; }

        public IPipelineElement Target { get; }
    }
}