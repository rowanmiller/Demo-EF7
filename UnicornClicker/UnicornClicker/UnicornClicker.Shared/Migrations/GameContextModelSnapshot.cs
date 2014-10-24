using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;
using UnicornClicker;

namespace UnicornClicker.Migrations
{
    [ContextType(typeof(GameContext))]
    public class GameContextModelSnapshot : ModelSnapshot
    {
        public override IModel Model
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