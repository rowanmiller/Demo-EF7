using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using System;

namespace Blogging.Migrations
{
    public partial class Initial : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("Blog",
                c => new
                    {
                        BlogId = c.Int(nullable: false, identity: true),
                        AvgRating = c.Int(nullable: false),
                        Name = c.String(),
                        Url = c.String()
                    })
                .PrimaryKey("PK_Blog", t => t.BlogId);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Blog");
        }
    }
}