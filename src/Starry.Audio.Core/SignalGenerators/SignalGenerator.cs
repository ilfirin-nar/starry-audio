using Starry.Audio.Core.Enums;
using Starry.Audio.Core.Intefaces;

namespace Starry.Audio.Core.SignalGenerators
{
    public class SignalGenerator : ISignalGenerator
    {
        private SignalType signalType;

        public SignalGenerator()
        {
            signalType = SignalType.Sin;
        }

        public SignalType SignalType
        {
            get
            {
                return signalType;
            }

            set
            {
                signalType = value;
            }
        }

        public ISignal Generate()
        {
            throw new System.NotImplementedException();
        }
    }
}