namespace Intercepting;

public class TitledGreeterDecorator : IGreeter
{
    private readonly IGreeter _decorate;

    public TitledGreeterDecorator(IGreeter greeter)
        => _decorate = greeter;

    public string Greet(string name)
    {
        if (name == null)
            throw new ArgumentNullException("name");
        name = $"Mr. {name}";
        return _decorate.Greet(name);
    }
}
