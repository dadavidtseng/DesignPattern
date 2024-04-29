namespace CommandPattern;

public class ComplexCommand(Receiver receiver, string a, string b) : ICommand
{
    public void Execute()
    {
        Console.WriteLine("ComplexCommand: Complex stuff should be done by a receiver object.");
        receiver.DoSomething(a);
        receiver.DoSomethingElse(b);
    }
}