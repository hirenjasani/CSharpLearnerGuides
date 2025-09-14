using System;

namespace SingletonPattern.SingletonPattern;

public interface ILogger
{
    void Log(string msg);
}

public class DependencyInjectionSingletonPattern : ILogger
{
    private static int _counter = 0;
    public int Id { get; }

    public DependencyInjectionSingletonPattern()
    {
        Id = Interlocked.Increment(ref _counter);
        Console.WriteLine($"[DI] Instance created with Id = {Id}");
    }

    public void Log(string msg) => Console.WriteLine($"[DI {Id}] {msg}");
}
