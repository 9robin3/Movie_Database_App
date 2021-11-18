using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Movie_Database_App.Data;
using Movie_Database_App.Models;

namespace Movie_Database_App.Areas.Identity.Pages.Account.Manage
{
    public class WatchListModel : PageModel
    {
        public AppDbContext _DbContext = new AppDbContext();

        public List<Movie> WatchList { get; set; } = new List<Movie>();
        
        public void OnGet()
        {
            WatchList = GetLoggedInUserWatchList();
        }

        public List<Movie> GetLoggedInUserWatchList()
        {
            AppUser user =  _DbContext.Users.Include(w => w.WatchList)
                .FirstOrDefault(u => u.Email == User.FindFirst(ClaimTypes.Email).Value);
            List<Movie> tempList = user.WatchList;
            return tempList;
        }
    }
}
