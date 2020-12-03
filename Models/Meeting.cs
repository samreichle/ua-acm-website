using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ua_acm_website.Models
{
    public class Meeting
    {
        [Key]
        public int Id { get; set; }

        public string Company { get; set; }

        public DateTime Date { get; set; }
        
        public string Location { get; set; }

        public string Recruiter { get; set; }

        public string Topic { get; set; }

        public int Attendance { get; set; }
    }
}
