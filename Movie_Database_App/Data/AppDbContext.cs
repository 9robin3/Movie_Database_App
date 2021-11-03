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
                    new Movie {  MovieID = 1, Title = "test1", RunningTime = 200, Description = "desc", PosterUrl = "https://www.google.se/search?q=poster&sxsrf=AOaemvJvuUydUxJYqGjMdmDHH6P_2iNWJA:1635937457901&source=lnms&tbm=isch&sa=X&ved=2ahUKEwi1pLX4hfzzAhWE66QKHYRxDxkQ_AUoAXoECAIQAw&biw=1164&bih=743&dpr=1.1#imgrc=Sh2WCaip0W2k0M", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2021-01-01) },
                    new Movie { MovieID = 2, Title = "test2", RunningTime = 70, Description = "desc2", PosterUrl = "https://www.google.se/search?q=poster&sxsrf=AOaemvJvuUydUxJYqGjMdmDHH6P_2iNWJA:1635937457901&source=lnms&tbm=isch&sa=X&ved=2ahUKEwi1pLX4hfzzAhWE66QKHYRxDxkQ_AUoAXoECAIQAw&biw=1164&bih=743&dpr=1.1#imgrc=wcdqdBsbqx0atM", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2019 - 01 - 01)},
                    new Movie { MovieID = 3, Title = "test3", RunningTime = 120, Description = "desc3", PosterUrl = "https://www.google.se/search?q=poster&sxsrf=AOaemvJvuUydUxJYqGjMdmDHH6P_2iNWJA:1635937457901&source=lnms&tbm=isch&sa=X&ved=2ahUKEwi1pLX4hfzzAhWE66QKHYRxDxkQ_AUoAXoECAIQAw&biw=1164&bih=743&dpr=1.1#imgrc=M8e_-Wr-XO27LM", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2007 - 01 - 01) }
                   
                );
        }
       
    }
}
