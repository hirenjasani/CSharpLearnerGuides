using SingletonPattern.SingletonPattern;

namespace SingletonPatternTests.SingletonPattern;

public class ThreadSafeSingletonTests
{
    [Fact]
    public void Instance_ShouldBeSameAcrossParallelCalls()
    {
        ThreadSafeSingletonPattern? instance1 = null;
        ThreadSafeSingletonPattern? instance2 = null;

        Parallel.Invoke(
            () => instance1 = ThreadSafeSingletonPattern.Instance,
            () => instance2 = ThreadSafeSingletonPattern.Instance
        );

        Assert.Same(instance1, instance2);
    }
}
