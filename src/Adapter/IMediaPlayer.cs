namespace Adapter
{
    public interface IMediaPlayer
    {
        string play(
            string audioType,
            string fileName);
    }
}