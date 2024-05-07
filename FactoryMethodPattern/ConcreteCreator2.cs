namespace FactoryMethodPattern;

public class ConcreteCreator2 : Creator
{
    protected override IProduct FactoryMethod() => new ConcreteProduct2();
}