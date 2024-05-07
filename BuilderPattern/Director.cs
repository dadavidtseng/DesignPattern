namespace BuilderPattern;

public class Director
{
    private IBuilder builder = null!;

    public void SetBuilder(IBuilder builder)
    {
        this.builder = builder;
    }

    public void BuildMinimalViableProduct()
    {
        builder.BuildPartA();
    }

    public void BuildFullFeaturedProduct()
    {
        builder.BuildPartA();
        builder.BuildPartB();
        builder.BuildPartC();
    }
}