namespace ObserverPattern;

public class ConcreteObserverB : IObserver
{
    public void Update(ISubject subject)
    {
        if (subject.GetState() is 0 or >= 2) 
            Console.WriteLine("ConcreteObserverB: Reacted to the event.");
    }
}