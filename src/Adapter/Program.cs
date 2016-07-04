using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            var audioPlayer = new AudioPlayer();

            Console.WriteLine(audioPlayer.play("mp3", "beyond the horizon.mp3"));
            Console.WriteLine(audioPlayer.play("mp4", "alone.mp4"));
            Console.WriteLine(audioPlayer.play("vlc", "far far away.vlc"));
            Console.WriteLine(audioPlayer.play("avi", "mind me.avi"));
            Console.ReadLine();
        }
    }
}