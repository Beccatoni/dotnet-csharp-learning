namespace NewDotNet.Intermediate.Section2.Extensibility;

public class DbMigrator2
{
    private readonly ILogger _logger;

    public DbMigrator2(ILogger logger)
    {
        _logger = logger;
    }
    public void Migrate()
    {
        _logger.LogInfo("Migration started at {0}" + DateTime.Now);
        // Details of migrating the database
        _logger.LogInfo("Migration finished at {0}" + DateTime.Now);
    }
}

public interface ILogger
{
    void LogError(string message);
    void LogInfo(string message);
}

public class ConsoleLogger : ILogger
{
    public void LogError(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
    }

    public void LogInfo(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
    }
}

public class FileLogger : ILogger
{
    private readonly string _path;

    public FileLogger(string path)
    {
        _path = path;
    }
    public void LogError(string message)
    {
        Log(message, "Error");
    }

    public void LogInfo(string message)
    {
      Log(message, "Info");
    }

    private void Log(string message, string messageType)
    {
        var streamWriter = new StreamWriter(_path, true);
        streamWriter.WriteLine(messageType, message);
    }
}