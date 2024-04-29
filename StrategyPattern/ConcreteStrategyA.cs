namespace StrategyPattern;

public class ConcreteStrategyA : IStrategy
{
    public IEnumerable<string> DoAlgorithm(object data)
    {
        var list = data as List<string>;
        
        list.Sort();

        return list;
    }
}