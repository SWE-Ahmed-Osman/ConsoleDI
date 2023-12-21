
using ConsoleDI;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

var builder = Host.CreateApplicationBuilder(args);

builder.Services.AddTransient<IExampleTransientService, ExampleTransientService>();
builder.Services.AddScoped<IExampleScopedService, ExampleScopedService>();
builder.Services.AddSingleton<IExampleSingletonService, ExampleSingletonService>();

builder.Services.AddTransient<ServiceLifetimeReporter>();

using var host = builder.Build();

ExemplifyServiceLifetime(host.Services, "Lifetime 1");
Console.WriteLine("...............................................................................................");
Console.WriteLine("...............................................................................................");
Console.WriteLine("...............................................................................................");
ExemplifyServiceLifetime(host.Services, "Lifetime 2");
Console.WriteLine("...............................................................................................");
Console.WriteLine("...............................................................................................");
Console.WriteLine("...............................................................................................");

await host.RunAsync();
return;

static void ExemplifyServiceLifetime(IServiceProvider serviceProvider, string lifetime)
{
    using var serviceScope = serviceProvider.CreateScope();
    var provider = serviceScope.ServiceProvider;
    
    var logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifetimeDetails($"{lifetime}: Call 1 to provider.GetRequiredService<ServiceLifetimeReporter>()");
    
    Console.WriteLine("...............................................................................................");
    
    logger = provider.GetRequiredService<ServiceLifetimeReporter>();
    logger.ReportServiceLifetimeDetails($"{lifetime}: Call 2 to provider.GetRequiredService<ServiceLifetimeReporter>()");
}