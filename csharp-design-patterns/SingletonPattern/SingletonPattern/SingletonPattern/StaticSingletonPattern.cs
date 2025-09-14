using System;

namespace SingletonPattern.SingletonPattern;

public sealed class StaticSingletonPattern
{
    private static readonly StaticSingletonPattern _instance = new();
    private static int _counter = 0;
    public int Id { get; }

    private StaticSingletonPattern()
    {
        Id = Interlocked.Increment(ref _counter);
        Console.WriteLine($"[Static] Instance created with Id = {Id}");
        Thread.Sleep(100);
    }

    public static StaticSingletonPattern Instance => _instance;

    public void Log(string msg) => Console.WriteLine($"[Static {Id}] {msg}");
}
