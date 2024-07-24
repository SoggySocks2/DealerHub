using DealerHub.Console.Dealers;
using DealerHub.Infrastructure.ConfigurationSettings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DealerHub.Console.Setup;
public static class ConsoleServices
{
    public static void BindConfigurations(this IConfigurationRoot configuration)
    {
        configuration.Bind(CoreDbSettings.CONFIG_NAME, CoreDbSettings.Instance);
    }
    public static void AddConsoleServices(this IServiceCollection services)
    {
        services.AddScoped<IDealerService, DealerService>();
    }
}
