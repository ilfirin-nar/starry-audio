using Starry.Audio.Core.Domain.Configurations;

namespace Starry.Audio.Core.Services.Configuration
{
    internal class AudioConfigurator : IAudioConfigurator
    {
        private IAudioConfiguration currentConfiguration;
        private readonly IAudioConfigurationChecker checker;

        public AudioConfigurator(
            ICurrentAudioConfiguration currentConfiguration,
            IAudioConfigurationChecker checker)
        {
            this.currentConfiguration = currentConfiguration;
            this.checker = checker;
        }

        public void SetConfiguation(IAudioConfiguration configuration)
        {
            checker.Check(configuration);
            currentConfiguration = configuration;
        }
    }
}