namespace ConsoleDI;

internal sealed class ExampleSingletonService : IExampleSingletonService
{
    Guid IReportServiceLifetime.Id { get; } = Guid.NewGuid();
}