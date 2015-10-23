using System;
using Starry.Common.Extensions;

namespace Starry.Audio.Core.Services.Configuration.Exceptions
{
    public class InvalidAudioConfigurationException : Exception
    {
        private readonly string failReasonDescription;

        public InvalidAudioConfigurationException(AudioConfigSetFailReason failReason)
        {
            failReasonDescription = failReason.GetDescription();
        }

        public override string Message => $"Invalid audio configuration: {failReasonDescription}";
    }
}