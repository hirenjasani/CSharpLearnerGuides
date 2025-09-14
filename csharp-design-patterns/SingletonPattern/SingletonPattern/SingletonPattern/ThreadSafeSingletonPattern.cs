using System;

namespace SingletonPattern.SingletonPattern;

public class ThreadSafeSingletonPattern
{
    private static ThreadSafeSingletonPattern? _instance;
    private static readonly object _lock = new();
    private static int _counter = 0;
    public int Id { get; }

    private ThreadSafeSingletonPattern()
    {
        Id = Interlocked.Increment(ref _counter);
        Console.WriteLine($"[ThreadSafe] Instance created with Id = {Id}");
        Thread.Sleep(100);
    }

    public static ThreadSafeSingletonPattern Instance
    {
        get
        {
            lock (_lock)
            {
                _instance ??= new ThreadSafeSingletonPattern();
            }
            return _instance;
        }
    }

    public void Log(string msg) => Console.WriteLine($"[ThreadSafe {Id}] {msg}");
}
