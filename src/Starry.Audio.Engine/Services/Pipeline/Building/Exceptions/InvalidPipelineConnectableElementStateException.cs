using System;
using Starry.Audio.Engine.Domain.Pipeline;

namespace Starry.Audio.Engine.Services.Pipeline.Building.Exceptions
{
    public class InvalidPipelineConnectableElementStateException : Exception
    {
        private readonly string elementTypeName;

        public InvalidPipelineConnectableElementStateException(IPipelineConnectable connectableElement)
        {
            elementTypeName = connectableElement.GetType().FullName;
        }

        public override string Message => $"Invalid pipeline unit state: {elementTypeName}";
    }
}