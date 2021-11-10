using Microsoft.AspNetCore.Identity;
using Movie_Database_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Database_App.Data
{
    public class AppUser: IdentityUser
    {
        public string User { get; set; }
        //public string LastName { get; set; }
        //public List<Movie> watchList { get; set; }
    }
}
