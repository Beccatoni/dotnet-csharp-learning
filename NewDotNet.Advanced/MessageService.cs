public class MessageService
{
    public void OnVideoEncoded(object source, EventArgs eventArgs)
    {
        Console.WriteLine("MessageService: Sending a text message...");
    }
}