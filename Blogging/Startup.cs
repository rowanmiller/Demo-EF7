using System;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Routing;
using Microsoft.AspNet.Security.Cookies;
using Microsoft.Data.Entity;
using Microsoft.Framework.ConfigurationModel;
using Microsoft.Framework.DependencyInjection;
using Blogging.Models;

namespace Blogging
{
    public class Startup
    {
        public void Configure(IApplicationBuilder app)
        {
            // Setup configuration sources
            var configuration = new Configuration();
            configuration.AddJsonFile("config.json");
            configuration.AddEnvironmentVariables();

            // Set up application services
            app.UseServices(services =>
            {
                // Add EF services to the services container
                services.AddEntityFramework()
                    .AddSqlServer();
                
                // Add MVC services to the services container
                services.AddMvc();

                services.AddScoped<BloggingContext, BloggingContext>();
            });

            app.UseStaticFiles();

			// Setup error pages
            app.UseErrorPage();
            app.UseMigrationsEndPoint();
            app.UseDatabaseErrorPage();

            // Add MVC to the request pipeline
            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default", 
                    template: "{controller}/{action}/{id?}",
                    defaults: new { controller = "Blogs", action = "Index" });

                routes.MapRoute(
                    name: "api",
                    template: "{controller}/{id?}");
            });
        }
    }
}
