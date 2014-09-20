using Blogging.Models;
using Microsoft.Data.Entity.Metadata;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using System;

namespace Blogging.Migrations
{
    [ContextType(typeof(BloggingContext))]
    public partial class Notes : IMigrationMetadata
    {
        string IMigrationMetadata.MigrationId
        {
            get
            {
                return "201409202340409_Notes";
            }
        }
        
        IModel IMigrationMetadata.TargetModel
        {
            get
            {
                var builder = new BasicModelBuilder();
                
                builder.Entity("Blogging.Models.Blog", b =>
                    {
                        b.Property<int>("AvgRating");
                        b.Property<int>("BlogId");
                        b.Property<int>("BlogId").Metadata.ValueGenerationOnAdd = ValueGenerationOnAdd.Client;
                        b.Property<int>("BlogId").Metadata.ValueGenerationOnSave = ValueGenerationOnSave.WhenInserting;
                        b.Property<string>("Name");
                        b.Property<string>("Notes");
                        b.Property<string>("Url");
                        b.Key("BlogId");
                    });
                
                return builder.Model;
            }
        }
    }
}