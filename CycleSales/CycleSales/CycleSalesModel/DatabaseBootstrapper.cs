using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Entity;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Microsoft.Framework.DependencyInjection;

namespace CycleSales.CycleSalesModel
{
    public class DatabaseBootstrapper
    {
        public static void EnsureInitialized()
        {
            using (var db = new CycleSalesContext())
            {
                if(!db.Database.AsRelational().Exists())
                {
                    db.Database.AsRelational().ApplyMigrations();

                    db.Bikes.Add(new Bike
                    {
                        Bike_Id = 1,
                        Name = "Mountain Monster 7000",
                        ModelNo = "MM7000",
                        Retail = 349.95M,
                        Description = "Tackle the mountains with confidence and attitude. Built to go fast, built to go hard, and built to last.",
                        ImageUrl = "~/ImageUploads/MountainMonster7000.png"
                    });

                    db.Bikes.Add(new Bike
                    {
                        Bike_Id = 2,
                        Name = "BMX Bandit B500",
                        ModelNo = "BBB500",
                        Retail = 249.95M,
                        Description = "Get your skills on with this little monster. Fly high, fly fast, and fly in style.",
                        ImageUrl = "~/ImageUploads/BmxBanditB500.png"
                    });

                    db.Bikes.Add(new Bike
                    {
                        Bike_Id = 3,
                        Name = "Toddler Terror Trainer 200",
                        ModelNo = "TTT200",
                        Retail = 199.95M,
                        Description = "The premium menacing machine for your young and aspiring bike rider. Who said training wheels couldn't look cool.",
                        ImageUrl = "~/ImageUploads/ToddlerTerrorTrainer200.png"
                    });

                    db.SaveChanges();
                }
            }
        }
    }
}
