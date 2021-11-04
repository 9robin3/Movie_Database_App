using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Movie_Database_App.Models
{
    public class Movie
    {
        public Movie()
        {

        }

        //public Movie(string title, float runningTime, string description)
        //{
        //    Title = title;
        //    RunningTime = runningTime;
        //    Description = description;
        //}
        
        [Key]
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
        public Review Review { get; set; }
    }
}
