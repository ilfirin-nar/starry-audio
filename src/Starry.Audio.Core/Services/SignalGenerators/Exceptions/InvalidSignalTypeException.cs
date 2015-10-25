using System;
using Starry.Audio.Core.Enums;

namespace Starry.Audio.Core.Services.SignalGenerators.Exceptions
{
    public class InvalidSignalTypeException : Exception
    {
        private readonly int signalType;

        public InvalidSignalTypeException(SignalType signalType)
        {
            this.signalType = (int) signalType;
        }

        public override string Message => $"Invalid signal type: {signalType}";
    }
}