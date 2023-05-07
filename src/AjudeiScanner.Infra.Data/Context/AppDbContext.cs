using AjudeiScanner.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjudeiScanner.Infra.Data.Context
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Connect to postgreSQL with PostgreSQLConnectionString provided on AppSettings
            optionsBuilder.UseNpgsql(Configuration.GetSection("Settings")["PostgreSQLConnectionString"]);
        }

        public DbSet<UserEntityDomain> Users { get; set; }
        public DbSet<CouponEntityDomain> Coupons { get; set; }
    }
}
