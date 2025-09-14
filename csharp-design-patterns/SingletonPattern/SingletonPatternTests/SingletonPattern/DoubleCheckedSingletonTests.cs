using SingletonPattern.SingletonPattern;

namespace SingletonPatternTests.SingletonPattern;

public class DoubleCheckedSingletonTests
{
    [Fact]
    public void Instance_ShouldBeSameAcrossParallelCalls()
    {
        DoubleCheckedSingletonPattern? instance1 = null;
        DoubleCheckedSingletonPattern? instance2 = null;

        Parallel.Invoke(
            () => instance1 = DoubleCheckedSingletonPattern.Instance,
            () => instance2 = DoubleCheckedSingletonPattern.Instance
        );

        Assert.Same(instance1, instance2);
    }
}
