
namespace NAudio
{
    internal class Wave
    {
        internal class WaveOutEvent
        {
            internal void Init(object audio)
            {
                throw new NotImplementedException();
            }

            internal void Play()
            {
                throw new NotImplementedException();
            }
        }

        internal class AudioFileReader
        {
            private string filePath;

            public AudioFileReader(string filePath)
            {
                this.filePath = filePath;
            }
        }
    }
}