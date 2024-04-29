namespace StrategyPattern;

public class ConcreteStrategyB : IStrategy
{
    public IEnumerable<string> DoAlgorithm(object data)
    {
        var list = data as List<string>;
        
        list.Sort();
        list.Reverse();

        return list;
    }
}