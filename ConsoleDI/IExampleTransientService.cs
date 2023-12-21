using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI;

public interface IExampleTransientService : IReportServiceLifetime
{
    ServiceLifetime IReportServiceLifetime.Lifetime => ServiceLifetime.Transient;
}