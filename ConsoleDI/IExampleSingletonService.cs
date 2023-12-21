using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI;

public interface IExampleSingletonService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Singleton;
}