using System;

namespace Adapter
{
    public class VlcPlayer : IAdvancedMediaPlayer
    {
        public string playMp4(string fileName)
        {
            return "";
        }

        public string playVlc(string fileName)
        {
            return "Playing vlc file.  Name: " + fileName;
        }
    }
}