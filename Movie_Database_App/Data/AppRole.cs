using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie_Database_App.Data
{
    public class AppRole: IdentityRole
    {
        public string RoleInfo { get; set; }
    }
}
