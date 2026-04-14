namespace NewDotNet.Fundamentals.DateTimeLearning;

public class Dates
{
    public void Run()
    {
        var dateTime = new DateTime(2015, 1, 1);
        var now = DateTime.Now;
        var today = DateTime.Today;

        Console.WriteLine(now.Hour);
        Console.WriteLine(now.Minute);
        Console.WriteLine(now.Second);
        
        var tomorrow = now.AddDays(1);
        var yesterday = now.AddDays(-1);
        Console.WriteLine(yesterday);
        Console.WriteLine(tomorrow);

        Console.WriteLine(now.ToLongDateString());
        Console.WriteLine(now.ToShortDateString());
        Console.WriteLine(now.ToLongTimeString());
        Console.WriteLine(now.ToShortTimeString());
        Console.WriteLine(now.ToString("U"));
        
        // Timespan -- length of time
        var timeSpan = new TimeSpan(1, 2, 3);
        var timeSpan2 = new TimeSpan(1, 0, 0);
        Console.WriteLine(timeSpan);
        Console.WriteLine(timeSpan2);
        var timeSpan3 = TimeSpan.FromHours(1);
        Console.WriteLine(timeSpan3);

        var start = DateTime.Now;
        var end = DateTime.Now.AddMinutes(5);
        var duration = end - start;
        Console.WriteLine("Duration:{0}", duration);

        // Properties
        Console.WriteLine("Minutes: {0}", timeSpan.Minutes);
        Console.WriteLine("Total Minutes: {0}", timeSpan.TotalMinutes);
        
        
        // Add
        Console.WriteLine("Add example: " + timeSpan.Add(TimeSpan.FromMinutes(8)));
        Console.WriteLine("Add example: " + timeSpan.Subtract(TimeSpan.FromMinutes(8)));
        
        // ToString
        Console.WriteLine("ToString:" + timeSpan);
        
        // Parse -- convert string to timespan
        Console.WriteLine("Parse: " + TimeSpan.Parse("01:02:03"));
    }
}