using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;
using UnicornClicker;

namespace UnicornClicker.Migrations
{
    [ContextType(typeof(GameContext))]
    public partial class IntialSchema : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201410311902518_IntialSchema";
            }
        }
        
        string IMigrationMetadata.ProductVersion
        {
            get
            {
                return "7.0.0-beta2-11512";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("UnicornClicker.Game", b =>
                    {
                        b.Property<int>("Clicks");
                        b.Property<double>("ClicksPerSecond");
                        b.Property<int>("Duration");
                        b.Property<Guid>("GameId")
                            .GenerateValueOnAdd();
                        b.Property<DateTime>("Played");
                        b.Key("GameId");
                    });
                
                return builder.Model;
            }
        }
    }
}