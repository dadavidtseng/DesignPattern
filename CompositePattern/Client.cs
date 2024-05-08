namespace CompositePattern;

public static class Client
{
    public static void ClientCode(Component leaf)
    {
        Console.WriteLine($"RESULT: {leaf.Operation()}\n");
    }

    public static void ClientCode2(Component component1, Component component2)
    {
        if (component1.IsComposite())
            component1.Add(component2);

        Console.WriteLine($"RESULT: {component1.Operation()}");
    }
}