namespace NewDotNet.Intermediate.Section2.Extensibility;

public interface INotificationChannel
{
    void Send(Message message);
}
public class VideoEncoder
{
    private readonly IList<INotificationChannel> _notificationChannels;

    public VideoEncoder()
    {
        _notificationChannels = new List<INotificationChannel>();
    }

    public void Encode(Video video)
    {
        // Video encoding logic
        // ...
        foreach (var channel in _notificationChannels)
        {
            channel.Send(new Message());
        }    
    }
    
    public void RegisterNotificationChannel(INotificationChannel channel)
    {
        _notificationChannels.Add(channel);
    }
}

public class MailService
{
    public void Send(Mail mail)
    {
        Console.WriteLine("Sending email...");
    }
}

public class Mail
{
    // Mail properties and methods
}

public class Video
{
// Video properties and methods
}

public class MailNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending email notification...");
    }
}

public class SmsNotificationChannel : INotificationChannel
{
    public void Send(Message message)
    {
        Console.WriteLine("Sending SMS notification...");
    }
}

public class Message
{
    
}