using DealerHub.Console;
using DealerHub.Console.Setup;
using DealerHub.Infrastructure.Setup;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

using (var host = CreateHostBuilder(args).Build())
{
    await host.Services.GetRequiredService<Controller>().ProcessCustomers(); // Invoke the entry point method
}
Environment.Exit(0);

static IHostBuilder CreateHostBuilder(string[] args)
{
    var builder = new ConfigurationBuilder()
        .SetBasePath(Path.Combine(AppContext.BaseDirectory))
        .AddJsonFile("appsettings.json", optional: false)
        .AddJsonFile($"appsettings.Development.json", optional: true, reloadOnChange: true);

    var configuration = builder.Build();

    configuration.BindConfigurations();

    return Host.CreateDefaultBuilder(args)
        .ConfigureServices(services =>
        {
            services.AddConsoleServices();
            services.AddInfrastructureServices();
            services.AddTransient<Controller>(); // Entry point
        });
}