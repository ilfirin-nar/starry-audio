using System.ComponentModel;

namespace Starry.Audio.Core.Services.Configuration.Exceptions
{
    public enum AudioConfigSetFailReason
    {
        [Description("Configuration is null")]
        IsNull,

        [Description("Channels count greater than maximum value")]
        ChannelsCounСontradictsСonstraints,

        [Description("Channel count cannot be less 2 channels in stereo mode")]
        ChannelsCountContradictsChannelsMode
    }
}