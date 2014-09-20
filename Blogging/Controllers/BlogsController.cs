using System;
using System.Linq;
using Microsoft.AspNet.Mvc;
using Blogging.Models;
using Microsoft.Data.Entity.Migrations.Infrastructure;
using Microsoft.Framework.DependencyInjection;
using Microsoft.Data.Entity.Migrations;

namespace Blogging.Controllers
{
    public class BlogsController : Controller
    {
        private BloggingContext _context;

        public BlogsController(BloggingContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View(_context.Blogs.OrderBy(b => b.Name).ToList());
        }

        public IActionResult DeleteDatabase()
        {
            _context.Database.EnsureDeleted();
            return View();
        }

        public IActionResult AddSomeBlogs()
        {
            _context.Blogs.Add(new Blog { Name = "EF Blog", Url = "http://blogs.msdn.com/adonet" });
            _context.Blogs.Add(new Blog { Name = "RoMiller", Url = "http://romiller.com" });
			_context.SaveChanges();
            return View();
        }

        public IActionResult Details(int id)
        {
            Blog blog = null;

            if (!blog.Url.StartsWith("http://"))
            {
                blog.Url = "http://" + blog.Url;
            }

            return View(blog);
        }
    }
}