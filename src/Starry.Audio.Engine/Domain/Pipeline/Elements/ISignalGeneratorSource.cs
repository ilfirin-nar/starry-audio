using Starry.Audio.Core.Services.SignalGenerators;

namespace Starry.Audio.Engine.Domain.Pipeline.Elements
{
    public interface ISignalGeneratorSource : IPipelineSource<ISignalGenerator> {}
}