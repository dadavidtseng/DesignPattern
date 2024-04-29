namespace CommandPattern
{
    public static class Program
    {
        private static void Main()
        {
            var receiver = new Receiver();

            var simpleCommand  = new SimpleCommand("Say Hi!");
            var complexCommand = new ComplexCommand(receiver, "Send email", "Save report");

            var invoker = new Invoker(simpleCommand, complexCommand);

            invoker.DoSomethingImportant();
        }
    }
}