namespace AdapterPattern;

public class Adapter(Adaptee adaptee) : ITarget
{
    public string GetRequest() => $"This is '{Adaptee.GetSpecificRequest()}'";
}