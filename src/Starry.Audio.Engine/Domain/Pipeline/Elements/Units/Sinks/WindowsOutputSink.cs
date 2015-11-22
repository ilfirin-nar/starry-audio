using Starry.Audio.Engine.Domain.Pipeline.Elements.Connectors.Input;
using Starry.Audio.Io.Domain.Outputs;

namespace Starry.Audio.Engine.Domain.Pipeline.Elements.Units.Sinks
{
    internal class WindowsOutputSink : IWindowsOutputSink
    {
        private readonly IWindowsAudioOutput outputService;

        public WindowsOutputSink(
            IWindowsAudioOutput outputService,
            IStandartInputConnector connector)
        {
            InputConnector = connector;
            this.outputService = outputService;
        }

        public IStandartInputConnector InputConnector { get; }

        public IPipelineUnitState State { get; }
    }
}