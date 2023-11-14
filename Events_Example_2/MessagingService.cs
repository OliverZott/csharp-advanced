namespace Events_Example_2;

public abstract class MessagingService
{
    protected virtual string Message => "Default";

    public void VideoEncodedMessage(object? sender, EventArgs e)
    {
        if (e is VideoEventArgs args)
        {
            var video = args.Video;
            Console.WriteLine($"Sending {Message} message, after encoding {video}");
        }
        else
        {
            Console.WriteLine($"Sending {Message} message, after encoding");
        }
    }
}


public class SmsMessage : MessagingService
{
    protected override string Message => "SMS";
}

public class MailMessage : MessagingService
{
    protected override string Message => "E-Mail";
}

public class SimpleMessage : MessagingService
{
    protected override string Message => "Simple";
}