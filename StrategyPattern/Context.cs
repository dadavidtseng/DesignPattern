namespace StrategyPattern;

public class Context
{
    private IStrategy _strategy;

    public void SetStrategy(IStrategy strategy)
    {
        _strategy = strategy;
    }
        
    public void DoSomeBusinessLogic()
    {
        Console.WriteLine("Context: Sorting data using the strategy (not sure how it'll do it)");
            
        var result = _strategy.DoAlgorithm(new List<string> { "a", "b", "c", "d", "e" });

        var resultStr = result.Aggregate(string.Empty, (current, element) => current + (element + ","));

        Console.WriteLine(resultStr);
    }
}