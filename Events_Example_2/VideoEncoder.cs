namespace Events_Example_2;

public sealed class VideoEncoder
{
    public event EventHandler<VideoEventArgs>? VideoEncoded;
    public event EventHandler? VideoEncodedSimple;

    public void Encode(Video video)
    {
        Console.WriteLine("Video being encoded...");
        Thread.Sleep(1000);
        OnVideoEncoded(video);
    }

    private void OnVideoEncoded(Video video)
    {
        VideoEncoded?.Invoke(this, new VideoEventArgs { Video = video });
        VideoEncodedSimple?.Invoke(this, EventArgs.Empty);
    }
}

public class VideoEventArgs : EventArgs
{
    public Video? Video { get; set; }
}