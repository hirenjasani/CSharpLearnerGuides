using SingletonPattern.SingletonPattern;

namespace SingletonPatternTests.SingletonPattern;

public class StaticSingletonTests
{
    [Fact]
    public void Instance_ShouldBeSameAcrossCalls()
    {
        var instance1 = StaticSingletonPattern.Instance;
        var instance2 = StaticSingletonPattern.Instance;

        Assert.Same(instance1, instance2);
    }
}
