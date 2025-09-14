using SingletonPattern.SingletonPattern;

namespace SingletonPatternTests.SingletonPattern;

public class LazySingletonTests
{
    [Fact]
    public void Instance_ShouldBeSameAcrossParallelCalls()
    {
        LazySingletonPattern? instance1 = null;
        LazySingletonPattern? instance2 = null;

        Parallel.Invoke(
            () => instance1 = LazySingletonPattern.Instance,
            () => instance2 = LazySingletonPattern.Instance
        );

        Assert.Same(instance1, instance2);
    }
}
