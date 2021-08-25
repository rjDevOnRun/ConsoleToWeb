using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using System;

namespace ConsoleToWeb
{
    /*
     * Reference: https://www.c-sharpcorner.com/blogs/each-asp-net-core-web-application-is-a-console-application
     * Convert a Console Project to Asp.NET Core Web Application
     * 
     * 1) change csproject settings
     * 2) Add Generic and Web host builders with options
     * 3) Add Startup.cs class to the root and ref it in IHostBuilders
     * 4) Call the Create Host Builder in Main method
     * 5) Setup the Startup class for register services, routes and middlewares
     */

    class Program
    {
        static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        /// <summary>
        /// Add default Generic Host Builder which enables support 
        /// for Dependency Injects, Logging, IConfiguration 
        /// and IHostedServices implementations
        /// </summary>
        /// <param name="args"></param>
        /// <returns></returns>
        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            // Note: You cannot rename CreateHostBuilder method
            // as this exact name is required 


            // Add default generic Host builder otpions
            // Support for Dependency Injects, Logging,
            // IConfiguration and IHostedServices implementations
            return Host.CreateDefaultBuilder(args)
            
                // Add Web Host builder options
                // Support for HTTP, IIS and Kestrol Server as default web-server.
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>(); // ref the Startup class
                });
        }


    }
}
