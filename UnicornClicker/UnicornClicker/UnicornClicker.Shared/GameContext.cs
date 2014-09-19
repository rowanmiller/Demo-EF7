using System;
using Microsoft.Data.Entity;
using System.Collections.Generic;
using System.Text;

namespace UnicornClicker
{
    class GameContext : DbContext
    {
        public DbSet<Game> Games { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {

#if WINDOWS_PHONE_APP
            var connection = "Filename=GameHistory.db";
#else
            var dir = Windows.Storage.ApplicationData.Current.LocalFolder.Path;
            var connection = "Filename=" + System.IO.Path.Combine(dir, "GameHistory.db");
#endif

            options.UseSQLite(connection);
        }
    }
}
