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

        public CycleSalesContext()
        { }

        public CycleSalesContext(bool useInMemory)
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
                // Should come from app/web.config but hard coding to work around issue in Migrations
                options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=CycleSales;integrated security=True;");
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
