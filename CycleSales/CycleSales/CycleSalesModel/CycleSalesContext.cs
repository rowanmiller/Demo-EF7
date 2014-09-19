using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Framework.DependencyInjection.Advanced;
using Microsoft.Framework.Logging;
using System;
using System.Configuration;

namespace CycleSales.CycleSalesModel
{
    public class CycleSalesContext : DbContext
    {
        private bool _useInMemory;

        public CycleSalesContext(bool useInMemory = false)
        {
            _useInMemory = useInMemory;
        }

        public DbSet<Bike> Bikes { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            if (_useInMemory)
            {
                options.UseInMemoryStore();
            }
            else
            {
                options.UseSqlServer(ConfigurationManager.ConnectionStrings["CycleSalesConnection"].ConnectionString);
            }

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bike>()
                .ToTable("Bikes")
                .Key(b => b.Bike_Id);
        }
    }
}
