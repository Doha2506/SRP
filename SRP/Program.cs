using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SRP.Interfaces;
using SRP.Services;

var host = Host.CreateDefaultBuilder(args)
    .ConfigureServices(services =>
    {
        services.AddTransient<ILogger, FileLogger>();
        services.AddTransient<INotifier, EmailNotifier>();
        services.AddTransient<IProductFetcher, ProductFetcher>();
    })
    .Build();

// Get service from DI container
var productFetcherService = host.Services.GetRequiredService<IProductFetcher>();

productFetcherService.FetchProduct();

var loggerService = host.Services.GetRequiredService<ILogger>();

loggerService.Log("Logging: Product fetched at " + DateTime.Now);

var notifierService = host.Services.GetRequiredService<INotifier>();

notifierService.Notify("Sending email: Product fetched.");

