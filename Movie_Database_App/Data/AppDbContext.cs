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
            //base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Movie>().HasData(
                    //new Movie { Title = "Test 1", RunningTime = 200, Description = "Desc" }
                    new Movie("Test 1", 200, "This is a test description"),
                    new Movie("Test 2", 75, "Another description"),
                    new Movie("Test 3", 120, "Action movie 2019")
                );
        }
       
    }
}
