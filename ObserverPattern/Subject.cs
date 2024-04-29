﻿namespace ObserverPattern;

public class Subject : ISubject
{
    private          int             State;
    private readonly List<IObserver> _observers = [];

    public void Attach(IObserver observer)
    {
        Console.WriteLine("Subject: Attached an observer.");
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
        Console.WriteLine("Subject: Detached an observer.");
    }

    public void Notify()
    {
        Console.WriteLine("Subject: Notifying observers...");

        foreach (var observer in _observers)
            observer.Update(this);
    }

    public int GetState() => State;

    public void SomeBusinessLogic()
    {
        Console.WriteLine("\nSubject: I'm doing something important.");

        State = new Random().Next(0, 10);

        Thread.Sleep(15);

        Console.WriteLine("Subject: My state has just changed to: " + State);

        Notify();
    }
}