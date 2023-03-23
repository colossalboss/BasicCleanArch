using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace BasicCleanArch.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });


        // Program.cs in .Net 7


        //var builder = WebApplication.CreateBuilder(args);

        //    builder.Services.ConfigurePersistence(builder.Configuration);
        //builder.Services.ConfigureApplication();

        //builder.Services.ConfigureApiBehavior();
        //builder.Services.ConfigureCorsPolicy();

        //builder.Services.AddControllers();
        //builder.Services.AddEndpointsApiExplorer();
        //builder.Services.AddSwaggerGen();

        //var app = builder.Build();

        //    var serviceScope = app.Services.CreateScope();
        //    var dataContext = serviceScope.ServiceProvider.GetService<DataContext>();
        //    dataContext?.Database.EnsureCreated();

        //app.UseSwagger();
        //app.UseSwaggerUI();
        //app.UseErrorHandler();
        //app.UseCors();
        //app.MapControllers();
        //app.Run();
    }
}
