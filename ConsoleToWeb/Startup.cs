using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleToWeb
{
    public class Startup
    {

        /// <summary>
        /// Register services using DI containers
        /// </summary>
        /// <param name="services"></param>
        public void ConfigureServices(IServiceCollection services)
        {
            //// This is implementaion for Asp.Net Core MVC application
            services.AddControllersWithViews();

            //// This is implementaion for  Asp.Net Core WebAPI application
            // services.AddControllers();

            //// This is implementaion for Asp.NET Core Razor application
            //services.AddRazorPages();
        }

        /// <summary>
        /// Setup Http request pipeline to insert the middlewares
        /// </summary>
        /// <param name="app"></param>
        /// <param name="env"></param>
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {

            // Add Routing and Endpoint ---------------------------------------
            // Routing is basically a mapping between
            // incoming http request and the resource.
            app.UseRouting();
            
            app.UseEndpoints(endpoints =>
            {

                //// This is implementaion for Asp.Net Core MVC application
                endpoints.MapDefaultControllerRoute();

                //// This is implementaion for Asp.NET Core WebAPI
                //endpoint.MapControllers();

                //// This is implementaion for Asp.Net Core Razor application
                //endpoints.MapRazorPages();

                // This is default implementations
                // Add as many routes as required for your application
                //    endpoints.MapGet("/", async context =>
                //    {
                //        await context.Response.WriteAsync("Hello from new web Application");
                //    });

                //    endpoints.MapGet("/test", async context =>
                //    {
                //        await context.Response.WriteAsync("Hello from test endpoint");
                //    });
            });

            // ----------------------------------------------------------------
        }

    }
}
