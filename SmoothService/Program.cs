using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Configuration;
using Serilog;

namespace SmoothService
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var configutaion = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();
            Log.Logger = new LoggerConfiguration()
                //.WriteTo.RollingFile("C:\\GitRepos\\Smooth\\Log\\log-{Date}.json")
                .ReadFrom.Configuration(configutaion)
                .CreateLogger();

            try
            {
                Log.Information("Application Starting Up");
                CreateHostBuilder(args).Build().Run();
            }
            catch (Exception ex)
            {
                Log.Fatal(ex, "The Application failed to start correctly.");
            }
            finally
            {
                Log.CloseAndFlush();
            }
            
        }

        public static IHostBuilder CreateHostBuilder(string[] args)
        {
            return Host.CreateDefaultBuilder(args)
                //.ConfigureLogging((context,logging) => 
                //{
                //    logging.ClearProviders();
                //    logging.AddConfiguration(context.Configuration.GetSection("Logging"));
                //    logging.AddDebug();
                //    logging.AddConsole();
                //})
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
        }
    }
}
