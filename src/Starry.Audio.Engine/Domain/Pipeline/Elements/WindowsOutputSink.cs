using System.Collections.Generic;
using Starry.Audio.Io.Domain.Outputs;

namespace Starry.Audio.Engine.Domain.Pipeline.Elements
{
    internal class WindowsOutputSink : IWindowsOutputSink
    {
        private readonly IWindowsAudioOutput output;

        public WindowsOutputSink(IWindowsAudioOutput output)
        {
            this.output = output;
        }

        public IList<IPipelineInputConnector> Inputs { get; }
    }
}