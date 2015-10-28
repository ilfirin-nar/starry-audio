namespace Starry.Audio.Engine.Domain.Pipeline
{
    public interface IPipelineConnectableTo : IPipelineConnectable {}

    public interface IPipelineConnectableTo<out TInputConnector> : IPipelineConnectableTo
        where TInputConnector : IPipelineInputConnector
    {
        TInputConnector InputConnector { get; }
    }
}