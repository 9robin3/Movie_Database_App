using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Database_App.Models
{
    

    public class Review
    {
        public Review()
        {

        }

        public Review(Movie movie)
        {
            MovieID = movie;
        }


        [Key]
        public int ReviewID { get; set; }
        //FK:
        [ForeignKey("MovieID")]
        [NotMapped]
        public Movie MovieID { get; set; }
        [Required]
        public string ReviewTitle { get; set; }
        [Required]
        public ERating Rating { get; set; }
        public enum ERating
        {
            One, Two, Three, Four, Five
        }

        [Required]
        public string Comment { get; set; }
        [Required]
        public DateTime DatePosted { get; set; }

    }
}
