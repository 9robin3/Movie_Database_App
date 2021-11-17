using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Movie_Database_App.Data;
using Movie_Database_App.Models;

namespace Movie_Database_App.Areas.Identity.Pages.Account.Manage
{
    public class WatchListModel : PageModel
    {
        public static AppDbContext _DbContext;
        
        public AppUser UserObj { get; set; }

        public void OnGet()
        {
            //UserObj = GetLoggedInUser();
        }

        public AppUser GetLoggedInUser()
        {
            AppUser user = _DbContext.Users.FirstOrDefault(x => x.Id == User.Identity.GetUserId());
            return user;
        }
    }
}
