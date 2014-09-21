using CycleSales.CycleSalesModel;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;

namespace CycleSales.Migrations
{
    [ContextType(typeof(CycleSalesContext))]
    public class CycleSalesContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("CycleSales.CycleSalesModel.Bike", b =>
                    {
                        b.Property<int>("Bike_Id");
                        b.Property<string>("Description");
                        b.Property<string>("ImageUrl");
                        b.Property<string>("ModelNo");
                        b.Property<string>("Name");
                        b.Property<decimal>("Retail");
                        b.Key("Bike_Id");
                        b.ToTable("Bikes");
                    });
                
                return builder.Model;
            }
        }
    }
}