using SingletonPattern.SingletonPattern;

namespace SingletonPatternTests.SingletonPattern;

public class SerializationSafeSingletonTests
{
    [Fact]
    public void Instance_ShouldBeSameAcrossCalls()
    {
        var instance1 = SerializationSafeSingletonPattern.Instance;
        var instance2 = SerializationSafeSingletonPattern.Instance;

        Assert.Same(instance1, instance2);
    }
}
