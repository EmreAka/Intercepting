namespace Intercepting;

public class NiceToMeetYouGreeterDecorator: IGreeter
{
    private readonly IGreeter decorator;
	public NiceToMeetYouGreeterDecorator(IGreeter greeter)
		=> this.decorator = greeter;

	public string Greet(string name)
	{
		var result = decorator.Greet(name);
		return $"{result} Nice to meet you!";
	}
}
