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

        public override int SaveChanges()
        {
            foreach (var item in this.ChangeTracker.Entries<Bike>().Where(e => e.State == EntityState.Modified))
            {
                var prop = Model.GetEntityType(typeof(Bike)).GetProperty("LastUpdated");
                item.StateEntry[prop] = DateTime.Now;
            }

            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptions options)
        {
            // TODO: This check is so that we can pass in external options from tests
            //       Need to come up with a better way to handle this scenario
            if (!((IDbContextOptionsExtensions)options).Extensions.Any())
            {
                // TODO: Connection string in code rather than config file because of temporary limitation with Migrations
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

            builder.Entity<Bike>()
                .Property<DateTime>("LastUpdated");
        }
    }
}
