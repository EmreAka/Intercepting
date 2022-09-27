using Intercepting;

IGreeter greeter = new NiceToMeetYouGreeterDecorator(new TitledGreeterDecorator(new FormalGreeter()));

var result = greeter.Greet("Emre Aka");
Console.WriteLine(result);