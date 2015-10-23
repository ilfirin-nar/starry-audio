using Starry.Audio.Core.Interfaces;
using Starry.Audio.Core.Services.Configuration.Exceptions;

namespace Starry.Audio.Core.Services.Configuration
{
    internal class AudioConfigurationChecker : IAudioConfigurationChecker
    {
        // TODO: Magic constants to another file
        private const uint MaxChannelsCount = 2;

        public void Check(IAudioConfiguration configuration)
        {
            if (configuration == null)
            {
                throw new InvalidAudioConfigurationException(AudioConfigSetFailReason.IsNull);
            }
            if (configuration.ChannelsCount > MaxChannelsCount)
            {
                throw new InvalidAudioConfigurationException(AudioConfigSetFailReason.ChannelsCounСontradictsСonstraints);
            }
            if (configuration.IsStereo && configuration.ChannelsCount < MaxChannelsCount)
            {
                throw new InvalidAudioConfigurationException(AudioConfigSetFailReason.ChannelsCountContradictsChannelsMode);
            }
        }
    }
}