namespace NewDotNet.AdvancedC.EventsAndDelegates
{
    public class VideoEncoder
    {
        // 1 - Define a delegate
        // 2 - Define an event based on that delegate
        // 3 - Raise the event
        public delegate void VideoEncoderEventHandler(object source, EventArgs e);
        public event VideoEncoderEventHandler? VideoEncoded;
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}