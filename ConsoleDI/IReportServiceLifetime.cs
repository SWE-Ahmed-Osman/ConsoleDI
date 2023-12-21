using Microsoft.Extensions.DependencyInjection;

namespace ConsoleDI;

public interface IReportServiceLifetime
{
    Guid Id { get; }
    ServiceLifetime Lifetime { get; }
}