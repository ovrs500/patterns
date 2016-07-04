using System;

namespace Adapter
{
    public class MediaAdapter : IMediaPlayer
    {
        IAdvancedMediaPlayer _advancedMediaPlayer;

        public MediaAdapter(
            string audioType)
        {
            if (audioType.ToLower() == "vlc")
            {
                _advancedMediaPlayer = new VlcPlayer();
            }
            else if (audioType.ToLower() == "mp4")
            {
                _advancedMediaPlayer = new Mp4Player();
            }
        }

        public string play(
            string audioType,
            string fileName)
        {
            if (audioType.ToLower() == "vlc")
            {
                return _advancedMediaPlayer.playVlc(fileName);
            }
            else if (audioType.ToLower() == "mp4")
            {
                return _advancedMediaPlayer.playMp4(fileName);
            }

            return "";
        }
    }
}