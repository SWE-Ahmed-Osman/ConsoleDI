using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI;

public interface IExampleScopedService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Scoped;
}