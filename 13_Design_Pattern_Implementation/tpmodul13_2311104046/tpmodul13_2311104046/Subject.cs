using System.Collections.Generic;

public class Subject : ISubject
{
    private List<IObserver> _observers = new List<IObserver>();
    private string _message;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(_message);
        }
    }

    public void CreateMessage(string message)
    {
        _message = message;
        Notify();
    }
}
