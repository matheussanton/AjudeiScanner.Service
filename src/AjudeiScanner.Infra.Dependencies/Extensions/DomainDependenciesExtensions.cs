using AjudeiScanner.Domain.Coupons.Commands.Handlers;
using AjudeiScanner.Domain.Coupons.Queries;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace AjudeiScanner.Infra.Dependencies.Extensions
{
    public static class DomainDependenciesExtensions
    {
        public static void RegisterDomainDependencies(this IServiceCollection services)
        {
            services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(Assembly.GetExecutingAssembly()));
            //services.AddTransient(typeof(CouponsQueryHandler));

            //var handlers = new[]
            //{
            //    typeof(CouponsQueryHandler)
            //};

            //services.AddMediatR(handlers);

            services.AddTransient<CouponsQueryHandler>();
            services.AddTransient<CouponsHandler>();


        }
    }
}
