using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Model;
using System;

namespace CycleSales.Migrations
{
    public partial class LastUpdated : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn("Bikes", "LastUpdated", c => c.DateTime(nullable: false, defaultValue: DateTime.Now));
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn("Bikes", "LastUpdated");
        }
    }
}