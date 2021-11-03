using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Movie_Database_App.Data;
using Movie_Database_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Database_App
{
    public class Program
    {
        public static AppDbContext _dbContext = new AppDbContext();

        public static void Main(string[] args)
        {
            //Test data 
            //_dbContext.Movies.AddAsync(new Movie("Test1", 200, "desc"));
            //_dbContext.Movies.AddAsync(new Movie("Test2", 70, "desc2"));
            //_dbContext.Movies.AddAsync(new Movie("Test3", 120, "desc3"));

            //_dbContext.SaveChangesAsync();

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
