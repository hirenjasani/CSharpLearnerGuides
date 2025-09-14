using System;

namespace SingletonPattern.SingletonPattern;

[Serializable]
public sealed class SerializationSafeSingletonPattern
{
    private static readonly SerializationSafeSingletonPattern _instance = new();
    private static int _counter = 0;
    public int Id { get; }

    private SerializationSafeSingletonPattern()
    {
        Id = Interlocked.Increment(ref _counter);
        Console.WriteLine($"[SerializationSafe] Instance created with Id = {Id}");
        Thread.Sleep(100);
    }

    public static SerializationSafeSingletonPattern Instance => _instance;

    public void Log(string msg) => Console.WriteLine($"[SerializationSafe {Id}] {msg}");
}
