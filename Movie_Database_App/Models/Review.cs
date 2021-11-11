using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Movie_Database_App.Models
{


    public class Review
    {
        public Review()
        {

        }

        public Review(int id)
        {
            MovieID = id;
            //Movie = mov;
        }

        [Key]
        public int ReviewID { get; set; }
        //FK:
        [ForeignKey("MovieID")]
        public int MovieID { get; set; }
        //[NotMapped]
        public Movie Movie { get; set; }
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
