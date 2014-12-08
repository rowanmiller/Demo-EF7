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

        }
    }
}
