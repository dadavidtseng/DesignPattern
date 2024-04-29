namespace CommandPattern;

public class Invoker(ICommand onStart, ICommand onFinish)
{
    public void DoSomethingImportant()
    {
        Console.WriteLine("Invoker: Does anybody want something done before I begin?");
        onStart.Execute();
        
        Console.WriteLine("Invoker: ...doing something really important...");
        
        Console.WriteLine("Invoker: Does anybody want something done after I finish?");
        onFinish.Execute();
    }
}