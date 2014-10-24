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
            // TODO: Connection string in code rather than config file because of temporary limitation with Migrations
            options.UseSqlServer(@"Server=(localdb)\v11.0;Database=CycleSales;integrated security=True;");
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
}
