namespace Events_Example_2;

public abstract class MessagingService
{
    protected virtual string Message => "Default";

    public void VideoEncodedMessage(object? sender, EventArgs e)
    {
        Console.WriteLine($"Sending {Message} message.");
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