using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ua_acm_website.Models.ViewModels
{
    public class RoleUserVM
    {
        public ApplicationUser AppUser { get; set; }
        public List<string> UserRoles { get; set; }
        public List<string> AllRoles { get; set; }
    }
}
