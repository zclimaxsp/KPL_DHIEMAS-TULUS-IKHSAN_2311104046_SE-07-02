using System;

public class Observer : IObserver
{
    private string _name;

    public Observer(string name)
    {
        _name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"[{_name}] menerima update: {message}");
    }
}
