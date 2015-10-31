namespace Starry.External.Interfaces.Audio.WaveGenerators
{
    public interface ISinWave32Generator
    {
        int Read(float[] buffer, int offset, int sampleCount);
    }
}
