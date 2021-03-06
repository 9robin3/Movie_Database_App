using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_Database_App.Models
{
    public class Movie
    {
        public Movie()
        {
            ReviewsList = new List<Review>();
        }

        public Movie(int Id)
        {
            MovieID = Id;
            ReviewsList = new List<Review>();
        }

        //public Movie(string title, float runningTime, string description)
        //{
        //    Title = title;
        //    RunningTime = runningTime;
        //    Description = description;
        //}

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MovieID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Genre { get; set; }
        [Required]
        public float RunningTime { get; set; }
        [Required]
        public string Description { get; set; }
        public string PosterUrl { get; set; }
        public string TrailerUrl { get; set; }
        public DateTime DatePublished { get; set; }
        public List<Review> ReviewsList { get; set; }
        public List<AppUser> UserList { get; set; } = new List<AppUser>();
    }
}
