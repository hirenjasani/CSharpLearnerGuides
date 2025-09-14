using System;

namespace SingletonPattern.SingletonPattern;

public sealed class LazySingletonPattern
{
    private static readonly Lazy<LazySingletonPattern> _lazy =
        new(() => new LazySingletonPattern());

    private static int _counter = 0;
    public int Id { get; }

    private LazySingletonPattern()
    {
        Id = Interlocked.Increment(ref _counter);
        Console.WriteLine($"[Lazy] Instance created with Id = {Id}");
        Thread.Sleep(100);
    }

    public static LazySingletonPattern Instance => _lazy.Value;

    public void Log(string msg) => Console.WriteLine($"[Lazy {Id}] {msg}");
}
