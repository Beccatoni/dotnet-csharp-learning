namespace NewDotNet.Intermediate.Section1.Classes.accessmodifiers;

public class StopWatch
{
    private DateTime StartTime { get; set; }
    private DateTime EndTime { get; set; }
    public TimeSpan Duration { get; set; }
    
    public void Start()
    {
        StartTime = DateTime.Now;
    }

    public TimeSpan Stop()
    {
        if(StartTime == DateTime.MinValue)
            throw new InvalidOperationException("You must start the stopwatch before you can stop it.");
        EndTime = DateTime.Now;
        Duration = EndTime - StartTime;
        
        return Duration;
    }
}