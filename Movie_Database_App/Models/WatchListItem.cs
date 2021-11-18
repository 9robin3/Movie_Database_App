using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Database_App.Models
{
    public class WatchListItem
    {
        public WatchListItem()
        {

        }

        public WatchListItem(AppUser user, int movID, Movie mov)
        {
            User = user;
            MovieID = movID;
            Movie = mov;
        }

        [Key]
        public int ItemID{ get; set; }
        [ForeignKey("User")]
        public AppUser User { get; set; }
        public int MovieID { get; set; }
        public Movie Movie { get; set; }

        internal int Count()
        {
            throw new NotImplementedException();
        }
    }
}
