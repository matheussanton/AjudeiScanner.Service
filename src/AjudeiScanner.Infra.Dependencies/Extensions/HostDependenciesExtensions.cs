
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AjudeiScanner.Infra.Dependencies.Extensions
{
    public static class HostDependenciesExtensions
    {
        public static AppSettings RegisterAppSettings(this IServiceCollection services, IConfiguration configuration)
        {
            var settings = configuration.GetSection("Settings");
            services.Configure<AppSettings>(settings);
            return settings.Get<AppSettings>();
        }
    }
}
