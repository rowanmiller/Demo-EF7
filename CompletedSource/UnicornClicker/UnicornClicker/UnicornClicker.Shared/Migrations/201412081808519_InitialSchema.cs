using Microsoft.Data.Entity.Migrations;
using Microsoft.Data.Entity.Migrations.Builders;
using Microsoft.Data.Entity.Relational.Model;
using System;

namespace UnicornClicker.Migrations
{
    public partial class InitialSchema : Migration
    {
        public override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable("Game",
                c => new
                    {
                        GameId = c.Guid(nullable: false, identity: true),
                        Clicks = c.Int(nullable: false),
                        ClicksPerSecond = c.Double(nullable: false),
                        Duration = c.Int(nullable: false),
                        Played = c.DateTime(nullable: false)
                    })
                .PrimaryKey("PK_Game", t => t.GameId);
        }
        
        public override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable("Game");
        }
    }
}