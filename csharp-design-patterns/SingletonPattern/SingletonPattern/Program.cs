using Microsoft.Extensions.DependencyInjection;
using SingletonPattern.SingletonPattern;
using System;
using System.Threading.Tasks;

namespace SingletonPattern;

static class Program
{
    static void Main()
    {
        Console.WriteLine("=== Stage 1: Naive Singleton ===");
        Parallel.Invoke(
            () => NaiveSingletonPattern.Instance.Log("Task 1"),
            () => NaiveSingletonPattern.Instance.Log("Task 2")
        );

        Console.WriteLine("\n=== Stage 2: Thread-Safe Singleton ===");
        Parallel.Invoke(
            () => ThreadSafeSingletonPattern.Instance.Log("Task 1"),
            () => ThreadSafeSingletonPattern.Instance.Log("Task 2")
        );

        Console.WriteLine("\n=== Stage 3: Double-Checked Locking Singleton ===");
        Parallel.Invoke(
            () => DoubleCheckedSingletonPattern.Instance.Log("Task 1"),
            () => DoubleCheckedSingletonPattern.Instance.Log("Task 2")
        );

        Console.WriteLine("\n=== Stage 4: Static Initialization Singleton ===");
        Parallel.Invoke(
            () => StaticSingletonPattern.Instance.Log("Task 1"),
            () => StaticSingletonPattern.Instance.Log("Task 2")
        );

        Console.WriteLine("\n=== Stage 5: Lazy Singleton ===");
        Parallel.Invoke(
            () => LazySingletonPattern.Instance.Log("Task 1"),
            () => LazySingletonPattern.Instance.Log("Task 2")
        );

        Console.WriteLine("\n=== Stage 6: Serialization-Safe Singleton ===");
        Parallel.Invoke(
            () => SerializationSafeSingletonPattern.Instance.Log("Task 1"),
            () => SerializationSafeSingletonPattern.Instance.Log("Task 2")
        );

        Console.WriteLine("\n=== Stage 7: Dependency Injection Singleton ===");
        var services = new ServiceCollection();
        services.AddSingleton<ILogger, DependencyInjectionSingletonPattern>();
        var provider = services.BuildServiceProvider();

        var logger1 = provider.GetService<ILogger>();
        var logger2 = provider.GetService<ILogger>();
        logger1!.Log("First call");
        logger2!.Log("Second call");

        Console.WriteLine("\nAll stages executed successfully.");
    }
}
