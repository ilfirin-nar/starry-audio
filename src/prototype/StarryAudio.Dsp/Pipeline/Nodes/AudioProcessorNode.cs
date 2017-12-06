 using System;
using StarryAudio.Dsp.SampleProcessing;
using StarryAudio.Dsp.Utils.NaudioExtensions;

namespace StarryAudio.Dsp.Pipeline.Nodes
{
    public class AudioProcessorNode<TSampleProcessor> : IAudioPipelineNode
        where TSampleProcessor : ISampleProcessor
    {
        public AudioProcessorNode(IAudioPipelineNode inNode, object settings)
        {
            var processor = (TSampleProcessor) Activator.CreateInstance(typeof(TSampleProcessor), settings);
            var standartSampleProvider = new StandartSampleProvider(inNode.AudioDataProvider, processor);
            AudioDataProvider = new AudioDataProvider(standartSampleProvider);
        }

        public AudioDataProvider AudioDataProvider { get; }
    }
}