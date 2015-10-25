using Starry.Audio.Core.Enums.Configuration;
using Starry.Audio.Core.ModuleInterface.Interfaces;

namespace Starry.Audio.Core.Domain.Configurations
{
    internal class AudioConfiguration : IAudioConfiguration
    {
        public BitDepthMode BitDepthMode { get; set; } = BitDepthMode.Int32;

        public SampleRateMode SampleRateMode { get; set; } = SampleRateMode.AudioCd;

        public bool IsStereo { get; set; } = true;

        public byte ChannelsCount { get; set; } = 2;
    }
}