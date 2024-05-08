namespace CompositePattern;

public static class Program
{
    private static void Main()
    {
        var leaf = new Leaf();

        Console.WriteLine("Client: I get a simple component:");
        Client.ClientCode(leaf);

        var tree    = new Composite();
        var branch1 = new Composite();

        branch1.Add(new Leaf());
        branch1.Add(new Leaf());

        var branch2 = new Composite();

        branch2.Add(new Leaf());
        tree.Add(branch1);
        tree.Add(branch2);

        Console.WriteLine("Client: Now I've got a composite tree:");
        Client.ClientCode(tree);

        Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
        Client.ClientCode2(tree, leaf);
    }
}