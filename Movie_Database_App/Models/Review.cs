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

        [Key]
        public int ReviewID { get; set; }
        //FK:
        //[ForeignKey("Movie")]
        //public Movie Movie { get; set; }
        public string ReviewTitle { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime DatePosted { get; set; }
    }
}
