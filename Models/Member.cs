﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ua_acm_website.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }

        public string Position { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public string Email { get; set; }

        public Boolean DuesPaid { get; set; }

        public int MeetingsAttended { get; set; }


    }
}
