using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System.Configuration;

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
            options.UseSqlServer(ConfigurationManager.ConnectionStrings["CycleSalesConnection"].ConnectionString);

            // TODO To use Migrations at the moment you need to replace ConfigurationManager call with the actual string
            // @"Server=.\SQLEXPRESS;Database=CycleSales;integrated security=True;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Bike>()
                .ToTable("Bikes")
                .Key(b => b.Bike_Id);
        }
    }
}
