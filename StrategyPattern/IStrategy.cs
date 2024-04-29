namespace StrategyPattern;

public interface IStrategy
{
    IEnumerable<string> DoAlgorithm(object data);
}