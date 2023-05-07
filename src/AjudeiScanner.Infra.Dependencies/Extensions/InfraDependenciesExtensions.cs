using AjudeiScanner.Domain.Coupons.Interfaces;
using AjudeiScanner.Infra.Data.Context;
using AjudeiScanner.Infra.Data.Repositories.Coupons;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AjudeiScanner.Infra.Dependencies.Extensions
{
    public static class InfraDependenciesExtensions
    {
        /// <summary>
        /// Register Data Layer Dependencies, including PostgreSQL and EFCore.
        /// </summary>
        /// <param name="services"></param>

        public static IServiceCollection RegisterDataLayerDependencies(this IServiceCollection services, AppSettings appSettings, IConfiguration configuration)
        {
            //services.RegisterAppSettings(configuration);
            return services.RegisterPostgreSQL(appSettings);
            //services.RegisterEFCore();
        }

        public static IServiceCollection RegisterPostgreSQL(this IServiceCollection services, AppSettings appSettings)
        {
            services.AddDbContext<AppDbContext>();

            //Repositories
            services.AddScoped<ICouponsRepository, CouponsRepository>();

            return services;
        }



    }
}
