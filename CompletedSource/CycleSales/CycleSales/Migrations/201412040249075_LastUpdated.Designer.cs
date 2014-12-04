using CycleSales.CycleSalesModel;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;

namespace CycleSales.Migrations
{
    [ContextType(typeof(CycleSalesContext))]
    public partial class LastUpdated : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201412040249075_LastUpdated";
            }
        }
        
        string IMigrationMetadata.ProductVersion
        {
            get
            {
                return "7.0.0-beta1-11518";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("CycleSales.CycleSalesModel.Bike", b =>
                    {
                        b.Property<int>("Bike_Id");
                        b.Property<string>("Description");
                        b.Property<string>("ImageUrl");
                        b.Property<DateTime>("LastUpdated");
                        b.Property<string>("ModelNo");
                        b.Property<string>("Name");
                        b.Property<decimal>("Retail");
                        b.Key("Bike_Id");
                        b.ForRelational().Table("Bikes");
                    });
                
                return builder.Model;
            }
        }
    }
}