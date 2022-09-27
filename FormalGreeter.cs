namespace Intercepting;

public class FormalGreeter : IGreeter
{
    public string Greet(string name)
    {
        return $"Hello, {name}.";
    }
}
