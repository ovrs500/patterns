namespace Adapter
{
    public class Mp4Player : IAdvancedMediaPlayer
    {
        public string playMp4(string fileName)
        {
            return "Playing mp4 file.  Name: " + fileName;
        }

        public string playVlc(string fileName)
        {
            return "";            
        }
    }
}