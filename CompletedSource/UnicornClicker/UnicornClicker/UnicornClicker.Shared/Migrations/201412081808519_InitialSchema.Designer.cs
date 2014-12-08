using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;
using UnicornClicker;

namespace UnicornClicker.Migrations
{
    [ContextType(typeof(GameContext))]
    public partial class InitialSchema : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201412081808519_InitialSchema";
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
                
                builder.Entity("UnicornClicker.Game", b =>
                    {
                        b.Property<int>("Clicks");
                        b.Property<double>("ClicksPerSecond");
                        b.Property<int>("Duration");
                        b.Property<Guid>("GameId")
                            .GenerateValuesOnAdd();
                        b.Property<DateTime>("Played");
                        b.Key("GameId");
                    });
                
                return builder.Model;
            }
        }
    }
}