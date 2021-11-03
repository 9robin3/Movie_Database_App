using Microsoft.EntityFrameworkCore;
using Movie_Database_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Database_App.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Movie> Movies { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Dummy hardcoded data
            //Replace with API fetched JSON/XML Data
            
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                    new Movie {  MovieID = 1, Title = "test1", RunningTime = 200, Description = "desc"},
                    new Movie { MovieID = 2, Title = "test2", RunningTime = 70, Description = "desc2" },
                    new Movie { MovieID = 3, Title = "test3", RunningTime = 120, Description = "desc3" }
                   
                );
        }
       
    }
}
