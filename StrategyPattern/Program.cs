namespace StrategyPattern;

public static class Program
{
    private static void Main()
    {
        var context = new Context();
            
        Console.WriteLine("Client: StrategyPattern is set to normal sorting.");
        context.SetStrategy(new ConcreteStrategyA());
        context.DoSomeBusinessLogic();
            
        Console.WriteLine();
            
        Console.WriteLine("Client: StrategyPattern is set to reverse sorting.");
        context.SetStrategy(new ConcreteStrategyB());
        context.DoSomeBusinessLogic();
    }
}