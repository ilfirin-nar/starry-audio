using System.Collections.Generic;
using System.Linq;
using StarryAudio.Dsp.Pipeline.Nodes;
using StarryAudio.Dsp.Pipeline.Nodes.Io;
using StarryAudio.Dsp.SampleProcessing;

namespace StarryAudio.Dsp.Pipeline
{
    public class AudioPipeline
    {
        private readonly IList<IAudioPipelineNode> _nodes;
        private readonly int _latency;
        private readonly IAudioIn _input;
        private IAudioOut _output;

        public AudioPipeline(int inputDevice, int latency)
        {
            _input = new DeviceAudioIn(inputDevice);
            _latency = latency;
            _nodes = new List<IAudioPipelineNode>();
        }

        private IAudioPipelineNode LastNode => _nodes.LastOrDefault() ?? _input;

        public AudioPipeline Processor<T>(object settings = null)
            where T : ISampleProcessor
        {
            var sampleProcessor = new AudioProcessorNode<T>(LastNode, settings);
            _nodes.Add(sampleProcessor);
            return this;
        }

        public AudioPipeline Output()
        {
            _output = new DeviceAudioOut(LastNode, _latency);
            return this;
        }

        public void Activate()
        {
            _input.Activate();
            _output.Activate();
        }

        public void Deactivate()
        {
            _input.Deactivate();
            _output.Deactivate();
        }
    }
}