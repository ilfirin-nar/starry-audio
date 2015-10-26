namespace Starry.Audio.Engine.Domain.Pipeline.Building
{
    public interface IPipelineElementsBinding
    {
        IPipelineElement Source { get; }

        IPipelineElement Target { get; }
    }
}