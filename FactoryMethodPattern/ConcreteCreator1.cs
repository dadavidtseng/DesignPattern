namespace FactoryMethodPattern;

public class ConcreteCreator1 : Creator
{
    protected override IProduct FactoryMethod() => new ConcreteProduct1();
}