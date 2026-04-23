namespace NewDotNet.Intermediate.Section1.Classes.accessmodifiers;

public class HttpCookie
{
    private readonly Dictionary<string, string> _dictionary = new();
    public DateTime Expiry { get; set; }

    public string this[string key]
    {
        get
        {
            return _dictionary[key];
        }
        set
        {
            _dictionary[key] = value;
        }
    }

}