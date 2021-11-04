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
                    new Movie {  MovieID = 1, Title = "test1", RunningTime = 200, Description = "desc",Genre = "Action" , PosterUrl = "https://artiks.se/media/catalog/product/cache/1941e30f13ad4c84c12405c473c5cb3f/1/3/41688/47916/berlin-vintage-poster.jpg", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2021-01-01) },
                    new Movie { MovieID = 2, Title = "test2", RunningTime = 70, Description = "desc2", Genre = "Scifi", PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2019 - 01 - 01)},
                    new Movie { MovieID = 3, Title = "test3", RunningTime = 120, Description = "desc3", Genre = "Horror", PosterUrl = "https://image.posterlounge.se/images/l/1892194.jpg", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2007 - 01 - 01) },
                    new Movie { MovieID = 4, Title = "test4", RunningTime = 120, Description = "desc4", Genre = "Horror", PosterUrl = "https://image.posterlounge.se/images/l/1892194.jpg", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(1997 - 01 - 01) },
                    new Movie { MovieID = 5, Title = "test5", RunningTime = 70, Description = "desc5", Genre = "Adventure", PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2019 - 01 - 01) },
                    new Movie { MovieID = 6, Title = "test6", RunningTime = 200, Description = "desc6", Genre = "Action", PosterUrl = "https://artiks.se/media/catalog/product/cache/1941e30f13ad4c84c12405c473c5cb3f/1/3/41688/47916/berlin-vintage-poster.jpg", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2021 - 01 - 01) },
                    new Movie { MovieID = 7, Title = "test7", RunningTime = 70, Description = "desc7", Genre = "Scifi", PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2019 - 01 - 01) },
                    new Movie { MovieID = 8, Title = "test8", RunningTime = 320, Description = "desc8", Genre = "Adventure", PosterUrl = "https://image.posterlounge.se/img/products/630000/620045/620045_poster_l.jpg", TrailerUrl = "https://www.youtube.com/watch?v=oZ6iiRrz1SY&ab_channel=SonyPicturesEntertainment", DatePublished = new DateTime(2019 - 01 - 01) }

                );
        }

        public DbSet<Movie_Database_App.Models.Review> Review { get; set; }
       
    }
}
