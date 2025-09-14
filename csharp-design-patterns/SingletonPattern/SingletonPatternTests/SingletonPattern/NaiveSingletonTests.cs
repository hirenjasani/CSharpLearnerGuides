using SingletonPattern.SingletonPattern;

namespace SingletonPatternTests.SingletonPattern;

public class NaiveSingletonTests
{
    [Fact]
    public void Instance_ShouldBeSameAcrossCalls()
    {
        var instance1 = NaiveSingletonPattern.Instance;
        var instance2 = NaiveSingletonPattern.Instance;

        Assert.Same(instance1, instance2);
    }
}
