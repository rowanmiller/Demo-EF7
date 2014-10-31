using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Model;
using System;

namespace CycleSales.Migrations
{
    public partial class InitialSchema : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("Bikes",
                c => new
                    {
                        Bike_Id = c.Int(nullable: false),
                        Description = c.String(),
                        ImageUrl = c.String(),
                        ModelNo = c.String(),
                        Name = c.String(),
                        Retail = c.Decimal(nullable: false)
                    })
                .PrimaryKey("PK_Bikes", t => t.Bike_Id);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Bikes");
        }
    }
}