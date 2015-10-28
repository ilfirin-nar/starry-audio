using Starry.Audio.Engine.Domain.Pipeline.Elements.Connectors.Input;
using Starry.Audio.Io.Domain.Outputs;

namespace Starry.Audio.Engine.Domain.Pipeline.Elements.Units.Sinks
{
    public interface IWindowsOutputSink : IPipelineSink<IWindowsAudioOutput, IStandartInputConnector> {}
}