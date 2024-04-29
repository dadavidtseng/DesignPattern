namespace ObserverPattern;

public class ConcreteObserverA : IObserver
{
    public void Update(ISubject subject)
    {            
        if (subject.GetState() < 3) 
            Console.WriteLine("ConcreteObserverA: Reacted to the event.");
    }
}