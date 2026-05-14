namespace NewDotNet.Intermediate.Exercises;

public class Stack
{
    private readonly List<object> _list = new ();

    public void Push(object obj)
    {
        if (obj == null)
        {
            throw new InvalidOperationException("You can not add a null object to the stack.");
        }
        _list.Add(obj);
    }

    public object Pop()
    {
        if (_list.Count == 0)
        {
            throw new InvalidOperationException("There are no elements in the stack yet.");
        }

        var index = _list.Count - 1;
        object toReturn = _list[index];

        _list.RemoveAt(index);

        return toReturn;
    }
}