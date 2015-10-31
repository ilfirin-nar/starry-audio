using System;
using Starry.Audio.Engine.Domain.Pipeline;

namespace Starry.Audio.Engine.Services.Pipeline.Building.Exceptions
{
    public class InvalidPipelineConnectableElementTypeException : Exception
    {
        private readonly string elementTypeName;

        public InvalidPipelineConnectableElementTypeException(IPipelineUnit connectableElement)
        {
            elementTypeName = connectableElement.GetType().FullName;
        }

        public override string Message => $"Invalid pipeline unit type: {elementTypeName}";
    }
}