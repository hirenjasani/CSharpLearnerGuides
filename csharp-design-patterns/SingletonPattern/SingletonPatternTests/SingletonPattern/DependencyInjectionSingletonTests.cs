using Microsoft.Extensions.DependencyInjection;
using SingletonPattern.SingletonPattern;

namespace SingletonPatternTests.SingletonPattern;

public class DependencyInjectionSingletonTests
{
    [Fact]
    public void DI_ShouldReturnSameInstance()
    {
        var services = new ServiceCollection();
        services.AddSingleton<ILogger, DependencyInjectionSingletonPattern>();
        var provider = services.BuildServiceProvider();

        var logger1 = provider.GetService<ILogger>();
        var logger2 = provider.GetService<ILogger>();

        Assert.Same(logger1, logger2);
    }
}
