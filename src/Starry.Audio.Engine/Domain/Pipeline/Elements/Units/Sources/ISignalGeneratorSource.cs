using Starry.Audio.Core.Services.SignalGenerators;
using Starry.Audio.Engine.Domain.Pipeline.Elements.Connectors.Output;

namespace Starry.Audio.Engine.Domain.Pipeline.Elements.Units.Sources
{
    public interface ISignalGeneratorSource : IPipelineSource<ISignalGenerator, IStandartOutputConnector> {}
}