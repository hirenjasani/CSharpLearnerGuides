using System;

namespace SingletonPattern.SingletonPattern;

public class DoubleCheckedSingletonPattern
{
    private static DoubleCheckedSingletonPattern? _instance;
    private static readonly object _lock = new();
    private static int _counter = 0;
    public int Id { get; }

    private DoubleCheckedSingletonPattern()
    {
        Id = Interlocked.Increment(ref _counter);
        Console.WriteLine($"[DoubleChecked] Instance created with Id = {Id}");
        Thread.Sleep(100);
    }

    public static DoubleCheckedSingletonPattern Instance
    {
        get
        {
            if (_instance == null)
            {
                lock (_lock)
                {
                    _instance ??= new DoubleCheckedSingletonPattern();
                }
            }
            return _instance;
        }
    }

    public void Log(string msg) => Console.WriteLine($"[DoubleChecked {Id}] {msg}");
}
