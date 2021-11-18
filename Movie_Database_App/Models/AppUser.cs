using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Movie_Database_App.Models
{
    public class AppUser: IdentityUser
    {

        public AppUser()
        {
            //WatchList = new List<Movie>();
        }
        public List<Movie> WatchList { get; set; } = new List<Movie>();
        //public List<WatchListItem> WatchList { get; set; } = new List<WatchListItem>();

        internal int Count()
        {
            throw new NotImplementedException();
        }
    }
}
