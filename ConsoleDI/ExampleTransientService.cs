namespace ConsoleDI;

internal sealed class ExampleTransientService : IExampleTransientService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}