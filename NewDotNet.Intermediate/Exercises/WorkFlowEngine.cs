namespace NewDotNet.Intermediate.Exercises;

public interface ITask
{
    void Execute();
}

public interface IWorkFlow
{
void Add(ITask task);
void Remove(ITask task);
IEnumerable<ITask> GetTasks();
}

public class WorkFlow : IWorkFlow
{
    private readonly List<ITask> _tasks;

    public WorkFlow()
    {
        _tasks = new List<ITask>();
    }
    public void Add(ITask task)
    { 
        _tasks.Add(task);
    }

    public void Remove(ITask task)
    {
        _tasks.Remove(task);
        
    }

    public IEnumerable<ITask> GetTasks()
    {
        return _tasks;
    }
}

public class WorkFlowEngine 
{
    public void Run(IWorkFlow  workFlow)
    {
        foreach (var I in workFlow.GetTasks())
        {
            I.Execute();
        }
    }
}

class VideoUploader : ITask
{
    public void Execute()
    {
        Console.WriteLine("Uploading a video!");
    }
}

class CallWebService : ITask
{
    public void Execute()
    {
        Console.WriteLine("Calling a web service!");
    }
}


class ChangeStatus : ITask
{
    public void Execute()
    {
        Console.WriteLine("Status is changed!");
    }
}


class SendEmail : ITask
{
    public void Execute()
    {
        Console.WriteLine("Sending an email!");
    }
}