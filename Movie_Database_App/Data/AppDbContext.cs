using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Movie_Database_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Database_App.Data
{
    public class AppDbContext: IdentityDbContext<AppUser>
    {
        public AppDbContext()
        {

        }

        public AppDbContext(DbContextOptions<DbContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MovieDBApp;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        public DbSet<Movie> Movies { get; set; }

        internal object Entity<T>()
        {
            throw new NotImplementedException();
        }

        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Dummy hardcoded data
            //Replace with API fetched JSON/XML Data
            base.OnModelCreating(modelBuilder);

            //modelBuilder.Entity<Movie>().HasKey(m => m.MovieID);

            modelBuilder.Entity<Movie>().HasData(

                    new Movie { MovieID = 1, Title = "Inception", RunningTime = 160, Description = "A thief who steals corporate secrets through the use of dream-sharing technology is given the inverse task of planting an idea into the mind of a C.E.O., but his tragic past may doom the project and his team to disaster.", Genre = "Scifi/Action", PosterUrl = "https://m.media-amazon.com/images/M/MV5BMjAxMzY3NjcxNF5BMl5BanBnXkFtZTcwNTI5OTM0Mw@@._V1_FMjpg_UX1000_.jpg", TrailerUrl = "https://www.youtube.com/watch?v=YoHD9XEInc0&ab_channel=MovieclipsClassicTrailers", DatePublished = new DateTime(2010-07-16) },
                    new Movie { MovieID = 2, Title = "Dune", RunningTime = 160, Description = "'Dune' tells the story of Paul Atreides, a brilliant and gifted young man born into a great destiny beyond his understanding, who must travel to the most dangerous planet in the universe to ensure the future of his family and his people. ", Genre = "Scifi/Adventure", PosterUrl = "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/405404/1e9f19f8529d69ceb08691e6fcb22c41-artwork-dune.jpg", TrailerUrl = "https://www.imdb.com/video/vi3986080537?playlistId=tt1160419&ref_=tt_ov_vi", DatePublished = new DateTime(2019-09-17) },
                    new Movie { MovieID = 3, Title = "Star Wars", RunningTime = 121, Description = "Luke Skywalker joins forces with a Jedi Knight, a cocky pilot, a Wookiee and two droids to save the galaxy from the Empire's world-destroying battle station, while also attempting to rescue Princess Leia from the mysterious Darth Vader.", Genre = "Scifi/Adventure", PosterUrl = "https://static.posters.cz/image/1300/poster/star-wars-classic-i97850.jpg", TrailerUrl = "https://www.imdb.com/video/vi1317709849?playlistId=tt0076759&ref_=tt_ov_vi", DatePublished = new DateTime(1977-01-01) },
                    new Movie { MovieID = 4, Title = "Squid Game", RunningTime = 55, Description = "Hundreds of cash-strapped players accept a strange invitation to compete in children's games. Inside, a tempting prize awaits with deadly high stakes. A survival game that has a whopping 45.6 billion-won prize at stake.", Genre = "Action/Drama/Mystery", PosterUrl = "https://d2iltjk184xms5.cloudfront.net/uploads/photo/file/418598/small_a21d1dd6edee7ca8e955852b1045464b-MV5BYWE3MDVkN2EtNjQ5MS00ZDQ4LTliNzYtMjc2YWMzMDEwMTA3XkEyXkFqcGdeQXVyMTEzMTI1Mjk3._V1_FMjpg_UX1000_.jpg", TrailerUrl = "https://www.imdb.com/video/vi2427699993?playlistId=tt10919420&ref_=tt_ov_vi", DatePublished = new DateTime(2021-09-01) },
                    new Movie { MovieID = 5, Title = "The Fellowship of the Ring", RunningTime = 180, Description = "A meek Hobbit from the Shire and eight companions set out on a journey to destroy the powerful One Ring and save Middle-earth from the Dark Lord Sauron.", Genre = "Adventure/Drama", PosterUrl = "https://m.media-amazon.com/images/M/MV5BN2EyZjM3NzUtNWUzMi00MTgxLWI0NTctMzY4M2VlOTdjZWRiXkEyXkFqcGdeQXVyNDUzOTQ5MjY@._V1_.jpg", TrailerUrl = "https://www.imdb.com/video/vi2073101337?playlistId=tt0120737&ref_=tt_ov_vi", DatePublished = new DateTime(2001-01-01) }

                    );

            //modelBuilder.Entity<Review>().HasData(

            //   new Review { ReviewID = 1, MovieID = 1, ReviewTitle = "A", Rating = Review.ERating.One, Comment = "A", DatePosted = new DateTime(2019 - 01 - 01) }

            //   );

        }

       
       
    }
}
