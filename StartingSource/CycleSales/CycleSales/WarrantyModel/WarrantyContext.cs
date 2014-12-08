using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using System.Configuration;
using Microsoft.Data.Entity.AzureTableStorage.Metadata;

namespace CycleSales.WarrantyModel
{
    public class WarrantyContext : DbContext
    {
        public DbSet<WarrantyInfo> Warranties { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            var connection = ConfigurationManager.ConnectionStrings["WarrantyConnection"].ConnectionString;

            // TODO Setup context to connect to Azure Table Storage
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            // TODO Configure partition and row key

        }
    }
}
