namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineConnectableFrom : IPipelineConnectable {}

    public interface IPipelineConnectableFrom<out TOutputConnector> : IPipelineConnectableFrom
        where TOutputConnector : IPipelineOutputConnector
    {
        TOutputConnector OutputConnector { get; }
    }
}