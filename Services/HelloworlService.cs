public class HelloWorldService : IHelloWorldService
{
    public string GetHelloWorld(){
        return "Hello Word!";
    }
}

public interface IHelloWorldService
{
    string GetHelloWorld();
}

