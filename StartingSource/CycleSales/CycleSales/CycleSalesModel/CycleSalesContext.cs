using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Infrastructure;
using Microsoft.Data.Entity.Metadata;
using System;
using System.Configuration;
using System.Linq;

namespace CycleSales.CycleSalesModel
{
    public class CycleSalesContext : DbContext
    {
        public CycleSalesContext()
        { }

        public CycleSalesContext(DbContextOptions options)
            : base(options)
        { }

        public DbSet<Bike> Bikes { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            if (!options.IsAlreadyConfigured())
            {
                options.UseSqlServer(@"Server=(localdb)\v11.0;Database=CycleSales;integrated security=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bike>()
                .Key(b => b.Bike_Id);

            builder.Entity<Bike>()
                .ForRelational()
                .Table("Bikes");
        }
    }

    public static class DbOptionsExtensions
    {
        public static bool IsAlreadyConfigured(this DbContextOptions options)
        {
            return ((IDbContextOptionsExtensions)options).Extensions.Any();
        }
    }
}
