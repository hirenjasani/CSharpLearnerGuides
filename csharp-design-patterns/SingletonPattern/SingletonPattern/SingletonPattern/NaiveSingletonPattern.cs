using System;

namespace SingletonPattern.SingletonPattern;

public class NaiveSingletonPattern
{
    private static NaiveSingletonPattern? _instance;
    private static int _counter = 0;
    public int Id { get; }

    private NaiveSingletonPattern()
    {
        Id = Interlocked.Increment(ref _counter);
        Console.WriteLine($"[Naive] Instance created with Id = {Id}");
        Thread.Sleep(100);
    }

    public static NaiveSingletonPattern Instance
    {
        get
        {
            _instance ??= new NaiveSingletonPattern();
            return _instance;
        }
    }

    public void Log(string msg) => Console.WriteLine($"[Naive {Id}] {msg}");
}
