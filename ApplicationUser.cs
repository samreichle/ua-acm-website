using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ua_acm_website
{
    public class ApplicationUser : IdentityUser 
    {
        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Position { get; set; }

        public Boolean DuesPaid { get; set; }

        public int MeetingsAttended { get; set; }
    }
}
