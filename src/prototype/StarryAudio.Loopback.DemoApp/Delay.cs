using System.Collections.Generic;

namespace StarryAudio.Loopback.DemoApp
{
    public class Delay : IEffect
    {
        private readonly IList<Queue<float>> _samplesQueues;

        public Delay(int echoLength = 200000, float echoFactor = 0.5f, int count = 2)
        {
            EchoLength = echoLength;
            EchoFactor = echoFactor;

            _samplesQueues = new List<Queue<float>>();
            for (var i = 0; i < count; i++)
            {
                var queue = new Queue<float>();
                for (var j = 0; j < echoLength; j++)
                {
                    queue.Enqueue(0f);
                }
                _samplesQueues.Add(queue);
            }
        }

        public int EchoLength { get; }

        public float EchoFactor { get; }

        public float ApplyEffect(float sample)
        {
            var result = 0f;
            foreach (var queue in _samplesQueues)
            {
                queue.Enqueue(sample);
                result += sample + EchoFactor * queue.Dequeue();
            }
            return result;
        }
    }
}