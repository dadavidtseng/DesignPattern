namespace CommandPattern;

public class SimpleCommand(string payload) : ICommand
{
    public void Execute()
    {
        Console.WriteLine($"SimpleCommand: See, I can do simple things like printing ({payload})");
    }
}