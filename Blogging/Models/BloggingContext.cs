using Microsoft.Data.Entity;
using System;

namespace Blogging.Models
{
    public class BloggingContext : DbContext
    {
	    public BloggingContext()
		{}
	
        public BloggingContext(IServiceProvider provider)
            :base(provider)
        {
        }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnConfiguring(DbContextOptions options)
        {
            options.UseSqlServer(@"Server=.\SQLEXPRESS;Database=Blogging;Trusted_Connection=True;");
        }
    }
}