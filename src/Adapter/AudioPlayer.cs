namespace Adapter
{
    public class AudioPlayer : IMediaPlayer
    {
        MediaAdapter mediaAdapter;

        public string play(
            string audioType,
            string fileName)
        {
            if (audioType.ToLower() == "mp3")
            {
                return "Playing mp3 file.  Name: " + fileName;
            }
            else if (audioType.ToLower() == "vlc" || audioType.ToLower() == "mp4")
            {
                mediaAdapter = new MediaAdapter(audioType);

                return mediaAdapter.play(audioType, fileName);
            }
            else
            {
                return "Invalid media. " + audioType + " format not supported";
            }
        }
    }
}