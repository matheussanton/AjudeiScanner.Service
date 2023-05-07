using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AjudeiScanner.Infra.Dependencies.Extensions;

namespace AjudeiScanner.Host
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public IHostEnvironment CurrentEnvironment { get; }

        public Startup(IConfiguration configuration, IHostEnvironment env)
        {
            Configuration = configuration;
            CurrentEnvironment = env;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            var appSettings = services.RegisterAppSettings(Configuration);

            services.RegisterDataLayerDependencies(appSettings, Configuration);
            services.RegisterDomainDependencies();


        }

        public void Configure(WebApplication app, IHostEnvironment env)
        {
            if (CurrentEnvironment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }


    }
}
